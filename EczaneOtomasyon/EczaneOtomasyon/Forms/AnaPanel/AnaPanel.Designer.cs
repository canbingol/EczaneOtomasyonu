namespace EczaneOtomasyon.Forms.AnaPanel
{
    partial class AnaPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaPanel));
            this.lbl_hastaProfil = new System.Windows.Forms.Label();
            this.lbl_ilaç = new System.Windows.Forms.Label();
            this.lbl_toplamKazancYazi = new System.Windows.Forms.Label();
            this.lbl_bugunKazancYazi = new System.Windows.Forms.Label();
            this.lbl_toplamKazanc = new System.Windows.Forms.Label();
            this.pnl_kullanıcı = new System.Windows.Forms.Panel();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.lbl_aktifKullanıcı = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.lbl_bugunKazanc = new System.Windows.Forms.Label();
            this.lbl_toplamİlaç = new System.Windows.Forms.Label();
            this.lbl_recete = new System.Windows.Forms.Label();
            this.lbl_receteYazi = new System.Windows.Forms.Label();
            this.lbl_ilaçSayısı = new System.Windows.Forms.Label();
            this.lbl_ilacSayiYazi = new System.Windows.Forms.Label();
            this.bar_dolulukOranı = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_doluluk = new System.Windows.Forms.Label();
            this.pnl_ana = new System.Windows.Forms.Panel();
            this.pnl_alt = new System.Windows.Forms.Panel();
            this.pnl_kullanıcı.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_ana.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_hastaProfil
            // 
            this.lbl_hastaProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.lbl_hastaProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_hastaProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hastaProfil.ForeColor = System.Drawing.Color.White;
            this.lbl_hastaProfil.Image = ((System.Drawing.Image)(resources.GetObject("lbl_hastaProfil.Image")));
            this.lbl_hastaProfil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_hastaProfil.Location = new System.Drawing.Point(30, 22);
            this.lbl_hastaProfil.Name = "lbl_hastaProfil";
            this.lbl_hastaProfil.Size = new System.Drawing.Size(326, 97);
            this.lbl_hastaProfil.TabIndex = 0;
            this.lbl_hastaProfil.Text = "TOPLAM HASTA";
            this.lbl_hastaProfil.TextAlign = System.Drawing.ContentAlignment.TopRight;
//            this.lbl_hastaProfil.Click += new System.EventHandler(this.lbl_hastaProfil_Click);
            this.lbl_hastaProfil.DoubleClick += new System.EventHandler(this.lbl_hastaProfil_DoubleClick);
            // 
            // lbl_ilaç
            // 
            this.lbl_ilaç.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(84)))), ((int)(((byte)(193)))));
            this.lbl_ilaç.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ilaç.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ilaç.ForeColor = System.Drawing.Color.White;
            this.lbl_ilaç.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ilaç.Image")));
            this.lbl_ilaç.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_ilaç.Location = new System.Drawing.Point(30, 174);
            this.lbl_ilaç.Name = "lbl_ilaç";
            this.lbl_ilaç.Size = new System.Drawing.Size(326, 97);
            this.lbl_ilaç.TabIndex = 0;
            this.lbl_ilaç.Text = "TOPLAM İLAÇ ADETİ";
            this.lbl_ilaç.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_ilaç.DoubleClick += new System.EventHandler(this.lbl_ilaç_DoubleClick);
            // 
            // lbl_toplamKazancYazi
            // 
            this.lbl_toplamKazancYazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(184)))), ((int)(((byte)(107)))));
            this.lbl_toplamKazancYazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_toplamKazancYazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplamKazancYazi.ForeColor = System.Drawing.Color.White;
            this.lbl_toplamKazancYazi.Image = ((System.Drawing.Image)(resources.GetObject("lbl_toplamKazancYazi.Image")));
            this.lbl_toplamKazancYazi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_toplamKazancYazi.Location = new System.Drawing.Point(443, 314);
            this.lbl_toplamKazancYazi.Name = "lbl_toplamKazancYazi";
            this.lbl_toplamKazancYazi.Size = new System.Drawing.Size(326, 97);
            this.lbl_toplamKazancYazi.TabIndex = 0;
            this.lbl_toplamKazancYazi.Text = "TOPLAM KAZANÇ";
            this.lbl_toplamKazancYazi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_bugunKazancYazi
            // 
            this.lbl_bugunKazancYazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(184)))), ((int)(((byte)(107)))));
            this.lbl_bugunKazancYazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_bugunKazancYazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bugunKazancYazi.ForeColor = System.Drawing.Color.White;
            this.lbl_bugunKazancYazi.Image = ((System.Drawing.Image)(resources.GetObject("lbl_bugunKazancYazi.Image")));
            this.lbl_bugunKazancYazi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_bugunKazancYazi.Location = new System.Drawing.Point(30, 314);
            this.lbl_bugunKazancYazi.Name = "lbl_bugunKazancYazi";
            this.lbl_bugunKazancYazi.Size = new System.Drawing.Size(326, 97);
            this.lbl_bugunKazancYazi.TabIndex = 0;
            this.lbl_bugunKazancYazi.Text = "BU GÜNÜN KAZANCI";
            this.lbl_bugunKazancYazi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_toplamKazanc
            // 
            this.lbl_toplamKazanc.AutoSize = true;
            this.lbl_toplamKazanc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(184)))), ((int)(((byte)(107)))));
            this.lbl_toplamKazanc.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplamKazanc.ForeColor = System.Drawing.Color.Black;
            this.lbl_toplamKazanc.Location = new System.Drawing.Point(649, 352);
            this.lbl_toplamKazanc.Name = "lbl_toplamKazanc";
            this.lbl_toplamKazanc.Size = new System.Drawing.Size(34, 37);
            this.lbl_toplamKazanc.TabIndex = 3;
            this.lbl_toplamKazanc.Text = "0";
            // 
            // pnl_kullanıcı
            // 
            this.pnl_kullanıcı.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_kullanıcı.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnl_kullanıcı.Controls.Add(this.btn_kapat);
            this.pnl_kullanıcı.Controls.Add(this.lbl_aktifKullanıcı);
            this.pnl_kullanıcı.Controls.Add(this.label7);
            this.pnl_kullanıcı.Controls.Add(this.pictureBox1);
            this.pnl_kullanıcı.Location = new System.Drawing.Point(0, 0);
            this.pnl_kullanıcı.Name = "pnl_kullanıcı";
            this.pnl_kullanıcı.Size = new System.Drawing.Size(875, 106);
            this.pnl_kullanıcı.TabIndex = 6;
            // 
            // btn_kapat
            // 
            this.btn_kapat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_kapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_kapat.Image = ((System.Drawing.Image)(resources.GetObject("btn_kapat.Image")));
            this.btn_kapat.Location = new System.Drawing.Point(818, 68);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(57, 38);
            this.btn_kapat.TabIndex = 0;
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Visible = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // lbl_aktifKullanıcı
            // 
            this.lbl_aktifKullanıcı.AutoSize = true;
            this.lbl_aktifKullanıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aktifKullanıcı.ForeColor = System.Drawing.Color.White;
            this.lbl_aktifKullanıcı.Location = new System.Drawing.Point(175, 62);
            this.lbl_aktifKullanıcı.Name = "lbl_aktifKullanıcı";
            this.lbl_aktifKullanıcı.Size = new System.Drawing.Size(36, 25);
            this.lbl_aktifKullanıcı.TabIndex = 2;
            this.lbl_aktifKullanıcı.Text = "ad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(170, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "AKTİF KULLANICI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.lbl_hasta.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hasta.ForeColor = System.Drawing.Color.Black;
            this.lbl_hasta.Location = new System.Drawing.Point(221, 53);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(34, 37);
            this.lbl_hasta.TabIndex = 3;
            this.lbl_hasta.Text = "0";
            // 
            // lbl_bugunKazanc
            // 
            this.lbl_bugunKazanc.AutoSize = true;
            this.lbl_bugunKazanc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(184)))), ((int)(((byte)(107)))));
            this.lbl_bugunKazanc.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bugunKazanc.ForeColor = System.Drawing.Color.Black;
            this.lbl_bugunKazanc.Location = new System.Drawing.Point(221, 352);
            this.lbl_bugunKazanc.Name = "lbl_bugunKazanc";
            this.lbl_bugunKazanc.Size = new System.Drawing.Size(34, 37);
            this.lbl_bugunKazanc.TabIndex = 3;
            this.lbl_bugunKazanc.Text = "0";
            // 
            // lbl_toplamİlaç
            // 
            this.lbl_toplamİlaç.AutoSize = true;
            this.lbl_toplamİlaç.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(84)))), ((int)(((byte)(193)))));
            this.lbl_toplamİlaç.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplamİlaç.ForeColor = System.Drawing.Color.Black;
            this.lbl_toplamİlaç.Location = new System.Drawing.Point(221, 211);
            this.lbl_toplamİlaç.Name = "lbl_toplamİlaç";
            this.lbl_toplamİlaç.Size = new System.Drawing.Size(34, 37);
            this.lbl_toplamİlaç.TabIndex = 3;
            this.lbl_toplamİlaç.Text = "0";
            // 
            // lbl_recete
            // 
            this.lbl_recete.AutoSize = true;
            this.lbl_recete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_recete.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_recete.ForeColor = System.Drawing.Color.Black;
            this.lbl_recete.Location = new System.Drawing.Point(649, 62);
            this.lbl_recete.Name = "lbl_recete";
            this.lbl_recete.Size = new System.Drawing.Size(34, 37);
            this.lbl_recete.TabIndex = 3;
            this.lbl_recete.Text = "0";
            // 
            // lbl_receteYazi
            // 
            this.lbl_receteYazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_receteYazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_receteYazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_receteYazi.ForeColor = System.Drawing.Color.White;
            this.lbl_receteYazi.Image = ((System.Drawing.Image)(resources.GetObject("lbl_receteYazi.Image")));
            this.lbl_receteYazi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_receteYazi.Location = new System.Drawing.Point(443, 22);
            this.lbl_receteYazi.Name = "lbl_receteYazi";
            this.lbl_receteYazi.Size = new System.Drawing.Size(326, 97);
            this.lbl_receteYazi.TabIndex = 0;
            this.lbl_receteYazi.Text = "TOPLAM REÇETE";
            this.lbl_receteYazi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_ilaçSayısı
            // 
            this.lbl_ilaçSayısı.AutoSize = true;
            this.lbl_ilaçSayısı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(84)))), ((int)(((byte)(193)))));
            this.lbl_ilaçSayısı.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ilaçSayısı.ForeColor = System.Drawing.Color.Black;
            this.lbl_ilaçSayısı.Location = new System.Drawing.Point(649, 211);
            this.lbl_ilaçSayısı.Name = "lbl_ilaçSayısı";
            this.lbl_ilaçSayısı.Size = new System.Drawing.Size(34, 37);
            this.lbl_ilaçSayısı.TabIndex = 3;
            this.lbl_ilaçSayısı.Text = "0";
            // 
            // lbl_ilacSayiYazi
            // 
            this.lbl_ilacSayiYazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(84)))), ((int)(((byte)(193)))));
            this.lbl_ilacSayiYazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ilacSayiYazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ilacSayiYazi.ForeColor = System.Drawing.Color.White;
            this.lbl_ilacSayiYazi.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ilacSayiYazi.Image")));
            this.lbl_ilacSayiYazi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_ilacSayiYazi.Location = new System.Drawing.Point(443, 174);
            this.lbl_ilacSayiYazi.Name = "lbl_ilacSayiYazi";
            this.lbl_ilacSayiYazi.Size = new System.Drawing.Size(326, 97);
            this.lbl_ilacSayiYazi.TabIndex = 0;
            this.lbl_ilacSayiYazi.Text = "İLAÇ SAYISI";
            this.lbl_ilacSayiYazi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bar_dolulukOranı
            // 
            this.bar_dolulukOranı.Location = new System.Drawing.Point(35, 457);
            this.bar_dolulukOranı.Maximum = 30000;
            this.bar_dolulukOranı.Minimum = 1;
            this.bar_dolulukOranı.Name = "bar_dolulukOranı";
            this.bar_dolulukOranı.Size = new System.Drawing.Size(245, 62);
            this.bar_dolulukOranı.TabIndex = 12;
            this.bar_dolulukOranı.Value = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(81, 566);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "DOLULUK ORANI";
            // 
            // lbl_doluluk
            // 
            this.lbl_doluluk.AutoSize = true;
            this.lbl_doluluk.BackColor = System.Drawing.Color.Transparent;
            this.lbl_doluluk.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_doluluk.ForeColor = System.Drawing.Color.Black;
            this.lbl_doluluk.Location = new System.Drawing.Point(332, 469);
            this.lbl_doluluk.Name = "lbl_doluluk";
            this.lbl_doluluk.Size = new System.Drawing.Size(24, 27);
            this.lbl_doluluk.TabIndex = 1;
            this.lbl_doluluk.Text = "0";
            // 
            // pnl_ana
            // 
            this.pnl_ana.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_ana.BackColor = System.Drawing.Color.White;
            this.pnl_ana.Controls.Add(this.lbl_toplamKazanc);
            this.pnl_ana.Controls.Add(this.lbl_doluluk);
            this.pnl_ana.Controls.Add(this.bar_dolulukOranı);
            this.pnl_ana.Controls.Add(this.lbl_ilaçSayısı);
            this.pnl_ana.Controls.Add(this.lbl_toplamKazancYazi);
            this.pnl_ana.Controls.Add(this.lbl_recete);
            this.pnl_ana.Controls.Add(this.lbl_ilacSayiYazi);
            this.pnl_ana.Controls.Add(this.lbl_bugunKazanc);
            this.pnl_ana.Controls.Add(this.lbl_receteYazi);
            this.pnl_ana.Controls.Add(this.lbl_toplamİlaç);
            this.pnl_ana.Controls.Add(this.lbl_bugunKazancYazi);
            this.pnl_ana.Controls.Add(this.lbl_hasta);
            this.pnl_ana.Controls.Add(this.lbl_ilaç);
            this.pnl_ana.Controls.Add(this.lbl_hastaProfil);
            this.pnl_ana.Location = new System.Drawing.Point(39, 155);
            this.pnl_ana.Name = "pnl_ana";
            this.pnl_ana.Size = new System.Drawing.Size(789, 555);
            this.pnl_ana.TabIndex = 13;
            // 
            // pnl_alt
            // 
            this.pnl_alt.Location = new System.Drawing.Point(39, 716);
            this.pnl_alt.Name = "pnl_alt";
            this.pnl_alt.Size = new System.Drawing.Size(816, 653);
            this.pnl_alt.TabIndex = 14;
            this.pnl_alt.Visible = false;
            // 
            // AnaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_kapat;
            this.ClientSize = new System.Drawing.Size(875, 800);
            this.Controls.Add(this.pnl_alt);
            this.Controls.Add(this.pnl_ana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnl_kullanıcı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaPanel";
            this.Load += new System.EventHandler(this.AnaPanel_Load);
            this.pnl_kullanıcı.ResumeLayout(false);
            this.pnl_kullanıcı.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_ana.ResumeLayout(false);
            this.pnl_ana.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hastaProfil;
        private System.Windows.Forms.Label lbl_ilaç;
        private System.Windows.Forms.Label lbl_bugunKazancYazi;
        private System.Windows.Forms.Label lbl_toplamKazancYazi;
        private System.Windows.Forms.Label lbl_toplamKazanc;
        private System.Windows.Forms.Panel pnl_kullanıcı;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.Label lbl_bugunKazanc;
        private System.Windows.Forms.Label lbl_toplamİlaç;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_recete;
        private System.Windows.Forms.Label lbl_receteYazi;
        private System.Windows.Forms.Label lbl_aktifKullanıcı;
        private System.Windows.Forms.Label lbl_ilaçSayısı;
        private System.Windows.Forms.Label lbl_ilacSayiYazi;
        private System.Windows.Forms.ProgressBar bar_dolulukOranı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_doluluk;
        private System.Windows.Forms.Panel pnl_ana;
        private System.Windows.Forms.Panel pnl_alt;
        private System.Windows.Forms.Button btn_kapat;
    }
}