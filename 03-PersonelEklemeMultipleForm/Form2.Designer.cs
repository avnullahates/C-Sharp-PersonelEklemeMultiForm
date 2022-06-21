
namespace _03_PersonelEklemeMultipleForm
{
    partial class Form2
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
            this.grbKayitlar = new System.Windows.Forms.GroupBox();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.lblKayit = new System.Windows.Forms.Label();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.grbKayitlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbKayitlar
            // 
            this.grbKayitlar.Controls.Add(this.btnGeriDon);
            this.grbKayitlar.Controls.Add(this.lblKayit);
            this.grbKayitlar.Controls.Add(this.btnIleri);
            this.grbKayitlar.Controls.Add(this.btnTemizle);
            this.grbKayitlar.Controls.Add(this.btnGeri);
            this.grbKayitlar.Location = new System.Drawing.Point(22, 27);
            this.grbKayitlar.Name = "grbKayitlar";
            this.grbKayitlar.Size = new System.Drawing.Size(512, 467);
            this.grbKayitlar.TabIndex = 1;
            this.grbKayitlar.TabStop = false;
            this.grbKayitlar.Text = "KAYITLAR";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(21, 404);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(432, 47);
            this.btnGeriDon.TabIndex = 17;
            this.btnGeriDon.Text = "KAYIT EKRANINA GERI DON";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // lblKayit
            // 
            this.lblKayit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKayit.Location = new System.Drawing.Point(32, 47);
            this.lblKayit.Name = "lblKayit";
            this.lblKayit.Size = new System.Drawing.Size(453, 277);
            this.lblKayit.TabIndex = 16;
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(341, 342);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(112, 47);
            this.btnIleri.TabIndex = 15;
            this.btnIleri.Text = "ILERI";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(167, 342);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(112, 47);
            this.btnTemizle.TabIndex = 14;
            this.btnTemizle.Text = "TEMIZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(21, 342);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(112, 47);
            this.btnGeri.TabIndex = 13;
            this.btnGeri.Text = "GERI";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 548);
            this.Controls.Add(this.grbKayitlar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grbKayitlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKayitlar;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Label lblKayit;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGeri;
    }
}