using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyon.Forms.Satış
{
    public partial class Satis : Form
    {
        string baglanti = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb";
        static public string toplamCiro;
        public Satis()
        {
            InitializeComponent();
        }
      // satılmayan reçetesi olan hastaları listbox a ekler
        void HastaListele()
        {
            using (OleDbConnection con = new OleDbConnection(baglanti))
            {
                string sorgu = $"SELECT DISTINCT tc  FROM Receteler WHERE durum=@durum";// reçete durumu false(satılmayan) 
                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))                 //hastları(her hasta 1 defa) okur
                {
                    cmd.Parameters.AddWithValue("@durum", false);
                    con.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            checklist_hastalar.Items.Add(reader["tc"].ToString());
                        }
                        if (checklist_hastalar.Items.Count == 0)
                        {
                            MessageBox.Show(" KAYITLI HASTALARA AİT ÖDENMEMİŞ REÇETE BULUNMUYOR");
                            lbl_hata.Visible = true;
                        }
                    }
                }
            }
        }
        string tc, toplamfiyat, sira, sigortaFiyat = "0";
        //hastalar listboxından seçilen hastanın reçeleri ilaç listboxına eklenır
        void ReceteListele()

        {
            using (OleDbConnection con = new OleDbConnection(baglanti))
            {
                string sorgu = "SELECT  sira,ilac1, ilac2, ilac3, ilac4, ilac5,toplamfiyaT FROM Receteler WHERE  tc=@tc AND durum=@durum  ";
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    cmd.Parameters.AddWithValue("@durum", false);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // okunan değerler birleştirilir
                            string ilaclar = "";
                            string sira = reader["sira"].ToString();
                            if (!(reader["ilac1"] is DBNull) && reader["ilac1"].ToString() != "-")
                            {
                                ilaclar += reader["ilac1"].ToString();
                            }
                            if (!(reader["ilac2"] is DBNull) && reader["ilac2"].ToString() != "-")
                            {
                                ilaclar += " - " + reader["ilac2"].ToString();
                            }
                            if (!(reader["ilac3"] is DBNull) && reader["ilac3"].ToString() != "-")
                            {
                                ilaclar += " - " + reader["ilac3"].ToString();
                            }
                            if (!(reader["ilac4"] is DBNull) && reader["ilac4"].ToString() != "-")
                            {
                                ilaclar += " - " + reader["ilac4"].ToString();
                            }
                            if (!(reader["ilac5"] is DBNull) && reader["ilac5"].ToString() != "-")
                            {
                                ilaclar += " - " + reader["ilac5"].ToString();
                            }
                            // birleştirilen değerler listox a eklenir
                            toplamfiyat = reader["toplamfiyat"].ToString();
                            ilaclar += " - " + toplamfiyat + "₺";
                            listBox_receteList.Items.Add(sira + "-" + ilaclar);
                        }
                    }
                }
            }
        }
        private void btn_hastaSec_Click(object sender, EventArgs e)
        {
            tc = checklist_hastalar.CheckedItems[0].ToString();
            ReceteListele(); //hastalar listboxından seçilen hastanın reçeleri ilaç listboxına eklenır
            if (listBox_receteList.Items.Count != 0)
                checklist_hastalar.Enabled = false;
            else
                MessageBox.Show("BU HASTAYA AİT ÖDENMEMİŞ REÇETE BULUNMUYORil");
        }

        private void Satış_Load(object sender, EventArgs e)
        {
            HastaListele();
        }
        // hastalar listboxıından seçim yapılınca
        private void checklist_hastalar_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < checklist_hastalar.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    checklist_hastalar.SetItemChecked(i, false);
                }
            }
        }

        string ad, soyad, fiyat, ilac1, ilac2, ilac3, ilac4, ilac5;
        DateTime tarih;

        // şeçilen reçetenin verilerini satışlar tablosuna eklemek için değişkenlere atanıyor
        private void btn_receteSec_Click(object sender, EventArgs e)
        {
            string ilaclar = listBox_receteList.CheckedItems[0].ToString();
            string[] ilaclarDizi = ilaclar.Trim().Split('-');
            int sayac = ilaclarDizi.Length;
            fiyat = ilaclarDizi[sayac - 1];
            lbl_toplamFiyat.Text = fiyat;
            sira = ilaclarDizi[0];
            ilac1 = ilaclarDizi[1]; lbl_ilac1.Text = ilac1; lbl_ilac1.Visible = true; lbl_ilacadi1.Visible = true;
            if (ilaclarDizi.Length > 3)
            {
                ilac2 = ilaclarDizi[2]; lbl_ilac2.Text = ilac2; lbl_ilac2.Visible = true; lbl_ilacadi2.Visible = true;
            }
            if (ilaclarDizi.Length > 4)
            {
                ilac3 = ilaclarDizi[3]; lbl_ilac3.Text = ilac3; lbl_ilac3.Visible = true; lbl_ilacadi3.Visible = true;
            }
            if (ilaclarDizi.Length > 5)
            {
                ilac4 = ilaclarDizi[4]; lbl_ilac4.Text = ilac4; lbl_ilac4.Visible = true; lbl_ilacadi4.Visible = true;
            }
            if (ilaclarDizi.Length > 6)
            {
                ilac5 = ilaclarDizi[5]; lbl_ilac5.Text = ilac5; lbl_ilac5.Visible = true; lbl_ilacadi5.Visible = true;
            }
            Hastabul();
            lbl_tc.Text = tc;
            lbl_ad.Text = ad;
            lbl_soyad.Text = soyad;
            listBox_receteList.Enabled = false;
            pnl_bilgi.Visible = true;
            pnl_ilacBilgi.Visible = true;
        }
        // satış işlemleri yapılır
        private void btn_satis_Click(object sender, EventArgs e)
        {
            bool sigortaDurumu = false;
            using (OleDbConnection con = new OleDbConnection(baglanti))
            {
                con.Open();
                string sorgu = "INSERT INTO Satislar (tc,ad,soyad,ilac1,ilac2,ilac3,ilac4,ilac5,satisTarihi,toplamFiyat) VALUES " +
                    "(@tc,@ad,@soyad,@ilac1,@ilac2,@ilac3,@ilac4,@ilac5,@tarih,@fiyat)";
                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@soyad", soyad);
                    cmd.Parameters.AddWithValue("@ilac1", ilac1);
                    //  daha önce atanmış olan ialc değerleri null ise hata vermemesi için atama yapılır
                    if (ilac2 != null)
                        cmd.Parameters.AddWithValue("@ilac2", ilac2);
                    else
                        cmd.Parameters.AddWithValue("@ilac2", DBNull.Value);
                    if (ilac3 != null)
                        cmd.Parameters.AddWithValue("@ilac3", ilac3);
                    else
                        cmd.Parameters.AddWithValue("@ilac3", DBNull.Value);
                    if (ilac4 != null)
                        cmd.Parameters.AddWithValue("@ilac4", ilac4);
                    else
                        cmd.Parameters.AddWithValue("@ilac4", DBNull.Value);
                    if (ilac5 != null)
                        cmd.Parameters.AddWithValue("@ilac5", ilac5);
                    else
                        cmd.Parameters.AddWithValue("@ilac5", DBNull.Value);

                    TarihAl(); //hastanın en son aldığı reçetenin tarihini alır

                    DateTime bugun = DateTime.Today;
                    string tarihParams = bugun.Day.ToString() + "." + bugun.Month.ToString() + "." + bugun.Year.ToString();
                    cmd.Parameters.AddWithValue("@tarih", tarihParams);

                    if (SigortaBak()) // girilen hastanın sigortasını kontrol eder
                    {
                        if (DateTime.Today.Subtract(tarih).TotalDays > 90)// 3 ay içinde ilaç alınmamış ise reçete ücreti alınmaz
                        {
                            cmd.Parameters.AddWithValue("@fiyat", sigortaFiyat);
                            sigortaDurumu = true;
                        }
                        else
                            cmd.Parameters.AddWithValue("@fiyat", toplamfiyat);
                    }
                    else
                        cmd.Parameters.AddWithValue("@fiyat", toplamfiyat);

                    int sayac = cmd.ExecuteNonQuery();
                    if (sayac > 0)
                    {
                        if (sigortaDurumu)
                            MessageBox.Show(" HASTA REÇETE BEDELİ SİGORTA TARAFINDAN KARŞILANDI");
                        else
                            MessageBox.Show("SATIŞ YAPILDI ");
                        RecetDurumuAyarla(); // satılan reçetenin durumunu true atar
                    }
                    else
                        MessageBox.Show("SATIŞ YAPILAMADI ");
                }
            }
            checklist_hastalar.Enabled = false;
            listBox_receteList.Enabled = false;
            pnl_bilgi.Visible = false; pnl_ilacBilgi.Visible = false;
            checklist_hastalar.Items.Clear();
           listBox_receteList.Items.Clear();
            HastaListele();
        }

        // satılan reçetenin durumunu true atar
        void RecetDurumuAyarla()
        {
            string sorgu = $"UPDATE Receteler SET  durum=@durum WHERE sira=@sira ";
            try
            {
                using (OleDbConnection con = new OleDbConnection(baglanti))
                {
                    con.Open();
                    using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                    {
                        cmd.Parameters.AddWithValue("@durum", true);
                        cmd.Parameters.AddWithValue("@sira", sira);
                        int sayac = cmd.ExecuteNonQuery();
                        if (sayac == 0)
                            MessageBox.Show(" Reçete durumu ayarlanırken hata oluştu");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("HATA OLUŞTU TEKRAR DENEYİN");
            }
        }
        //tc si girilen hastanın en son satılan reçetesinin tarih değerini alır
        void TarihAl()
        {
            using (OleDbConnection con = new OleDbConnection(baglanti))
            {
                string sorgu = "SELECT MAX(satisTarihi) FROM Satislar WHERE Tc=@tc";
                con.Open();
                using (OleDbCommand tarihAl = new OleDbCommand(sorgu, con))
                {
                    tarihAl.Parameters.AddWithValue("@tc", tc);

                    object sonuc = tarihAl.ExecuteScalar();

                    if (sonuc != null && sonuc != DBNull.Value)
                        tarih = Convert.ToDateTime(sonuc);
                }
            }
        }
        // tc si girilen hastanın sigorta durumunu kontrol eder
        bool SigortaBak()
        {
            string sigorta = null;
            using (OleDbConnection con = new OleDbConnection(baglanti))
            {
                string sorgu = "SELECT Sigorta FROM Hastalar WHERE tc= @tc";
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    using (OleDbDataReader sigortaBul = cmd.ExecuteReader())
                    {
                        if (sigortaBul.Read())
                        {
                            sigorta = sigortaBul["sigorta"].ToString();

                        }
                    }
                }
            }
            return Convert.ToBoolean(sigorta);
        }
        // girilen tc değerine göre hasta bilgilerini alır ve ilgili label lara atar
        void Hastabul()
        {
            using (OleDbConnection con = new OleDbConnection(baglanti))
            {
                string sorgu = "SELECT adi,soyadi,sigorta FROM Hastalar WHERE tc= @tc";
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    using (OleDbDataReader hastabul = cmd.ExecuteReader())
                    {
                        if (hastabul.Read())
                        {
                            ad = hastabul["adi"].ToString();
                            soyad = hastabul["soyadi"].ToString();

                        }
                    }
                }
            }
        }
    }
}
