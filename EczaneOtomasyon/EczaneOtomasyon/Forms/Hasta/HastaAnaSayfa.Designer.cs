﻿namespace EczaneOtomasyon.Forms.Hasta
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
            this.txt_hastaAra = new System.Windows.Forms.TextBox();
            this.panel_hastaAnaSayfa = new System.Windows.Forms.Panel();
            this.data_hasta = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.data_hasta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_hastaAra
            // 
            this.txt_hastaAra.BackColor = System.Drawing.Color.DodgerBlue;
            this.txt_hastaAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_hastaAra.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_hastaAra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_hastaAra.ForeColor = System.Drawing.Color.White;
            this.txt_hastaAra.Location = new System.Drawing.Point(0, 0);
            this.txt_hastaAra.MaxLength = 11;
            this.txt_hastaAra.Multiline = true;
            this.txt_hastaAra.Name = "txt_hastaAra";
            this.txt_hastaAra.Size = new System.Drawing.Size(152, 29);
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
            this.data_hasta.GridColor = System.Drawing.Color.Black;
            this.data_hasta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.data_hasta.Location = new System.Drawing.Point(0, 0);
            this.data_hasta.Name = "data_hasta";
            this.data_hasta.ReadOnly = true;
            this.data_hasta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.data_hasta.RowTemplate.Height = 24;
            this.data_hasta.Size = new System.Drawing.Size(718, 746);
            this.data_hasta.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_hastaAra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 29);
            this.panel1.TabIndex = 7;
            // 
            // HastaAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(718, 746);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.data_hasta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HastaAnaSayfa";
            this.Text = "HastaAnaSayfa";
            this.Load += new System.EventHandler(this.HastaAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_hasta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_hastaAra;
        public System.Windows.Forms.Panel panel_hastaAnaSayfa;
        private System.Windows.Forms.DataGridView data_hasta;
        private System.Windows.Forms.Panel panel1;
    }
}