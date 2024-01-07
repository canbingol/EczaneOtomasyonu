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
            this.lbl_KullanıcıAdı = new System.Windows.Forms.Label();
            this.lbl_Parola = new System.Windows.Forms.Label();
            this.txt_KullanıcıAdı = new System.Windows.Forms.TextBox();
            this.btn_Giriş = new System.Windows.Forms.Button();
            this.btn_sifreUnuttum = new System.Windows.Forms.LinkLabel();
            this.btn_yeniKullanıcı = new System.Windows.Forms.Button();
            this.PanelYeniKayıt = new System.Windows.Forms.Panel();
            this.comboBox_yetki = new System.Windows.Forms.ComboBox();
            this.btn_kayıtKapat = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_yeniParolaTekrar = new System.Windows.Forms.Label();
            this.lbl_hataKayıtParola2 = new System.Windows.Forms.Label();
            this.lbl_hataKayıtParola1 = new System.Windows.Forms.Label();
            this.lbl_hataKayıtKullanıcıAdı = new System.Windows.Forms.Label();
            this.btn_YeniKayıtEkle = new System.Windows.Forms.Button();
            this.lbl_YeniParola = new System.Windows.Forms.Label();
            this.lblYeniKullanıcıAdı = new System.Windows.Forms.Label();
            this.txt_kayıtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.txt_kayıtParola = new System.Windows.Forms.TextBox();
            this.txt_kayıtParola2 = new System.Windows.Forms.TextBox();
            this.panel_SifreDegistir = new System.Windows.Forms.Panel();
            this.btn_parolaKapat = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_hataUnuttumParola2 = new System.Windows.Forms.Label();
            this.lbl_hataParolaKullanıcıadı = new System.Windows.Forms.Label();
            this.lbl_hataUnuttumParola1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_yeniParolaKaydet = new System.Windows.Forms.Button();
            this.txt_YeniParola2 = new System.Windows.Forms.TextBox();
            this.txt_YeniParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_parolaKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_hataKullanıcıAdı = new System.Windows.Forms.Label();
            this.lbl_hataParola = new System.Windows.Forms.Label();
            this.btn_cıkıs = new System.Windows.Forms.Button();
            this.txt_Parola = new System.Windows.Forms.TextBox();
            this.PanelYeniKayıt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kayıtKapat)).BeginInit();
            this.panel_SifreDegistir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_parolaKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_KullanıcıAdı
            // 
            this.lbl_KullanıcıAdı.AutoSize = true;
            this.lbl_KullanıcıAdı.BackColor = System.Drawing.Color.White;
            this.lbl_KullanıcıAdı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_KullanıcıAdı.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_KullanıcıAdı.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KullanıcıAdı.ForeColor = System.Drawing.Color.Black;
            this.lbl_KullanıcıAdı.Location = new System.Drawing.Point(474, 109);
            this.lbl_KullanıcıAdı.Name = "lbl_KullanıcıAdı";
            this.lbl_KullanıcıAdı.Size = new System.Drawing.Size(154, 29);
            this.lbl_KullanıcıAdı.TabIndex = 0;
            this.lbl_KullanıcıAdı.Text = "Kullanıcı Adı";
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
            // txt_KullanıcıAdı
            // 
            this.txt_KullanıcıAdı.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KullanıcıAdı.Location = new System.Drawing.Point(652, 109);
            this.txt_KullanıcıAdı.Multiline = true;
            this.txt_KullanıcıAdı.Name = "txt_KullanıcıAdı";
            this.txt_KullanıcıAdı.Size = new System.Drawing.Size(217, 32);
            this.txt_KullanıcıAdı.TabIndex = 0;
            // 
            // btn_Giriş
            // 
            this.btn_Giriş.BackColor = System.Drawing.Color.White;
            this.btn_Giriş.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Giriş.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Giriş.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giriş.Location = new System.Drawing.Point(645, 238);
            this.btn_Giriş.Name = "btn_Giriş";
            this.btn_Giriş.Size = new System.Drawing.Size(217, 44);
            this.btn_Giriş.TabIndex = 2;
            this.btn_Giriş.Text = "&GİRİŞ";
            this.btn_Giriş.UseVisualStyleBackColor = false;
            this.btn_Giriş.Click += new System.EventHandler(this.btn_Giriş_Click);
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
            this.btn_yeniKullanıcı.Click += new System.EventHandler(this.btn_yeniKullanıcı_Click);
            // 
            // PanelYeniKayıt
            // 
            this.PanelYeniKayıt.BackColor = System.Drawing.Color.Transparent;
            this.PanelYeniKayıt.Controls.Add(this.comboBox_yetki);
            this.PanelYeniKayıt.Controls.Add(this.btn_kayıtKapat);
            this.PanelYeniKayıt.Controls.Add(this.label5);
            this.PanelYeniKayıt.Controls.Add(this.label6);
            this.PanelYeniKayıt.Controls.Add(this.lbl_yeniParolaTekrar);
            this.PanelYeniKayıt.Controls.Add(this.lbl_hataKayıtParola2);
            this.PanelYeniKayıt.Controls.Add(this.lbl_hataKayıtParola1);
            this.PanelYeniKayıt.Controls.Add(this.lbl_hataKayıtKullanıcıAdı);
            this.PanelYeniKayıt.Controls.Add(this.btn_YeniKayıtEkle);
            this.PanelYeniKayıt.Controls.Add(this.lbl_YeniParola);
            this.PanelYeniKayıt.Controls.Add(this.lblYeniKullanıcıAdı);
            this.PanelYeniKayıt.Controls.Add(this.txt_kayıtKullanıcıAdı);
            this.PanelYeniKayıt.Controls.Add(this.txt_kayıtParola);
            this.PanelYeniKayıt.Controls.Add(this.txt_kayıtParola2);
            this.PanelYeniKayıt.Location = new System.Drawing.Point(12, 109);
            this.PanelYeniKayıt.Name = "PanelYeniKayıt";
            this.PanelYeniKayıt.Size = new System.Drawing.Size(474, 557);
            this.PanelYeniKayıt.TabIndex = 5;
            this.PanelYeniKayıt.Visible = false;
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
            // btn_kayıtKapat
            // 
            this.btn_kayıtKapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_kayıtKapat.Image")));
            this.btn_kayıtKapat.Location = new System.Drawing.Point(385, 20);
            this.btn_kayıtKapat.Name = "btn_kayıtKapat";
            this.btn_kayıtKapat.Size = new System.Drawing.Size(35, 35);
            this.btn_kayıtKapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_kayıtKapat.TabIndex = 9;
            this.btn_kayıtKapat.TabStop = false;
            this.btn_kayıtKapat.Click += new System.EventHandler(this.btn_kayıtKapat_Click);
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
            // lbl_hataKayıtParola2
            // 
            this.lbl_hataKayıtParola2.AutoSize = true;
            this.lbl_hataKayıtParola2.BackColor = System.Drawing.Color.White;
            this.lbl_hataKayıtParola2.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataKayıtParola2.Location = new System.Drawing.Point(187, 201);
            this.lbl_hataKayıtParola2.Name = "lbl_hataKayıtParola2";
            this.lbl_hataKayıtParola2.Size = new System.Drawing.Size(184, 16);
            this.lbl_hataKayıtParola2.TabIndex = 7;
            this.lbl_hataKayıtParola2.Text = "BU ALAN BOŞ BIRAKILAMAZ";
            this.lbl_hataKayıtParola2.Visible = false;
            // 
            // lbl_hataKayıtParola1
            // 
            this.lbl_hataKayıtParola1.AutoSize = true;
            this.lbl_hataKayıtParola1.BackColor = System.Drawing.Color.White;
            this.lbl_hataKayıtParola1.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataKayıtParola1.Location = new System.Drawing.Point(188, 142);
            this.lbl_hataKayıtParola1.Name = "lbl_hataKayıtParola1";
            this.lbl_hataKayıtParola1.Size = new System.Drawing.Size(184, 16);
            this.lbl_hataKayıtParola1.TabIndex = 7;
            this.lbl_hataKayıtParola1.Text = "BU ALAN BOŞ BIRAKILAMAZ";
            this.lbl_hataKayıtParola1.Visible = false;
            // 
            // lbl_hataKayıtKullanıcıAdı
            // 
            this.lbl_hataKayıtKullanıcıAdı.AutoSize = true;
            this.lbl_hataKayıtKullanıcıAdı.BackColor = System.Drawing.Color.White;
            this.lbl_hataKayıtKullanıcıAdı.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataKayıtKullanıcıAdı.Location = new System.Drawing.Point(187, 80);
            this.lbl_hataKayıtKullanıcıAdı.Name = "lbl_hataKayıtKullanıcıAdı";
            this.lbl_hataKayıtKullanıcıAdı.Size = new System.Drawing.Size(184, 16);
            this.lbl_hataKayıtKullanıcıAdı.TabIndex = 7;
            this.lbl_hataKayıtKullanıcıAdı.Text = "BU ALAN BOŞ BIRAKILAMAZ";
            this.lbl_hataKayıtKullanıcıAdı.Visible = false;
            // 
            // btn_YeniKayıtEkle
            // 
            this.btn_YeniKayıtEkle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_YeniKayıtEkle.Location = new System.Drawing.Point(185, 375);
            this.btn_YeniKayıtEkle.Name = "btn_YeniKayıtEkle";
            this.btn_YeniKayıtEkle.Size = new System.Drawing.Size(217, 44);
            this.btn_YeniKayıtEkle.TabIndex = 4;
            this.btn_YeniKayıtEkle.Text = "KAYIT EKLE";
            this.btn_YeniKayıtEkle.UseVisualStyleBackColor = true;
            this.btn_YeniKayıtEkle.Click += new System.EventHandler(this.btn_YeniKayıtEkle_Click);
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
            // txt_kayıtKullanıcıAdı
            // 
            this.txt_kayıtKullanıcıAdı.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kayıtKullanıcıAdı.Location = new System.Drawing.Point(185, 97);
            this.txt_kayıtKullanıcıAdı.Multiline = true;
            this.txt_kayıtKullanıcıAdı.Name = "txt_kayıtKullanıcıAdı";
            this.txt_kayıtKullanıcıAdı.Size = new System.Drawing.Size(217, 32);
            this.txt_kayıtKullanıcıAdı.TabIndex = 1;
            // 
            // txt_kayıtParola
            // 
            this.txt_kayıtParola.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kayıtParola.Location = new System.Drawing.Point(185, 159);
            this.txt_kayıtParola.Multiline = true;
            this.txt_kayıtParola.Name = "txt_kayıtParola";
            this.txt_kayıtParola.Size = new System.Drawing.Size(217, 32);
            this.txt_kayıtParola.TabIndex = 1;
            // 
            // txt_kayıtParola2
            // 
            this.txt_kayıtParola2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kayıtParola2.Location = new System.Drawing.Point(185, 219);
            this.txt_kayıtParola2.Multiline = true;
            this.txt_kayıtParola2.Name = "txt_kayıtParola2";
            this.txt_kayıtParola2.Size = new System.Drawing.Size(217, 32);
            this.txt_kayıtParola2.TabIndex = 1;
            // 
            // panel_SifreDegistir
            // 
            this.panel_SifreDegistir.BackColor = System.Drawing.Color.Transparent;
            this.panel_SifreDegistir.Controls.Add(this.btn_parolaKapat);
            this.panel_SifreDegistir.Controls.Add(this.label4);
            this.panel_SifreDegistir.Controls.Add(this.lbl_hataUnuttumParola2);
            this.panel_SifreDegistir.Controls.Add(this.lbl_hataParolaKullanıcıadı);
            this.panel_SifreDegistir.Controls.Add(this.lbl_hataUnuttumParola1);
            this.panel_SifreDegistir.Controls.Add(this.label2);
            this.panel_SifreDegistir.Controls.Add(this.btn_yeniParolaKaydet);
            this.panel_SifreDegistir.Controls.Add(this.txt_YeniParola2);
            this.panel_SifreDegistir.Controls.Add(this.txt_YeniParola);
            this.panel_SifreDegistir.Controls.Add(this.label1);
            this.panel_SifreDegistir.Controls.Add(this.txt_parolaKullanıcıAdı);
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
            // lbl_hataParolaKullanıcıadı
            // 
            this.lbl_hataParolaKullanıcıadı.AutoSize = true;
            this.lbl_hataParolaKullanıcıadı.BackColor = System.Drawing.Color.White;
            this.lbl_hataParolaKullanıcıadı.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataParolaKullanıcıadı.Location = new System.Drawing.Point(197, 85);
            this.lbl_hataParolaKullanıcıadı.Name = "lbl_hataParolaKullanıcıadı";
            this.lbl_hataParolaKullanıcıadı.Size = new System.Drawing.Size(184, 16);
            this.lbl_hataParolaKullanıcıadı.TabIndex = 7;
            this.lbl_hataParolaKullanıcıadı.Text = "BU ALAN BOŞ BIRAKILAMAZ";
            this.lbl_hataParolaKullanıcıadı.Visible = false;
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
            // txt_parolaKullanıcıAdı
            // 
            this.txt_parolaKullanıcıAdı.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_parolaKullanıcıAdı.Location = new System.Drawing.Point(191, 105);
            this.txt_parolaKullanıcıAdı.Multiline = true;
            this.txt_parolaKullanıcıAdı.Name = "txt_parolaKullanıcıAdı";
            this.txt_parolaKullanıcıAdı.Size = new System.Drawing.Size(217, 32);
            this.txt_parolaKullanıcıAdı.TabIndex = 1;
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
            // lbl_hataKullanıcıAdı
            // 
            this.lbl_hataKullanıcıAdı.AutoSize = true;
            this.lbl_hataKullanıcıAdı.BackColor = System.Drawing.Color.White;
            this.lbl_hataKullanıcıAdı.ForeColor = System.Drawing.Color.Red;
            this.lbl_hataKullanıcıAdı.Location = new System.Drawing.Point(658, 89);
            this.lbl_hataKullanıcıAdı.Name = "lbl_hataKullanıcıAdı";
            this.lbl_hataKullanıcıAdı.Size = new System.Drawing.Size(184, 16);
            this.lbl_hataKullanıcıAdı.TabIndex = 7;
            this.lbl_hataKullanıcıAdı.Text = "BU ALAN BOŞ BIRAKILAMAZ";
            this.lbl_hataKullanıcıAdı.Visible = false;
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
            // btn_cıkıs
            // 
            this.btn_cıkıs.BackColor = System.Drawing.Color.Transparent;
            this.btn_cıkıs.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cıkıs.Location = new System.Drawing.Point(1090, 2);
            this.btn_cıkıs.Name = "btn_cıkıs";
            this.btn_cıkıs.Size = new System.Drawing.Size(42, 36);
            this.btn_cıkıs.TabIndex = 11;
            this.btn_cıkıs.Text = "&X";
            this.btn_cıkıs.UseVisualStyleBackColor = false;
            this.btn_cıkıs.Click += new System.EventHandler(this.btn_cıkıs_Click_1);
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
            this.AcceptButton = this.btn_Giriş;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btn_cıkıs;
            this.ClientSize = new System.Drawing.Size(1132, 690);
            this.Controls.Add(this.btn_cıkıs);
            this.Controls.Add(this.lbl_hataParola);
            this.Controls.Add(this.lbl_hataKullanıcıAdı);
            this.Controls.Add(this.PanelYeniKayıt);
            this.Controls.Add(this.panel_SifreDegistir);
            this.Controls.Add(this.btn_yeniKullanıcı);
            this.Controls.Add(this.btn_sifreUnuttum);
            this.Controls.Add(this.btn_Giriş);
            this.Controls.Add(this.txt_KullanıcıAdı);
            this.Controls.Add(this.lbl_Parola);
            this.Controls.Add(this.lbl_KullanıcıAdı);
            this.Controls.Add(this.txt_Parola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.PanelYeniKayıt.ResumeLayout(false);
            this.PanelYeniKayıt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_kayıtKapat)).EndInit();
            this.panel_SifreDegistir.ResumeLayout(false);
            this.panel_SifreDegistir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_parolaKapat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_KullanıcıAdı;
        private System.Windows.Forms.Label lbl_Parola;
        private System.Windows.Forms.TextBox txt_KullanıcıAdı;
        private System.Windows.Forms.Button btn_Giriş;
        private System.Windows.Forms.LinkLabel btn_sifreUnuttum;
        private System.Windows.Forms.Button btn_yeniKullanıcı;
        private System.Windows.Forms.Panel PanelYeniKayıt;
        private System.Windows.Forms.Label lbl_YeniParola;
        private System.Windows.Forms.Label lblYeniKullanıcıAdı;
        private System.Windows.Forms.Label lbl_yeniParolaTekrar;
        private System.Windows.Forms.TextBox txt_kayıtKullanıcıAdı;
        private System.Windows.Forms.TextBox txt_kayıtParola2;
        private System.Windows.Forms.Button btn_YeniKayıtEkle;
        private System.Windows.Forms.Panel panel_SifreDegistir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_yeniParolaKaydet;
        private System.Windows.Forms.TextBox txt_YeniParola2;
        private System.Windows.Forms.TextBox txt_YeniParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_hataUnuttumParola2;
        private System.Windows.Forms.Label lbl_hataUnuttumParola1;
        private System.Windows.Forms.Label lbl_hataKullanıcıAdı;
        private System.Windows.Forms.Label lbl_hataParola;
        private System.Windows.Forms.Label lbl_hataKayıtParola1;
        private System.Windows.Forms.Label lbl_hataKayıtKullanıcıAdı;
        private System.Windows.Forms.Label lbl_hataKayıtParola2;
        private System.Windows.Forms.Label lbl_hataParolaKullanıcıadı;
        private System.Windows.Forms.TextBox txt_parolaKullanıcıAdı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btn_kayıtKapat;
        private System.Windows.Forms.PictureBox btn_parolaKapat;
        private System.Windows.Forms.Button btn_cıkıs;
        private System.Windows.Forms.TextBox txt_Parola;
        private System.Windows.Forms.TextBox txt_kayıtParola;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_yetki;
    }
}

