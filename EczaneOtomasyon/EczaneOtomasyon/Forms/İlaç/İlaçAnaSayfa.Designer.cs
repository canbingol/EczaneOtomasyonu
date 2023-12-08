namespace EczaneOtomasyon.Forms.İlaç
{
    partial class İlaçAnaSayfa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txt_ilaçListesi = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ağrıKesici = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_kalp = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_alerji = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_antibiyotik = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_diyabetİlaçları = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_tansiyon = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_depresan = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_diğer = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ilaçkaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ilaçGüncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_listele = new System.Windows.Forms.ToolStripMenuItem();
            this.antideprToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.data_ilaçlar = new System.Windows.Forms.DataGridView();
            this.panel_ilaçAnaSayfa = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_ilaçlar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_ilaçListesi,
            this.btn_ilaçkaydet,
            this.btn_ilaçGüncelle,
            this.anaSayfaToolStripMenuItem,
            this.txt_listele});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txt_ilaçListesi
            // 
            this.txt_ilaçListesi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ağrıKesici,
            this.btn_kalp,
            this.btn_alerji,
            this.btn_antibiyotik,
            this.btn_diyabetİlaçları,
            this.btn_tansiyon,
            this.btn_depresan,
            this.btn_diğer});
            this.txt_ilaçListesi.Name = "txt_ilaçListesi";
            this.txt_ilaçListesi.Size = new System.Drawing.Size(90, 24);
            this.txt_ilaçListesi.Text = "İlaç Listesi";
            // 
            // btn_ağrıKesici
            // 
            this.btn_ağrıKesici.Name = "btn_ağrıKesici";
            this.btn_ağrıKesici.Size = new System.Drawing.Size(196, 26);
            this.btn_ağrıKesici.Text = "Ağrı Kesiciler";
            this.btn_ağrıKesici.Click += new System.EventHandler(this.btn_ağrıKesici_Click);
            // 
            // btn_kalp
            // 
            this.btn_kalp.Name = "btn_kalp";
            this.btn_kalp.Size = new System.Drawing.Size(196, 26);
            this.btn_kalp.Text = "Kalp İlaçları";
            this.btn_kalp.Click += new System.EventHandler(this.btn_kalp_Click);
            // 
            // btn_alerji
            // 
            this.btn_alerji.Name = "btn_alerji";
            this.btn_alerji.Size = new System.Drawing.Size(196, 26);
            this.btn_alerji.Text = "Alerji İlaçları";
            this.btn_alerji.Click += new System.EventHandler(this.btn_alerji_Click);
            // 
            // btn_antibiyotik
            // 
            this.btn_antibiyotik.Name = "btn_antibiyotik";
            this.btn_antibiyotik.Size = new System.Drawing.Size(196, 26);
            this.btn_antibiyotik.Text = "Antibiyotikler";
            this.btn_antibiyotik.Click += new System.EventHandler(this.btn_antibiyotik_Click);
            // 
            // btn_diyabetİlaçları
            // 
            this.btn_diyabetİlaçları.Name = "btn_diyabetİlaçları";
            this.btn_diyabetİlaçları.Size = new System.Drawing.Size(196, 26);
            this.btn_diyabetİlaçları.Text = "Diyabet İlaçları";
            this.btn_diyabetİlaçları.Click += new System.EventHandler(this.btn_diyabetİlaçları_Click);
            // 
            // btn_tansiyon
            // 
            this.btn_tansiyon.Name = "btn_tansiyon";
            this.btn_tansiyon.Size = new System.Drawing.Size(196, 26);
            this.btn_tansiyon.Text = "Tansiyon İlaçları";
            this.btn_tansiyon.Click += new System.EventHandler(this.btn_tansiyon_Click);
            // 
            // btn_depresan
            // 
            this.btn_depresan.Name = "btn_depresan";
            this.btn_depresan.Size = new System.Drawing.Size(196, 26);
            this.btn_depresan.Text = "Antidepresan";
            this.btn_depresan.Click += new System.EventHandler(this.btn_depresan_Click);
            // 
            // btn_diğer
            // 
            this.btn_diğer.Name = "btn_diğer";
            this.btn_diğer.Size = new System.Drawing.Size(196, 26);
            this.btn_diğer.Text = "Diğer İlaçlar";
            this.btn_diğer.Click += new System.EventHandler(this.btn_diğer_Click);
            // 
            // btn_ilaçkaydet
            // 
            this.btn_ilaçkaydet.Name = "btn_ilaçkaydet";
            this.btn_ilaçkaydet.Size = new System.Drawing.Size(96, 24);
            this.btn_ilaçkaydet.Text = "İlaç Kaydet";
            this.btn_ilaçkaydet.Click += new System.EventHandler(this.btn_ilaçkaydet_Click);
            // 
            // btn_ilaçGüncelle
            // 
            this.btn_ilaçGüncelle.Name = "btn_ilaçGüncelle";
            this.btn_ilaçGüncelle.Size = new System.Drawing.Size(107, 24);
            this.btn_ilaçGüncelle.Text = "İlaç Güncelle";
            this.btn_ilaçGüncelle.Click += new System.EventHandler(this.btn_ilaçGüncelle_Click);
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.anaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            // 
            // txt_listele
            // 
            this.txt_listele.Name = "txt_listele";
            this.txt_listele.Size = new System.Drawing.Size(65, 24);
            this.txt_listele.Text = "Listele";
            this.txt_listele.Click += new System.EventHandler(this.txt_listele_Click);
            // 
            // antideprToolStripMenuItem
            // 
            this.antideprToolStripMenuItem.Name = "antideprToolStripMenuItem";
            this.antideprToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.antideprToolStripMenuItem.Text = "Antidepresanlar";
            // 
            // data_ilaçlar
            // 
            this.data_ilaçlar.AllowUserToAddRows = false;
            this.data_ilaçlar.AllowUserToDeleteRows = false;
            this.data_ilaçlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_ilaçlar.BackgroundColor = System.Drawing.Color.White;
            this.data_ilaçlar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.data_ilaçlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ilaçlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_ilaçlar.Location = new System.Drawing.Point(0, 28);
            this.data_ilaçlar.Name = "data_ilaçlar";
            this.data_ilaçlar.ReadOnly = true;
            this.data_ilaçlar.RowHeadersWidth = 51;
            this.data_ilaçlar.RowTemplate.Height = 24;
            this.data_ilaçlar.Size = new System.Drawing.Size(987, 741);
            this.data_ilaçlar.TabIndex = 1;
            // 
            // panel_ilaçAnaSayfa
            // 
            this.panel_ilaçAnaSayfa.BackColor = System.Drawing.Color.White;
            this.panel_ilaçAnaSayfa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ilaçAnaSayfa.Location = new System.Drawing.Point(0, 317);
            this.panel_ilaçAnaSayfa.Name = "panel_ilaçAnaSayfa";
            this.panel_ilaçAnaSayfa.Size = new System.Drawing.Size(987, 452);
            this.panel_ilaçAnaSayfa.TabIndex = 2;
            this.panel_ilaçAnaSayfa.Visible = false;
            // 
            // İlaçAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 769);
            this.Controls.Add(this.panel_ilaçAnaSayfa);
            this.Controls.Add(this.data_ilaçlar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "İlaçAnaSayfa";
            this.Text = "İlaçAnaSayfa";
            this.Load += new System.EventHandler(this.İlaçAnaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_ilaçlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem txt_ilaçListesi;
        private System.Windows.Forms.ToolStripMenuItem btn_ilaçkaydet;
        private System.Windows.Forms.ToolStripMenuItem btn_ilaçGüncelle;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.DataGridView data_ilaçlar;
        private System.Windows.Forms.ToolStripMenuItem btn_ağrıKesici;
        private System.Windows.Forms.ToolStripMenuItem btn_kalp;
        private System.Windows.Forms.ToolStripMenuItem btn_alerji;
        private System.Windows.Forms.ToolStripMenuItem btn_antibiyotik;
        private System.Windows.Forms.ToolStripMenuItem btn_diyabetİlaçları;
        private System.Windows.Forms.ToolStripMenuItem antideprToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_tansiyon;
        private System.Windows.Forms.ToolStripMenuItem btn_depresan;
        private System.Windows.Forms.ToolStripMenuItem txt_listele;
        private System.Windows.Forms.Panel panel_ilaçAnaSayfa;
        private System.Windows.Forms.ToolStripMenuItem btn_diğer;
    }
}