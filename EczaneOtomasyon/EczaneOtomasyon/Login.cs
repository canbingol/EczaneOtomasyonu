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
        public static string aktifKullanıcı;

        void Temizle(TextBox txt, TextBox txt2, TextBox txt3)
        {
            txt.Clear();
            txt2.Clear();
            txt3.Clear();
        }
        void Temizle(TextBox txt, TextBox txt2)
        {
            txt.Clear();
            txt2.Clear();
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
            else
                lbl_hataParola.Visible = false;

            using (OleDbConnection con = new OleDbConnection(connection))
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand("Select * from Kullanıcılar where kullanıcıAdı=@kullanıcıAdı and parola =@parola", con))
                {
                    cmd.Parameters.AddWithValue("@Username", kullanıcıAdı);
                    cmd.Parameters.AddWithValue("@Password", parola);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            aktifKullanıcı = reader["kullanıcıAdı"].ToString();

                        }

                        if (reader.HasRows)
                        {

                            AnaEkran anaEkran = new AnaEkran();
                            anaEkran.Show();
                            this.Hide();
                        }
                        else
                        {

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
                OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM Kullanıcılar WHERE kullanıcıAdı = @p1", con);
                cmd.Parameters.AddWithValue("@p1", kullaniciAdi);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }


        }
        public void HataMesajı(string str, Label lbl)
        {
            if (string.IsNullOrEmpty(str))
                lbl.Visible = true;
            else
                lbl.Visible = false;
        }

        private void btn_yeniParolaKaydet_Click(object sender, EventArgs e)
        {


            string parola1 = txt_YeniParola.Text;
            string parola2 = txt_YeniParola2.Text;
            String kullanıcı = txt_parolaKullanıcıAdı.Text;

            // textBox ların boş olup olmadığını kontrol eder
            HataMesajı(parola1, lbl_hataUnuttumParola1);
            HataMesajı(parola2, lbl_hataUnuttumParola2);
            HataMesajı(kullanıcı, lbl_hataParolaKullanıcıadı);

            if (KullaniciAdiMevcutMu(kullanıcı))
            {
                if (!string.IsNullOrEmpty(parola2) && !string.IsNullOrEmpty(parola1))
                {
                    if (parola1.Length < 4)
                    {
                        MessageBox.Show(" Parola 4 haneden kısa olamaz");
                    }
                    else
                    {
                        if (parola1 != parola2)
                            MessageBox.Show(" Şifreler uyuşmuyor !");

                        // parolalar uyuşuyor ise şifreyi günceller
                        else
                        {
                            using (OleDbConnection con = new OleDbConnection(connection))
                            {
                                using (OleDbCommand cmd = new OleDbCommand("UPDATE Kullanıcılar SET parola = @parola WHERE kullanıcıAdı =@kullanıcı", con))
                                {
                                    cmd.Parameters.AddWithValue("@parola", parola1);
                                    cmd.Parameters.AddWithValue("@kullanıcı", kullanıcı);

                                    con.Open();
                                    int etkilenenSatırSayısı = cmd.ExecuteNonQuery();
                                    //con.Close();

                                    if (etkilenenSatırSayısı > 0)
                                    {
                                        txt_YeniParola.Clear();
                                        txt_YeniParola2.Clear();
                                        txt_parolaKullanıcıAdı.Clear();
                                        MessageBox.Show("Parola başarılı bir şekilde güncellendi");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Güncelleme başarısız. Kullanıcı bulunamadı veya başka bir hata oluştu.");
                                    }
                                }
                            }
                        }
                    }
                }
                //  Temizle(txt_YeniParola2, txt_YeniParola, txt_parolaKullanıcıAdı);
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
            PanelYeniKayıt.Location = new Point(345, 10);
            if (panel_SifreDegistir.Visible == true)
            {
                panel_SifreDegistir.Visible = false;
            }
            Temizle(txt_kayıtKullanıcıAdı, txt_Parola);
        }

        private void btn_sifreUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            panel_SifreDegistir.Visible = true;
            panel_SifreDegistir.Location = new Point(346, 1);
            btn_YeniKayıtEkle.Visible = false;
            if (PanelYeniKayıt.Visible == true)
            {
                PanelYeniKayıt.Visible = false;
            }
            Temizle(txt_KullanıcıAdı, txt_Parola);
        }
        private void btn_kayıtKapat_Click(object sender, EventArgs e)
        {

            PanelYeniKayıt.Visible = false;
            Temizle(txt_kayıtKullanıcıAdı, txt_kayıtParola, txt_kayıtParola2);
        }

        private void btn_parolaKapat_Click(object sender, EventArgs e)
        {

            panel_SifreDegistir.Visible = false;
            btn_YeniKayıtEkle.Visible = true;
            Temizle(txt_YeniParola2, txt_YeniParola, txt_parolaKullanıcıAdı);
        }

        private void btn_YeniKayıtEkle_Click(object sender, EventArgs e)
        {

            string kullanıcı = txt_kayıtKullanıcıAdı.Text;
            string parola1 = txt_kayıtParola.Text;
            string parola2 = txt_kayıtParola2.Text;

            HataMesajı(kullanıcı, lbl_hataKayıtKullanıcıAdı);
            HataMesajı(parola1, lbl_hataKayıtParola1);
            HataMesajı(parola2, lbl_hataKayıtParola2);

            if (KullaniciAdiMevcutMu(kullanıcı))
                MessageBox.Show(" Bu kullanıcı adı alınmış lütfen tekrar deneyin");
            else
            {
                if (string.IsNullOrEmpty(parola2) && string.IsNullOrEmpty(parola1))
                    MessageBox.Show("  şifre alanları boş bırakılamaz");
                else
                {
                    if (!(parola1 == parola2))
                        MessageBox.Show(" Şifreler aynı olmalı");
                    else
                    {
                        if (parola1.Length < 4)
                            MessageBox.Show("Parola 4 haneden küçük olamaz");
                        else
                        {
                            using (OleDbConnection con = new OleDbConnection(connection))
                            {
                                using (OleDbCommand cmd = new OleDbCommand("INSERT INTO  Kullanıcılar(kullanıcıAdı, parola) VALUES (@kullanıcı, @parola) ", con))
                                {

                                    cmd.Parameters.AddWithValue("@kullanıcı", kullanıcı);
                                    cmd.Parameters.AddWithValue("@parola", parola1);

                                    con.Open();
                                    int etkilenenSatırSayısı = cmd.ExecuteNonQuery();
                                    con.Close();

                                    if (etkilenenSatırSayısı > 0)
                                    {
                                        MessageBox.Show("Kayıt  başarılı bir şekilde eklendi");
                                        txt_kayıtKullanıcıAdı.Clear();
                                        txt_kayıtParola.Clear();
                                        txt_kayıtParola2.Clear();
                                    }
                                    else
                                        MessageBox.Show("Kayıt Yapılırken Hata oluştu Lütfen tekrar deneyim");
                                }
                            }
                        }
                    }
                }
            }
            // Temizle(txt_kayıtKullanıcıAdı, txt_kayıtParola, txt_kayıtParola2);
        }

        private void btn_cıkıs_Click_1(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("ÇIKIŞ YAPMAK İSTEDİĞİNE EMİN MİSİN?", "ÇIKIŞ", MessageBoxButtons.OKCancel);
            if (sonuc == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

            txt_kayıtParola2.PasswordChar = Encoding.GetEncoding("Windows-1252").GetString(new byte[] { 149, })[0];
            txt_kayıtParola.PasswordChar = Encoding.GetEncoding("Windows-1252").GetString(new byte[] { 149, })[0];
            txt_Parola.PasswordChar = Encoding.GetEncoding("Windows-1252").GetString(new byte[] { 149, })[0];
            txt_YeniParola.PasswordChar = Encoding.GetEncoding("Windows-1252").GetString(new byte[] { 149, })[0];
            txt_YeniParola2.PasswordChar = Encoding.GetEncoding("Windows-1252").GetString(new byte[] { 149, })[0];
        }

    }

}
