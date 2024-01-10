namespace EczaneOtomasyon.Forms.Hasta
{
    partial class HastaGuncelle
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
            this.btn_hastaGuncelle = new System.Windows.Forms.Button();
            this.lbl_guncelleTelHata = new System.Windows.Forms.Label();
            this.lbl_guncelleAdresHata = new System.Windows.Forms.Label();
            this.lbl_guncelleSoyadHata = new System.Windows.Forms.Label();
            this.lbl_guncelleAdHata = new System.Windows.Forms.Label();
            this.lbl_gucelleTcHata = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_telNo = new System.Windows.Forms.TextBox();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbbox_sigorta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_hastaGuncelle
            // 
            this.btn_hastaGuncelle.BackColor = System.Drawing.Color.Green;
            this.btn_hastaGuncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hastaGuncelle.ForeColor = System.Drawing.Color.White;
            this.btn_hastaGuncelle.Location = new System.Drawing.Point(238, 293);
            this.btn_hastaGuncelle.Name = "btn_hastaGuncelle";
            this.btn_hastaGuncelle.Size = new System.Drawing.Size(439, 56);
            this.btn_hastaGuncelle.TabIndex = 70;
            this.btn_hastaGuncelle.Text = "HASTA KAYDI GÜNCELLE";
            this.btn_hastaGuncelle.UseVisualStyleBackColor = false;
            this.btn_hastaGuncelle.Click += new System.EventHandler(this.btn_hastaGüncelle_Click);
            // 
            // lbl_guncelleTelHata
            // 
            this.lbl_guncelleTelHata.AutoSize = true;
            this.lbl_guncelleTelHata.ForeColor = System.Drawing.Color.Red;
            this.lbl_guncelleTelHata.Location = new System.Drawing.Point(643, 44);
            this.lbl_guncelleTelHata.Name = "lbl_guncelleTelHata";
            this.lbl_guncelleTelHata.Size = new System.Drawing.Size(213, 16);
            this.lbl_guncelleTelHata.TabIndex = 69;
            this.lbl_guncelleTelHata.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_guncelleTelHata.Visible = false;
            // 
            // lbl_guncelleAdresHata
            // 
            this.lbl_guncelleAdresHata.AutoSize = true;
            this.lbl_guncelleAdresHata.ForeColor = System.Drawing.Color.Red;
            this.lbl_guncelleAdresHata.Location = new System.Drawing.Point(643, 122);
            this.lbl_guncelleAdresHata.Name = "lbl_guncelleAdresHata";
            this.lbl_guncelleAdresHata.Size = new System.Drawing.Size(213, 16);
            this.lbl_guncelleAdresHata.TabIndex = 68;
            this.lbl_guncelleAdresHata.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_guncelleAdresHata.Visible = false;
            // 
            // lbl_guncelleSoyadHata
            // 
            this.lbl_guncelleSoyadHata.AutoSize = true;
            this.lbl_guncelleSoyadHata.ForeColor = System.Drawing.Color.Red;
            this.lbl_guncelleSoyadHata.Location = new System.Drawing.Point(161, 200);
            this.lbl_guncelleSoyadHata.Name = "lbl_guncelleSoyadHata";
            this.lbl_guncelleSoyadHata.Size = new System.Drawing.Size(213, 16);
            this.lbl_guncelleSoyadHata.TabIndex = 67;
            this.lbl_guncelleSoyadHata.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_guncelleSoyadHata.Visible = false;
            // 
            // lbl_guncelleAdHata
            // 
            this.lbl_guncelleAdHata.AutoSize = true;
            this.lbl_guncelleAdHata.ForeColor = System.Drawing.Color.Red;
            this.lbl_guncelleAdHata.Location = new System.Drawing.Point(161, 122);
            this.lbl_guncelleAdHata.Name = "lbl_guncelleAdHata";
            this.lbl_guncelleAdHata.Size = new System.Drawing.Size(213, 16);
            this.lbl_guncelleAdHata.TabIndex = 66;
            this.lbl_guncelleAdHata.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_guncelleAdHata.Visible = false;
            // 
            // lbl_gucelleTcHata
            // 
            this.lbl_gucelleTcHata.AutoSize = true;
            this.lbl_gucelleTcHata.ForeColor = System.Drawing.Color.Red;
            this.lbl_gucelleTcHata.Location = new System.Drawing.Point(161, 44);
            this.lbl_gucelleTcHata.Name = "lbl_gucelleTcHata";
            this.lbl_gucelleTcHata.Size = new System.Drawing.Size(213, 16);
            this.lbl_gucelleTcHata.TabIndex = 64;
            this.lbl_gucelleTcHata.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_gucelleTcHata.Visible = false;
            // 
            // txt_soyad
            // 
            this.txt_soyad.BackColor = System.Drawing.Color.White;
            this.txt_soyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_soyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_soyad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyad.Location = new System.Drawing.Point(163, 219);
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
            this.txt_ad.BackColor = System.Drawing.Color.White;
            this.txt_ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(164, 141);
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
            this.txt_tcNo.BackColor = System.Drawing.Color.White;
            this.txt_tcNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tcNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_tcNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tcNo.Location = new System.Drawing.Point(164, 63);
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
            this.label7.Location = new System.Drawing.Point(232, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(341, 34);
            this.label7.TabIndex = 58;
            this.label7.Text = "HASTA KAYDI GÜNCELLE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(454, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 22);
            this.label6.TabIndex = 56;
            this.label6.Text = "TELEFON NUMARA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(454, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 22);
            this.label5.TabIndex = 52;
            this.label5.Text = "HASTA ADRES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(8, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 57;
            this.label3.Text = "HASTA SOYAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(8, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 54;
            this.label2.Text = "HASTA  AD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(8, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 55;
            this.label1.Text = "HASTA TC NO";
            // 
            // txt_telNo
            // 
            this.txt_telNo.BackColor = System.Drawing.Color.White;
            this.txt_telNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_telNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_telNo.Location = new System.Drawing.Point(643, 141);
            this.txt_telNo.MaxLength = 11;
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
            this.txt_adres.BackColor = System.Drawing.Color.White;
            this.txt_adres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_adres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_adres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adres.Location = new System.Drawing.Point(646, 63);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(258, 43);
            this.txt_adres.TabIndex = 63;
            this.txt_adres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_adres.MouseLeave += new System.EventHandler(this.txt_adres_MouseLeave);
            this.txt_adres.MouseHover += new System.EventHandler(this.txt_adres_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(454, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 56;
            this.label4.Text = "SİGORTA";
            // 
            // cmbbox_sigorta
            // 
            this.cmbbox_sigorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_sigorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbbox_sigorta.FormattingEnabled = true;
            this.cmbbox_sigorta.Items.AddRange(new object[] {
            "VAR",
            "YOK"});
            this.cmbbox_sigorta.Location = new System.Drawing.Point(646, 231);
            this.cmbbox_sigorta.Name = "cmbbox_sigorta";
            this.cmbbox_sigorta.Size = new System.Drawing.Size(258, 28);
            this.cmbbox_sigorta.TabIndex = 71;
            // 
            // HastaGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 361);
            this.Controls.Add(this.cmbbox_sigorta);
            this.Controls.Add(this.btn_hastaGuncelle);
            this.Controls.Add(this.lbl_guncelleTelHata);
            this.Controls.Add(this.lbl_guncelleAdresHata);
            this.Controls.Add(this.lbl_guncelleSoyadHata);
            this.Controls.Add(this.lbl_guncelleAdHata);
            this.Controls.Add(this.lbl_gucelleTcHata);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.txt_telNo);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_tcNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HastaGuncelle";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HastaGüncelle";
            this.Load += new System.EventHandler(this.HastaGüncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_hastaGuncelle;
        public System.Windows.Forms.Label lbl_guncelleTelHata;
        public System.Windows.Forms.Label lbl_guncelleAdresHata;
        public System.Windows.Forms.Label lbl_guncelleSoyadHata;
        public System.Windows.Forms.Label lbl_guncelleAdHata;
        public System.Windows.Forms.Label lbl_gucelleTcHata;
        public System.Windows.Forms.TextBox txt_soyad;
        public System.Windows.Forms.TextBox txt_ad;
        public System.Windows.Forms.TextBox txt_tcNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_telNo;
        public System.Windows.Forms.TextBox txt_adres;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbbox_sigorta;
        // public System.Windows.Forms.RichTextBox txt_adres;
    }
}