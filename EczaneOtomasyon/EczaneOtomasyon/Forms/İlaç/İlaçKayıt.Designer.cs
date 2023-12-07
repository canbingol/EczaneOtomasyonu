namespace EczaneOtomasyon.Forms.İlaç
{
    partial class İlaçKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İlaçKayıt));
            this.txt_ilaçAd = new System.Windows.Forms.TextBox();
            this.txt_ilaçFirma = new System.Windows.Forms.TextBox();
            this.txt_adet = new System.Windows.Forms.NumericUpDown();
            this.txt_kategori = new System.Windows.Forms.ComboBox();
            this.txt_sontarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ilaçKaydet = new System.Windows.Forms.Button();
            this.lbl_hataİlaçAd = new System.Windows.Forms.Label();
            this.lbl_hataİlaçFirma = new System.Windows.Forms.Label();
            this.lbl_hataİlaçKategori = new System.Windows.Forms.Label();
            this.lbl_hataİlaçBarkod = new System.Windows.Forms.Label();
            this.lbl_hataİlaçStok = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_barkod = new System.Windows.Forms.TextBox();
            this.lbl_hataİlaçFiyat = new System.Windows.Forms.Label();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.btn_KayıtKapat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_KayıtKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ilaçAd
            // 
            this.txt_ilaçAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ilaçAd.Location = new System.Drawing.Point(250, 79);
            this.txt_ilaçAd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ilaçAd.Multiline = true;
            this.txt_ilaçAd.Name = "txt_ilaçAd";
            this.txt_ilaçAd.Size = new System.Drawing.Size(258, 43);
            this.txt_ilaçAd.TabIndex = 0;
            // 
            // txt_ilaçFirma
            // 
            this.txt_ilaçFirma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ilaçFirma.Location = new System.Drawing.Point(250, 163);
            this.txt_ilaçFirma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ilaçFirma.Multiline = true;
            this.txt_ilaçFirma.Name = "txt_ilaçFirma";
            this.txt_ilaçFirma.Size = new System.Drawing.Size(258, 43);
            this.txt_ilaçFirma.TabIndex = 0;
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(250, 506);
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
            this.txt_adet.Size = new System.Drawing.Size(258, 28);
            this.txt_adet.TabIndex = 1;
            this.txt_adet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.txt_kategori.Location = new System.Drawing.Point(250, 337);
            this.txt_kategori.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kategori.Name = "txt_kategori";
            this.txt_kategori.Size = new System.Drawing.Size(258, 29);
            this.txt_kategori.Sorted = true;
            this.txt_kategori.TabIndex = 3;
            // 
            // txt_sontarih
            // 
            this.txt_sontarih.Location = new System.Drawing.Point(250, 587);
            this.txt_sontarih.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sontarih.Name = "txt_sontarih";
            this.txt_sontarih.Size = new System.Drawing.Size(258, 28);
            this.txt_sontarih.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "İLAÇ ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "ÜRETİCİSİ FİRMA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "KATEGORİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "BARKOD NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "STOK ADEDİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(10, 593);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "SON KULLANMA TARİHİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(89, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 34);
            this.label7.TabIndex = 35;
            this.label7.Text = "YENİ İLAÇ KAYDI";
            // 
            // btn_ilaçKaydet
            // 
            this.btn_ilaçKaydet.BackColor = System.Drawing.Color.Red;
            this.btn_ilaçKaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ilaçKaydet.Location = new System.Drawing.Point(336, 651);
            this.btn_ilaçKaydet.Name = "btn_ilaçKaydet";
            this.btn_ilaçKaydet.Size = new System.Drawing.Size(258, 56);
            this.btn_ilaçKaydet.TabIndex = 52;
            this.btn_ilaçKaydet.Text = "İLAÇ KAYDI OLUŞTUR";
            this.btn_ilaçKaydet.UseVisualStyleBackColor = false;
            this.btn_ilaçKaydet.Click += new System.EventHandler(this.btn_ilaçKaydet_Click);
            // 
            // lbl_hataİlaçAd
            // 
            this.lbl_hataİlaçAd.AutoSize = true;
            this.lbl_hataİlaçAd.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hataİlaçAd.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataİlaçAd.Location = new System.Drawing.Point(246, 54);
            this.lbl_hataİlaçAd.Name = "lbl_hataİlaçAd";
            this.lbl_hataİlaçAd.Size = new System.Drawing.Size(198, 17);
            this.lbl_hataİlaçAd.TabIndex = 53;
            this.lbl_hataİlaçAd.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_hataİlaçAd.Visible = false;
            // 
            // lbl_hataİlaçFirma
            // 
            this.lbl_hataİlaçFirma.AutoSize = true;
            this.lbl_hataİlaçFirma.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hataİlaçFirma.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataİlaçFirma.Location = new System.Drawing.Point(247, 142);
            this.lbl_hataİlaçFirma.Name = "lbl_hataİlaçFirma";
            this.lbl_hataİlaçFirma.Size = new System.Drawing.Size(198, 17);
            this.lbl_hataİlaçFirma.TabIndex = 53;
            this.lbl_hataİlaçFirma.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_hataİlaçFirma.Visible = false;
            // 
            // lbl_hataİlaçKategori
            // 
            this.lbl_hataİlaçKategori.AutoSize = true;
            this.lbl_hataİlaçKategori.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hataİlaçKategori.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataİlaçKategori.Location = new System.Drawing.Point(247, 316);
            this.lbl_hataİlaçKategori.Name = "lbl_hataİlaçKategori";
            this.lbl_hataİlaçKategori.Size = new System.Drawing.Size(198, 17);
            this.lbl_hataİlaçKategori.TabIndex = 53;
            this.lbl_hataİlaçKategori.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_hataİlaçKategori.Visible = false;
            // 
            // lbl_hataİlaçBarkod
            // 
            this.lbl_hataİlaçBarkod.AutoSize = true;
            this.lbl_hataİlaçBarkod.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hataİlaçBarkod.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataİlaçBarkod.Location = new System.Drawing.Point(247, 400);
            this.lbl_hataİlaçBarkod.Name = "lbl_hataİlaçBarkod";
            this.lbl_hataİlaçBarkod.Size = new System.Drawing.Size(198, 17);
            this.lbl_hataİlaçBarkod.TabIndex = 53;
            this.lbl_hataİlaçBarkod.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_hataİlaçBarkod.Visible = false;
            // 
            // lbl_hataİlaçStok
            // 
            this.lbl_hataİlaçStok.AutoSize = true;
            this.lbl_hataİlaçStok.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hataİlaçStok.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataİlaçStok.Location = new System.Drawing.Point(246, 485);
            this.lbl_hataİlaçStok.Name = "lbl_hataİlaçStok";
            this.lbl_hataİlaçStok.Size = new System.Drawing.Size(198, 17);
            this.lbl_hataİlaçStok.TabIndex = 53;
            this.lbl_hataİlaçStok.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_hataİlaçStok.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(10, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 22);
            this.label12.TabIndex = 32;
            this.label12.Text = "FİYAT";
            // 
            // txt_barkod
            // 
            this.txt_barkod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_barkod.Location = new System.Drawing.Point(249, 421);
            this.txt_barkod.Margin = new System.Windows.Forms.Padding(4);
            this.txt_barkod.MaxLength = 13;
            this.txt_barkod.Multiline = true;
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Size = new System.Drawing.Size(258, 43);
            this.txt_barkod.TabIndex = 0;
            this.txt_barkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_barkod_KeyPress);
            // 
            // lbl_hataİlaçFiyat
            // 
            this.lbl_hataİlaçFiyat.AutoSize = true;
            this.lbl_hataİlaçFiyat.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hataİlaçFiyat.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataİlaçFiyat.Location = new System.Drawing.Point(246, 228);
            this.lbl_hataİlaçFiyat.Name = "lbl_hataİlaçFiyat";
            this.lbl_hataİlaçFiyat.Size = new System.Drawing.Size(198, 17);
            this.lbl_hataİlaçFiyat.TabIndex = 53;
            this.lbl_hataİlaçFiyat.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_hataİlaçFiyat.Visible = false;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fiyat.Location = new System.Drawing.Point(249, 251);
            this.txt_fiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fiyat.MaxLength = 13;
            this.txt_fiyat.Multiline = true;
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(258, 43);
            this.txt_fiyat.TabIndex = 0;
            this.txt_fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fiyat_KeyPress);
            // 
            // btn_KayıtKapat
            // 
            this.btn_KayıtKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KayıtKapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_KayıtKapat.Image")));
            this.btn_KayıtKapat.Location = new System.Drawing.Point(631, 3);
            this.btn_KayıtKapat.Name = "btn_KayıtKapat";
            this.btn_KayıtKapat.Size = new System.Drawing.Size(35, 35);
            this.btn_KayıtKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_KayıtKapat.TabIndex = 54;
            this.btn_KayıtKapat.TabStop = false;
            this.btn_KayıtKapat.Click += new System.EventHandler(this.btn_KayıtKapat_Click);
            // 
            // İlaçKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 720);
            this.Controls.Add(this.btn_KayıtKapat);
            this.Controls.Add(this.lbl_hataİlaçStok);
            this.Controls.Add(this.lbl_hataİlaçBarkod);
            this.Controls.Add(this.lbl_hataİlaçKategori);
            this.Controls.Add(this.lbl_hataİlaçFiyat);
            this.Controls.Add(this.lbl_hataİlaçFirma);
            this.Controls.Add(this.lbl_hataİlaçAd);
            this.Controls.Add(this.btn_ilaçKaydet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sontarih);
            this.Controls.Add(this.txt_kategori);
            this.Controls.Add(this.txt_adet);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.txt_barkod);
            this.Controls.Add(this.txt_ilaçFirma);
            this.Controls.Add(this.txt_ilaçAd);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "İlaçKayıt";
            this.Text = "İlaçKayıt";
            ((System.ComponentModel.ISupportInitialize)(this.txt_adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_KayıtKapat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ilaçAd;
        private System.Windows.Forms.TextBox txt_ilaçFirma;
        private System.Windows.Forms.NumericUpDown txt_adet;
        private System.Windows.Forms.ComboBox txt_kategori;
        private System.Windows.Forms.DateTimePicker txt_sontarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btn_ilaçKaydet;
        public System.Windows.Forms.Label lbl_hataİlaçAd;
        public System.Windows.Forms.Label lbl_hataİlaçFirma;
        public System.Windows.Forms.Label lbl_hataİlaçKategori;
        public System.Windows.Forms.Label lbl_hataİlaçBarkod;
        public System.Windows.Forms.Label lbl_hataİlaçStok;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_barkod;
        public System.Windows.Forms.Label lbl_hataİlaçFiyat;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.PictureBox btn_KayıtKapat;
    }
}