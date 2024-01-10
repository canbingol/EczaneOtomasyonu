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
        string baglanti = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb";

        public Login()
        {
            InitializeComponent();
        }
        public static string aktifKullanici;
        // parametre olarak girilen textboxlar temizlenir
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
        // giriş butonuna tıklandığında çalışır
        private void btn_Giriş_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_KullaniciAdi.Text;
            string parola = txt_Parola.Text;

            if (string.IsNullOrEmpty(kullaniciAdi))
                lbl_hataKullaniciAdi.Visible = true;
            else
                lbl_hataKullaniciAdi.Visible = false;

            if (string.IsNullOrEmpty(parola))
                lbl_hataParola.Visible = true;
            else
                lbl_hataParola.Visible = false;
            try
            {
                using (OleDbConnection con = new OleDbConnection(baglanti))
                {
                    con.Open();
                    using (OleDbCommand cmd = new OleDbCommand("Select * from Kullanicilar where kullaniciAdi=@kullaniciAdi and parola =@parola", con))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        cmd.Parameters.AddWithValue("@parola", parola);
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                                aktifKullanici = reader["kullaniciAdi"].ToString();
                            //  okunan değer boş değil ise
                            if (reader.HasRows)
                            {
                                AnaEkran anaEkran = new AnaEkran();
                                anaEkran.Show();
                                this.Hide();
                            }
                            else
                                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("HATA OLUŞTU LÜTGEN TEKRAR DENEYİN");
            }


        }
        // parametre ile girilen kullanı adının olup olmadığını kontrol eder
        public bool KullaniciAdiMevcutMu(string kullaniciAdi)
        {
            using (OleDbConnection con = new OleDbConnection(baglanti))
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT COUNT(*) FROM Kullanicilar WHERE kullaniciAdi = @p1", con);
                cmd.Parameters.AddWithValue("@p1", kullaniciAdi);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        // parametre olarak girilen label ların görünürlükleri ayarlanır
        public void HataMesaji(string str, Label lbl)
        {
            if (string.IsNullOrEmpty(str))
                lbl.Visible = true;
            else
                lbl.Visible = false;
        }
        // parolamı unuttuma basınca çalışır
        private void btn_yeniParolaKaydet_Click(object sender, EventArgs e)
        {
            string parola1 = txt_YeniParola.Text;
            string parola2 = txt_YeniParola2.Text;
            String kullanici = txt_parolaKullaniciAdi.Text;

            // textBox ların boş olup olmadığını kontrol eder
            HataMesaji(parola1, lbl_hataUnuttumParola1);
            HataMesaji(parola2, lbl_hataUnuttumParola2);
            HataMesaji(kullanici, lbl_hataParolaKullaniciAdi);

            if (!string.IsNullOrEmpty(kullanici))
            {
                // girilen kullanıcı adının olup olmadığı kontrol edilir
                if (KullaniciAdiMevcutMu(kullanici))
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
                                using (OleDbConnection con = new OleDbConnection(baglanti))
                                {
                                    using (OleDbCommand cmd = new OleDbCommand("UPDATE Kullanicilar SET parola = @parola WHERE kullaniciAdi =@kullaniciAdi", con))
                                    {
                                        cmd.Parameters.AddWithValue("@parola", parola1);
                                        cmd.Parameters.AddWithValue("@kullaniciAdi", kullanici);

                                        con.Open();
                                        int sayac = cmd.ExecuteNonQuery();
                                        con.Close();

                                        if (sayac > 0)
                                        {
                                            txt_YeniParola.Clear();
                                            txt_YeniParola2.Clear();
                                            txt_parolaKullaniciAdi.Clear();
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
                }
                else
                    MessageBox.Show("Kullanıcı bulunamadı. Geçerli bir kullanıcı adı giriniz.");
            }
            else
                MessageBox.Show("LÜTFEN KULLANICI ADINI GİRİNİZ");

        }

        private void btn_yeniKullanici_Click(object sender, EventArgs e)
        {

            // panel görünür kılındı ve lokasyınu yeniden ayarlandı
            PanelYeniKayit.Visible = true;
            PanelYeniKayit.Location = new Point(345, 10);
            if (panel_SifreDegistir.Visible == true)
            {
                panel_SifreDegistir.Visible = false;
            }
            Temizle(txt_kayitKullaniciAdi, txt_Parola);
        }

        private void btn_sifreUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            panel_SifreDegistir.Visible = true;
            panel_SifreDegistir.Location = new Point(346, 1);
            btn_YeniKayitEkle.Visible = false;
            if (PanelYeniKayit.Visible == true)
            {
                PanelYeniKayit.Visible = false;
            }
            Temizle(txt_KullaniciAdi, txt_Parola);
        }
        private void btn_kayitKapat_Click(object sender, EventArgs e)
        {

            PanelYeniKayit.Visible = false;
            Temizle(txt_kayitKullaniciAdi, txt_kayitParola, txt_kayitParola2);
        }

        private void btn_parolaKapat_Click(object sender, EventArgs e)
        {
            panel_SifreDegistir.Visible = false;
            btn_YeniKayitEkle.Visible = true;
            Temizle(txt_YeniParola2, txt_YeniParola, txt_parolaKullaniciAdi);
        }

        // yeni kayıt ekleme işlemi
        private void btn_YeniKayitEkle_Click(object sender, EventArgs e)
        {

            string kullanici = txt_kayitKullaniciAdi.Text;
            string parola1 = txt_kayitParola.Text;
            string parola2 = txt_kayitParola2.Text;
            string yetki = comboBox_yetki.Text;
            HataMesaji(kullanici, lbl_hataKayitKullaniciAdi);
            HataMesaji(parola1, lbl_hataKayitParola1);
            HataMesaji(parola2, lbl_hataKayitParola2);

            try
            {
                if (KullaniciAdiMevcutMu(kullanici))
                    MessageBox.Show(" Bu kullanıcı adı alınmış lütfen tekrar deneyin");
                else
                {
                    if (string.IsNullOrEmpty(parola2) && string.IsNullOrEmpty(parola1) && string.IsNullOrEmpty(yetki))
                        MessageBox.Show("lütfen bütün alanları doldurun");
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
                                using (OleDbConnection con = new OleDbConnection(baglanti))
                                {
                                    using (OleDbCommand cmd = new OleDbCommand("INSERT INTO  Kullanicilar(kullaniciAdi, parola,yetki) VALUES (@kullanici, @parola,@yetki) ", con))
                                    {

                                        cmd.Parameters.AddWithValue("@kullanıcı", kullanici);
                                        cmd.Parameters.AddWithValue("@parola", parola1);
                                        cmd.Parameters.AddWithValue("@yetki", yetki);

                                        con.Open();
                                        int sayac = cmd.ExecuteNonQuery();
                                        con.Close();

                                        if (sayac > 0)
                                        {
                                            MessageBox.Show("Kayıt  başarılı bir şekilde eklendi");
                                            txt_kayitKullaniciAdi.Clear();
                                            txt_kayitParola.Clear();
                                            txt_kayitParola2.Clear();
                                        }
                                        else
                                            MessageBox.Show("Kayıt Yapılırken Hata oluştu Lütfen tekrar deneyim");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Yapılırken Hata oluştu Lütfen tekrar deneyin");
            }
        }

        private void btn_cikis_Click_1(object sender, EventArgs e)
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
            // form üzerinden paswordChar kullanılamadığı için burada yapıldı
            txt_kayitParola2.PasswordChar = Encoding.GetEncoding("Windows-1252").GetString(new byte[] { 149, })[0];
            txt_kayitParola.PasswordChar = Encoding.GetEncoding("Windows-1252").GetString(new byte[] { 149, })[0];
            txt_Parola.PasswordChar = Encoding.GetEncoding("Windows-1252").GetString(new byte[] { 149, })[0];
            txt_YeniParola.PasswordChar = Encoding.GetEncoding("Windows-1252").GetString(new byte[] { 149, })[0];
            txt_YeniParola2.PasswordChar = Encoding.GetEncoding("Windows-1252").GetString(new byte[] { 149, })[0];
        }

    }

}
