using EczaneOtomasyon.Forms.Hasta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyon.Forms.İlaç
{
    public partial class IlacAnaSayfa : Form
    {
        string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb";

        public IlacAnaSayfa()
        {
            InitializeComponent();
        }
        // verilen barkod değerine göre datagrid e deger Ilaclar tablosundna deger atar
        public void Listele(string barkod)
        {
            OleDbConnection con = new OleDbConnection(baglantı);
            OleDbCommand cmd = new OleDbCommand("SELECT isim, kategori, fiyat, barkod, adet FROM Ilaclar WHERE Kategori =@kategori", con);
            cmd.Parameters.AddWithValue("@barkod",barkod);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data_ilaclar.DataSource = dt;
            data_ilaclar.Columns["isim"].HeaderText = "İSİM";
            data_ilaclar.Columns["kategori"].HeaderText = "KATEGORİ";
            data_ilaclar.Columns["fiyat"].HeaderText = "FİYAT";
            data_ilaclar.Columns["barkod"].HeaderText = "BARKOD";
            data_ilaclar.Columns["adet"].HeaderText = "ADET";
        }
        // ılaclar tablosununda çekilen verileri datagrid e atar
        public void Listele()
        {
            OleDbConnection con = new OleDbConnection(baglantı);
            OleDbCommand cmd = new OleDbCommand("SELECT isim, kategori, fiyat, barkod, adet FROM Ilaclar", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data_ilaclar.DataSource = dt;
            data_ilaclar.Columns["isim"].HeaderText = "İSİM";
            data_ilaclar.Columns["kategori"].HeaderText = "KATEGORİ";
            data_ilaclar.Columns["fiyat"].HeaderText = "FİYAT";
            data_ilaclar.Columns["barkod"].HeaderText = "BARKOD";
            data_ilaclar.Columns["adet"].HeaderText = "ADET";
        }
        private void İlaçAnaSayfa_Load(object sender, EventArgs e)
        {
            Listele();
        }

        #region kategoriye göre ilaç listeleme buton işlemleri 

        private void btn_ağrıKesici_Click(object sender, EventArgs e)
        {
            Listele("Ağrı Kesici");
        }
        private void btn_kalp_Click(object sender, EventArgs e)
        {
            Listele("Kalp İlacı");
        }
        private void btn_alerji_Click(object sender, EventArgs e)
        {
            Listele("Alerji İlacı");
        }
        private void btn_antibiyotik_Click(object sender, EventArgs e)
        {
            Listele("Antibiyotik");
        }
        private void btn_diyabetİlaçları_Click(object sender, EventArgs e)
        {
            Listele("Diyabet İlacı");
        }
        private void btn_tansiyon_Click(object sender, EventArgs e)
        {
            Listele("Tansiyon İlacı");
        }
        private void btn_depresan_Click(object sender, EventArgs e)
        {
            Listele("Antidepresan");
        }
        private void btn_diğer_Click(object sender, EventArgs e)
        {
            Listele("Diğer");
        }
        #endregion

        private void txt_listele_Click(object sender, EventArgs e)
        {
            Listele();
        }
        // txt_ilacAra textbox ına her giriş olduğunda yada silindiğinde datagrid veri çeker
        private void txt_ilacAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txt_ilacAra.Text;
            OleDbConnection con = new OleDbConnection(baglantı);

            if (aranan.Length >= 1)
            {
                try
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM Ilaclar WHERE barkod LIKE @barkod", con);
                    cmd.Parameters.AddWithValue("@barkod", aranan + "%");

                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    data_ilaclar.DataSource = tablo;
                    data_ilaclar.Columns["isim"].HeaderText = "İSİM";
                    data_ilaclar.Columns["kategori"].HeaderText = "KATEGORİ";
                    data_ilaclar.Columns["fiyat"].HeaderText = "FİYAT";
                    data_ilaclar.Columns["barkod"].HeaderText = "BARKOD";
                    data_ilaclar.Columns["adet"].HeaderText = "ADET";
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                Listele();
            }
        }
        // silme işlemi yapılır
        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_ilaclar.SelectedRows.Count > 0)
                {
                    DialogResult sonuc;
                    sonuc = MessageBox.Show("KAYDI SİLMEK İSTİYORMUSUNUZ", "KAYIT SİLME", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.OK)
                    {
                        string barkod = data_ilaclar.SelectedRows[0].Cells["barkod"].Value.ToString();
                        using (OleDbConnection con = new OleDbConnection(baglantı))
                        {
                            con.Open();
                            string sorgu = "DELETE FROM Ilaclar WHERE barkod=@barkod";
                            using (OleDbCommand sil = new OleDbCommand(sorgu, con))
                            {
                                sil.Parameters.AddWithValue("@barkod", barkod);
                                int sayac = sil.ExecuteNonQuery();
                                if (sayac > 0)
                                    MessageBox.Show("KAYI BAŞARLI BİR ŞEKİLDE SİLİNDİ");
                                else
                                    MessageBox.Show("KAYIT SİLİNEMEDİ");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("SİLMEK İÇİN BİR KAYIT SEÇİNİZ");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("KAYDI SİLME  BAŞARISIZ", "KAYIT SİLME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Listele();
            }

        }
        private void btn_ilacAra_Click(object sender, EventArgs e)
        {
            if (pnl_ilacArama.Visible== true)
                pnl_ilacArama.Visible = false;
            else
                pnl_ilacArama.Visible = true;
        }

        private void btn_panelkapa_Click(object sender, EventArgs e)
        {
            txt_ilacAra.Clear();
            pnl_ilacArama.Visible=false;
        }
    }

}
