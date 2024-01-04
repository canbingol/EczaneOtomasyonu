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
   
   
    public partial class Satış : Form
    {
        string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb";
        static public int toplamCiro;
        public Satış()
        {
            InitializeComponent();
        }
        int siraAl()
        {
            int sira = 0;
            using (OleDbConnection con = new OleDbConnection(baglantı))
            {
                con.Open();
                string sorgu = "SELECT sira FROM Reçeteler WHERE tc=@tc";
                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    using (OleDbDataReader siraOku = cmd.ExecuteReader())
                    {
                        if (siraOku.Read())
                        {
                            sira = (int)siraOku["sira"];
                        }
                    }
                }
            }

            return sira;
        }
      
        void HastaListele()
        {
            using (OleDbConnection con = new OleDbConnection(baglantı))
            {
                string sorgu = "SELECT DISTINCT tc  FROM Reçeteler";
                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    con.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            checklist_hastalar.Items.Add(reader["tc"].ToString());
                        }
                    }
                }
            }
        }
        string tc,toplamfiyat;
        void ReçeteListele()
           
        {
            string durum;
            using (OleDbConnection con = new OleDbConnection(baglantı))
            {
                string sorgu = "SELECT  ilac1, ilac2, ilac3, ilac4, ilac5,toplamfiyaT FROM Reçeteler WHERE  tc=@tc AND durum=@durum  ";
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    cmd.Parameters.AddWithValue("@durum", false);
                   
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ilaclar = "";
                            // Her bir ilaç değerini kontrol et, eğer değer "-" ise ListBox'a eklemez
                            // Reçete formunda boş ilaçlar - işareti ile belirtildiği için bu kontrol yapılmakta
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
                            toplamfiyat = reader["toplamfiyat"].ToString();
                            ilaclar += " - " + toplamfiyat;
                            listBox_receteList.Items.Add(ilaclar);

                        }
                    }
                }
            }


        }

        private void btn_hastaSec_Click(object sender, EventArgs e)
        {
            tc = checklist_hastalar.CheckedItems[0].ToString();
            ReçeteListele();
            checklist_hastalar.Enabled= false;

        }

        private void Satış_Load(object sender, EventArgs e)
        {
            HastaListele();

        }

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

        private void btn_receteSec_Click(object sender, EventArgs e)
        {
            string ilaclar = listBox_receteList.CheckedItems[0].ToString();
            string[] ilaclarDizi = ilaclar.Trim().Split('-');
            int sayac = ilaclarDizi.Length;
            fiyat = ilaclarDizi[sayac - 1];
            lbl_toplamFiyat.Text = fiyat;

            ilac1 = ilaclarDizi[0];
            if (ilaclarDizi.Length > 2)
                ilac2 = ilaclarDizi[1];
            if (ilaclarDizi.Length > 3)
                ilac3 = ilaclarDizi[2];
            if (ilaclarDizi.Length > 4)
                ilac4 = ilaclarDizi[3];
            if (ilaclarDizi.Length > 5)
                ilac5 = ilaclarDizi[4];

            Hastabul();
            lbl_tc.Text = tc;
            lbl_ad.Text = ad;
            lbl_soyad.Text = soyad;
            listBox_receteList.Enabled = false;
        }
        private void btn_satis_Click(object sender, EventArgs e)
        {

            using (OleDbConnection con = new OleDbConnection(baglantı))
            {
                con.Open();
                string sorgu = "INSERT INTO Satislar (Tc,Ad,Soyad,ToplamFiyat,Ilac1,Ilac2,Ilac3,Ilac4,Ilac5) VALUES " +
                    "(@tc,@soyad,@ad,@fiyat,@ilac1,@ilac2,@ilac3,@ilac4,@ilac5)";
                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@soyad", soyad);
                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                    cmd.Parameters.AddWithValue("@ilac1", ilac1);
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

                    int sayac = cmd.ExecuteNonQuery();
                    if (sayac > 0)
                    {
                        MessageBox.Show("SATIŞ YAPILDI SAĞLIKLI GNLER DİLERİZ");
                        toplamCiro += Convert.ToInt32(toplamfiyat);
                    }
                    else
                    {
                        MessageBox.Show("SATIŞ YAPILAMADI KOMMENASİ");

                    }
                }

                string sorgu2 = "UPDATE Reçeteler SET  durum =true WHERE sira=@sira ";
                try
                {
                    using (OleDbCommand cmd = new OleDbCommand(sorgu2, con))
                    {
                        cmd.Parameters.AddWithValue("@sira", siraAl().ToString());
                        // cmd.Parameters.AddWithValue("@durum", true);
                        int sayac = cmd.ExecuteNonQuery();
                        con.Close();
                        if (sayac > 0)
                        {
                            MessageBox.Show("oldu");
                        }
                        else
                        {
                            MessageBox.Show("olmadı");

                        }

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("HATA OLUŞTU TEKRAR DENEYİN");

                }

            }
            checklist_hastalar.Enabled = true;
            listBox_receteList.Enabled = true;


        }

        void Hastabul()
        {
            using (OleDbConnection con = new OleDbConnection(baglantı))
            {
                string sorgu = "SELECT Adı,Soyadı FROM Hastalar WHERE Tc= @tc";
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    cmd.Parameters.AddWithValue("@tc", tc);
                    using (OleDbDataReader hastabul = cmd.ExecuteReader())
                    {
                        if (hastabul.Read())
                        {
                            ad = hastabul["Adı"].ToString();
                            soyad = hastabul["Soyadı"].ToString();
                        }
                    }
                }
            }
        }

    }

}
