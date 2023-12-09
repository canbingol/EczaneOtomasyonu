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
            this.label1 = new System.Windows.Forms.Label();
            this.pBar = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "AĞRI KESİCİLER";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 85);
            this.button2.TabIndex = 0;
            this.button2.Text = "ALERJİ İLAÇALRI";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(298, 478);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 85);
            this.button3.TabIndex = 0;
            this.button3.Text = "ANTİBİYOTİKLER";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(39, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 85);
            this.button4.TabIndex = 0;
            this.button4.Text = "ANTİDEPRESANLAR";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(298, 240);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 85);
            this.button5.TabIndex = 0;
            this.button5.Text = "DİYABET İLÇLARI";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(298, 359);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(164, 85);
            this.button6.TabIndex = 0;
            this.button6.Text = "KALP İLÇLARI";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(39, 346);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(164, 85);
            this.button7.TabIndex = 0;
            this.button7.Text = "TANSİYON İLÇLARI";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(39, 478);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(164, 85);
            this.button8.TabIndex = 0;
            this.button8.Text = "DİĞER İLÇLAR";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOPLAM İLAÇ SAYISI";
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
            this.pBar.Location = new System.Drawing.Point(618, 194);
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
            this.label2.Location = new System.Drawing.Point(675, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "DOLULUK ORANI";
            // 
            // StokAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 769);
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
        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar pBar;
        private System.Windows.Forms.Label label2;
    }
}