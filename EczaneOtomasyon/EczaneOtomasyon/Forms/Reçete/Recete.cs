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
            TcListele();
        }

        bool TcListele()
        {
            bool oldumu = false;
            OleDbConnection con = new OleDbConnection(baglantı);
            try
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
            catch (Exception)
            {
                MessageBox.Show("HATA OLUŞTU TEKRAR DENEYİN");
            }
            finally
            {
                con.Close();
            }

            return oldumu;
        }
        int olanAdet, toplamUcret, istenenAdet, sayac = 0;

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
                istenenAdet = Convert.ToInt32(txt_adet.Text);
                ReçeteyeEkle();
                toplamUcret += istenenAdet * Convert.ToInt32(İlaçFiyat);
                lbl_toplamFiyat.Text = toplamUcret.ToString();
                adetCikar();
                lbl_ilaçAd.Text = null; lbl_kategori.Text = null; lbl_fiyat.Text = null;
                lbl_adet.Text = null; txt_adet.Text = "1";
                txt_ilaçBarkod.Clear();
                txt_ilaçBarkod.ReadOnly = false;
                ad = null; kategori = null; İlaçFiyat = null; barkod = null; adet = null;

            }
        }
        string ad, kategori, İlaçFiyat, barkod, adet;

        private void btn_hastaOnayla_Click(object sender, EventArgs e)
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
            pnl_hastaBilgisi.Visible = true;
            lbl_hastaAd.Text = null; lbl_soyad.Text = null; lbl_tc.Text = null;
        }

        // reçeteyi veri tabanına ekler ve reçetedeki ilaç label larını temizler, görünürlüklerini kapatır
        private void btn_satıs_Click(object sender, EventArgs e)
        {
            // reçeteye eklenecek ilk ilaç üzerinden reçetenin boş olup olmadığını kontrol eder
            if (lbl_ilaçAdı1.Text == "-" || lbl_ilaçKategori1.Text == "-" || lbl_barkoNo1.Text == "-" ||
            lbl_ilaçAdeti1.Text == "-" || lbl_ilaçFiyat1.Text == "-")
            {
                MessageBox.Show(" REÇETE BOŞ LÜTFEN ÖNCE İLAÇ EKLEYİN");
            }
            else
            {
                VeriEkle();
                Temizle(lbl_ilaçAdı1, lbl_ilaçKategori1, lbl_barkoNo1, lbl_ilaçFiyat1, lbl_ilaçAdeti1);
                Temizle(lbl_ilaçAdı2, lbl_ilaçKategori2, lbl_barkoNo2, lbl_ilaçFiyat2, lbl_ilaçAdeti2);
                Temizle(lbl_ilaçAdı3, lbl_ilaçKategori3, lbl_barkoNo3, lbl_ilaçFiyat3, lbl_ilaçAdeti3);
                Temizle(lbl_ilaçAdı4, lbl_ilaçKategori4, lbl_barkoNo4, lbl_ilaçFiyat4, lbl_ilaçAdeti4);
                Temizle(lbl_ilaçAdı5, lbl_ilaçKategori5, lbl_barkoNo5, lbl_ilaçFiyat5, lbl_ilaçAdeti5);
                lbl_hastaAdı.Text = null; lbl_hastaSoyad.Text = null; lbl_hastaTc.Text = null;
                lbl_hastaAdı.Visible = false; lbl_hastaSoyad.Visible = false; lbl_hastaTc.Visible = false;
                pnl_hasta.Visible = true;
                pnl_hastaBilgisi.Visible = false;
                pnl_ilaçEkle.Visible = false;
                RefMetot(ref toplamUcret);
            }
        }
        private void RefMetot(ref int ucret)
        {
            ucret = 0;
        }
        void Temizle(Label ad, Label kategori, Label barkod, Label fiyat, Label adet)
        {
            ad.Text = null; ad.Visible = false; kategori.Text = null; kategori.Visible = false;
            barkod.Text = null; barkod.Visible = false; fiyat.Text = null; fiyat.Visible = false;
            adet.Text = null; adet.Visible = false;
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

            }
        }
        private void btn_barkodBul_Click(object sender, EventArgs e)
        {
            if (txt_ilaçBarkod.Text == null)
            {
                MessageBox.Show("LİÜTFEN İLAÇ BARKODU GİRİN");
            }
            BarkodListele();
            txt_ilaçBarkod.ReadOnly = true;
        }
        void adetCikar()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(baglantı))
                {
                    string sorgu = "UPDATE İlaçlar SET adet=@adet WHERE barkod=@barkod";
                    using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                    {
                        int sonuc = olanAdet - istenenAdet;
                        cmd.Parameters.AddWithValue("@adet", sonuc.ToString());
                        cmd.Parameters.AddWithValue("@barkod", barkod);
                        con.Open();
                        int sayac = cmd.ExecuteNonQuery();
                        con.Close();
                        if (sayac > 0)
                        {
                            MessageBox.Show("adet düşüldü");
                        }
                        else
                        {
                            MessageBox.Show("olmadı");

                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("HATA OLUŞTU TEKRAR DENEYİN");
            }

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
            using (OleDbConnection con = new OleDbConnection(baglantı))
            {
                string sorgu = "INSERT INTO Reçeteler (tc,ilac1,fiyat1,ilac2,fiyat2,ilac3,fiyat3,ilac4,fiyat4,ilac5,fiyat5,toplamfiyat,durum )" +
                    " VALUES (@tc, @i1, @f1,@i2, @f2,@i3, @f3,@i4, @f4,@i5, @f5,@topfiyat,@durum)";

                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    cmd.Parameters.AddWithValue("@tc", lbl_hastaTc.Text);

                    cmd.Parameters.AddWithValue("@i1", lbl_ilaçAdı1.Text);
                    cmd.Parameters.AddWithValue("@f1", lbl_ilaçFiyat1.Text);
                    ParamtreEkle("@i2", lbl_ilaçAdı2, cmd);
                    ParamtreEkle("@f2", lbl_ilaçFiyat2, cmd);
                    ParamtreEkle("@i3", lbl_ilaçAdı3, cmd);
                    ParamtreEkle("@f3", lbl_ilaçFiyat3, cmd);
                    ParamtreEkle("@i4", lbl_ilaçAdı4, cmd);
                    ParamtreEkle("@f4", lbl_ilaçFiyat4, cmd);
                    ParamtreEkle("@i5", lbl_ilaçAdı5, cmd);
                    ParamtreEkle("@f5", lbl_ilaçFiyat5, cmd);

                    cmd.Parameters.AddWithValue("@topfiyat", lbl_toplamFiyat.Text);
                    cmd.Parameters.AddWithValue("@durum", false);

                    con.Open();
                    int sayac = cmd.ExecuteNonQuery();
                    con.Close();
                    if (sayac > 0)
                    {
                        MessageBox.Show("KAYIT BAŞARILI BİR ŞEKİLDE EKLENDİ", "KAYIT EKLEME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("KAYIT  EKLENEMEDİ", "KAYIT EKLEME HATASI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        void ParamtreEkle(string parametre, Label lbl, OleDbCommand cmd)
        {
            if (lbl.Text != "-")
                cmd.Parameters.AddWithValue(parametre, lbl.Text);
            else
                cmd.Parameters.AddWithValue(parametre, DBNull.Value);
        }
    }
}
