namespace EczaneOtomasyon.Forms.Stok
{
    partial class StokAnaSayfa
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBar = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_toplamAdet = new System.Windows.Forms.Label();
            this.bar = new System.Windows.Forms.ProgressBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "AĞRI KESİCİLER";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 85);
            this.button2.TabIndex = 0;
            this.button2.Text = "ALERJİ İLAÇALRI";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(298, 530);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 85);
            this.button3.TabIndex = 0;
            this.button3.Text = "ANTİBİYOTİKLER";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(39, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 85);
            this.button4.TabIndex = 0;
            this.button4.Text = "ANTİDEPRESANLAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(298, 292);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 85);
            this.button5.TabIndex = 0;
            this.button5.Text = "DİYABET İLÇLARI";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(298, 411);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(164, 85);
            this.button6.TabIndex = 0;
            this.button6.Text = "KALP İLÇLARI";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(39, 398);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(164, 85);
            this.button7.TabIndex = 0;
            this.button7.Text = "TANSİYON İLÇLARI";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(39, 530);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(164, 85);
            this.button8.TabIndex = 0;
            this.button8.Text = "DİĞER İLÇLAR";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lbl_toplamAdet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 100);
            this.panel1.TabIndex = 1;
            // 
            // pBar
            // 
            this.pBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pBar.AnimationSpeed = 500;
            this.pBar.BackColor = System.Drawing.Color.Transparent;
            this.pBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pBar.ForeColor = System.Drawing.Color.White;
            this.pBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pBar.InnerMargin = 2;
            this.pBar.InnerWidth = -1;
            this.pBar.Location = new System.Drawing.Point(493, 194);
            this.pBar.MarqueeAnimationSpeed = 2000;
            this.pBar.Name = "pBar";
            this.pBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pBar.OuterMargin = -25;
            this.pBar.OuterWidth = 26;
            this.pBar.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.pBar.ProgressWidth = 18;
            this.pBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pBar.Size = new System.Drawing.Size(250, 250);
            this.pBar.StartAngle = 270;
            this.pBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pBar.SubscriptText = "";
            this.pBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pBar.SuperscriptText = "";
            this.pBar.TabIndex = 1;
            this.pBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pBar.Value = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(557, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "DOLULUK ORANI";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(38, 51);
            this.textBox1.MaxLength = 13;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 37);
            this.textBox1.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DodgerBlue;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(264, 44);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(134, 53);
            this.button9.TabIndex = 1;
            this.button9.Text = "İLAÇ SORGULA";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(548, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOPLAM İLAÇ ADEDİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "İLAÇ BARKODU GİRİNİZ";
            // 
            // lbl_toplamAdet
            // 
            this.lbl_toplamAdet.AutoSize = true;
            this.lbl_toplamAdet.BackColor = System.Drawing.Color.Transparent;
            this.lbl_toplamAdet.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplamAdet.ForeColor = System.Drawing.Color.White;
            this.lbl_toplamAdet.Location = new System.Drawing.Point(634, 54);
            this.lbl_toplamAdet.Name = "lbl_toplamAdet";
            this.lbl_toplamAdet.Size = new System.Drawing.Size(25, 27);
            this.lbl_toplamAdet.TabIndex = 0;
            this.lbl_toplamAdet.Text = "0";
            // 
            // bar
            // 
            this.bar.Location = new System.Drawing.Point(520, 482);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(199, 48);
            this.bar.TabIndex = 2;
            // 
            // StokAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 746);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StokAnaSayfa";
            this.Text = "StokAnaSayfa";
            this.Load += new System.EventHandler(this.StokAnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel1;
        private CircularProgressBar.CircularProgressBar pBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_toplamAdet;
        private System.Windows.Forms.ProgressBar bar;
    }
}