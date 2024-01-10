namespace EczaneOtomasyon.Forms.AnaPanel
{
    partial class HastaProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaProfil));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_hastaAd = new System.Windows.Forms.Label();
            this.lbl_hastaTc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_girilenTc = new System.Windows.Forms.TextBox();
            this.btn_hastaBul = new System.Windows.Forms.Button();
            this.lbl_hastaSoyad = new System.Windows.Forms.Label();
            this.datagrid_hastarecete = new System.Windows.Forms.DataGridView();
            this.lbl_hastaTelno = new System.Windows.Forms.Label();
            this.lbl_hastaAdres = new System.Windows.Forms.Label();
            this.lbl_hastaSigorta = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_sigorta = new System.Windows.Forms.Label();
            this.pnl_hastabilgi = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_hastarecete)).BeginInit();
            this.pnl_hastabilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_hastaAd
            // 
            this.lbl_hastaAd.AutoSize = true;
            this.lbl_hastaAd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hastaAd.Location = new System.Drawing.Point(5, 40);
            this.lbl_hastaAd.Name = "lbl_hastaAd";
            this.lbl_hastaAd.Size = new System.Drawing.Size(44, 27);
            this.lbl_hastaAd.TabIndex = 2;
            this.lbl_hastaAd.Text = "ad";
            // 
            // lbl_hastaTc
            // 
            this.lbl_hastaTc.AutoSize = true;
            this.lbl_hastaTc.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hastaTc.Location = new System.Drawing.Point(5, 1);
            this.lbl_hastaTc.Name = "lbl_hastaTc";
            this.lbl_hastaTc.Size = new System.Drawing.Size(35, 27);
            this.lbl_hastaTc.TabIndex = 3;
            this.lbl_hastaTc.Text = "tc";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_girilenTc);
            this.panel1.Controls.Add(this.btn_hastaBul);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 70);
            this.panel1.TabIndex = 4;
            // 
            // txt_girilenTc
            // 
            this.txt_girilenTc.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_girilenTc.Location = new System.Drawing.Point(12, 13);
            this.txt_girilenTc.MaxLength = 11;
            this.txt_girilenTc.Multiline = true;
            this.txt_girilenTc.Name = "txt_girilenTc";
            this.txt_girilenTc.Size = new System.Drawing.Size(157, 42);
            this.txt_girilenTc.TabIndex = 3;
            this.txt_girilenTc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_girilenTc_KeyPress);
            // 
            // btn_hastaBul
            // 
            this.btn_hastaBul.Image = ((System.Drawing.Image)(resources.GetObject("btn_hastaBul.Image")));
            this.btn_hastaBul.Location = new System.Drawing.Point(190, 13);
            this.btn_hastaBul.Name = "btn_hastaBul";
            this.btn_hastaBul.Size = new System.Drawing.Size(75, 42);
            this.btn_hastaBul.TabIndex = 2;
            this.btn_hastaBul.UseVisualStyleBackColor = true;
            this.btn_hastaBul.Click += new System.EventHandler(this.btn_hastaBul_Click);
            // 
            // lbl_hastaSoyad
            // 
            this.lbl_hastaSoyad.AutoSize = true;
            this.lbl_hastaSoyad.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hastaSoyad.Location = new System.Drawing.Point(5, 80);
            this.lbl_hastaSoyad.Name = "lbl_hastaSoyad";
            this.lbl_hastaSoyad.Size = new System.Drawing.Size(81, 27);
            this.lbl_hastaSoyad.TabIndex = 1;
            this.lbl_hastaSoyad.Text = "soyad";
            // 
            // datagrid_hastarecete
            // 
            this.datagrid_hastarecete.AllowUserToAddRows = false;
            this.datagrid_hastarecete.AllowUserToDeleteRows = false;
            this.datagrid_hastarecete.BackgroundColor = System.Drawing.Color.White;
            this.datagrid_hastarecete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_hastarecete.Location = new System.Drawing.Point(0, 296);
            this.datagrid_hastarecete.Name = "datagrid_hastarecete";
            this.datagrid_hastarecete.ReadOnly = true;
            this.datagrid_hastarecete.RowHeadersWidth = 51;
            this.datagrid_hastarecete.RowTemplate.Height = 24;
            this.datagrid_hastarecete.Size = new System.Drawing.Size(816, 367);
            this.datagrid_hastarecete.TabIndex = 5;
            // 
            // lbl_hastaTelno
            // 
            this.lbl_hastaTelno.AutoSize = true;
            this.lbl_hastaTelno.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hastaTelno.Location = new System.Drawing.Point(267, 8);
            this.lbl_hastaTelno.Name = "lbl_hastaTelno";
            this.lbl_hastaTelno.Size = new System.Drawing.Size(76, 27);
            this.lbl_hastaTelno.TabIndex = 3;
            this.lbl_hastaTelno.Text = "tel no";
            // 
            // lbl_hastaAdres
            // 
            this.lbl_hastaAdres.AutoSize = true;
            this.lbl_hastaAdres.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hastaAdres.Location = new System.Drawing.Point(267, 53);
            this.lbl_hastaAdres.Name = "lbl_hastaAdres";
            this.lbl_hastaAdres.Size = new System.Drawing.Size(75, 27);
            this.lbl_hastaAdres.TabIndex = 2;
            this.lbl_hastaAdres.Text = "adres";
            // 
            // lbl_hastaSigorta
            // 
            this.lbl_hastaSigorta.AutoSize = true;
            this.lbl_hastaSigorta.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hastaSigorta.Location = new System.Drawing.Point(134, 125);
            this.lbl_hastaSigorta.Name = "lbl_hastaSigorta";
            this.lbl_hastaSigorta.Size = new System.Drawing.Size(88, 27);
            this.lbl_hastaSigorta.TabIndex = 1;
            this.lbl_hastaSigorta.Text = "sigorta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(248, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "HASTA BİLGİLERİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(510, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "İLETİŞİM BİLGİLERİ";
            // 
            // lbl_sigorta
            // 
            this.lbl_sigorta.AutoSize = true;
            this.lbl_sigorta.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sigorta.Location = new System.Drawing.Point(5, 125);
            this.lbl_sigorta.Name = "lbl_sigorta";
            this.lbl_sigorta.Size = new System.Drawing.Size(123, 27);
            this.lbl_sigorta.TabIndex = 1;
            this.lbl_sigorta.Text = "SİGORTA :\r\n";
            // 
            // pnl_hastabilgi
            // 
            this.pnl_hastabilgi.Controls.Add(this.lbl_hastaSigorta);
            this.pnl_hastabilgi.Controls.Add(this.lbl_hastaTc);
            this.pnl_hastabilgi.Controls.Add(this.lbl_hastaTelno);
            this.pnl_hastabilgi.Controls.Add(this.lbl_sigorta);
            this.pnl_hastabilgi.Controls.Add(this.lbl_hastaAd);
            this.pnl_hastabilgi.Controls.Add(this.lbl_hastaSoyad);
            this.pnl_hastabilgi.Controls.Add(this.lbl_hastaAdres);
            this.pnl_hastabilgi.Location = new System.Drawing.Point(253, 126);
            this.pnl_hastabilgi.Name = "pnl_hastabilgi";
            this.pnl_hastabilgi.Size = new System.Drawing.Size(429, 164);
            this.pnl_hastabilgi.TabIndex = 6;
            this.pnl_hastabilgi.Visible = false;
            // 
            // HastaProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 675);
            this.Controls.Add(this.pnl_hastabilgi);
            this.Controls.Add(this.datagrid_hastarecete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HastaProfil";
            this.Text = "HastaProfil";
            this.Load += new System.EventHandler(this.HastaProfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_hastarecete)).EndInit();
            this.pnl_hastabilgi.ResumeLayout(false);
            this.pnl_hastabilgi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_hastaAd;
        private System.Windows.Forms.Label lbl_hastaTc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_hastaSoyad;
        private System.Windows.Forms.Button btn_hastaBul;
        private System.Windows.Forms.DataGridView datagrid_hastarecete;
        private System.Windows.Forms.Label lbl_hastaTelno;
        private System.Windows.Forms.Label lbl_hastaAdres;
        private System.Windows.Forms.Label lbl_hastaSigorta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_girilenTc;
        private System.Windows.Forms.Label lbl_sigorta;
        private System.Windows.Forms.Panel pnl_hastabilgi;
    }
}