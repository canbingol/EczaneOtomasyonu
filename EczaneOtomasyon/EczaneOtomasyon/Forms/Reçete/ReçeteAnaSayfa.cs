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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EczaneOtomasyon.Forms.Reçete
{
    public partial class ReçeteAnaSayfa : Form
    {
        string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb";

        string hastaAdı, hastaSoyad, hastaTc;

        void TcListele()
        {
            using (OleDbConnection con = new OleDbConnection(baglantı))
            {
                string Tc = txt_hastaTc.Text;
                string sorgu = "SELECT Adı, Soyadı, Tc FROM Hastalar Where Tc = @tc";
                using (OleDbCommand tcBul = new OleDbCommand(sorgu, con))
                {
                    tcBul.Parameters.AddWithValue("@tc", Tc);
                    con.Open();
                    using (OleDbDataReader tcOku = tcBul.ExecuteReader())
                    {
                        if (tcOku.Read())
                        {
                            hastaAdı = tcOku["Adı"].ToString();
                            hastaSoyad = tcOku["Soyadı"].ToString();
                            hastaTc = tcOku["Tc"].ToString();
                            lbl_tc.Text = hastaTc.ToUpper();
                            lbl_hastaAd.Text = hastaAdı.ToUpper();
                            lbl_soyad.Text = hastaSoyad.ToUpper();
                        }
                        else
                        {
                            MessageBox.Show("KAYIT OKUNAMADI");
                        }
                    }
                }
            }

        }

        int olanAdet, istenenAdet, sayac = 0;
        string ad, kategori, İlaçFiyat, barkod;

        void BArkodListele()
        {
            using (OleDbConnection con = new OleDbConnection(baglantı))
            {

                string aranaBarkod = txt_ilaçBarkod.Text;
                string sorgu = "SELECT isim, adet, kategori,fiyat,barkod FROM İlaçlar Where barkod = @barkod";
                using (OleDbCommand barkodBul = new OleDbCommand(sorgu, con))
                {
                    barkodBul.Parameters.AddWithValue("@barkod", aranaBarkod);
                    con.Open();
                    using (OleDbDataReader barkodOku = barkodBul.ExecuteReader())
                    {
                        if (barkodOku.Read())
                        {
                            ad = barkodOku["isim"].ToString();
                            kategori = barkodOku["kategori"].ToString();
                            İlaçFiyat = barkodOku["fiyat"].ToString();
                            string deger = barkodOku["adet"].ToString();
                            olanAdet = Convert.ToInt16(deger);

                            lbl_ilaçAd.Text = ad;
                            lbl_kategori.Text = kategori;
                            lbl_fiyat.Text = İlaçFiyat;

                            lbl_ilaçAd.Visible = true;
                            lbl_kategori.Visible = true;
                            lbl_fiyat.Visible = true;

                            MessageBox.Show(" LÜTFEN İLAÇ ADEDİ GİRİN");
                            btn_adetEkle.Visible = true;
                            label.Visible = true;
                            txt_adet.Visible = true;
                            lbl_adet.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("KAYIT OKUNAMADI");
                        }

                    }
                }
            }

        }
        int toplamFiyat;
        private void btn_ilaçEkle_Click(object sender, EventArgs e)
        {
            if (hastaKayıtlımı == false)
            {
                MessageBox.Show("LÜTFEN ÖNCE HASTA EKLEYİN");
            }
            else
            {
                ++sayac;
                if (sayac == 9)
                {
                    MessageBox.Show(" DAHA FAZLA İLAÇ EKLENEMEZ");
                    return;
                }
                Label ad = Controls["lbl_ilaçAdı" + sayac] as Label;
                Label kategori = Controls["lbl_ilaçKategori" + sayac] as Label;
                Label fiyat = Controls["lbl_ilaçFiyat" + sayac] as Label;
                Label barkod = Controls["lbl_barkoNo" + sayac] as Label;
                Label adet = Controls["lbl_ilaçAdeti" + sayac] as Label;

                ReçeteyeEkle();
                toplamFiyat += olanAdet * Convert.ToInt32(İlaçFiyat);
                lbl_toplamFiyat.Text = toplamFiyat.ToString();

                MessageBox.Show(" İLAÇ REÇETEYE EKLENDİ");
            }

        }
        void ReçeteyeEkle()
        {
            switch (sayac)
            {
                case 1:
                    lbl_ilaçAdı1.Text = ad; lbl_ilaçKategori1.Text = kategori; lbl_barkoNo1.Text = barkod;
                    lbl_ilaçAdeti1.Text = istenenAdet.ToString(); lbl_ilaçFiyat1.Text = İlaçFiyat;
                    lbl_ilaçAdı1.Visible = true; lbl_ilaçKategori1.Visible = true; lbl_barkoNo1.Visible = true;
                    lbl_ilaçAdeti1.Visible = true; lbl_ilaçFiyat1.Visible = true;
                    break;
                case 2:
                    lbl_ilaçAdı2.Text = ad; lbl_ilaçKategori2.Text = kategori; lbl_barkoNo2.Text = barkod;
                    lbl_ilaçAdeti2.Text = istenenAdet.ToString(); lbl_ilaçFiyat2.Text = İlaçFiyat;
                    lbl_ilaçAdı2.Visible = true; lbl_ilaçKategori2.Visible = true; lbl_barkoNo2.Visible = true;
                    lbl_ilaçAdeti2.Visible = true; lbl_ilaçFiyat2.Visible = true;
                    break;
                case 3:
                    lbl_ilaçAdı3.Text = ad; lbl_ilaçKategori3.Text = kategori; lbl_barkoNo3.Text = barkod;
                    lbl_ilaçAdeti3.Text = istenenAdet.ToString(); lbl_ilaçFiyat3.Text = İlaçFiyat;
                    lbl_ilaçAdı3.Visible = true; lbl_ilaçKategori3.Visible = true; lbl_barkoNo3.Visible = true;
                    lbl_ilaçAdeti3.Visible = true; lbl_ilaçFiyat3.Visible = true;
                    break;
                case 4:
                    lbl_ilaçAdı4.Text = ad; lbl_ilaçKategori4.Text = kategori; lbl_barkoNo4.Text = barkod;
                    lbl_ilaçAdeti4.Text = istenenAdet.ToString(); lbl_ilaçFiyat4.Text = İlaçFiyat;
                    lbl_ilaçAdı4.Visible = true; lbl_ilaçKategori4.Visible = true; lbl_barkoNo4.Visible = true;
                    lbl_ilaçAdeti4.Visible = true; lbl_ilaçFiyat4.Visible = true;
                    break;
                case 5:
                    lbl_ilaçAdı5.Text = ad; lbl_ilaçKategori5.Text = kategori; lbl_barkoNo5.Text = barkod;
                    lbl_ilaçAdeti5.Text = istenenAdet.ToString(); lbl_ilaçFiyat5.Text = İlaçFiyat;
                    lbl_ilaçAdı5.Visible = true; lbl_ilaçKategori5.Visible = true; lbl_barkoNo5.Visible = true;
                    lbl_ilaçAdeti5.Visible = true; lbl_ilaçFiyat5.Visible = true;
                    break;
                case 6:
                    lbl_ilaçAdı6.Text = ad; lbl_ilaçKategori6.Text = kategori; lbl_barkoNo6.Text = barkod;
                    lbl_ilaçAdeti6.Text = istenenAdet.ToString(); lbl_ilaçFiyat6.Text = İlaçFiyat;
                    lbl_ilaçAdı6.Visible = true; lbl_ilaçKategori6.Visible = true; lbl_barkoNo6.Visible = true;
                    lbl_ilaçAdeti6.Visible = true; lbl_ilaçFiyat6.Visible = true;
                    break;
                case 7:
                    lbl_ilaçAdı7.Text = ad; lbl_ilaçKategori7.Text = kategori; lbl_barkoNo7.Text = barkod;
                    lbl_ilaçAdeti7.Text = istenenAdet.ToString(); lbl_ilaçFiyat7.Text = İlaçFiyat;
                    lbl_ilaçAdı7.Visible = true; lbl_ilaçKategori7.Visible = true; lbl_barkoNo7.Visible = true;
                    lbl_ilaçAdeti7.Visible = true; lbl_ilaçFiyat7.Visible = true;
                    break;
                case 8:
                    lbl_ilaçAdı8.Text = ad; lbl_ilaçKategori8.Text = kategori; lbl_barkoNo8.Text = barkod;
                    lbl_ilaçAdeti8.Text = istenenAdet.ToString(); lbl_ilaçFiyat8.Text = İlaçFiyat;
                    lbl_ilaçAdı7.Visible = true; lbl_ilaçKategori7.Visible = true; lbl_barkoNo7.Visible = true;
                    lbl_ilaçAdeti7.Visible = true; lbl_ilaçFiyat7.Visible = true;
                    break;
            }
        }

        public ReçeteAnaSayfa()
        {
            InitializeComponent();
        }

        private void btn_barkodBul_Click_1(object sender, EventArgs e)
        {
            BArkodListele();
        }

        private void btn_adetEkle_Click_1(object sender, EventArgs e)
        {
            istenenAdet = Convert.ToInt16(txt_adet.Text);

            if (olanAdet >= istenenAdet && istenenAdet != 0)
            {
                lbl_adet.Text = istenenAdet.ToString();
                MessageBox.Show("adet eklendi");
            }
            else
            {
                MessageBox.Show(" İLAÇ ADETİ YETERSİZ");
            }
        }
        bool hastaKayıtlımı = false;
        private void btn_hastaOnayla_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(hastaTc) || !string.IsNullOrEmpty(hastaAdı) || !string.IsNullOrEmpty(hastaSoyad))
            {
                lbl_hastaTc.Text = hastaTc;
                lbl_hastaAdı.Text = hastaAdı;
                lbl_hastaSoyad.Text = hastaSoyad;
                hastaKayıtlımı = true;
                pnl_hasta.Visible = false;
                txt_hastaTc.Clear();
            }
            else
                MessageBox.Show("HASTA GİRİŞİ YAPINIZ");

        }

        private void btn_tcBul_Click(object sender, EventArgs e)
        {

            TcListele();
        }

        private void btn_reçeteOnayla_Click(object sender, EventArgs e)
        {
            hastaKayıtlımı = false;
            pnl_hasta.Visible = true;
        }
    }
}
