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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_hastaListele = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_hastaKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_hastaGüncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_anaMenü = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_hastaAra = new System.Windows.Forms.TextBox();
            this.panel_hastaAnaSayfa = new System.Windows.Forms.Panel();
            this.data_hasta = new System.Windows.Forms.DataGridView();
            this.panel_anaSayfa = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_hasta)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_hastaListele,
            this.btn_hastaKaydet,
            this.btn_hastaGüncelle,
            this.btn_anaMenü});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_hastaListele
            // 
            this.btn_hastaListele.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hastaListele.Name = "btn_hastaListele";
            this.btn_hastaListele.Size = new System.Drawing.Size(108, 24);
            this.btn_hastaListele.Text = "Hasta Listesi";
            this.btn_hastaListele.Click += new System.EventHandler(this.btn_hastaListele_Click);
            // 
            // btn_hastaKaydet
            // 
            this.btn_hastaKaydet.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hastaKaydet.Name = "btn_hastaKaydet";
            this.btn_hastaKaydet.Size = new System.Drawing.Size(119, 24);
            this.btn_hastaKaydet.Text = "hasta Kaydet";
            this.btn_hastaKaydet.Click += new System.EventHandler(this.btn_hastaKaydet_Click);
            // 
            // btn_hastaGüncelle
            // 
            this.btn_hastaGüncelle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hastaGüncelle.Name = "btn_hastaGüncelle";
            this.btn_hastaGüncelle.Size = new System.Drawing.Size(135, 24);
            this.btn_hastaGüncelle.Text = "Hasta Güncelle";
            this.btn_hastaGüncelle.Click += new System.EventHandler(this.btn_hastaGüncelle_Click);
            // 
            // btn_anaMenü
            // 
            this.btn_anaMenü.Name = "btn_anaMenü";
            this.btn_anaMenü.Size = new System.Drawing.Size(90, 24);
            this.btn_anaMenü.Text = "Ana Manü";
            // 
            // txt_hastaAra
            // 
            this.txt_hastaAra.BackColor = System.Drawing.Color.DodgerBlue;
            this.txt_hastaAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_hastaAra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_hastaAra.ForeColor = System.Drawing.Color.White;
            this.txt_hastaAra.Location = new System.Drawing.Point(817, 2);
            this.txt_hastaAra.MaxLength = 11;
            this.txt_hastaAra.Multiline = true;
            this.txt_hastaAra.Name = "txt_hastaAra";
            this.txt_hastaAra.Size = new System.Drawing.Size(167, 23);
            this.txt_hastaAra.TabIndex = 0;
            this.txt_hastaAra.Text = "Hasta Ara";
            this.txt_hastaAra.Click += new System.EventHandler(this.txt_hastaAra_Click);
            this.txt_hastaAra.TextChanged += new System.EventHandler(this.txt_hastaAra_TextChanged);
            // 
            // panel_hastaAnaSayfa
            // 
            this.panel_hastaAnaSayfa.BackColor = System.Drawing.Color.Silver;
            this.panel_hastaAnaSayfa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_hastaAnaSayfa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_hastaAnaSayfa.Location = new System.Drawing.Point(0, 297);
            this.panel_hastaAnaSayfa.Name = "panel_hastaAnaSayfa";
            this.panel_hastaAnaSayfa.Size = new System.Drawing.Size(928, 472);
            this.panel_hastaAnaSayfa.TabIndex = 4;
            this.panel_hastaAnaSayfa.Visible = false;
            // 
            // data_hasta
            // 
            this.data_hasta.AllowUserToAddRows = false;
            this.data_hasta.AllowUserToDeleteRows = false;
            this.data_hasta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_hasta.BackgroundColor = System.Drawing.Color.White;
            this.data_hasta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_hasta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_hasta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_hasta.ColumnHeadersHeight = 29;
            this.data_hasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_hasta.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_hasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_hasta.GridColor = System.Drawing.Color.White;
            this.data_hasta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.data_hasta.Location = new System.Drawing.Point(0, 28);
            this.data_hasta.Name = "data_hasta";
            this.data_hasta.ReadOnly = true;
            this.data_hasta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.data_hasta.RowTemplate.Height = 24;
            this.data_hasta.Size = new System.Drawing.Size(987, 741);
            this.data_hasta.TabIndex = 6;
            // 
            // panel_anaSayfa
            // 
            this.panel_anaSayfa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_anaSayfa.Location = new System.Drawing.Point(0, 334);
            this.panel_anaSayfa.Name = "panel_anaSayfa";
            this.panel_anaSayfa.Size = new System.Drawing.Size(987, 435);
            this.panel_anaSayfa.TabIndex = 7;
            // 
            // HastaAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 769);
            this.Controls.Add(this.txt_hastaAra);
            this.Controls.Add(this.panel_anaSayfa);
            this.Controls.Add(this.data_hasta);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HastaAnaSayfa";
            this.Text = "HastaAnaSayfa";
            this.Load += new System.EventHandler(this.HastaAnaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_hasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_hastaListele;
        private System.Windows.Forms.ToolStripMenuItem btn_hastaKaydet;
        private System.Windows.Forms.ToolStripMenuItem btn_hastaGüncelle;
        private System.Windows.Forms.ToolStripMenuItem btn_anaMenü;
        private System.Windows.Forms.TextBox txt_hastaAra;
        public  System.Windows.Forms.Panel panel_hastaAnaSayfa;
        private System.Windows.Forms.Panel panel_anaSayfa;
        private System.Windows.Forms.DataGridView data_hasta;
    }
}