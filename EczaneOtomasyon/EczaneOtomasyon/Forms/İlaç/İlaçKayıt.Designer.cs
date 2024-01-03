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
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ilaçKaydet = new System.Windows.Forms.Button();
            this.btn_KayıtKapat = new System.Windows.Forms.PictureBox();
            this.lbl_hataİlaçBarkod = new System.Windows.Forms.Label();
            this.lbl_hataİlaçKategori = new System.Windows.Forms.Label();
            this.lbl_hataİlaçFiyat = new System.Windows.Forms.Label();
            this.lbl_hataİlaçAd = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_sontarih = new System.Windows.Forms.DateTimePicker();
            this.txt_kategori = new System.Windows.Forms.ComboBox();
            this.txt_adet = new System.Windows.Forms.NumericUpDown();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_barkod = new System.Windows.Forms.TextBox();
            this.txt_ilaçAd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_KayıtKapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adet)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(253, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 34);
            this.label7.TabIndex = 35;
            this.label7.Text = "YENİ İLAÇ KAYDI";
            // 
            // btn_ilaçKaydet
            // 
            this.btn_ilaçKaydet.BackColor = System.Drawing.Color.Green;
            this.btn_ilaçKaydet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ilaçKaydet.Location = new System.Drawing.Point(205, 272);
            this.btn_ilaçKaydet.Name = "btn_ilaçKaydet";
            this.btn_ilaçKaydet.Size = new System.Drawing.Size(439, 56);
            this.btn_ilaçKaydet.TabIndex = 52;
            this.btn_ilaçKaydet.Text = "YENİ İLAÇ KAYDET";
            this.btn_ilaçKaydet.UseVisualStyleBackColor = false;
            this.btn_ilaçKaydet.Click += new System.EventHandler(this.btn_ilaçKaydet_Click);
            // 
            // btn_KayıtKapat
            // 
            this.btn_KayıtKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KayıtKapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_KayıtKapat.Image")));
            this.btn_KayıtKapat.Location = new System.Drawing.Point(917, 7);
            this.btn_KayıtKapat.Name = "btn_KayıtKapat";
            this.btn_KayıtKapat.Size = new System.Drawing.Size(35, 35);
            this.btn_KayıtKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_KayıtKapat.TabIndex = 54;
            this.btn_KayıtKapat.TabStop = false;
            this.btn_KayıtKapat.Click += new System.EventHandler(this.btn_KayıtKapat_Click);
            // 
            // lbl_hataİlaçBarkod
            // 
            this.lbl_hataİlaçBarkod.AutoSize = true;
            this.lbl_hataİlaçBarkod.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hataİlaçBarkod.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataİlaçBarkod.Location = new System.Drawing.Point(132, 109);
            this.lbl_hataİlaçBarkod.Name = "lbl_hataİlaçBarkod";
            this.lbl_hataİlaçBarkod.Size = new System.Drawing.Size(198, 17);
            this.lbl_hataİlaçBarkod.TabIndex = 95;
            this.lbl_hataİlaçBarkod.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_hataİlaçBarkod.Visible = false;
            // 
            // lbl_hataİlaçKategori
            // 
            this.lbl_hataİlaçKategori.AutoSize = true;
            this.lbl_hataİlaçKategori.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hataİlaçKategori.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataİlaçKategori.Location = new System.Drawing.Point(509, 103);
            this.lbl_hataİlaçKategori.Name = "lbl_hataİlaçKategori";
            this.lbl_hataİlaçKategori.Size = new System.Drawing.Size(198, 17);
            this.lbl_hataİlaçKategori.TabIndex = 94;
            this.lbl_hataİlaçKategori.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_hataİlaçKategori.Visible = false;
            // 
            // lbl_hataİlaçFiyat
            // 
            this.lbl_hataİlaçFiyat.AutoSize = true;
            this.lbl_hataİlaçFiyat.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hataİlaçFiyat.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataİlaçFiyat.Location = new System.Drawing.Point(509, 31);
            this.lbl_hataİlaçFiyat.Name = "lbl_hataİlaçFiyat";
            this.lbl_hataİlaçFiyat.Size = new System.Drawing.Size(198, 17);
            this.lbl_hataİlaçFiyat.TabIndex = 93;
            this.lbl_hataİlaçFiyat.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_hataİlaçFiyat.Visible = false;
            // 
            // lbl_hataİlaçAd
            // 
            this.lbl_hataİlaçAd.AutoSize = true;
            this.lbl_hataİlaçAd.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hataİlaçAd.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataİlaçAd.Location = new System.Drawing.Point(131, 31);
            this.lbl_hataİlaçAd.Name = "lbl_hataİlaçAd";
            this.lbl_hataİlaçAd.Size = new System.Drawing.Size(198, 17);
            this.lbl_hataİlaçAd.TabIndex = 91;
            this.lbl_hataİlaçAd.Text = " BU ALANI BOŞ BIRAKAMAZSINIZ";
            this.lbl_hataİlaçAd.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(4, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(204, 22);
            this.label15.TabIndex = 87;
            this.label15.Text = "SON KULLANMA TARİHİ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(395, 199);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 22);
            this.label16.TabIndex = 86;
            this.label16.Text = "STOK ADEDİ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(4, 131);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(115, 22);
            this.label17.TabIndex = 88;
            this.label17.Text = "BARKOD NO";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(395, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 22);
            this.label18.TabIndex = 85;
            this.label18.Text = "KATEGORİ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(400, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 22);
            this.label19.TabIndex = 84;
            this.label19.Text = "FİYAT";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(4, 64);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 22);
            this.label21.TabIndex = 82;
            this.label21.Text = "İLAÇ ADI";
            // 
            // txt_sontarih
            // 
            this.txt_sontarih.Location = new System.Drawing.Point(215, 194);
            this.txt_sontarih.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sontarih.Name = "txt_sontarih";
            this.txt_sontarih.Size = new System.Drawing.Size(167, 28);
            this.txt_sontarih.TabIndex = 81;
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
            this.txt_kategori.Location = new System.Drawing.Point(512, 129);
            this.txt_kategori.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kategori.Name = "txt_kategori";
            this.txt_kategori.Size = new System.Drawing.Size(258, 29);
            this.txt_kategori.Sorted = true;
            this.txt_kategori.TabIndex = 80;
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(512, 194);
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
            this.txt_adet.TabIndex = 79;
            this.txt_adet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_fiyat.Location = new System.Drawing.Point(512, 52);
            this.txt_fiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fiyat.MaxLength = 13;
            this.txt_fiyat.Multiline = true;
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(258, 43);
            this.txt_fiyat.TabIndex = 77;
            // 
            // txt_barkod
            // 
            this.txt_barkod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_barkod.Location = new System.Drawing.Point(134, 131);
            this.txt_barkod.Margin = new System.Windows.Forms.Padding(4);
            this.txt_barkod.MaxLength = 13;
            this.txt_barkod.Multiline = true;
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Size = new System.Drawing.Size(258, 43);
            this.txt_barkod.TabIndex = 76;
            // 
            // txt_ilaçAd
            // 
            this.txt_ilaçAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ilaçAd.Location = new System.Drawing.Point(135, 56);
            this.txt_ilaçAd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ilaçAd.Multiline = true;
            this.txt_ilaçAd.Name = "txt_ilaçAd";
            this.txt_ilaçAd.Size = new System.Drawing.Size(258, 43);
            this.txt_ilaçAd.TabIndex = 75;
            // 
            // İlaçKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(839, 367);
            this.Controls.Add(this.lbl_hataİlaçBarkod);
            this.Controls.Add(this.lbl_hataİlaçKategori);
            this.Controls.Add(this.lbl_hataİlaçFiyat);
            this.Controls.Add(this.lbl_hataİlaçAd);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txt_sontarih);
            this.Controls.Add(this.txt_kategori);
            this.Controls.Add(this.txt_adet);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.txt_barkod);
            this.Controls.Add(this.txt_ilaçAd);
            this.Controls.Add(this.btn_KayıtKapat);
            this.Controls.Add(this.btn_ilaçKaydet);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "İlaçKayıt";
            this.Text = "İlaçKayıt";
            this.Load += new System.EventHandler(this.İlaçKayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_KayıtKapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_adet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btn_ilaçKaydet;
        private System.Windows.Forms.PictureBox btn_KayıtKapat;
        public System.Windows.Forms.Label lbl_hataİlaçBarkod;
        public System.Windows.Forms.Label lbl_hataİlaçKategori;
        public System.Windows.Forms.Label lbl_hataİlaçFiyat;
        public System.Windows.Forms.Label lbl_hataİlaçAd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker txt_sontarih;
        private System.Windows.Forms.ComboBox txt_kategori;
        private System.Windows.Forms.NumericUpDown txt_adet;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_barkod;
        private System.Windows.Forms.TextBox txt_ilaçAd;
    }
}