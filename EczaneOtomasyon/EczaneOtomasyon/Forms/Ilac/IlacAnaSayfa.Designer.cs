namespace EczaneOtomasyon.Forms.İlaç
{
    partial class IlacAnaSayfa
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
            this.txt_ilacListesi = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ağrıKesici = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_kalp = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_alerji = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_antibiyotik = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_diyabetİlaçları = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_tansiyon = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_depresan = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_diğer = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_listele = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_sil = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ilacAra = new System.Windows.Forms.ToolStripMenuItem();
            this.antideprToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.data_ilaclar = new System.Windows.Forms.DataGridView();
            this.pnl_ilacArama = new System.Windows.Forms.Panel();
            this.btn_panelkapa = new System.Windows.Forms.Button();
            this.txt_ilacAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_ilaclar)).BeginInit();
            this.pnl_ilacArama.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_ilacListesi,
            this.txt_listele,
            this.btn_sil,
            this.btn_ilacAra});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txt_ilacListesi
            // 
            this.txt_ilacListesi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ağrıKesici,
            this.btn_kalp,
            this.btn_alerji,
            this.btn_antibiyotik,
            this.btn_diyabetİlaçları,
            this.btn_tansiyon,
            this.btn_depresan,
            this.btn_diğer});
            this.txt_ilacListesi.Name = "txt_ilacListesi";
            this.txt_ilacListesi.Size = new System.Drawing.Size(90, 24);
            this.txt_ilacListesi.Text = "İlaç Listesi";
            // 
            // btn_ağrıKesici
            // 
            this.btn_ağrıKesici.Name = "btn_ağrıKesici";
            this.btn_ağrıKesici.Size = new System.Drawing.Size(224, 26);
            this.btn_ağrıKesici.Text = "Ağrı Kesiciler";
            this.btn_ağrıKesici.Click += new System.EventHandler(this.btn_ağrıKesici_Click);
            // 
            // btn_kalp
            // 
            this.btn_kalp.Name = "btn_kalp";
            this.btn_kalp.Size = new System.Drawing.Size(224, 26);
            this.btn_kalp.Text = "Kalp İlaçları";
            this.btn_kalp.Click += new System.EventHandler(this.btn_kalp_Click);
            // 
            // btn_alerji
            // 
            this.btn_alerji.Name = "btn_alerji";
            this.btn_alerji.Size = new System.Drawing.Size(224, 26);
            this.btn_alerji.Text = "Alerji İlaçları";
            this.btn_alerji.Click += new System.EventHandler(this.btn_alerji_Click);
            // 
            // btn_antibiyotik
            // 
            this.btn_antibiyotik.Name = "btn_antibiyotik";
            this.btn_antibiyotik.Size = new System.Drawing.Size(224, 26);
            this.btn_antibiyotik.Text = "Antibiyotikler";
            this.btn_antibiyotik.Click += new System.EventHandler(this.btn_antibiyotik_Click);
            // 
            // btn_diyabetİlaçları
            // 
            this.btn_diyabetİlaçları.Name = "btn_diyabetİlaçları";
            this.btn_diyabetİlaçları.Size = new System.Drawing.Size(224, 26);
            this.btn_diyabetİlaçları.Text = "Diyabet İlaçları";
            this.btn_diyabetİlaçları.Click += new System.EventHandler(this.btn_diyabetİlaçları_Click);
            // 
            // btn_tansiyon
            // 
            this.btn_tansiyon.Name = "btn_tansiyon";
            this.btn_tansiyon.Size = new System.Drawing.Size(224, 26);
            this.btn_tansiyon.Text = "Tansiyon İlaçları";
            this.btn_tansiyon.Click += new System.EventHandler(this.btn_tansiyon_Click);
            // 
            // btn_depresan
            // 
            this.btn_depresan.Name = "btn_depresan";
            this.btn_depresan.Size = new System.Drawing.Size(224, 26);
            this.btn_depresan.Text = "Antidepresan";
            this.btn_depresan.Click += new System.EventHandler(this.btn_depresan_Click);
            // 
            // btn_diğer
            // 
            this.btn_diğer.Name = "btn_diğer";
            this.btn_diğer.Size = new System.Drawing.Size(224, 26);
            this.btn_diğer.Text = "Diğer İlaçlar";
            this.btn_diğer.Click += new System.EventHandler(this.btn_diğer_Click);
            // 
            // txt_listele
            // 
            this.txt_listele.Name = "txt_listele";
            this.txt_listele.Size = new System.Drawing.Size(65, 24);
            this.txt_listele.Text = "Listele";
            this.txt_listele.Click += new System.EventHandler(this.txt_listele_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(39, 24);
            this.btn_sil.Text = "Sil";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ilacAra
            // 
            this.btn_ilacAra.Name = "btn_ilacAra";
            this.btn_ilacAra.Size = new System.Drawing.Size(73, 24);
            this.btn_ilacAra.Text = "İlaç Ara";
            this.btn_ilacAra.Click += new System.EventHandler(this.btn_ilacAra_Click);
            // 
            // antideprToolStripMenuItem
            // 
            this.antideprToolStripMenuItem.Name = "antideprToolStripMenuItem";
            this.antideprToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.antideprToolStripMenuItem.Text = "Antidepresanlar";
            // 
            // data_ilaclar
            // 
            this.data_ilaclar.AllowUserToAddRows = false;
            this.data_ilaclar.AllowUserToDeleteRows = false;
            this.data_ilaclar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_ilaclar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_ilaclar.BackgroundColor = System.Drawing.Color.White;
            this.data_ilaclar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.data_ilaclar.ColumnHeadersHeight = 35;
            this.data_ilaclar.GridColor = System.Drawing.Color.Black;
            this.data_ilaclar.Location = new System.Drawing.Point(0, 28);
            this.data_ilaclar.Name = "data_ilaclar";
            this.data_ilaclar.ReadOnly = true;
            this.data_ilaclar.RowHeadersWidth = 51;
            this.data_ilaclar.RowTemplate.Height = 24;
            this.data_ilaclar.Size = new System.Drawing.Size(987, 741);
            this.data_ilaclar.TabIndex = 1;
            // 
            // pnl_ilacArama
            // 
            this.pnl_ilacArama.Controls.Add(this.btn_panelkapa);
            this.pnl_ilacArama.Controls.Add(this.txt_ilacAra);
            this.pnl_ilacArama.Controls.Add(this.label1);
            this.pnl_ilacArama.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_ilacArama.Location = new System.Drawing.Point(787, 28);
            this.pnl_ilacArama.Name = "pnl_ilacArama";
            this.pnl_ilacArama.Size = new System.Drawing.Size(200, 741);
            this.pnl_ilacArama.TabIndex = 2;
            this.pnl_ilacArama.Visible = false;
            // 
            // btn_panelkapa
            // 
            this.btn_panelkapa.BackColor = System.Drawing.Color.Transparent;
            this.btn_panelkapa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_panelkapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_panelkapa.Location = new System.Drawing.Point(161, 4);
            this.btn_panelkapa.Name = "btn_panelkapa";
            this.btn_panelkapa.Size = new System.Drawing.Size(36, 33);
            this.btn_panelkapa.TabIndex = 15;
            this.btn_panelkapa.Text = "X";
            this.btn_panelkapa.UseVisualStyleBackColor = false;
            this.btn_panelkapa.Click += new System.EventHandler(this.btn_panelkapa_Click);
            // 
            // txt_ilacAra
            // 
            this.txt_ilacAra.Location = new System.Drawing.Point(12, 51);
            this.txt_ilacAra.MaxLength = 11;
            this.txt_ilacAra.Multiline = true;
            this.txt_ilacAra.Name = "txt_ilacAra";
            this.txt_ilacAra.Size = new System.Drawing.Size(141, 33);
            this.txt_ilacAra.TabIndex = 14;
            this.txt_ilacAra.TextChanged += new System.EventHandler(this.txt_ilacAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(31, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "İLAÇ ARA";
            // 
            // İlaçAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 769);
            this.Controls.Add(this.pnl_ilacArama);
            this.Controls.Add(this.data_ilaclar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "İlaçAnaSayfa";
            this.Text = "İlaçAnaSayfa";
            this.Load += new System.EventHandler(this.İlaçAnaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_ilaclar)).EndInit();
            this.pnl_ilacArama.ResumeLayout(false);
            this.pnl_ilacArama.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem txt_ilacListesi;
        private System.Windows.Forms.DataGridView data_ilaclar;
        private System.Windows.Forms.ToolStripMenuItem btn_ağrıKesici;
        private System.Windows.Forms.ToolStripMenuItem btn_kalp;
        private System.Windows.Forms.ToolStripMenuItem btn_alerji;
        private System.Windows.Forms.ToolStripMenuItem btn_antibiyotik;
        private System.Windows.Forms.ToolStripMenuItem btn_diyabetİlaçları;
        private System.Windows.Forms.ToolStripMenuItem antideprToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_tansiyon;
        private System.Windows.Forms.ToolStripMenuItem btn_depresan;
        private System.Windows.Forms.ToolStripMenuItem txt_listele;
        private System.Windows.Forms.ToolStripMenuItem btn_diğer;
        private System.Windows.Forms.ToolStripMenuItem btn_sil;
        private System.Windows.Forms.Panel pnl_ilacArama;
        private System.Windows.Forms.Button btn_panelkapa;
        private System.Windows.Forms.TextBox txt_ilacAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem btn_ilacAra;
    }
}