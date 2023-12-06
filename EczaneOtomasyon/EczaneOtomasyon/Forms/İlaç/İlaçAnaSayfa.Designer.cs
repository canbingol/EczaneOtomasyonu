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
            this.ilaçListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilaçGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.data_ilaçlar = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_ilaçlar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ilaçListesiToolStripMenuItem,
            this.ilaçKaydetToolStripMenuItem,
            this.ilaçGüncelleToolStripMenuItem,
            this.anaSayfaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(843, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ilaçListesiToolStripMenuItem
            // 
            this.ilaçListesiToolStripMenuItem.Name = "ilaçListesiToolStripMenuItem";
            this.ilaçListesiToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.ilaçListesiToolStripMenuItem.Text = "İlaç listesi";
            // 
            // ilaçKaydetToolStripMenuItem
            // 
            this.ilaçKaydetToolStripMenuItem.Name = "ilaçKaydetToolStripMenuItem";
            this.ilaçKaydetToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.ilaçKaydetToolStripMenuItem.Text = "İlaç Kaydet";
            // 
            // ilaçGüncelleToolStripMenuItem
            // 
            this.ilaçGüncelleToolStripMenuItem.Name = "ilaçGüncelleToolStripMenuItem";
            this.ilaçGüncelleToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.ilaçGüncelleToolStripMenuItem.Text = "İlaç Güncelle";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.anaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            // 
            // data_ilaçlar
            // 
            this.data_ilaçlar.AllowUserToAddRows = false;
            this.data_ilaçlar.AllowUserToDeleteRows = false;
            this.data_ilaçlar.BackgroundColor = System.Drawing.Color.White;
            this.data_ilaçlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ilaçlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_ilaçlar.Location = new System.Drawing.Point(0, 28);
            this.data_ilaçlar.Name = "data_ilaçlar";
            this.data_ilaçlar.ReadOnly = true;
            this.data_ilaçlar.RowHeadersWidth = 51;
            this.data_ilaçlar.RowTemplate.Height = 24;
            this.data_ilaçlar.Size = new System.Drawing.Size(843, 741);
            this.data_ilaçlar.TabIndex = 1;
            // 
            // İlaçAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 769);
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
        private System.Windows.Forms.ToolStripMenuItem ilaçListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilaçGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.DataGridView data_ilaçlar;
    }
}