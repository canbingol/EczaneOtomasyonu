﻿namespace EczaneOtomasyon.Forms.Hasta
{
    partial class HastaKayit
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_telNo = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.lbl_kayitTcHata = new System.Windows.Forms.Label();
            this.lbl_kayitAdHata = new System.Windows.Forms.Label();
            this.lbl_hayitSoyadHata = new System.Windows.Forms.Label();
            this.lbl_kayitAdresHata = new System.Windows.Forms.Label();
            this.lbl_kayitTelHata = new System.Windows.Forms.Label();
            this.btn_hastaKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbbox_sigorta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(431, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "TELEFON NUMARASI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(451, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "HASTA ADRESİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(-3, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "HASTA SOYAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(8, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "HASTA  ADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(8, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "HASTA TC NO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(311, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(263, 34);
            this.label7.TabIndex = 34;
            this.label7.Text = "YENİ HASTA KAYDI";
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.BackColor = System.Drawing.Color.White;
            this.txt_tcNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tcNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_tcNo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tcNo.Location = new System.Drawing.Point(151, 63);
            this.txt_tcNo.MaxLength = 11;
            this.txt_tcNo.Multiline = true;
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.Size = new System.Drawing.Size(258, 43);
            this.txt_tcNo.TabIndex = 0;
            this.txt_tcNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_tcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tcNo_KeyPress);
            this.txt_tcNo.MouseLeave += new System.EventHandler(this.txt_tcNo_MouseLeave);
            this.txt_tcNo.MouseHover += new System.EventHandler(this.txt_tcNo_MouseHover);
            // 
            // txt_ad
            // 
            this.txt_ad.BackColor = System.Drawing.Color.White;
            this.txt_ad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ad.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(151, 141);
            this.txt_ad.Multiline = true;
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(258, 43);
            this.txt_ad.TabIndex = 1;
            this.txt_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ad.MouseLeave += new System.EventHandler(this.txt_ad_MouseLeave);
            this.txt_ad.MouseHover += new System.EventHandler(this.txt_ad_MouseHover);
            // 
            // txt_adres
            // 
            this.txt_adres.BackColor = System.Drawing.Color.White;
            this.txt_adres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_adres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_adres.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adres.Location = new System.Drawing.Point(643, 63);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(258, 43);
            this.txt_adres.TabIndex = 3;
            this.txt_adres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_adres.MouseLeave += new System.EventHandler(this.txt_adres_MouseLeave);
            this.txt_adres.MouseHover += new System.EventHandler(this.txt_adres_MouseHover);
            // 
            // txt_telNo
            // 
            this.txt_telNo.BackColor = System.Drawing.Color.White;
            this.txt_telNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_telNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_telNo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_telNo.Location = new System.Drawing.Point(643, 141);
            this.txt_telNo.MaxLength = 11;
            this.txt_telNo.Multiline = true;
            this.txt_telNo.Name = "txt_telNo";
            this.txt_telNo.Size = new System.Drawing.Size(258, 43);
            this.txt_telNo.TabIndex = 4;
            this.txt_telNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_telNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telNo_KeyPress);
            this.txt_telNo.MouseLeave += new System.EventHandler(this.txt_telNo_MouseLeave);
            this.txt_telNo.MouseHover += new System.EventHandler(this.txt_telNo_MouseHover);
            // 
            // txt_soyad
            // 
            this.txt_soyad.BackColor = System.Drawing.Color.White;
            this.txt_soyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_soyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_soyad.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyad.Location = new System.Drawing.Point(150, 219);
            this.txt_soyad.Multiline = true;
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(258, 43);
            this.txt_soyad.TabIndex = 2;
            this.txt_soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_soyad.MouseLeave += new System.EventHandler(this.txt_soyad_MouseLeave);
            this.txt_soyad.MouseHover += new System.EventHandler(this.txt_soyad_MouseHover);
            // 
            // lbl_kayitTcHata
            // 
            this.lbl_kayitTcHata.AutoSize = true;
            this.lbl_kayitTcHata.ForeColor = System.Drawing.Color.Red;
            this.lbl_kayitTcHata.Location = new System.Drawing.Point(148, 43);
            this.lbl_kayitTcHata.Name = "lbl_kayitTcHata";
            this.lbl_kayitTcHata.Size = new System.Drawing.Size(213, 16);
            this.lbl_kayitTcHata.TabIndex = 45;
            this.lbl_kayitTcHata.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_kayitTcHata.Visible = false;
            // 
            // lbl_kayitAdHata
            // 
            this.lbl_kayitAdHata.AutoSize = true;
            this.lbl_kayitAdHata.ForeColor = System.Drawing.Color.Red;
            this.lbl_kayitAdHata.Location = new System.Drawing.Point(148, 122);
            this.lbl_kayitAdHata.Name = "lbl_kayitAdHata";
            this.lbl_kayitAdHata.Size = new System.Drawing.Size(213, 16);
            this.lbl_kayitAdHata.TabIndex = 47;
            this.lbl_kayitAdHata.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_kayitAdHata.Visible = false;
            // 
            // lbl_hayitSoyadHata
            // 
            this.lbl_hayitSoyadHata.AutoSize = true;
            this.lbl_hayitSoyadHata.ForeColor = System.Drawing.Color.Red;
            this.lbl_hayitSoyadHata.Location = new System.Drawing.Point(148, 200);
            this.lbl_hayitSoyadHata.Name = "lbl_hayitSoyadHata";
            this.lbl_hayitSoyadHata.Size = new System.Drawing.Size(213, 16);
            this.lbl_hayitSoyadHata.TabIndex = 48;
            this.lbl_hayitSoyadHata.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_hayitSoyadHata.Visible = false;
            // 
            // lbl_kayitAdresHata
            // 
            this.lbl_kayitAdresHata.AutoSize = true;
            this.lbl_kayitAdresHata.ForeColor = System.Drawing.Color.Red;
            this.lbl_kayitAdresHata.Location = new System.Drawing.Point(640, 44);
            this.lbl_kayitAdresHata.Name = "lbl_kayitAdresHata";
            this.lbl_kayitAdresHata.Size = new System.Drawing.Size(213, 16);
            this.lbl_kayitAdresHata.TabIndex = 49;
            this.lbl_kayitAdresHata.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_kayitAdresHata.Visible = false;
            // 
            // lbl_kayitTelHata
            // 
            this.lbl_kayitTelHata.AutoSize = true;
            this.lbl_kayitTelHata.ForeColor = System.Drawing.Color.Red;
            this.lbl_kayitTelHata.Location = new System.Drawing.Point(640, 122);
            this.lbl_kayitTelHata.Name = "lbl_kayitTelHata";
            this.lbl_kayitTelHata.Size = new System.Drawing.Size(213, 16);
            this.lbl_kayitTelHata.TabIndex = 50;
            this.lbl_kayitTelHata.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_kayitTelHata.Visible = false;
            // 
            // btn_hastaKaydet
            // 
            this.btn_hastaKaydet.BackColor = System.Drawing.Color.Green;
            this.btn_hastaKaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hastaKaydet.Location = new System.Drawing.Point(249, 280);
            this.btn_hastaKaydet.Name = "btn_hastaKaydet";
            this.btn_hastaKaydet.Size = new System.Drawing.Size(439, 56);
            this.btn_hastaKaydet.TabIndex = 51;
            this.btn_hastaKaydet.Text = "HASTA KAYDI OLUŞTUR";
            this.btn_hastaKaydet.UseVisualStyleBackColor = false;
            this.btn_hastaKaydet.Click += new System.EventHandler(this.btn_hastaKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(451, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 32;
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
            this.cmbbox_sigorta.Location = new System.Drawing.Point(643, 225);
            this.cmbbox_sigorta.Name = "cmbbox_sigorta";
            this.cmbbox_sigorta.Size = new System.Drawing.Size(258, 28);
            this.cmbbox_sigorta.TabIndex = 72;
            // 
            // HastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(989, 361);
            this.Controls.Add(this.cmbbox_sigorta);
            this.Controls.Add(this.btn_hastaKaydet);
            this.Controls.Add(this.lbl_kayitTelHata);
            this.Controls.Add(this.lbl_kayitAdresHata);
            this.Controls.Add(this.lbl_hayitSoyadHata);
            this.Controls.Add(this.lbl_kayitAdHata);
            this.Controls.Add(this.lbl_kayitTcHata);
            this.Controls.Add(this.txt_telNo);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_tcNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HastaKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HastaKayıt";
            this.Load += new System.EventHandler(this.HastaKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tcNo;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.TextBox txt_telNo;
        private System.Windows.Forms.TextBox txt_soyad;
        public System.Windows.Forms.Label lbl_kayitTcHata;
        public System.Windows.Forms.Label lbl_kayitAdHata;
        public System.Windows.Forms.Label lbl_hayitSoyadHata;
        public System.Windows.Forms.Label lbl_kayitAdresHata;
        public System.Windows.Forms.Label lbl_kayitTelHata;
        public System.Windows.Forms.Button btn_hastaKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbbox_sigorta;
    }
}