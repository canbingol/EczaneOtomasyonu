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
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EczaneOtomasyon.Forms.Reçete
{

    public partial class Recete : Form
    {
        FilterInfoCollection fico;
        VideoCaptureDevice vcd;
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
       
        bool TcListele() // girilen tc noya göre veri çeker ve verileri label lara atar
        {
            bool oldumu = false;
            OleDbConnection con = new OleDbConnection(baglantı);
            string Tc = txt_hastaTc.Text;
            string sorgu = "SELECT adi, soyadi, tc FROM Hastalar Where tc = @tc";
            try
            {
                using (OleDbCommand tcBul = new OleDbCommand(sorgu, con))
                {
                    tcBul.Parameters.AddWithValue("@tc", Tc);
                    con.Open();
                    using (OleDbDataReader tcOku = tcBul.ExecuteReader())
                    {
                        if (tcOku.Read())// girilen tc ile veri tabanından değer okunuyorsa çalışır
                        {
                            hastaAdı = tcOku["adi"].ToString();
                            hastaSoyad = tcOku["soyadi"].ToString();
                            hastaTc = tcOku["tc"].ToString();
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
                            txt_hastaTc.Clear();
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
        
        private void btn_ilaçEkle_Click(object sender, EventArgs e)// label lara girilen ilacın bilgilerini atar
        {
            if (hastaKayıtlımı == false)
            {
                MessageBox.Show("LÜTFEN ÖNCE HASTA EKLEYİN");
            }
            else
            {
                if (sayac > 4)
                {
                    MessageBox.Show(" DAHA FAZLA İLAÇ EKLENEMEZ");
                    return;
                }
                istenenAdet = Convert.ToInt32(txt_adet.Text);
                ReçeteyeEkle(); // barkodu girilen ilacın bilgileri label lara atanır
                toplamUcret += istenenAdet * Convert.ToInt32(İlaçFiyat);
                lbl_toplamFiyat.Text = toplamUcret.ToString();
                adetCikar(); // ilacların adeti düşülür
                lbl_ilacAd.Text = null; lbl_kategori.Text = null; lbl_fiyat.Text = null;
                lbl_adet.Text = null; txt_adet.Text = "1";
                txt_ilacBarkod.Clear();
                txt_ilacBarkod.ReadOnly = false;
                ad = null; kategori = null; İlaçFiyat = null; barkod = null; adet = null;

            }
        }
        string ad, kategori, İlaçFiyat, barkod, adet;

        private void btn_hastaOnayla_Click(object sender, EventArgs e)
        {
            if (TcListele()) // girilen tc var ise ilgli label lara tc si girilen hastanın biligileri atanır
            {
                lbl_hastaTc.Text = hastaTc;
                lbl_hastaAdi.Text = hastaAdı;
                lbl_hastaSoyad.Text = hastaSoyad;
                hastaKayıtlımı = true;
                pnl_hasta.Visible = false;
                txt_hastaTc.Clear();
                pnl_ilacEkle.Visible = true;
                lbl_hastaTc.Visible = true;
                lbl_hastaAdi.Visible = true;
                lbl_hastaSoyad.Visible = true;
            }
            else
            {
                MessageBox.Show("HATA OLUŞTU TEKRAR DENEYİNM");
            }
            pnl_hastaBilgisi.Visible = true;
            lbl_hastaAd.Text = null; lbl_soyad.Text = null; lbl_tc.Text = null;
        }
        #region barkod okuma işlemleri
        System.Windows.Forms.ComboBox kamera = new System.Windows.Forms.ComboBox();
        private void Recete_Load(object sender, EventArgs e)
        {
            fico = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo item in fico)
            {
                kamera.Items.Add(item.Name);
            }
        }

        private void btn_barkodOku_Click(object sender, EventArgs e)
        {
            pnl_kamera.Visible = true;
            vcd = new VideoCaptureDevice(fico[1].MonikerString);
            vcd.NewFrame += Vcd_NewFrame1;
            vcd.Start();
            timer_zaman.Start();
        }

        private void Vcd_NewFrame1(object sender, NewFrameEventArgs eventArgs)
        {
            picture_kamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer_zaman_Tick(object sender, EventArgs e)
        {
            if (picture_kamera.Image != null)
            {
                BarcodeReader br = new BarcodeReader();
                Result sonuc = br.Decode((Bitmap)picture_kamera.Image);
                if (sonuc != null)
                {
                    txt_ilacBarkod.Text = sonuc.ToString();
                    timer_zaman.Stop();
                    pnl_kamera.Visible = false;
                }
            }
        }

        private void btn_kameraKapa_Click(object sender, EventArgs e)
        {
            pnl_kamera.Visible=false;
            vcd.Stop();

        }
        #endregion

        // reçeteyi veri tabanına ekler ve reçetedeki ilaç label larını temizler, görünürlüklerini kapatır
        private void btn_satıs_Click(object sender, EventArgs e)
        {
            // reçeteye eklenecek ilk ilaç üzerinden reçetenin boş olup olmadığını kontrol eder
            if (lbl_ilacAdi1.Text == "-" || lbl_ilacKategori1.Text == "-" || lbl_barkoNo1.Text == "-" ||
            lbl_ilacAdeti1.Text == "-" || lbl_ilacFiyat1.Text == "-")
            {
                MessageBox.Show(" REÇETE BOŞ LÜTFEN ÖNCE İLAÇ EKLEYİN");
            }
            else
            {
                VeriEkle(); // reçeteey eklene verileri satıslar tablosuna ekler
                Temizle(lbl_ilacAdi1, lbl_ilacKategori1, lbl_barkoNo1, lbl_ilacFiyat1, lbl_ilacAdeti1);
                Temizle(lbl_ilacAdi2, lbl_ilacKategori2, lbl_barkoNo2, lbl_ilacFiyat2, lbl_ilacAdeti2);
                Temizle(lbl_ilacAdi3, lbl_ilacKategori3, lbl_barkoNo3, lbl_ilacFiyat3, lbl_ilacAdeti3);
                Temizle(lbl_ilacAdi4, lbl_ilacKategori4, lbl_barkoNo4, lbl_ilacFiyat4, lbl_ilacAdeti4);
                Temizle(lbl_ilacAdi5, lbl_ilacKategori5, lbl_barkoNo5, lbl_ilacFiyat5, lbl_ilacAdeti5);
                lbl_hastaAdi.Text = null; lbl_hastaSoyad.Text = null; lbl_hastaTc.Text = null;
                lbl_hastaAdi.Visible = false; lbl_hastaSoyad.Visible = false; lbl_hastaTc.Visible = false;
                pnl_hasta.Visible = true;
                pnl_hastaBilgisi.Visible = false;
                pnl_ilacEkle.Visible = false;
                lbl_toplamFiyat.Text = "0";
                RefMetot(ref toplamUcret); // toplam ücret değişkenin değerini sıfırlar
            }
        }
        private void RefMetot(ref int ucret)
        {
            ucret = 0;
        }
        // girilen labelların textlarini sıfırlar ve görünürlükleri kapatılır
        void Temizle(Label ad, Label kategori, Label barkod, Label fiyat, Label adet)
        {
            ad.Text = "-"; ad.Visible = false; kategori.Text = "-"; kategori.Visible = false;
            barkod.Text = "-"; barkod.Visible = false; fiyat.Text = "-"; fiyat.Visible = false;
            adet.Text = "-"; adet.Visible = false;
        }

        // reçeteye ekleye basıldığı zaman sıras ile eklenen değerler label larda görünür
        void ReçeteyeEkle()
        { // her ilaç eklendiğinde sayac 1 artar ve artan değere göre diğer label lara ilaç bilgileri atanır
            switch (sayac)
            {
                case 0:
                    if (ad == null || kategori == null || barkod == null || adet == null || İlaçFiyat == null)
                        MessageBox.Show("BOŞ DEĞER VAR LÜTFEN BÜTÜN DEĞERLERİ DOLDURUN");
                    else
                    {
                        lbl_ilacAdi1.Text = ad; lbl_ilacKategori1.Text = kategori; lbl_barkoNo1.Text = barkod;
                        lbl_ilacAdeti1.Text = adet; lbl_ilacFiyat1.Text = İlaçFiyat;
                        lbl_ilacAdi1.Visible = true; lbl_ilacKategori1.Visible = true; lbl_barkoNo1.Visible = true;
                        lbl_ilacAdeti1.Visible = true; lbl_ilacFiyat1.Visible = true;
                        MessageBox.Show("İLAÇ REÇETEYE EKLENDİ");
                        ++sayac;
                    }
                    break;
                case 1:
                    if (ad == null || kategori == null || barkod == null || adet == null || İlaçFiyat == null)
                        MessageBox.Show("BOŞ DEĞER VAR LÜTFEN BÜTÜN DEĞERLERİ DOLDURUN");
                    else
                    {
                        lbl_ilacAdi2.Text = ad; lbl_ilacKategori2.Text = kategori; lbl_barkoNo2.Text = barkod;
                        lbl_ilacAdeti2.Text = adet; lbl_ilacFiyat2.Text = İlaçFiyat;
                        lbl_ilacAdi2.Visible = true; lbl_ilacKategori2.Visible = true; lbl_barkoNo2.Visible = true;
                        lbl_ilacAdeti2.Visible = true; lbl_ilacFiyat2.Visible = true;
                        MessageBox.Show("İLAÇ REÇETEYE EKLENDİ");
                        ++sayac;
                    }
                    break;
                case 2:
                    if (ad == null || kategori == null || barkod == null || adet == null || İlaçFiyat == null)
                        MessageBox.Show("BOŞ DEĞER VAR LÜTFEN BÜTÜN DEĞERLERİ DOLDURUN");
                    else
                    {
                        lbl_ilacAdi3.Text = ad; lbl_ilacKategori3.Text = kategori; lbl_barkoNo3.Text = barkod;
                        lbl_ilacAdeti3.Text = adet; lbl_ilacFiyat3.Text = İlaçFiyat;
                        lbl_ilacAdi3.Visible = true; lbl_ilacKategori3.Visible = true; lbl_barkoNo3.Visible = true;
                        lbl_ilacAdeti3.Visible = true; lbl_ilacFiyat3.Visible = true;
                        MessageBox.Show("İLAÇ REÇETEYE EKLENDİ");
                        ++sayac;
                    }
                    break;
                case 3:
                    if (ad == null || kategori == null || barkod == null || adet == null || İlaçFiyat == null)
                        MessageBox.Show("BOŞ DEĞER VAR LÜTFEN BÜTÜN DEĞERLERİ DOLDURUN");
                    else
                    {
                        lbl_ilacAdi4.Text = ad; lbl_ilacKategori4.Text = kategori; lbl_barkoNo4.Text = barkod;
                        lbl_ilacAdeti4.Text = adet; lbl_ilacFiyat4.Text = İlaçFiyat;
                        lbl_ilacAdi4.Visible = true; lbl_ilacKategori4.Visible = true; lbl_barkoNo4.Visible = true;
                        lbl_ilacAdeti4.Visible = true; lbl_ilacFiyat4.Visible = true;
                        MessageBox.Show("İLAÇ REÇETEYE EKLENDİ");
                        ++sayac;
                    }
                    break;
                case 4:
                    if (ad == null || kategori == null || barkod == null || adet == null || İlaçFiyat == null)
                        MessageBox.Show("BOŞ DEĞER VAR LÜTFEN BÜTÜN DEĞERLERİ DOLDURUN");
                    else
                    {
                        lbl_ilacAdi5.Text = ad; lbl_ilacKategori5.Text = kategori; lbl_barkoNo5.Text = barkod;
                        lbl_ilacAdeti5.Text = adet; lbl_ilacFiyat5.Text = İlaçFiyat;
                        lbl_ilacAdi5.Visible = true; lbl_ilacKategori5.Visible = true; lbl_barkoNo5.Visible = true;
                        lbl_ilacAdeti5.Visible = true; lbl_ilacFiyat5.Visible = true;
                        MessageBox.Show("İLAÇ REÇETEYE EKLENDİ");
                        ++sayac;
                    }
                    break;
            }
        }
        // 
        private void btn_barkodBul_Click(object sender, EventArgs e)
        {
            txt_ilacBarkod.ReadOnly = true;
            if (txt_ilacBarkod.Text == null)
            {
                MessageBox.Show("LİÜTFEN İLAÇ BARKODU GİRİN");
                txt_ilacBarkod.ReadOnly = false;
            }
            BarkodListele();
            txt_ilacBarkod.Clear();
            btn_barkodOku.Enabled = false;
        }
        // reçeteye eklenen ilaçların adeti azaltılır
        void adetCikar()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(baglantı))
                {
                    string sorgu = "UPDATE Ilaclar SET adet=@adet WHERE barkod=@barkod";
                    using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                    {
                        int sonuc = olanAdet - istenenAdet;
                        cmd.Parameters.AddWithValue("@adet", sonuc.ToString());
                        cmd.Parameters.AddWithValue("@barkod", barkod);
                        con.Open();
                        int sayac = cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("HATA OLUŞTU TEKRAR DENEYİN");
            }
        }
        // girilen ilaç barkoduna göre ilaç aranır bulunursa bilgileri label lara atanır bulunamaz ise hata verir
        void BarkodListele()
        {
            using (OleDbConnection con = new OleDbConnection(baglantı))
            {
                string arananBarkod = txt_ilacBarkod.Text;
                string sorgu = "SELECT isim, adet, kategori,fiyat,barkod FROM Ilaclar Where barkod = @barkod";
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
                            lbl_ilacAd.Text = ad;
                            lbl_kategori.Text = kategori;
                            lbl_fiyat.Text = İlaçFiyat;
                            lbl_adet.Text = adet;

                            lbl_ilacAd.Visible = true;
                            lbl_kategori.Visible = true;
                            lbl_fiyat.Visible = true;
                            lbl_adet.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("İLAÇ BULUNAMADI");
                            txt_ilacBarkod.ReadOnly = false;
                        }
                    }
                }
            }
        }
        // reçeteye eklen verileri alr ve satıslar tablosuna ekler
        void VeriEkle()
        {
            using (OleDbConnection con = new OleDbConnection(baglantı))
            {
                string sorgu = "INSERT INTO Receteler (tc,ilac1,fiyat1,ilac2,fiyat2,ilac3,fiyat3,ilac4,fiyat4,ilac5,fiyat5,toplamfiyat,durum )" +
                    " VALUES (@tc, @i1, @f1,@i2, @f2,@i3, @f3,@i4, @f4,@i5, @f5,@topfiyat,@durum)";

                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    cmd.Parameters.AddWithValue("@tc", lbl_hastaTc.Text);

                    cmd.Parameters.AddWithValue("@i1", lbl_ilacAdi1.Text);
                    cmd.Parameters.AddWithValue("@f1", lbl_ilacFiyat1.Text);
                    ParamtreEkle("@i2", lbl_ilacAdi2, cmd);
                    ParamtreEkle("@f2", lbl_ilacFiyat2, cmd);
                    ParamtreEkle("@i3", lbl_ilacAdi3, cmd);
                    ParamtreEkle("@f3", lbl_ilacFiyat3, cmd);
                    ParamtreEkle("@i4", lbl_ilacAdi4, cmd);
                    ParamtreEkle("@f4", lbl_ilacFiyat4, cmd);
                    ParamtreEkle("@i5", lbl_ilacAdi5, cmd);
                    ParamtreEkle("@f5", lbl_ilacFiyat5, cmd);

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
        // command nesnesi için yazılan parametreli atar
        void ParamtreEkle(string parametre, Label lbl, OleDbCommand cmd)
        {
            if (lbl.Text != "-")
                cmd.Parameters.AddWithValue(parametre, lbl.Text);
            else
                cmd.Parameters.AddWithValue(parametre, DBNull.Value);
        }
    }
}
