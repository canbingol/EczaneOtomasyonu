namespace EczaneOtomasyon
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_Parola = new System.Windows.Forms.Label();
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.btn_sifreUnuttum = new System.Windows.Forms.LinkLabel();
            this.btn_yeniKullanıcı = new System.Windows.Forms.Button();
            this.PanelYeniKayit = new System.Windows.Forms.Panel();
            this.comboBox_yetki = new System.Windows.Forms.ComboBox();
            this.btn_kayitKapat = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_yeniParolaTekrar = new System.Windows.Forms.Label();
            this.lbl_hataKayitParola2 = new System.Windows.Forms.Label();
            this.lbl_hataKayitParola1 = new System.Windows.Forms.Label();
            this.lbl_hataKayitKullaniciAdi = new System.Windows.Forms.Label();
            this.btn_YeniKayitEkle = new System.Windows.Forms.Button();
            this.lbl_YeniParola = new System.Windows.Forms.Label();
            this.lblYeniKullanıcıAdı = new System.Windows.Forms.Label();
            this.txt_kayitKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_kayitParola = new System.Windows.Forms.TextBox();
            this.txt_kayitParola2 = new System.Windows.Forms.TextBox();
            this.panel_SifreDegistir = new System.Windows.Forms.Panel();
            this.btn_parolaKapat = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_hataUnuttumParola2 = new System.Windows.Forms.Label();
            this.lbl_hataParolaKullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_hataUnuttumParola1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_yeniParolaKaydet = new System.Windows.Forms.Button();
            this.txt_YeniParola2 = new System.Windows.Forms.TextBox();
            this.txt_YeniParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_parolaKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_hataKullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_hataParola = new System.Windows.Forms.Label();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.txt_Parola = new System.Windows.Forms.TextBox();
            this.PanelYeniKayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kayitKapat)).BeginInit();
            this.panel_SifreDegistir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_parolaKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.BackColor = System.Drawing.Color.White;
            this.lbl_KullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_KullaniciAdi.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_KullaniciAdi.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(474, 109);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(154, 29);
            this.lbl_KullaniciAdi.TabIndex = 0;
            this.lbl_KullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lbl_Parola
            // 
            this.lbl_Parola.AutoSize = true;
            this.lbl_Parola.BackColor = System.Drawing.Color.White;
            this.lbl_Parola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Parola.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_Parola.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Parola.ForeColor = System.Drawing.Color.Black;
            this.lbl_Parola.Location = new System.Drawing.Point(550, 169);
            this.lbl_Parola.Name = "lbl_Parola";
            this.lbl_Parola.Size = new System.Drawing.Size(85, 29);
            this.lbl_Parola.TabIndex = 0;
            this.lbl_Parola.Text = "Parola";
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(652, 109);
            this.txt_KullaniciAdi.Multiline = true;
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(217, 32);
            this.txt_KullaniciAdi.TabIndex = 0;
            // 
            // btn_Giris
            // 
            this.btn_Giris.BackColor = System.Drawing.Color.White;
            this.btn_Giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Giris.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Giris.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.Location = new System.Drawing.Point(645, 238);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(217, 44);
            this.btn_Giris.TabIndex = 2;
            this.btn_Giris.Text = "&GİRİŞ";
            this.btn_Giris.UseVisualStyleBackColor = false;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giriş_Click);
            // 
            // btn_sifreUnuttum
            // 
            this.btn_sifreUnuttum.AutoSize = true;
            this.btn_sifreUnuttum.BackColor = System.Drawing.Color.White;
            this.btn_sifreUnuttum.Location = new System.Drawing.Point(536, 238);
            this.btn_sifreUnuttum.Name = "btn_sifreUnuttum";
            this.btn_sifreUnuttum.Size = new System.Drawing.Size(99, 16);
            this.btn_sifreUnuttum.TabIndex = 3;
            this.btn_sifreUnuttum.TabStop = true;
            this.btn_sifreUnuttum.Text = "Şifremi Unuttum";
            this.btn_sifreUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_sifreUnuttum_LinkClicked);
            // 
            // btn_yeniKullanıcı
            // 
            this.btn_yeniKullanıcı.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yeniKullanıcı.Location = new System.Drawing.Point(686, 484);
            this.btn_yeniKullanıcı.Name = "btn_yeniKullanıcı";
            this.btn_yeniKullanıcı.Size = new System.Drawing.Size(217, 44);
            this.btn_yeniKullanıcı.TabIndex = 4;
            this.btn_yeniKullanıcı.Text = "YENİ KULLANICI";
            this.btn_yeniKullanıcı.UseVisualStyleBackColor = true;
            this.btn_yeniKullanıcı.Click += new System.EventHandler(this.btn_yeniKullanici_Click);
            // 
            // PanelYeniKayit
            // 
            this.PanelYeniKayit.BackColor = System.Drawing.Color.Transparent;
            this.PanelYeniKayit.Controls.Add(this.comboBox_yetki);
            this.PanelYeniKayit.Controls.Add(this.btn_kayitKapat);
            this.PanelYeniKayit.Controls.Add(this.label5);
            this.PanelYeniKayit.Controls.Add(this.label6);
            this.PanelYeniKayit.Controls.Add(this.lbl_yeniParolaTekrar);
            this.PanelYeniKayit.Controls.Add(this.lbl_hataKayitParola2);
            this.PanelYeniKayit.Controls.Add(this.lbl_hataKayitParola1);
            this.PanelYeniKayit.Controls.Add(this.lbl_hataKayitKullaniciAdi);
            this.PanelYeniKayit.Controls.Add(this.btn_YeniKayitEkle);
            this.PanelYeniKayit.Controls.Add(this.lbl_YeniParola);
            this.PanelYeniKayit.Controls.Add(this.lblYeniKullanıcıAdı);
            this.PanelYeniKayit.Controls.Add(this.txt_kayitKullaniciAdi);
            this.PanelYeniKayit.Controls.Add(this.txt_kayitParola);
            this.PanelYeniKayit.Controls.Add(this.txt_kayitParola2);
            this.PanelYeniKayit.Location = new System.Drawing.Point(12, 109);
            this.PanelYeniKayit.Name = "PanelYeniKayit";
            this.PanelYeniKayit.Size = new System.Drawing.Size(474, 557);
            this.PanelYeniKayit.TabIndex = 5;
            this.PanelYeniKayit.Visible = false;
            // 
            // comboBox_yetki
            // 
            this.comboBox_yetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_yetki.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_yetki.FormattingEnabled = true;
            this.comboBox_yetki.Items.AddRange(new object[] {
            "admin",
            "calisan"});
            this.comboBox_yetki.Location = new System.Drawing.Point(190, 281);
            this.comboBox_yetki.Name = "comboBox_yetki";
            this.comboBox_yetki.Size = new System.Drawing.Size(212, 31);
            this.comboBox_yetki.TabIndex = 10;
            // 
            // btn_kayitKapat
            // 
            this.btn_kayitKapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_kayitKapat.Image")));
            this.btn_kayitKapat.Location = new System.Drawing.Point(385, 20);
            this.btn_kayitKapat.Name = "btn_kayitKapat";
            this.btn_kayitKapat.Size = new System.Drawing.Size(35, 35);
            this.btn_kayitKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_kayitKapat.TabIndex = 9;
            this.btn_kayitKapat.TabStop = false;
            this.btn_kayitKapat.Click += new System.EventHandler(this.btn_kayitKapat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(21, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "YENİ KULLANICI KAYDI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(75, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "YETKİ";
            // 
            // lbl_yeniParolaTekrar
            // 
            this.lbl_yeniParolaTekrar.AutoSize = true;
            this.lbl_yeniParolaTekrar.BackColor = System.Drawing.Color.White;
            this.lbl_yeniParolaTekrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_yeniParolaTekrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_yeniParolaTekrar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yeniParolaTekrar.ForeColor = System.Drawing.Color.Black;
            this.lbl_yeniParolaTekrar.Location = new System.Drawing.Point(75, 219);
            this.lbl_yeniParolaTekrar.Name = "lbl_yeniParolaTekrar";
            this.lbl_yeniParolaTekrar.Size = new System.Drawing.Size(85, 29);
            this.lbl_yeniParolaTekrar.TabIndex = 0;
            this.lbl_yeniParolaTekrar.Text = "Parola";
            // 
            // lbl_hataKayitParola2
            // 
            this.lbl_hataKayitParola2.AutoSize = true;
            this.lbl_hataKayitParola2.BackColor = System.Drawing.Color.White;
            this.lbl_hataKayitParola2.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataKayitParola2.Location = new System.Drawing.Point(187, 201);
            this.lbl_hataKayitParola2.Name = "lbl_hataKayitParola2";
            this.lbl_hataKayitParola2.Size = new System.Drawing.Size(184, 16);
            this.lbl_hataKayitParola2.TabIndex = 7;
            this.lbl_hataKayitParola2.Text = "BU ALAN BOŞ BIRAKILAMAZ";
            this.lbl_hataKayitParola2.Visible = false;
            // 
            // lbl_hataKayitParola1
            // 
            this.lbl_hataKayitParola1.AutoSize = true;
            this.lbl_hataKayitParola1.BackColor = System.Drawing.Color.White;
            this.lbl_hataKayitParola1.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataKayitParola1.Location = new System.Drawing.Point(188, 142);
            this.lbl_hataKayitParola1.Name = "lbl_hataKayitParola1";
            this.lbl_hataKayitParola1.Size = new System.Drawing.Size(184, 16);
            this.lbl_hataKayitParola1.TabIndex = 7;
            this.lbl_hataKayitParola1.Text = "BU ALAN BOŞ BIRAKILAMAZ";
            this.lbl_hataKayitParola1.Visible = false;
            // 
            // lbl_hataKayitKullaniciAdi
            // 
            this.lbl_hataKayitKullaniciAdi.AutoSize = true;
            this.lbl_hataKayitKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.lbl_hataKayitKullaniciAdi.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataKayitKullaniciAdi.Location = new System.Drawing.Point(187, 80);
            this.lbl_hataKayitKullaniciAdi.Name = "lbl_hataKayitKullaniciAdi";
            this.lbl_hataKayitKullaniciAdi.Size = new System.Drawing.Size(184, 16);
            this.lbl_hataKayitKullaniciAdi.TabIndex = 7;
            this.lbl_hataKayitKullaniciAdi.Text = "BU ALAN BOŞ BIRAKILAMAZ";
            this.lbl_hataKayitKullaniciAdi.Visible = false;
            // 
            // btn_YeniKayitEkle
            // 
            this.btn_YeniKayitEkle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_YeniKayitEkle.Location = new System.Drawing.Point(185, 375);
            this.btn_YeniKayitEkle.Name = "btn_YeniKayitEkle";
            this.btn_YeniKayitEkle.Size = new System.Drawing.Size(217, 44);
            this.btn_YeniKayitEkle.TabIndex = 4;
            this.btn_YeniKayitEkle.Text = "KAYIT EKLE";
            this.btn_YeniKayitEkle.UseVisualStyleBackColor = true;
            this.btn_YeniKayitEkle.Click += new System.EventHandler(this.btn_YeniKayitEkle_Click);
            // 
            // lbl_YeniParola
            // 
            this.lbl_YeniParola.AutoSize = true;
            this.lbl_YeniParola.BackColor = System.Drawing.Color.White;
            this.lbl_YeniParola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_YeniParola.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_YeniParola.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_YeniParola.ForeColor = System.Drawing.Color.Black;
            this.lbl_YeniParola.Location = new System.Drawing.Point(75, 159);
            this.lbl_YeniParola.Name = "lbl_YeniParola";
            this.lbl_YeniParola.Size = new System.Drawing.Size(85, 29);
            this.lbl_YeniParola.TabIndex = 0;
            this.lbl_YeniParola.Text = "Parola";
            // 
            // lblYeniKullanıcıAdı
            // 
            this.lblYeniKullanıcıAdı.AutoSize = true;
            this.lblYeniKullanıcıAdı.BackColor = System.Drawing.Color.White;
            this.lblYeniKullanıcıAdı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYeniKullanıcıAdı.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblYeniKullanıcıAdı.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniKullanıcıAdı.ForeColor = System.Drawing.Color.Black;
            this.lblYeniKullanıcıAdı.Location = new System.Drawing.Point(6, 97);
            this.lblYeniKullanıcıAdı.Name = "lblYeniKullanıcıAdı";
            this.lblYeniKullanıcıAdı.Size = new System.Drawing.Size(154, 29);
            this.lblYeniKullanıcıAdı.TabIndex = 0;
            this.lblYeniKullanıcıAdı.Text = "Kullanıcı Adı";
            // 
            // txt_kayitKullaniciAdi
            // 
            this.txt_kayitKullaniciAdi.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kayitKullaniciAdi.Location = new System.Drawing.Point(185, 97);
            this.txt_kayitKullaniciAdi.Multiline = true;
            this.txt_kayitKullaniciAdi.Name = "txt_kayitKullaniciAdi";
            this.txt_kayitKullaniciAdi.Size = new System.Drawing.Size(217, 32);
            this.txt_kayitKullaniciAdi.TabIndex = 1;
            // 
            // txt_kayitParola
            // 
            this.txt_kayitParola.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kayitParola.Location = new System.Drawing.Point(185, 159);
            this.txt_kayitParola.Multiline = true;
            this.txt_kayitParola.Name = "txt_kayitParola";
            this.txt_kayitParola.Size = new System.Drawing.Size(217, 32);
            this.txt_kayitParola.TabIndex = 1;
            // 
            // txt_kayitParola2
            // 
            this.txt_kayitParola2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kayitParola2.Location = new System.Drawing.Point(185, 219);
            this.txt_kayitParola2.Multiline = true;
            this.txt_kayitParola2.Name = "txt_kayitParola2";
            this.txt_kayitParola2.Size = new System.Drawing.Size(217, 32);
            this.txt_kayitParola2.TabIndex = 1;
            // 
            // panel_SifreDegistir
            // 
            this.panel_SifreDegistir.BackColor = System.Drawing.Color.Transparent;
            this.panel_SifreDegistir.Controls.Add(this.btn_parolaKapat);
            this.panel_SifreDegistir.Controls.Add(this.label4);
            this.panel_SifreDegistir.Controls.Add(this.lbl_hataUnuttumParola2);
            this.panel_SifreDegistir.Controls.Add(this.lbl_hataParolaKullaniciAdi);
            this.panel_SifreDegistir.Controls.Add(this.lbl_hataUnuttumParola1);
            this.panel_SifreDegistir.Controls.Add(this.label2);
            this.panel_SifreDegistir.Controls.Add(this.btn_yeniParolaKaydet);
            this.panel_SifreDegistir.Controls.Add(this.txt_YeniParola2);
            this.panel_SifreDegistir.Controls.Add(this.txt_YeniParola);
            this.panel_SifreDegistir.Controls.Add(this.label1);
            this.panel_SifreDegistir.Controls.Add(this.txt_parolaKullaniciAdi);
            this.panel_SifreDegistir.Controls.Add(this.label3);
            this.panel_SifreDegistir.Location = new System.Drawing.Point(539, 296);
            this.panel_SifreDegistir.Name = "panel_SifreDegistir";
            this.panel_SifreDegistir.Size = new System.Drawing.Size(495, 537);
            this.panel_SifreDegistir.TabIndex = 6;
            this.panel_SifreDegistir.Visible = false;
            // 
            // btn_parolaKapat
            // 
            this.btn_parolaKapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_parolaKapat.Image")));
            this.btn_parolaKapat.Location = new System.Drawing.Point(457, 3);
            this.btn_parolaKapat.Name = "btn_parolaKapat";
            this.btn_parolaKapat.Size = new System.Drawing.Size(35, 35);
            this.btn_parolaKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_parolaKapat.TabIndex = 9;
            this.btn_parolaKapat.TabStop = false;
            this.btn_parolaKapat.Click += new System.EventHandler(this.btn_parolaKapat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "PAROLA GÜNCELLE";
            // 
            // lbl_hataUnuttumParola2
            // 
            this.lbl_hataUnuttumParola2.AutoSize = true;
            this.lbl_hataUnuttumParola2.BackColor = System.Drawing.Color.White;
            this.lbl_hataUnuttumParola2.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataUnuttumParola2.Location = new System.Drawing.Point(186, 217);
            this.lbl_hataUnuttumParola2.Name = "lbl_hataUnuttumParola2";
            this.lbl_hataUnuttumParola2.Size = new System.Drawing.Size(184, 16);
            this.lbl_hataUnuttumParola2.TabIndex = 7;
            this.lbl_hataUnuttumParola2.Text = "BU ALAN BOŞ BIRAKILAMAZ";
            this.lbl_hataUnuttumParola2.Visible = false;
            // 
            // lbl_hataParolaKullaniciAdi
            // 
            this.lbl_hataParolaKullaniciAdi.AutoSize = true;
            this.lbl_hataParolaKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.lbl_hataParolaKullaniciAdi.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataParolaKullaniciAdi.Location = new System.Drawing.Point(197, 85);
            this.lbl_hataParolaKullaniciAdi.Name = "lbl_hataParolaKullaniciAdi";
            this.lbl_hataParolaKullaniciAdi.Size = new System.Drawing.Size(184, 16);
            this.lbl_hataParolaKullaniciAdi.TabIndex = 7;
            this.lbl_hataParolaKullaniciAdi.Text = "BU ALAN BOŞ BIRAKILAMAZ";
            this.lbl_hataParolaKullaniciAdi.Visible = false;
            // 
            // lbl_hataUnuttumParola1
            // 
            this.lbl_hataUnuttumParola1.AutoSize = true;
            this.lbl_hataUnuttumParola1.BackColor = System.Drawing.Color.White;
            this.lbl_hataUnuttumParola1.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataUnuttumParola1.Location = new System.Drawing.Point(190, 151);
            this.lbl_hataUnuttumParola1.Name = "lbl_hataUnuttumParola1";
            this.lbl_hataUnuttumParola1.Size = new System.Drawing.Size(184, 16);
            this.lbl_hataUnuttumParola1.TabIndex = 7;
            this.lbl_hataUnuttumParola1.Text = "BU ALAN BOŞ BIRAKILAMAZ";
            this.lbl_hataUnuttumParola1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(79, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parola";
            // 
            // btn_yeniParolaKaydet
            // 
            this.btn_yeniParolaKaydet.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yeniParolaKaydet.Location = new System.Drawing.Point(168, 282);
            this.btn_yeniParolaKaydet.Name = "btn_yeniParolaKaydet";
            this.btn_yeniParolaKaydet.Size = new System.Drawing.Size(240, 44);
            this.btn_yeniParolaKaydet.TabIndex = 4;
            this.btn_yeniParolaKaydet.Text = "PAROLA KAYDET";
            this.btn_yeniParolaKaydet.UseVisualStyleBackColor = true;
            this.btn_yeniParolaKaydet.Click += new System.EventHandler(this.btn_yeniParolaKaydet_Click);
            // 
            // txt_YeniParola2
            // 
            this.txt_YeniParola2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_YeniParola2.Location = new System.Drawing.Point(189, 232);
            this.txt_YeniParola2.Multiline = true;
            this.txt_YeniParola2.Name = "txt_YeniParola2";
            this.txt_YeniParola2.Size = new System.Drawing.Size(217, 32);
            this.txt_YeniParola2.TabIndex = 1;
            // 
            // txt_YeniParola
            // 
            this.txt_YeniParola.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_YeniParola.Location = new System.Drawing.Point(190, 167);
            this.txt_YeniParola.Multiline = true;
            this.txt_YeniParola.Name = "txt_YeniParola";
            this.txt_YeniParola.PasswordChar = '*';
            this.txt_YeniParola.Size = new System.Drawing.Size(217, 32);
            this.txt_YeniParola.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(79, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parola";
            // 
            // txt_parolaKullaniciAdi
            // 
            this.txt_parolaKullaniciAdi.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_parolaKullaniciAdi.Location = new System.Drawing.Point(191, 105);
            this.txt_parolaKullaniciAdi.Multiline = true;
            this.txt_parolaKullaniciAdi.Name = "txt_parolaKullaniciAdi";
            this.txt_parolaKullaniciAdi.Size = new System.Drawing.Size(217, 32);
            this.txt_parolaKullaniciAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // lbl_hataKullaniciAdi
            // 
            this.lbl_hataKullaniciAdi.AutoSize = true;
            this.lbl_hataKullaniciAdi.BackColor = System.Drawing.Color.White;
            this.lbl_hataKullaniciAdi.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataKullaniciAdi.Location = new System.Drawing.Point(658, 89);
            this.lbl_hataKullaniciAdi.Name = "lbl_hataKullaniciAdi";
            this.lbl_hataKullaniciAdi.Size = new System.Drawing.Size(184, 16);
            this.lbl_hataKullaniciAdi.TabIndex = 7;
            this.lbl_hataKullaniciAdi.Text = "BU ALAN BOŞ BIRAKILAMAZ";
            this.lbl_hataKullaniciAdi.Visible = false;
            // 
            // lbl_hataParola
            // 
            this.lbl_hataParola.AutoSize = true;
            this.lbl_hataParola.BackColor = System.Drawing.Color.White;
            this.lbl_hataParola.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataParola.Location = new System.Drawing.Point(658, 161);
            this.lbl_hataParola.Name = "lbl_hataParola";
            this.lbl_hataParola.Size = new System.Drawing.Size(184, 16);
            this.lbl_hataParola.TabIndex = 7;
            this.lbl_hataParola.Text = "BU ALAN BOŞ BIRAKILAMAZ";
            this.lbl_hataParola.Visible = false;
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Transparent;
            this.btn_cikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(1090, 2);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(42, 36);
            this.btn_cikis.TabIndex = 11;
            this.btn_cikis.Text = "&X";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click_1);
            // 
            // txt_Parola
            // 
            this.txt_Parola.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Parola.Location = new System.Drawing.Point(652, 171);
            this.txt_Parola.Multiline = true;
            this.txt_Parola.Name = "txt_Parola";
            this.txt_Parola.Size = new System.Drawing.Size(217, 32);
            this.txt_Parola.TabIndex = 1;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_Giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btn_cikis;
            this.ClientSize = new System.Drawing.Size(1132, 690);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.lbl_hataParola);
            this.Controls.Add(this.lbl_hataKullaniciAdi);
            this.Controls.Add(this.PanelYeniKayit);
            this.Controls.Add(this.panel_SifreDegistir);
            this.Controls.Add(this.btn_yeniKullanıcı);
            this.Controls.Add(this.btn_sifreUnuttum);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.Controls.Add(this.lbl_Parola);
            this.Controls.Add(this.lbl_KullaniciAdi);
            this.Controls.Add(this.txt_Parola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.PanelYeniKayit.ResumeLayout(false);
            this.PanelYeniKayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kayitKapat)).EndInit();
            this.panel_SifreDegistir.ResumeLayout(false);
            this.panel_SifreDegistir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_parolaKapat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.Label lbl_Parola;
        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.LinkLabel btn_sifreUnuttum;
        private System.Windows.Forms.Button btn_yeniKullanıcı;
        private System.Windows.Forms.Panel PanelYeniKayit;
        private System.Windows.Forms.Label lbl_YeniParola;
        private System.Windows.Forms.Label lblYeniKullanıcıAdı;
        private System.Windows.Forms.Label lbl_yeniParolaTekrar;
        private System.Windows.Forms.TextBox txt_kayitKullaniciAdi;
        private System.Windows.Forms.TextBox txt_kayitParola2;
        private System.Windows.Forms.Button btn_YeniKayitEkle;
        private System.Windows.Forms.Panel panel_SifreDegistir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_yeniParolaKaydet;
        private System.Windows.Forms.TextBox txt_YeniParola2;
        private System.Windows.Forms.TextBox txt_YeniParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_hataUnuttumParola2;
        private System.Windows.Forms.Label lbl_hataUnuttumParola1;
        private System.Windows.Forms.Label lbl_hataKullaniciAdi;
        private System.Windows.Forms.Label lbl_hataParola;
        private System.Windows.Forms.Label lbl_hataKayitParola1;
        private System.Windows.Forms.Label lbl_hataKayitKullaniciAdi;
        private System.Windows.Forms.Label lbl_hataKayitParola2;
        private System.Windows.Forms.Label lbl_hataParolaKullaniciAdi;
        private System.Windows.Forms.TextBox txt_parolaKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btn_kayitKapat;
        private System.Windows.Forms.PictureBox btn_parolaKapat;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.TextBox txt_Parola;
        private System.Windows.Forms.TextBox txt_kayitParola;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_yetki;
    }
}

