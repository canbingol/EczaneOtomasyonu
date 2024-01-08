namespace EczaneOtomasyon.Forms.Hasta
{
    partial class HastaAnaSayfa
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
            this.panel_hastaAnaSayfa = new System.Windows.Forms.Panel();
            this.data_hasta = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_sil = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_hastaAra = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_hastaAra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_hastaAra = new System.Windows.Forms.TextBox();
            this.btn_panelkapa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_hasta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnl_hastaAra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_hastaAnaSayfa
            // 
            this.panel_hastaAnaSayfa.Location = new System.Drawing.Point(0, 0);
            this.panel_hastaAnaSayfa.Name = "panel_hastaAnaSayfa";
            this.panel_hastaAnaSayfa.Size = new System.Drawing.Size(200, 100);
            this.panel_hastaAnaSayfa.TabIndex = 0;
            // 
            // data_hasta
            // 
            this.data_hasta.AllowUserToAddRows = false;
            this.data_hasta.AllowUserToDeleteRows = false;
            this.data_hasta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_hasta.BackgroundColor = System.Drawing.Color.White;
            this.data_hasta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.data_hasta.ColumnHeadersHeight = 35;
            this.data_hasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_hasta.GridColor = System.Drawing.Color.Black;
            this.data_hasta.Location = new System.Drawing.Point(0, 28);
            this.data_hasta.Name = "data_hasta";
            this.data_hasta.ReadOnly = true;
            this.data_hasta.RowHeadersWidth = 51;
            this.data_hasta.RowTemplate.Height = 24;
            this.data_hasta.Size = new System.Drawing.Size(718, 718);
            this.data_hasta.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeleToolStripMenuItem,
            this.btn_sil,
            this.btn_hastaAra});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listeleToolStripMenuItem
            // 
            this.listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            this.listeleToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.listeleToolStripMenuItem.Text = "Listele";
            this.listeleToolStripMenuItem.Click += new System.EventHandler(this.listeleToolStripMenuItem_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(39, 24);
            this.btn_sil.Text = "Sil";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_hastaAra
            // 
            this.btn_hastaAra.Name = "btn_hastaAra";
            this.btn_hastaAra.Size = new System.Drawing.Size(92, 24);
            this.btn_hastaAra.Text = "Hasta Ara ";
            this.btn_hastaAra.Click += new System.EventHandler(this.btn_hastaAra_Click);
            // 
            // pnl_hastaAra
            // 
            this.pnl_hastaAra.Controls.Add(this.btn_panelkapa);
            this.pnl_hastaAra.Controls.Add(this.txt_hastaAra);
            this.pnl_hastaAra.Controls.Add(this.label1);
            this.pnl_hastaAra.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_hastaAra.Location = new System.Drawing.Point(514, 28);
            this.pnl_hastaAra.Name = "pnl_hastaAra";
            this.pnl_hastaAra.Size = new System.Drawing.Size(204, 718);
            this.pnl_hastaAra.TabIndex = 10;
            this.pnl_hastaAra.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA ARA";
            // 
            // txt_hastaAra
            // 
            this.txt_hastaAra.Location = new System.Drawing.Point(12, 50);
            this.txt_hastaAra.MaxLength = 11;
            this.txt_hastaAra.Multiline = true;
            this.txt_hastaAra.Name = "txt_hastaAra";
            this.txt_hastaAra.Size = new System.Drawing.Size(141, 33);
            this.txt_hastaAra.TabIndex = 1;
            this.txt_hastaAra.TextChanged += new System.EventHandler(this.txt_hastaAra_TextChanged);
            // 
            // btn_panelkapa
            // 
            this.btn_panelkapa.BackColor = System.Drawing.Color.Transparent;
            this.btn_panelkapa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_panelkapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_panelkapa.Location = new System.Drawing.Point(161, 3);
            this.btn_panelkapa.Name = "btn_panelkapa";
            this.btn_panelkapa.Size = new System.Drawing.Size(36, 33);
            this.btn_panelkapa.TabIndex = 12;
            this.btn_panelkapa.Text = "X";
            this.btn_panelkapa.UseVisualStyleBackColor = false;
            this.btn_panelkapa.Click += new System.EventHandler(this.btn_panelkapa_Click);
            // 
            // HastaAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 746);
            this.Controls.Add(this.pnl_hastaAra);
            this.Controls.Add(this.data_hasta);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HastaAnaSayfa";
            this.Text = "HastaAnaSayfa";
            this.Load += new System.EventHandler(this.HastaAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_hasta)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_hastaAra.ResumeLayout(false);
            this.pnl_hastaAra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel panel_hastaAnaSayfa;
        private System.Windows.Forms.DataGridView data_hasta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_sil;
        private System.Windows.Forms.ToolStripMenuItem btn_hastaAra;
        private System.Windows.Forms.Panel pnl_hastaAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_hastaAra;
        private System.Windows.Forms.Button btn_panelkapa;
    }
}