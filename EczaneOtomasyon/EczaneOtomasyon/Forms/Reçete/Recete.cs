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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EczaneOtomasyon.Forms.Reçete
{
    public partial class Recete : Form
    {
        public Recete()
        {
            InitializeComponent();
        }
        string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb";

        string hastaAdı, hastaSoyad, hastaTc;
        bool hastaKayıtlımı = false;
        private void btn_tcBul_Click(object sender, EventArgs e)
        {
            if (TcListele())
            {
                lbl_hastaTc.Text = hastaTc;
                lbl_hastaAdı.Text = hastaAdı;
                lbl_hastaSoyad.Text = hastaSoyad;
                hastaKayıtlımı = true;
                pnl_hasta.Visible = false;
                txt_hastaTc.Clear();
                pnl_ilaçEkle.Visible = true;
                lbl_hastaTc.Visible = true;
                lbl_hastaAdı.Visible = true;
                lbl_hastaSoyad.Visible = true;
            }
            else
            {
                MessageBox.Show("HATA OLUŞTU TEKRAR DENEYİNM");
            }
        }

        bool TcListele()
        {
            bool oldumu;
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

                            lbl_hastaAd.Visible = true;
                            lbl_tc.Visible = true;
                            lbl_soyad.Visible = true;
                            oldumu = true;
                        }
                        else
                        {
                            oldumu = false;
                            MessageBox.Show("KAYIT BULUNAMADI");

                        }
                    }
                }
            }
            return oldumu;
        }
        int olanAdet, istenenAdet, toplamFiyat, sayac = 0;


        private void btn_ilaçEkle_Click(object sender, EventArgs e)
        {
            if (hastaKayıtlımı == false)
            {
                MessageBox.Show("LÜTFEN ÖNCE HASTA EKLEYİN");
            }
            else
            {

                if (sayac > 5)
                {
                    MessageBox.Show(" DAHA FAZLA İLAÇ EKLENEMEZ");
                    return;
                }
              
                ReçeteyeEkle();
                toplamFiyat += olanAdet * Convert.ToInt32(İlaçFiyat);
                lbl_toplamFiyat.Text = toplamFiyat.ToString();

                lbl_ilaçAd.Text = null; lbl_kategori.Text = null; lbl_fiyat.Text = null;
                lbl_adet.Text = null; txt_adet.Text = "1";
                txt_ilaçBarkod.Clear();
                txt_ilaçBarkod.ReadOnly = false;
                ad = null; kategori = null; İlaçFiyat = null; barkod = null; adet = null;

            }
        }
        string ad, kategori, İlaçFiyat, barkod, adet;

        private void btn_satıs_Click(object sender, EventArgs e)
        {
            VeriEkle();
        }
        // reçeteye ekleye basıldığı zaman sıras ile eklenen değerler label larda görünür
        void ReçeteyeEkle()
        {
           

            switch (sayac)
            {
                case 0:
                    if (ad == null || kategori == null || barkod == null || adet == null || İlaçFiyat == null)
                    {
                        MessageBox.Show("BOŞ DEĞER VAR LÜTFEN BÜTÜN DEĞERLERİ DOLDURUN");
                    }
                    else
                    {
                        lbl_ilaçAdı1.Text = ad; lbl_ilaçKategori1.Text = kategori; lbl_barkoNo1.Text = barkod;
                        lbl_ilaçAdeti1.Text = adet; lbl_ilaçFiyat1.Text = İlaçFiyat;
                        lbl_ilaçAdı1.Visible = true; lbl_ilaçKategori1.Visible = true; lbl_barkoNo1.Visible = true;
                        lbl_ilaçAdeti1.Visible = true; lbl_ilaçFiyat1.Visible = true;
                        MessageBox.Show("İLAÇ REÇETEYE EKLENDİ");
                        ++sayac;
                    }

                    break;
                case 1:
                    if (ad == null || kategori == null || barkod == null || adet == null || İlaçFiyat == null)
                    {
                        MessageBox.Show("BOŞ DEĞER VAR LÜTFEN BÜTÜN DEĞERLERİ DOLDURUN");
                    }
                    else
                    {
                        lbl_ilaçAdı2.Text = ad; lbl_ilaçKategori2.Text = kategori; lbl_barkoNo2.Text = barkod;
                        lbl_ilaçAdeti2.Text = adet; lbl_ilaçFiyat2.Text = İlaçFiyat;
                        lbl_ilaçAdı2.Visible = true; lbl_ilaçKategori2.Visible = true; lbl_barkoNo2.Visible = true;
                        lbl_ilaçAdeti2.Visible = true; lbl_ilaçFiyat2.Visible = true;
                        MessageBox.Show("İLAÇ REÇETEYE EKLENDİ");
                        ++sayac;
                    }
                    break;
                case 2:
                    if (ad == null || kategori == null || barkod == null || adet == null || İlaçFiyat == null)
                    {
                        MessageBox.Show("BOŞ DEĞER VAR LÜTFEN BÜTÜN DEĞERLERİ DOLDURUN");
                    }
                    else
                    {
                        lbl_ilaçAdı3.Text = ad; lbl_ilaçKategori3.Text = kategori; lbl_barkoNo3.Text = barkod;
                        lbl_ilaçAdeti3.Text = adet; lbl_ilaçFiyat3.Text = İlaçFiyat;
                        lbl_ilaçAdı3.Visible = true; lbl_ilaçKategori3.Visible = true; lbl_barkoNo3.Visible = true;
                        lbl_ilaçAdeti3.Visible = true; lbl_ilaçFiyat3.Visible = true;
                        MessageBox.Show("İLAÇ REÇETEYE EKLENDİ");
                        ++sayac;
                    }
                    break;
                case 3:
                    if (ad == null || kategori == null || barkod == null || adet == null || İlaçFiyat == null)
                    {
                        MessageBox.Show("BOŞ DEĞER VAR LÜTFEN BÜTÜN DEĞERLERİ DOLDURUN");
                    }
                    else
                    {
                        lbl_ilaçAdı4.Text = ad; lbl_ilaçKategori4.Text = kategori; lbl_barkoNo4.Text = barkod;
                        lbl_ilaçAdeti4.Text = adet; lbl_ilaçFiyat4.Text = İlaçFiyat;
                        lbl_ilaçAdı4.Visible = true; lbl_ilaçKategori4.Visible = true; lbl_barkoNo4.Visible = true;
                        lbl_ilaçAdeti4.Visible = true; lbl_ilaçFiyat4.Visible = true;
                        MessageBox.Show("İLAÇ REÇETEYE EKLENDİ");
                        ++sayac;
                    }
                    break;
                case 4:
                    if (ad == null || kategori == null || barkod == null || adet == null || İlaçFiyat == null)
                    {
                        MessageBox.Show("BOŞ DEĞER VAR LÜTFEN BÜTÜN DEĞERLERİ DOLDURUN");
                    }
                    else
                    {
                        lbl_ilaçAdı5.Text = ad; lbl_ilaçKategori5.Text = kategori; lbl_barkoNo5.Text = barkod;
                        lbl_ilaçAdeti5.Text = adet; lbl_ilaçFiyat5.Text = İlaçFiyat;
                        lbl_ilaçAdı5.Visible = true; lbl_ilaçKategori5.Visible = true; lbl_barkoNo5.Visible = true;
                        lbl_ilaçAdeti5.Visible = true; lbl_ilaçFiyat5.Visible = true;
                        MessageBox.Show("İLAÇ REÇETEYE EKLENDİ");
                        ++sayac;
                    }
                    break;
                    //case 6:
                    //    lbl_ilaçAdı6.Text = ad; lbl_ilaçKategori6.Text = kategori; lbl_barkoNo6.Text = barkod;
                    //    lbl_ilaçAdeti6.Text = adet; lbl_ilaçFiyat6.Text = İlaçFiyat;
                    //    lbl_ilaçAdı6.Visible = true; lbl_ilaçKategori6.Visible = true; lbl_barkoNo6.Visible = true;
                    //    lbl_ilaçAdeti6.Visible = true; lbl_ilaçFiyat6.Visible = true;
                    //    break;
                    //case 7:
                    //    lbl_ilaçAdı7.Text = ad; lbl_ilaçKategori7.Text = kategori; lbl_barkoNo7.Text = barkod;
                    //    lbl_ilaçAdeti7.Text = adet; lbl_ilaçFiyat7.Text = İlaçFiyat;
                    //    lbl_ilaçAdı7.Visible = true; lbl_ilaçKategori7.Visible = true; lbl_barkoNo7.Visible = true;
                    //    lbl_ilaçAdeti7.Visible = true; lbl_ilaçFiyat7.Visible = true;
                    //    break;

            }
        }
        private void btn_barkodBul_Click(object sender, EventArgs e)
        {
            BarkodListele();
            txt_ilaçBarkod.ReadOnly = true;
        }

        void BarkodListele()
        {
            using (OleDbConnection con = new OleDbConnection(baglantı))
            {
                string arananBarkod = txt_ilaçBarkod.Text;
                string sorgu = "SELECT isim, adet, kategori,fiyat,barkod FROM İlaçlar Where barkod = @barkod";
                using (OleDbCommand barkodBul = new OleDbCommand(sorgu, con))
                {
                    barkodBul.Parameters.AddWithValue("@barkod", arananBarkod);
                    con.Open();
                    using (OleDbDataReader barkodOku = barkodBul.ExecuteReader())
                    {
                        if (barkodOku.Read())
                        {
                            barkod = barkodOku["barkod"].ToString();
                            ad = barkodOku["isim"].ToString();
                            kategori = barkodOku["kategori"].ToString();
                            İlaçFiyat = barkodOku["fiyat"].ToString();
                            string deger = barkodOku["adet"].ToString();
                            olanAdet = Convert.ToInt16(deger);
                            adet = txt_adet.Text;

                            lbl_ilaçAd.Text = ad;
                            lbl_kategori.Text = kategori;
                            lbl_fiyat.Text = İlaçFiyat;
                            lbl_adet.Text = adet;


                            lbl_ilaçAd.Visible = true;
                            lbl_kategori.Visible = true;
                            lbl_fiyat.Visible = true;
                            lbl_adet.Visible = true;

                        }
                        else
                        {
                            MessageBox.Show("KAYIT EKLEMEDİ");
                        }

                    }
                }
            }

        }
        // giirlen değerleri veri tabanına ekler r
        void VeriEkle()
        {
            string tc, ilac1, fiyat1, ilac2, fiyat2, ilac3, fiyat3, ilac4, fiyat4, ila5, fiyat5;

            using (OleDbConnection con = new OleDbConnection(baglantı))
            {
                string sorgu = $"INSERT INTO Reçeteler (tc,ilac1,fiyat1,ilac2,fiyat2,ilac3,fiyat3,ilac4,fiyat4,ilac5,fiyat5,toplamfiyat )" +
                    $" VALUES (@tc, @i1, @f1,@i2, @f2,@i3, @f3,@i4, @f4,@i5, @f5,@topfiyat)";

                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    cmd.Parameters.AddWithValue("@tc", lbl_hastaTc.Text);
                    cmd.Parameters.AddWithValue("@i1", lbl_ilaçAdı1.Text);
                    cmd.Parameters.AddWithValue("@f1", lbl_ilaçFiyat1.Text);
                    cmd.Parameters.AddWithValue("@i2", lbl_ilaçAdı2.Text);
                    cmd.Parameters.AddWithValue("@f2", lbl_ilaçFiyat2.Text);
                    cmd.Parameters.AddWithValue("@i3", lbl_ilaçAdı3.Text);
                    cmd.Parameters.AddWithValue("@f3", lbl_ilaçFiyat3.Text);
                    cmd.Parameters.AddWithValue("@i4", lbl_ilaçAdı4.Text);
                    cmd.Parameters.AddWithValue("@f4", lbl_ilaçFiyat4.Text);
                    cmd.Parameters.AddWithValue("@i5", lbl_ilaçAdı5.Text);
                    cmd.Parameters.AddWithValue("@f5", lbl_ilaçFiyat5.Text);
                    cmd.Parameters.AddWithValue("@topfiyat", lbl_toplamFiyat.Text);

                    con.Open();
                    int sayac = cmd.ExecuteNonQuery();
                    con.Close();
                    if (sayac > 0)
                    {
                        MessageBox.Show("KAYIT BAŞARILI BİR ŞEKİLDE EKLENDİ", "KAYIT EKLEME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("KAYIT  EKLENemedi", "KAYIT EKLEME HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }

        }

    }
}
