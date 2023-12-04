using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace EczaneOtomasyon
{
    public partial class Login : Form
    {
        string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb";

        public Login()
        {
            InitializeComponent();
        }

        private void btn_Giriş_Click(object sender, EventArgs e)
        {
            string kullanıcıAdı = txt_KullanıcıAdı.Text;
            string parola = txt_Parola.Text;

            if (string.IsNullOrEmpty(kullanıcıAdı))
                lbl_hataKullanıcıAdı.Visible = true;
            else
                lbl_hataKullanıcıAdı.Visible = false;

            if (string.IsNullOrEmpty(parola))
                lbl_hataParola.Visible = true;
            else lbl_hataParola.Visible = false;

            using (OleDbConnection con = new OleDbConnection(connection))
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand("Select * from Kullanıcılar where kullanıcıAdı=@kullanıcıAdı and parola =@parola", con))
                {
                    cmd.Parameters.AddWithValue("@Username", kullanıcıAdı);
                    cmd.Parameters.AddWithValue("@Password", parola);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Kullanıcı doğrulandı, giriş yapabilirsiniz.
                            MessageBox.Show("Giriş başarılı!");
                            AnaEkran anaEkran = new AnaEkran();
                            anaEkran.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Kullanıcı doğrulanamadı, hata mesajı gösterin.
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı!");

                        }
                    }
                }


            }
        }
        public bool KullaniciAdiMevcutMu(string kullaniciAdi)
        {
            using (OleDbConnection con = new OleDbConnection(connection))
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM Kullanıcılar WHERE kullanıcıAdı = @kullanici", con))
                {
                    cmd.Parameters.AddWithValue("@kullanici", kullaniciAdi);
                    int kullaniciSayisi = (int)cmd.ExecuteScalar();
                    return kullaniciSayisi > 0;
                }
            }
        }


        private void btn_yeniParolaKaydet_Click(object sender, EventArgs e)
        {
            string parola1 = txt_YeniParola.Text;
            string parola2 = txt_YeniParola2.Text;
            String kullanıcı = txt_parolaKullanıcıAdı.Text;

            // textBox ların boş olup olmadığını kontrol eder
            if (string.IsNullOrEmpty(parola1))
                lbl_hataUnuttumParola1.Visible = true;
            else lbl_hataUnuttumParola1.Visible = false;
            if (string.IsNullOrEmpty(parola2))
                lbl_hataUnuttumParola2.Visible = true;
            else lbl_hataUnuttumParola2.Visible = false;
            if (string.IsNullOrEmpty(kullanıcı))
                lbl_hataParolaKullanıcıadı.Visible = true;
            else
                lbl_hataParolaKullanıcıadı.Visible = false;

            if (KullaniciAdiMevcutMu(kullanıcı))
            {
                if (parola1 != parola2)
                    MessageBox.Show(" Şifreler uyuşmuyor !");

                // parolalar uyuşuyor ise şifreyi günceller
                else
                {
                    using (OleDbConnection con = new OleDbConnection(connection))
                    {
                        using (OleDbCommand cmd = new OleDbCommand("UPDATE Kullanıcılar SET parola = @parola where kullanıcıAdı =@kullanıcı", con))
                        {
                            cmd.Parameters.AddWithValue("@parola", parola1);
                            cmd.Parameters.AddWithValue("@kullanıcı", kullanıcı);
                            txt_YeniParola.Clear();
                            txt_YeniParola2.Clear();
                            txt_parolaKullanıcıAdı.Clear();
                            MessageBox.Show("Parola başarılı bir şekilde güncellendi");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Kullanıcı bulunamadı. Geçerli bir kullanıcı adı giriniz.");
            }

        }

        private void btn_yeniKullanıcı_Click(object sender, EventArgs e)
        {
            // panel görünür kılındı ve lokasyınu yeniden ayarlandı
            PanelYeniKayıt.Visible = true;
            PanelYeniKayıt.Location = new Point(345, 28);
            if (panel_SifreDegistir.Visible == true)
            {
                panel_SifreDegistir.Visible = false;
            }

        }

        private void btn_sifreUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel_SifreDegistir.Visible = true;
            panel_SifreDegistir.Location = new Point(346, 63);

            if (PanelYeniKayıt.Visible == true)
            {
                PanelYeniKayıt.Visible = false;
            }
        }
    }
}
