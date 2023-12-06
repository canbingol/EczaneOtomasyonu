namespace EczaneOtomasyon.Forms.Hasta
{
    partial class HastaGüncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaGüncelle));
            this.btn_hastaGüncelle = new System.Windows.Forms.Button();
            this.lbl_güncelleTelHata = new System.Windows.Forms.Label();
            this.lbl_güncelleAdresHata = new System.Windows.Forms.Label();
            this.lbl_güncelleSoyadHata = new System.Windows.Forms.Label();
            this.lbl_güncelleAdHata = new System.Windows.Forms.Label();
            this.dogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.lbl_gücelleTcHata = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_telNo = new System.Windows.Forms.TextBox();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_EkranKapat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EkranKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hastaGüncelle
            // 
            this.btn_hastaGüncelle.BackColor = System.Drawing.Color.Red;
            this.btn_hastaGüncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hastaGüncelle.Location = new System.Drawing.Point(376, 622);
            this.btn_hastaGüncelle.Name = "btn_hastaGüncelle";
            this.btn_hastaGüncelle.Size = new System.Drawing.Size(266, 56);
            this.btn_hastaGüncelle.TabIndex = 70;
            this.btn_hastaGüncelle.Text = "HASTA KAYDI GÜNCELLE";
            this.btn_hastaGüncelle.UseVisualStyleBackColor = false;
            this.btn_hastaGüncelle.Click += new System.EventHandler(this.btn_hastaGüncelle_Click);
            // 
            // lbl_güncelleTelHata
            // 
            this.lbl_güncelleTelHata.AutoSize = true;
            this.lbl_güncelleTelHata.ForeColor = System.Drawing.Color.Red;
            this.lbl_güncelleTelHata.Location = new System.Drawing.Point(280, 500);
            this.lbl_güncelleTelHata.Name = "lbl_güncelleTelHata";
            this.lbl_güncelleTelHata.Size = new System.Drawing.Size(213, 16);
            this.lbl_güncelleTelHata.TabIndex = 69;
            this.lbl_güncelleTelHata.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_güncelleTelHata.Visible = false;
            // 
            // lbl_güncelleAdresHata
            // 
            this.lbl_güncelleAdresHata.AutoSize = true;
            this.lbl_güncelleAdresHata.ForeColor = System.Drawing.Color.Red;
            this.lbl_güncelleAdresHata.Location = new System.Drawing.Point(281, 408);
            this.lbl_güncelleAdresHata.Name = "lbl_güncelleAdresHata";
            this.lbl_güncelleAdresHata.Size = new System.Drawing.Size(213, 16);
            this.lbl_güncelleAdresHata.TabIndex = 68;
            this.lbl_güncelleAdresHata.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_güncelleAdresHata.Visible = false;
            // 
            // lbl_güncelleSoyadHata
            // 
            this.lbl_güncelleSoyadHata.AutoSize = true;
            this.lbl_güncelleSoyadHata.ForeColor = System.Drawing.Color.Red;
            this.lbl_güncelleSoyadHata.Location = new System.Drawing.Point(281, 244);
            this.lbl_güncelleSoyadHata.Name = "lbl_güncelleSoyadHata";
            this.lbl_güncelleSoyadHata.Size = new System.Drawing.Size(213, 16);
            this.lbl_güncelleSoyadHata.TabIndex = 67;
            this.lbl_güncelleSoyadHata.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_güncelleSoyadHata.Visible = false;
            // 
            // lbl_güncelleAdHata
            // 
            this.lbl_güncelleAdHata.AutoSize = true;
            this.lbl_güncelleAdHata.ForeColor = System.Drawing.Color.Red;
            this.lbl_güncelleAdHata.Location = new System.Drawing.Point(281, 157);
            this.lbl_güncelleAdHata.Name = "lbl_güncelleAdHata";
            this.lbl_güncelleAdHata.Size = new System.Drawing.Size(213, 16);
            this.lbl_güncelleAdHata.TabIndex = 66;
            this.lbl_güncelleAdHata.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_güncelleAdHata.Visible = false;
            // 
            // dogumtarihi
            // 
            this.dogumtarihi.Location = new System.Drawing.Point(284, 361);
            this.dogumtarihi.Name = "dogumtarihi";
            this.dogumtarihi.Size = new System.Drawing.Size(258, 22);
            this.dogumtarihi.TabIndex = 65;
            // 
            // lbl_gücelleTcHata
            // 
            this.lbl_gücelleTcHata.AutoSize = true;
            this.lbl_gücelleTcHata.ForeColor = System.Drawing.Color.Red;
            this.lbl_gücelleTcHata.Location = new System.Drawing.Point(281, 70);
            this.lbl_gücelleTcHata.Name = "lbl_gücelleTcHata";
            this.lbl_gücelleTcHata.Size = new System.Drawing.Size(213, 16);
            this.lbl_gücelleTcHata.TabIndex = 64;
            this.lbl_gücelleTcHata.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_gücelleTcHata.Visible = false;
            // 
            // txt_soyad
            // 
            this.txt_soyad.BackColor = System.Drawing.Color.Silver;
            this.txt_soyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_soyad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyad.Location = new System.Drawing.Point(283, 263);
            this.txt_soyad.Multiline = true;
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(258, 43);
            this.txt_soyad.TabIndex = 63;
            this.txt_soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_soyad.MouseLeave += new System.EventHandler(this.txt_soyad_MouseLeave);
            this.txt_soyad.MouseHover += new System.EventHandler(this.txt_soyad_MouseHover);
            // 
            // txt_ad
            // 
            this.txt_ad.BackColor = System.Drawing.Color.Silver;
            this.txt_ad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(284, 176);
            this.txt_ad.Multiline = true;
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(258, 43);
            this.txt_ad.TabIndex = 60;
            this.txt_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ad.MouseLeave += new System.EventHandler(this.txt_ad_MouseLeave);
            this.txt_ad.MouseHover += new System.EventHandler(this.txt_ad_MouseHover);
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.BackColor = System.Drawing.Color.Silver;
            this.txt_tcNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tcNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tcNo.Location = new System.Drawing.Point(284, 89);
            this.txt_tcNo.MaxLength = 11;
            this.txt_tcNo.Multiline = true;
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.Size = new System.Drawing.Size(258, 43);
            this.txt_tcNo.TabIndex = 59;
            this.txt_tcNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tcNo_KeyPress);
            this.txt_tcNo.MouseLeave += new System.EventHandler(this.txt_tcNo_MouseLeave);
            this.txt_tcNo.MouseHover += new System.EventHandler(this.txt_tcNo_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(156, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(341, 34);
            this.label7.TabIndex = 58;
            this.label7.Text = "HASTA KAYDI GÜNCELLE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(90, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 22);
            this.label6.TabIndex = 56;
            this.label6.Text = "TELEFON NUMARASI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(90, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 52;
            this.label5.Text = "HASTA ADRESİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(90, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 22);
            this.label3.TabIndex = 57;
            this.label3.Text = "HASTA SOYADI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(90, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 22);
            this.label4.TabIndex = 53;
            this.label4.Text = "DOĞUM TARİHİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(90, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 54;
            this.label2.Text = "HASTA  ADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(90, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 55;
            this.label1.Text = "HASTA TC NO";
            // 
            // txt_telNo
            // 
            this.txt_telNo.BackColor = System.Drawing.Color.Silver;
            this.txt_telNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_telNo.Location = new System.Drawing.Point(282, 427);
            this.txt_telNo.Multiline = true;
            this.txt_telNo.Name = "txt_telNo";
            this.txt_telNo.Size = new System.Drawing.Size(258, 43);
            this.txt_telNo.TabIndex = 63;
            this.txt_telNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_telNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telNo_KeyPress);
            this.txt_telNo.MouseLeave += new System.EventHandler(this.txt_telNo_MouseLeave);
            this.txt_telNo.MouseHover += new System.EventHandler(this.txt_telNo_MouseHover);
            // 
            // txt_adres
            // 
            this.txt_adres.BackColor = System.Drawing.Color.Silver;
            this.txt_adres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_adres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adres.Location = new System.Drawing.Point(284, 519);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(258, 43);
            this.txt_adres.TabIndex = 63;
            this.txt_adres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_adres.MouseLeave += new System.EventHandler(this.txt_adres_MouseLeave);
            this.txt_adres.MouseHover += new System.EventHandler(this.txt_adres_MouseHover);
            // 
            // btn_EkranKapat
            // 
            this.btn_EkranKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EkranKapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_EkranKapat.Image")));
            this.btn_EkranKapat.Location = new System.Drawing.Point(630, 3);
            this.btn_EkranKapat.Name = "btn_EkranKapat";
            this.btn_EkranKapat.Size = new System.Drawing.Size(35, 35);
            this.btn_EkranKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_EkranKapat.TabIndex = 71;
            this.btn_EkranKapat.TabStop = false;
            this.btn_EkranKapat.Click += new System.EventHandler(this.btn_EkranKapat_Click);
            // 
            // HastaGüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 720);
            this.Controls.Add(this.btn_EkranKapat);
            this.Controls.Add(this.btn_hastaGüncelle);
            this.Controls.Add(this.lbl_güncelleTelHata);
            this.Controls.Add(this.lbl_güncelleAdresHata);
            this.Controls.Add(this.lbl_güncelleSoyadHata);
            this.Controls.Add(this.lbl_güncelleAdHata);
            this.Controls.Add(this.dogumtarihi);
            this.Controls.Add(this.lbl_gücelleTcHata);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.txt_telNo);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_tcNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HastaGüncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HastaGüncelle";
            ((System.ComponentModel.ISupportInitialize)(this.btn_EkranKapat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_hastaGüncelle;
        public System.Windows.Forms.Label lbl_güncelleTelHata;
        public System.Windows.Forms.Label lbl_güncelleAdresHata;
        public System.Windows.Forms.Label lbl_güncelleSoyadHata;
        public System.Windows.Forms.Label lbl_güncelleAdHata;
        private System.Windows.Forms.DateTimePicker dogumtarihi;
        public System.Windows.Forms.Label lbl_gücelleTcHata;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_tcNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_telNo;
        private System.Windows.Forms.TextBox txt_adres;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox btn_EkranKapat;
        // public System.Windows.Forms.RichTextBox txt_adres;
    }
}