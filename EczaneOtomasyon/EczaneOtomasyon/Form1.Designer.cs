namespace EczaneOtomasyon
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbl_KullanıcıAdı = new System.Windows.Forms.Label();
            this.lbl_Parola = new System.Windows.Forms.Label();
            this.txt_Parola = new System.Windows.Forms.TextBox();
            this.txt_KullanıcıAdı = new System.Windows.Forms.TextBox();
            this.btn_Giriş = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_KullanıcıAdı
            // 
            this.lbl_KullanıcıAdı.AutoSize = true;
            this.lbl_KullanıcıAdı.BackColor = System.Drawing.Color.White;
            this.lbl_KullanıcıAdı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_KullanıcıAdı.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_KullanıcıAdı.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_KullanıcıAdı.ForeColor = System.Drawing.Color.Black;
            this.lbl_KullanıcıAdı.Location = new System.Drawing.Point(331, 148);
            this.lbl_KullanıcıAdı.Name = "lbl_KullanıcıAdı";
            this.lbl_KullanıcıAdı.Size = new System.Drawing.Size(154, 29);
            this.lbl_KullanıcıAdı.TabIndex = 0;
            this.lbl_KullanıcıAdı.Text = "Kullanıcı Adı";
            this.lbl_KullanıcıAdı.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Parola
            // 
            this.lbl_Parola.AutoSize = true;
            this.lbl_Parola.BackColor = System.Drawing.Color.White;
            this.lbl_Parola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Parola.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_Parola.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Parola.ForeColor = System.Drawing.Color.Black;
            this.lbl_Parola.Location = new System.Drawing.Point(400, 196);
            this.lbl_Parola.Name = "lbl_Parola";
            this.lbl_Parola.Size = new System.Drawing.Size(85, 29);
            this.lbl_Parola.TabIndex = 0;
            this.lbl_Parola.Text = "Parola";
            this.lbl_Parola.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Parola
            // 
            this.txt_Parola.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Parola.Location = new System.Drawing.Point(517, 196);
            this.txt_Parola.Multiline = true;
            this.txt_Parola.Name = "txt_Parola";
            this.txt_Parola.Size = new System.Drawing.Size(217, 32);
            this.txt_Parola.TabIndex = 1;
            // 
            // txt_KullanıcıAdı
            // 
            this.txt_KullanıcıAdı.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KullanıcıAdı.Location = new System.Drawing.Point(517, 148);
            this.txt_KullanıcıAdı.Multiline = true;
            this.txt_KullanıcıAdı.Name = "txt_KullanıcıAdı";
            this.txt_KullanıcıAdı.Size = new System.Drawing.Size(217, 32);
            this.txt_KullanıcıAdı.TabIndex = 1;
            // 
            // btn_Giriş
            // 
            this.btn_Giriş.BackColor = System.Drawing.Color.White;
            this.btn_Giriş.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Giriş.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giriş.Location = new System.Drawing.Point(517, 265);
            this.btn_Giriş.Name = "btn_Giriş";
            this.btn_Giriş.Size = new System.Drawing.Size(217, 44);
            this.btn_Giriş.TabIndex = 2;
            this.btn_Giriş.Text = "GİRİŞ";
            this.btn_Giriş.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(386, 265);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 16);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi Unuttum";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(517, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "YENİ KULLANICI";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(740, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_Giriş);
            this.Controls.Add(this.txt_KullanıcıAdı);
            this.Controls.Add(this.txt_Parola);
            this.Controls.Add(this.lbl_Parola);
            this.Controls.Add(this.lbl_KullanıcıAdı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_KullanıcıAdı;
        private System.Windows.Forms.Label lbl_Parola;
        private System.Windows.Forms.TextBox txt_Parola;
        private System.Windows.Forms.TextBox txt_KullanıcıAdı;
        private System.Windows.Forms.Button btn_Giriş;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
    }
}

