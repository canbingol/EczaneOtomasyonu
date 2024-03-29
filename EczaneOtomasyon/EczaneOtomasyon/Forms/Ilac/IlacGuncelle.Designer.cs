﻿namespace EczaneOtomasyon.Forms.İlaç
{
    partial class IlacGuncelle
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
            this.lbl_hataIlacBarkod = new System.Windows.Forms.Label();
            this.lbl_hataIlacKategori = new System.Windows.Forms.Label();
            this.btn_ilacGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.txt_sontarih = new System.Windows.Forms.DateTimePicker();
            this.txt_kategori = new System.Windows.Forms.ComboBox();
            this.txt_barkod = new System.Windows.Forms.TextBox();
            this.btn_barkodBul = new System.Windows.Forms.Button();
            this.txt_ilacAd = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_adet = new System.Windows.Forms.NumericUpDown();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_fiyat = new System.Windows.Forms.Label();
            this.lbl_adet = new System.Windows.Forms.Label();
            this.lbl_hataIlacAd = new System.Windows.Forms.Label();
            this.lbl_hataIlacFiyat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_hataIlacBarkod
            // 
            this.lbl_hataIlacBarkod.AutoSize = true;
            this.lbl_hataIlacBarkod.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hataIlacBarkod.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataIlacBarkod.Location = new System.Drawing.Point(147, 41);
            this.lbl_hataIlacBarkod.Name = "lbl_hataIlacBarkod";
            this.lbl_hataIlacBarkod.Size = new System.Drawing.Size(198, 17);
            this.lbl_hataIlacBarkod.TabIndex = 74;
            this.lbl_hataIlacBarkod.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_hataIlacBarkod.Visible = false;
            // 
            // lbl_hataIlacKategori
            // 
            this.lbl_hataIlacKategori.AutoSize = true;
            this.lbl_hataIlacKategori.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hataIlacKategori.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataIlacKategori.Location = new System.Drawing.Point(145, 134);
            this.lbl_hataIlacKategori.Name = "lbl_hataIlacKategori";
            this.lbl_hataIlacKategori.Size = new System.Drawing.Size(198, 17);
            this.lbl_hataIlacKategori.TabIndex = 73;
            this.lbl_hataIlacKategori.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_hataIlacKategori.Visible = false;
            // 
            // btn_ilacGuncelle
            // 
            this.btn_ilacGuncelle.BackColor = System.Drawing.Color.Green;
            this.btn_ilacGuncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ilacGuncelle.Location = new System.Drawing.Point(256, 313);
            this.btn_ilacGuncelle.Name = "btn_ilacGuncelle";
            this.btn_ilacGuncelle.Size = new System.Drawing.Size(439, 56);
            this.btn_ilacGuncelle.TabIndex = 69;
            this.btn_ilacGuncelle.Text = "İLAÇ GÜNCELLE";
            this.btn_ilacGuncelle.UseVisualStyleBackColor = false;
            this.btn_ilacGuncelle.Visible = false;
            this.btn_ilacGuncelle.Click += new System.EventHandler(this.btn_ilaçGüncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(377, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(352, 34);
            this.label7.TabIndex = 68;
            this.label7.Text = "İLAÇ BİLGİLERİ GÜNCELLE";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarih.Location = new System.Drawing.Point(4, 233);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(204, 22);
            this.lbl_tarih.TabIndex = 66;
            this.lbl_tarih.Text = "SON KULLANMA TARİHİ";
            this.lbl_tarih.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(4, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 67;
            this.label4.Text = "BARKOD NO";
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kategori.Location = new System.Drawing.Point(4, 155);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.Size = new System.Drawing.Size(96, 22);
            this.lbl_kategori.TabIndex = 64;
            this.lbl_kategori.Text = "KATEGORİ";
            this.lbl_kategori.Visible = false;
            // 
            // txt_sontarih
            // 
            this.txt_sontarih.Location = new System.Drawing.Point(225, 228);
            this.txt_sontarih.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sontarih.Name = "txt_sontarih";
            this.txt_sontarih.Size = new System.Drawing.Size(258, 22);
            this.txt_sontarih.TabIndex = 60;
            this.txt_sontarih.Visible = false;
            // 
            // txt_kategori
            // 
            this.txt_kategori.FormattingEnabled = true;
            this.txt_kategori.Items.AddRange(new object[] {
            "Ağrı Kesici",
            "Alerji İlacı",
            "Antibiyotik",
            "Antidepresan",
            "Diğer",
            "Diyabet İlacı",
            "Kalp İlacı",
            "Tansiyon İlacı"});
            this.txt_kategori.Location = new System.Drawing.Point(148, 155);
            this.txt_kategori.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kategori.Name = "txt_kategori";
            this.txt_kategori.Size = new System.Drawing.Size(258, 24);
            this.txt_kategori.Sorted = true;
            this.txt_kategori.TabIndex = 59;
            this.txt_kategori.Visible = false;
            this.txt_kategori.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kategori_KeyPress_1);
            // 
            // txt_barkod
            // 
            this.txt_barkod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_barkod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_barkod.Location = new System.Drawing.Point(148, 62);
            this.txt_barkod.Margin = new System.Windows.Forms.Padding(4);
            this.txt_barkod.MaxLength = 13;
            this.txt_barkod.Multiline = true;
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Size = new System.Drawing.Size(258, 43);
            this.txt_barkod.TabIndex = 55;
            this.txt_barkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_barkod_KeyPress);
            this.txt_barkod.MouseLeave += new System.EventHandler(this.txt_barkod_MouseLeave);
            this.txt_barkod.MouseHover += new System.EventHandler(this.txt_barkod_MouseHover);
            // 
            // btn_barkodBul
            // 
            this.btn_barkodBul.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_barkodBul.Location = new System.Drawing.Point(425, 62);
            this.btn_barkodBul.Name = "btn_barkodBul";
            this.btn_barkodBul.Size = new System.Drawing.Size(123, 47);
            this.btn_barkodBul.TabIndex = 97;
            this.btn_barkodBul.Text = "İLAÇ BUL";
            this.btn_barkodBul.UseVisualStyleBackColor = false;
            this.btn_barkodBul.Click += new System.EventHandler(this.btn_barkodBul_Click);
            // 
            // txt_ilacAd
            // 
            this.txt_ilacAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ilacAd.Location = new System.Drawing.Point(704, 149);
            this.txt_ilacAd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ilacAd.Multiline = true;
            this.txt_ilacAd.Name = "txt_ilacAd";
            this.txt_ilacAd.Size = new System.Drawing.Size(258, 43);
            this.txt_ilacAd.TabIndex = 54;
            this.txt_ilacAd.Visible = false;
            this.txt_ilacAd.MouseLeave += new System.EventHandler(this.txt_ilaçAd_MouseLeave);
            this.txt_ilacAd.MouseHover += new System.EventHandler(this.txt_ilaçAd_MouseHover_1);
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fiyat.Location = new System.Drawing.Point(704, 63);
            this.txt_fiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fiyat.MaxLength = 13;
            this.txt_fiyat.Multiline = true;
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(258, 43);
            this.txt_fiyat.TabIndex = 56;
            this.txt_fiyat.Visible = false;
            this.txt_fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fiyat_KeyPress);
            this.txt_fiyat.MouseLeave += new System.EventHandler(this.txt_fiyat_MouseLeave);
            this.txt_fiyat.MouseHover += new System.EventHandler(this.txt_fiyat_MouseHover);
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(704, 233);
            this.txt_adet.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adet.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_adet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(258, 22);
            this.txt_adet.TabIndex = 58;
            this.txt_adet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_adet.Visible = false;
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.Location = new System.Drawing.Point(554, 170);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(86, 22);
            this.lbl_ad.TabIndex = 61;
            this.lbl_ad.Text = "İLAÇ ADI";
            this.lbl_ad.Visible = false;
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_fiyat.AutoSize = true;
            this.lbl_fiyat.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_fiyat.Location = new System.Drawing.Point(554, 68);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(106, 22);
            this.lbl_fiyat.TabIndex = 61;
            this.lbl_fiyat.Text = "İLAÇ FİYATI";
            this.lbl_fiyat.Visible = false;
            // 
            // lbl_adet
            // 
            this.lbl_adet.AutoSize = true;
            this.lbl_adet.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adet.Location = new System.Drawing.Point(554, 236);
            this.lbl_adet.Name = "lbl_adet";
            this.lbl_adet.Size = new System.Drawing.Size(111, 22);
            this.lbl_adet.TabIndex = 65;
            this.lbl_adet.Text = "STOK ADEDİ";
            this.lbl_adet.Visible = false;
            // 
            // lbl_hataIlacAd
            // 
            this.lbl_hataIlacAd.AutoSize = true;
            this.lbl_hataIlacAd.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hataIlacAd.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataIlacAd.Location = new System.Drawing.Point(701, 128);
            this.lbl_hataIlacAd.Name = "lbl_hataIlacAd";
            this.lbl_hataIlacAd.Size = new System.Drawing.Size(198, 17);
            this.lbl_hataIlacAd.TabIndex = 70;
            this.lbl_hataIlacAd.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_hataIlacAd.Visible = false;
            // 
            // lbl_hataIlacFiyat
            // 
            this.lbl_hataIlacFiyat.AutoSize = true;
            this.lbl_hataIlacFiyat.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hataIlacFiyat.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataIlacFiyat.Location = new System.Drawing.Point(701, 44);
            this.lbl_hataIlacFiyat.Name = "lbl_hataIlacFiyat";
            this.lbl_hataIlacFiyat.Size = new System.Drawing.Size(198, 17);
            this.lbl_hataIlacFiyat.TabIndex = 72;
            this.lbl_hataIlacFiyat.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_hataIlacFiyat.Visible = false;
            // 
            // IlacGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 413);
            this.Controls.Add(this.btn_barkodBul);
            this.Controls.Add(this.lbl_hataIlacBarkod);
            this.Controls.Add(this.lbl_hataIlacKategori);
            this.Controls.Add(this.lbl_hataIlacFiyat);
            this.Controls.Add(this.lbl_hataIlacAd);
            this.Controls.Add(this.btn_ilacGuncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.lbl_adet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_kategori);
            this.Controls.Add(this.lbl_fiyat);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.txt_sontarih);
            this.Controls.Add(this.txt_kategori);
            this.Controls.Add(this.txt_adet);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.txt_barkod);
            this.Controls.Add(this.txt_ilacAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IlacGuncelle";
            this.Text = "İlaçGüncelle";
            this.Load += new System.EventHandler(this.İlaçGüncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_adet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_hataIlacBarkod;
        public System.Windows.Forms.Label lbl_hataIlacKategori;
        public System.Windows.Forms.Button btn_ilacGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_kategori;
        private System.Windows.Forms.DateTimePicker txt_sontarih;
        private System.Windows.Forms.ComboBox txt_kategori;
        private System.Windows.Forms.TextBox txt_barkod;
        private System.Windows.Forms.Button btn_barkodBul;
        private System.Windows.Forms.TextBox txt_ilacAd;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.NumericUpDown txt_adet;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_fiyat;
        private System.Windows.Forms.Label lbl_adet;
        public System.Windows.Forms.Label lbl_hataIlacAd;
        public System.Windows.Forms.Label lbl_hataIlacFiyat;
    }
}