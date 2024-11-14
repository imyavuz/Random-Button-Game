
namespace Rastgele_Buton
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnCiftRenk = new System.Windows.Forms.Button();
            this.txtRenkKodu = new System.Windows.Forms.TextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartStop
            // 
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartStop.Location = new System.Drawing.Point(9, 312);
            this.btnStartStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(157, 44);
            this.btnStartStop.TabIndex = 1;
            this.btnStartStop.Text = "Rastgele Başlat";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // btnCiftRenk
            // 
            this.btnCiftRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCiftRenk.Location = new System.Drawing.Point(170, 312);
            this.btnCiftRenk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCiftRenk.Name = "btnCiftRenk";
            this.btnCiftRenk.Size = new System.Drawing.Size(157, 44);
            this.btnCiftRenk.TabIndex = 3;
            this.btnCiftRenk.Text = "Kırmızı-Mavi Başlat";
            this.btnCiftRenk.UseVisualStyleBackColor = true;
            this.btnCiftRenk.Click += new System.EventHandler(this.btnCiftRenk_Click);
            // 
            // txtRenkKodu
            // 
            this.txtRenkKodu.BackColor = System.Drawing.Color.Black;
            this.txtRenkKodu.Enabled = false;
            this.txtRenkKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRenkKodu.ForeColor = System.Drawing.Color.Transparent;
            this.txtRenkKodu.Location = new System.Drawing.Point(9, 10);
            this.txtRenkKodu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRenkKodu.Name = "txtRenkKodu";
            this.txtRenkKodu.Size = new System.Drawing.Size(186, 30);
            this.txtRenkKodu.TabIndex = 4;
            this.txtRenkKodu.Text = "Buton Seçilmedi";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Red;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(506, 312);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(85, 44);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(380, 312);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(122, 44);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.txtRenkKodu);
            this.Controls.Add(this.btnCiftRenk);
            this.Controls.Add(this.btnStartStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rastgele Buton Oluşturma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Button btnCiftRenk;
        private System.Windows.Forms.TextBox txtRenkKodu;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
    }
}

