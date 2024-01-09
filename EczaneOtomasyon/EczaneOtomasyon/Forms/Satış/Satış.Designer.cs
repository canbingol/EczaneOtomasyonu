namespace EczaneOtomasyon.Forms.Satış
{
    partial class Satış
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checklist_hastalar = new System.Windows.Forms.CheckedListBox();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.btn_receteSec = new System.Windows.Forms.Button();
            this.btn_hastaSec = new System.Windows.Forms.Button();
            this.lbl_toplamFiyat = new System.Windows.Forms.Label();
            this.btn_satis = new System.Windows.Forms.Button();
            this.listBox_receteList = new System.Windows.Forms.CheckedListBox();
            this.pnl_bilgi = new System.Windows.Forms.Panel();
            this.pnl_ilacBilgi = new System.Windows.Forms.Panel();
            this.lbl_ilacadi1 = new System.Windows.Forms.Label();
            this.lbl_ilac4 = new System.Windows.Forms.Label();
            this.lbl_ilac3 = new System.Windows.Forms.Label();
            this.lbl_ilac2 = new System.Windows.Forms.Label();
            this.lbl_ilac1 = new System.Windows.Forms.Label();
            this.lbl_ilac5 = new System.Windows.Forms.Label();
            this.lbl_ilacadi2 = new System.Windows.Forms.Label();
            this.lbl_ilacadi3 = new System.Windows.Forms.Label();
            this.lbl_ilacadi4 = new System.Windows.Forms.Label();
            this.lbl_ilacadi5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_hata = new System.Windows.Forms.Label();
            this.pnl_bilgi.SuspendLayout();
            this.pnl_ilacBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTALAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "REÇETELER";
            // 
            // checklist_hastalar
            // 
            this.checklist_hastalar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checklist_hastalar.FormattingEnabled = true;
            this.checklist_hastalar.Location = new System.Drawing.Point(12, 66);
            this.checklist_hastalar.Name = "checklist_hastalar";
            this.checklist_hastalar.Size = new System.Drawing.Size(257, 257);
            this.checklist_hastalar.TabIndex = 1;
            this.checklist_hastalar.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checklist_hastalar_ItemCheck);
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tc.Location = new System.Drawing.Point(190, 27);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(125, 21);
            this.lbl_tc.TabIndex = 3;
            this.lbl_tc.Text = "TC KİMLİK NO";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ad.Location = new System.Drawing.Point(190, 71);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(36, 21);
            this.lbl_ad.TabIndex = 3;
            this.lbl_ad.Text = "AD";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyad.Location = new System.Drawing.Point(190, 111);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(70, 21);
            this.lbl_soyad.TabIndex = 3;
            this.lbl_soyad.Text = "SOYAD";
            // 
            // btn_receteSec
            // 
            this.btn_receteSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_receteSec.Location = new System.Drawing.Point(816, 329);
            this.btn_receteSec.Name = "btn_receteSec";
            this.btn_receteSec.Size = new System.Drawing.Size(180, 56);
            this.btn_receteSec.TabIndex = 4;
            this.btn_receteSec.Text = "REÇETE SEÇ";
            this.btn_receteSec.UseVisualStyleBackColor = true;
            this.btn_receteSec.Click += new System.EventHandler(this.btn_receteSec_Click);
            // 
            // btn_hastaSec
            // 
            this.btn_hastaSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hastaSec.Location = new System.Drawing.Point(100, 331);
            this.btn_hastaSec.Name = "btn_hastaSec";
            this.btn_hastaSec.Size = new System.Drawing.Size(169, 56);
            this.btn_hastaSec.TabIndex = 4;
            this.btn_hastaSec.Text = "HASTA SEÇ";
            this.btn_hastaSec.UseVisualStyleBackColor = true;
            this.btn_hastaSec.Click += new System.EventHandler(this.btn_hastaSec_Click);
            // 
            // lbl_toplamFiyat
            // 
            this.lbl_toplamFiyat.AutoSize = true;
            this.lbl_toplamFiyat.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplamFiyat.Location = new System.Drawing.Point(190, 155);
            this.lbl_toplamFiyat.Name = "lbl_toplamFiyat";
            this.lbl_toplamFiyat.Size = new System.Drawing.Size(55, 21);
            this.lbl_toplamFiyat.TabIndex = 3;
            this.lbl_toplamFiyat.Text = "FİYAT";
            // 
            // btn_satis
            // 
            this.btn_satis.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_satis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_satis.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_satis.ForeColor = System.Drawing.Color.White;
            this.btn_satis.Location = new System.Drawing.Point(825, 699);
            this.btn_satis.Name = "btn_satis";
            this.btn_satis.Size = new System.Drawing.Size(180, 56);
            this.btn_satis.TabIndex = 4;
            this.btn_satis.Text = "SATIŞ YAP";
            this.btn_satis.UseVisualStyleBackColor = false;
            this.btn_satis.Click += new System.EventHandler(this.btn_satis_Click);
            // 
            // listBox_receteList
            // 
            this.listBox_receteList.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_receteList.FormattingEnabled = true;
            this.listBox_receteList.Location = new System.Drawing.Point(275, 66);
            this.listBox_receteList.Name = "listBox_receteList";
            this.listBox_receteList.ScrollAlwaysVisible = true;
            this.listBox_receteList.Size = new System.Drawing.Size(721, 257);
            this.listBox_receteList.TabIndex = 5;
            // 
            // pnl_bilgi
            // 
            this.pnl_bilgi.Controls.Add(this.label9);
            this.pnl_bilgi.Controls.Add(this.label5);
            this.pnl_bilgi.Controls.Add(this.label4);
            this.pnl_bilgi.Controls.Add(this.label3);
            this.pnl_bilgi.Controls.Add(this.lbl_tc);
            this.pnl_bilgi.Controls.Add(this.lbl_ad);
            this.pnl_bilgi.Controls.Add(this.lbl_soyad);
            this.pnl_bilgi.Controls.Add(this.lbl_toplamFiyat);
            this.pnl_bilgi.Location = new System.Drawing.Point(3, 448);
            this.pnl_bilgi.Name = "pnl_bilgi";
            this.pnl_bilgi.Size = new System.Drawing.Size(344, 195);
            this.pnl_bilgi.TabIndex = 6;
            this.pnl_bilgi.Visible = false;
            // 
            // pnl_ilacBilgi
            // 
            this.pnl_ilacBilgi.Controls.Add(this.lbl_ilac1);
            this.pnl_ilacBilgi.Controls.Add(this.lbl_ilac2);
            this.pnl_ilacBilgi.Controls.Add(this.lbl_ilac3);
            this.pnl_ilacBilgi.Controls.Add(this.lbl_ilac5);
            this.pnl_ilacBilgi.Controls.Add(this.lbl_ilac4);
            this.pnl_ilacBilgi.Controls.Add(this.lbl_ilacadi5);
            this.pnl_ilacBilgi.Controls.Add(this.lbl_ilacadi4);
            this.pnl_ilacBilgi.Controls.Add(this.lbl_ilacadi3);
            this.pnl_ilacBilgi.Controls.Add(this.lbl_ilacadi2);
            this.pnl_ilacBilgi.Controls.Add(this.lbl_ilacadi1);
            this.pnl_ilacBilgi.Location = new System.Drawing.Point(421, 448);
            this.pnl_ilacBilgi.Name = "pnl_ilacBilgi";
            this.pnl_ilacBilgi.Size = new System.Drawing.Size(574, 223);
            this.pnl_ilacBilgi.TabIndex = 7;
            this.pnl_ilacBilgi.Visible = false;
            // 
            // lbl_ilacadi1
            // 
            this.lbl_ilacadi1.AutoSize = true;
            this.lbl_ilacadi1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ilacadi1.Location = new System.Drawing.Point(21, 25);
            this.lbl_ilacadi1.Name = "lbl_ilacadi1";
            this.lbl_ilacadi1.Size = new System.Drawing.Size(109, 23);
            this.lbl_ilacadi1.TabIndex = 4;
            this.lbl_ilacadi1.Text = "İLAÇ ADI :";
            this.lbl_ilacadi1.Visible = false;
            // 
            // lbl_ilac4
            // 
            this.lbl_ilac4.AutoSize = true;
            this.lbl_ilac4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ilac4.Location = new System.Drawing.Point(160, 155);
            this.lbl_ilac4.Name = "lbl_ilac4";
            this.lbl_ilac4.Size = new System.Drawing.Size(39, 21);
            this.lbl_ilac4.TabIndex = 3;
            this.lbl_ilac4.Text = "ilac";
            this.lbl_ilac4.Visible = false;
            // 
            // lbl_ilac3
            // 
            this.lbl_ilac3.AutoSize = true;
            this.lbl_ilac3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ilac3.Location = new System.Drawing.Point(160, 111);
            this.lbl_ilac3.Name = "lbl_ilac3";
            this.lbl_ilac3.Size = new System.Drawing.Size(39, 21);
            this.lbl_ilac3.TabIndex = 3;
            this.lbl_ilac3.Text = "ilac";
            this.lbl_ilac3.Visible = false;
            // 
            // lbl_ilac2
            // 
            this.lbl_ilac2.AutoSize = true;
            this.lbl_ilac2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ilac2.Location = new System.Drawing.Point(160, 71);
            this.lbl_ilac2.Name = "lbl_ilac2";
            this.lbl_ilac2.Size = new System.Drawing.Size(39, 21);
            this.lbl_ilac2.TabIndex = 3;
            this.lbl_ilac2.Text = "ilac";
            this.lbl_ilac2.Visible = false;
            // 
            // lbl_ilac1
            // 
            this.lbl_ilac1.AutoSize = true;
            this.lbl_ilac1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ilac1.Location = new System.Drawing.Point(160, 27);
            this.lbl_ilac1.Name = "lbl_ilac1";
            this.lbl_ilac1.Size = new System.Drawing.Size(39, 21);
            this.lbl_ilac1.TabIndex = 3;
            this.lbl_ilac1.Text = "ilac";
            this.lbl_ilac1.Visible = false;
            // 
            // lbl_ilac5
            // 
            this.lbl_ilac5.AutoSize = true;
            this.lbl_ilac5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ilac5.Location = new System.Drawing.Point(160, 198);
            this.lbl_ilac5.Name = "lbl_ilac5";
            this.lbl_ilac5.Size = new System.Drawing.Size(39, 21);
            this.lbl_ilac5.TabIndex = 3;
            this.lbl_ilac5.Text = "ilac";
            this.lbl_ilac5.Visible = false;
            // 
            // lbl_ilacadi2
            // 
            this.lbl_ilacadi2.AutoSize = true;
            this.lbl_ilacadi2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ilacadi2.Location = new System.Drawing.Point(21, 69);
            this.lbl_ilacadi2.Name = "lbl_ilacadi2";
            this.lbl_ilacadi2.Size = new System.Drawing.Size(109, 23);
            this.lbl_ilacadi2.TabIndex = 4;
            this.lbl_ilacadi2.Text = "İLAÇ ADI :";
            this.lbl_ilacadi2.Visible = false;
            // 
            // lbl_ilacadi3
            // 
            this.lbl_ilacadi3.AutoSize = true;
            this.lbl_ilacadi3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ilacadi3.Location = new System.Drawing.Point(21, 109);
            this.lbl_ilacadi3.Name = "lbl_ilacadi3";
            this.lbl_ilacadi3.Size = new System.Drawing.Size(109, 23);
            this.lbl_ilacadi3.TabIndex = 4;
            this.lbl_ilacadi3.Text = "İLAÇ ADI :";
            this.lbl_ilacadi3.Visible = false;
            // 
            // lbl_ilacadi4
            // 
            this.lbl_ilacadi4.AutoSize = true;
            this.lbl_ilacadi4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ilacadi4.Location = new System.Drawing.Point(21, 153);
            this.lbl_ilacadi4.Name = "lbl_ilacadi4";
            this.lbl_ilacadi4.Size = new System.Drawing.Size(109, 23);
            this.lbl_ilacadi4.TabIndex = 4;
            this.lbl_ilacadi4.Text = "İLAÇ ADI :";
            this.lbl_ilacadi4.Visible = false;
            // 
            // lbl_ilacadi5
            // 
            this.lbl_ilacadi5.AutoSize = true;
            this.lbl_ilacadi5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ilacadi5.Location = new System.Drawing.Point(21, 196);
            this.lbl_ilacadi5.Name = "lbl_ilacadi5";
            this.lbl_ilacadi5.Size = new System.Drawing.Size(109, 23);
            this.lbl_ilacadi5.TabIndex = 4;
            this.lbl_ilacadi5.Text = "İLAÇ ADI :";
            this.lbl_ilacadi5.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(9, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "TOPLAM FİYAT :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "SOYAD :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "AD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "TC KİMLİK NO :";
            // 
            // lbl_hata
            // 
            this.lbl_hata.AutoSize = true;
            this.lbl_hata.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hata.ForeColor = System.Drawing.Color.Red;
            this.lbl_hata.Location = new System.Drawing.Point(622, 9);
            this.lbl_hata.Name = "lbl_hata";
            this.lbl_hata.Size = new System.Drawing.Size(373, 18);
            this.lbl_hata.TabIndex = 8;
            this.lbl_hata.Text = "HASTALARA AİT ÖDENMEMİŞ REÇETE BULUNMUYOR";
            this.lbl_hata.Visible = false;
            // 
            // Satış
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 767);
            this.Controls.Add(this.lbl_hata);
            this.Controls.Add(this.pnl_ilacBilgi);
            this.Controls.Add(this.pnl_bilgi);
            this.Controls.Add(this.listBox_receteList);
            this.Controls.Add(this.btn_hastaSec);
            this.Controls.Add(this.btn_satis);
            this.Controls.Add(this.btn_receteSec);
            this.Controls.Add(this.checklist_hastalar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Satış";
            this.Text = "Satış";
            this.Load += new System.EventHandler(this.Satış_Load);
            this.pnl_bilgi.ResumeLayout(false);
            this.pnl_bilgi.PerformLayout();
            this.pnl_ilacBilgi.ResumeLayout(false);
            this.pnl_ilacBilgi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checklist_hastalar;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Button btn_receteSec;
        private System.Windows.Forms.Button btn_hastaSec;
        private System.Windows.Forms.Label lbl_toplamFiyat;
        private System.Windows.Forms.Button btn_satis;
        private System.Windows.Forms.CheckedListBox listBox_receteList;
        private System.Windows.Forms.Panel pnl_bilgi;
        private System.Windows.Forms.Panel pnl_ilacBilgi;
        private System.Windows.Forms.Label lbl_ilacadi1;
        private System.Windows.Forms.Label lbl_ilac1;
        private System.Windows.Forms.Label lbl_ilac2;
        private System.Windows.Forms.Label lbl_ilac3;
        private System.Windows.Forms.Label lbl_ilac5;
        private System.Windows.Forms.Label lbl_ilac4;
        private System.Windows.Forms.Label lbl_ilacadi5;
        private System.Windows.Forms.Label lbl_ilacadi4;
        private System.Windows.Forms.Label lbl_ilacadi3;
        private System.Windows.Forms.Label lbl_ilacadi2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_hata;
    }
}