using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rastgele_Buton
{
    public partial class Form1 : Form
    {
        private Timer timerRandom;
        private Timer timerAlternating;
        private Random random;
        private bool isRandomCreating;
        private bool isAlternatingCreating;
        private bool isRed;
        public Form1()
        {
            random = new Random();
            isRandomCreating = false;
            isAlternatingCreating = false;
            isRed = true;


            timerRandom = new Timer();
            timerRandom.Interval = 1000;
            timerRandom.Tick += TimerRandom_Tick;


            timerAlternating = new Timer();
            timerAlternating.Interval = 1000;
            timerAlternating.Tick += TimerAlternating_Tick;
            InitializeComponent();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {

            if (!isRandomCreating)
            {

                timerRandom.Start();
                isRandomCreating = true;
                btnStartStop.Text = "Rastgele Durdur";
            }
            else
            {

                timerRandom.Stop();
                isRandomCreating = false;
                btnStartStop.Text = "Rastgele Başlat";
            }
        }

        private void btnCiftRenk_Click(object sender, EventArgs e)
        {

            if (!isAlternatingCreating)
            {

                timerAlternating.Start();
                isAlternatingCreating = true;
                btnCiftRenk.Text = "Kırmızı-Mavi Durdur";
            }
            else
            {

                timerAlternating.Stop();
                isAlternatingCreating = false;
                btnCiftRenk.Text = "Kırmızı-Mavi Başlat";
            }
        }

        private void TimerRandom_Tick(object sender, EventArgs e)
        {

            Button newButton = new Button();
            newButton.Size = new Size(50, 50);


            int x = random.Next(0, this.ClientSize.Width - newButton.Width);
            int y = random.Next(0, this.ClientSize.Height - newButton.Height);
            newButton.Location = new Point(x, y);


            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            newButton.BackColor = randomColor;


            newButton.Click += (s, args) =>
            {
                txtRenkKodu.Text = ColorTranslator.ToHtml(randomColor);
            };


            this.Controls.Add(newButton);
        }

        private void TimerAlternating_Tick(object sender, EventArgs e)
        {

            Button newButton = new Button();
            newButton.Size = new Size(50, 50);


            int x = random.Next(0, this.ClientSize.Width - newButton.Width);
            int y = random.Next(0, this.ClientSize.Height - newButton.Height);
            newButton.Location = new Point(x, y);


            if (isRed)
            {
                newButton.BackColor = Color.Red;
            }
            else
            {
                newButton.BackColor = Color.Blue;
            }


            isRed = !isRed;


            newButton.Click += (s, args) =>
            {
                txtRenkKodu.Text = ColorTranslator.ToHtml(newButton.BackColor);
            };


            this.Controls.Add(newButton);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {

                if (control is Button && control != btnStartStop && control != btnCiftRenk && control != btnTemizle && control != btnCikis)
                {
                    this.Controls.Remove(control);
                    control.Dispose();
                }
            }


            txtRenkKodu.Text = "Buton Seçilmedi";
        }
    }
}
