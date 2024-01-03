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
            this.listBox_receteList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_receteSec = new System.Windows.Forms.Button();
            this.btn_hastaSec = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
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
            this.checklist_hastalar.FormattingEnabled = true;
            this.checklist_hastalar.Items.AddRange(new object[] {
            "fdgdfgds",
            "sg",
            "dsf",
            "ds",
            "fds",
            "fds",
            "fs",
            "f",
            "sf",
            "sdf",
            "ds",
            "f",
            "s"});
            this.checklist_hastalar.Location = new System.Drawing.Point(12, 66);
            this.checklist_hastalar.Name = "checklist_hastalar";
            this.checklist_hastalar.Size = new System.Drawing.Size(257, 259);
            this.checklist_hastalar.TabIndex = 1;
            this.checklist_hastalar.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checklist_hastalar_ItemCheck);
            this.checklist_hastalar.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // listBox_receteList
            // 
            this.listBox_receteList.FormattingEnabled = true;
            this.listBox_receteList.ItemHeight = 16;
            this.listBox_receteList.Location = new System.Drawing.Point(275, 65);
            this.listBox_receteList.Name = "listBox_receteList";
            this.listBox_receteList.Size = new System.Drawing.Size(464, 260);
            this.listBox_receteList.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "TC KİMLİK NO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "AD :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "SOYAD :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(239, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "TC KİMLİK NO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(239, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "AD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(239, 566);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "SOYAD";
            // 
            // btn_receteSec
            // 
            this.btn_receteSec.Location = new System.Drawing.Point(516, 331);
            this.btn_receteSec.Name = "btn_receteSec";
            this.btn_receteSec.Size = new System.Drawing.Size(180, 56);
            this.btn_receteSec.TabIndex = 4;
            this.btn_receteSec.Text = "REÇETE SEÇ";
            this.btn_receteSec.UseVisualStyleBackColor = true;
            // 
            // btn_hastaSec
            // 
            this.btn_hastaSec.Location = new System.Drawing.Point(100, 331);
            this.btn_hastaSec.Name = "btn_hastaSec";
            this.btn_hastaSec.Size = new System.Drawing.Size(169, 56);
            this.btn_hastaSec.TabIndex = 4;
            this.btn_hastaSec.Text = "HASTA SEÇ";
            this.btn_hastaSec.UseVisualStyleBackColor = true;
            this.btn_hastaSec.Click += new System.EventHandler(this.btn_hastaSec_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(38, 606);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "TOPLAM FİYAT :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(239, 609);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "FİYAT";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(516, 669);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 56);
            this.button3.TabIndex = 4;
            this.button3.Text = "SATIŞ YAP";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Satış
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 767);
            this.Controls.Add(this.btn_hastaSec);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_receteSec);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_receteList);
            this.Controls.Add(this.checklist_hastalar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Satış";
            this.Text = "Satış";
            this.Load += new System.EventHandler(this.Satış_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checklist_hastalar;
        private System.Windows.Forms.ListBox listBox_receteList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_receteSec;
        private System.Windows.Forms.Button btn_hastaSec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
    }
}