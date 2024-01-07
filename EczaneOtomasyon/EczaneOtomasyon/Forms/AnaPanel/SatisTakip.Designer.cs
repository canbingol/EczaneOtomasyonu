namespace EczaneOtomasyon.Forms.AnaPanel
{
    partial class SatisTakip
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
            this.combobox_zaman = new System.Windows.Forms.ComboBox();
            this.dataGrid_satis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_satis)).BeginInit();
            this.SuspendLayout();
            // 
            // combobox_zaman
            // 
            this.combobox_zaman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_zaman.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combobox_zaman.FormattingEnabled = true;
            this.combobox_zaman.Items.AddRange(new object[] {
            "BU GÜN",
            "SON BİR HAFTA",
            "SON BİR AY"});
            this.combobox_zaman.Location = new System.Drawing.Point(637, 12);
            this.combobox_zaman.Name = "combobox_zaman";
            this.combobox_zaman.Size = new System.Drawing.Size(167, 29);
            this.combobox_zaman.TabIndex = 0;
            this.combobox_zaman.SelectedIndexChanged += new System.EventHandler(this.combobox_zaman_SelectedIndexChanged);
            // 
            // dataGrid_satis
            // 
            this.dataGrid_satis.AllowUserToAddRows = false;
            this.dataGrid_satis.AllowUserToDeleteRows = false;
            this.dataGrid_satis.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_satis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_satis.Location = new System.Drawing.Point(1, 65);
            this.dataGrid_satis.Name = "dataGrid_satis";
            this.dataGrid_satis.ReadOnly = true;
            this.dataGrid_satis.RowHeadersWidth = 51;
            this.dataGrid_satis.RowTemplate.Height = 24;
            this.dataGrid_satis.Size = new System.Drawing.Size(810, 567);
            this.dataGrid_satis.TabIndex = 1;
            // 
            // SatisTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 675);
            this.Controls.Add(this.dataGrid_satis);
            this.Controls.Add(this.combobox_zaman);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SatisTakip";
            this.Text = "SatisTakip";
            this.Load += new System.EventHandler(this.SatisTakip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_satis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_zaman;
        private System.Windows.Forms.DataGridView dataGrid_satis;
    }
}