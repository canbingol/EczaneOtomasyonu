using EczaneOtomasyon.Forms.Satış;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyon.Forms.AnaPanel
{

    public partial class AnaPanel : Form
    {
        static public int kapasite = 10000;
        string toplamIlac;
        string baglanti = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb";
        int deger;
        public AnaPanel()
        {
            InitializeComponent();
        }
        // parametre olarak girilen sorgudan okunan değeri parametre olarak girilen label e atar
        void ToplamDeger(string sorgu, Label lbl)
        {
            using (OleDbConnection con = new OleDbConnection(baglanti))
            {
                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    con.Open();
                    deger = Convert.ToInt32(cmd.ExecuteScalar());
                    lbl.Text = deger.ToString();
                }
            }
        }
        // toplam ilaç değerini alıp ilgili label e atayan metod 
        void IlacSayisi()
        {
            using (OleDbConnection con = new OleDbConnection(baglanti))
            {
                string sorgu = "SELECT SUM(adet) FROM Ilaclar";

                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();

                    int toplamAdet = (result == DBNull.Value || result == null) ? 0 : Convert.ToInt32(result);
                    toplamIlac = toplamAdet.ToString();
                }
            }
        }
        string yetki;
        // giriş yapan kullanıcının kullanıcı adı üzerinden yetki kontrölü yaparak ana panel üzerinde yetki izinsiz giriş engellendi
        void YetkiKontrol()
        {
            string kullanici = Login.aktifKullanici;
            using (OleDbConnection con = new OleDbConnection(baglanti))
            {
                con.Open();
                string sorgu = "SELECT yetki FROM Kullanicilar WHERE kullaniciAdi=@kullanici";
                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    cmd.Parameters.AddWithValue("@kullanici", kullanici);
                    using (OleDbDataReader yetkiOku = cmd.ExecuteReader())
                    {
                        if (yetkiOku.Read())
                        {
                            yetki = yetkiOku["yetki"].ToString();
                            if (yetki == "calisan")
                            {
                                lbl_hasta.Text = "****"; lbl_hastaProfil.Enabled = true;
                                lbl_toplamIlac.Text = "****"; lbl_ilac.Enabled = true; lbl_ilacSayisi.Text = "****";
                                lbl_toplamKazanc.Text = "****"; lbl_recete.Text = "****"; lbl_bugunKazanc.Text = "****";

                            }
                        }
                    }
                }
            }
        }
        private void AnaPanel_Load(object sender, EventArgs e)
        {
            IlacSayisi(); // toplam ilaç değerini alıp ilgili label e atayan metod çagılıdı
            int deger = Convert.ToInt32(toplamIlac);
            int oran = (deger * 100) / kapasite;
            bar_dolulukOrani.Value = deger;
            lbl_doluluk.Text = "ECZANE DOLULUK ORANI " + "%" + oran.ToString();

            lbl_aktifKullanici.Text = Login.aktifKullanici.ToUpper();
            ToplamDeger("SELECT COUNT(*) FROM Hastalar", lbl_hasta);
            ToplamDeger("SELECT COUNT(*) FROM Ilaclar", lbl_ilacSayisi);
            ToplamDeger("SELECT SUM(adet) FROM Ilaclar", lbl_toplamIlac);
            ToplamDeger("SELECT COUNT(*) FROM Receteler", lbl_recete);
            ToplamCiroAl();
            BugunCiroAl();
            YetkiKontrol();
        }
        // satislar tablosundan toplam satışları çekip ilgili label e atar
        void ToplamCiroAl()
        {
            using (OleDbConnection con = new OleDbConnection(baglanti))
            {
                con.Open();
                string sorgu = "SELECT SUM(toplamFiyat) FROM Satislar";
                using (OleDbCommand ciro = new OleDbCommand(sorgu, con))
                {
                    object toplam = ciro.ExecuteScalar();
                    int sonuc = (toplam == DBNull.Value || toplam == null) ? 0 : Convert.ToInt32(toplam);
                    lbl_toplamKazanc.Text = sonuc.ToString();
                }
            }
        }
        // satislar tablosundan bu güne ait satışları çekip ilgili label e atar
        void BugunCiroAl()
        {
            DateTime bugun = DateTime.Today;
            string tarih = bugun.Day.ToString() + "." + bugun.Month.ToString() + "." + bugun.Year.ToString();
            try
            {
                using (OleDbConnection con = new OleDbConnection(baglanti))
                {
                    con.Open();
                    string sorgu = "SELECT SUM(toplamFiyat) FROM Satislar WHERE SatisTarihi=@tarih";
                    using (OleDbCommand ciro = new OleDbCommand(sorgu, con))
                    {
                        ciro.Parameters.AddWithValue("@tarih", tarih);

                        object toplam = ciro.ExecuteScalar();
                        int sonuc = (toplam == DBNull.Value || toplam == null) ? 0 : Convert.ToInt32(toplam);// veri tabanında çekilen değerin boş olup olmadığını kontrol edne ternary ifadesi
                        lbl_bugunKazanc.Text = sonuc.ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("BUGÜNÜN KAZANCI YAZILIRKEN HATA OLUŞTU");
            }
        }
        Form aktifForm = null;
        // bu form üzerinde başka bir formu göstermek için
        void AltFormGoster(Form altForm)
        {
            btn_kapat.Visible = true;
            pnl_alt.Controls.Clear();
            pnl_alt.Visible = true;
            aktifForm = altForm;
            altForm.TopLevel = false;
            altForm.FormBorderStyle = FormBorderStyle.None;
            altForm.Dock = DockStyle.Fill;
            pnl_alt.Controls.Add(altForm);
            pnl_alt.Tag = altForm;
            altForm.BringToFront();
            pnl_alt.Location = new Point(39, 102);
            altForm.Show();

        }
        // giriş yapan çalışana göre yetki kontrolü yapılıyor yetki çalışan ise buton işlevi kapatılır
        private void lbl_hastaProfil_DoubleClick(object sender, EventArgs e)
        {
            if (yetki == "calisan")
                MessageBox.Show("YETKİSİZ ERİŞİM");
            else
                AltFormGoster(new HastaProfil());
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            btn_kapat.Visible = false;
            pnl_alt.Visible = false;
        }
        // giriş yapan çalışana göre eyetki kontrolü yapılıyor

        private void lbl_ilac_DoubleClick(object sender, EventArgs e)
        {
            if (yetki == "calisan")
                MessageBox.Show("YETKİSİZ ERİŞİM");
            else
                AltFormGoster(new Stok());
        }
    }
}
