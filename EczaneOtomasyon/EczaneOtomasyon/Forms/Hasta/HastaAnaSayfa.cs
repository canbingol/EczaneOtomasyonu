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
using System.Diagnostics;

namespace EczaneOtomasyon.Forms.Hasta
{
    public partial class HastaAnaSayfa : Form
    {
        string baglanti = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb";
       
        public void Listele() // Hasatalar tablosundan bütün değerleri çekre ve datagrid e atar
        {
            OleDbConnection con = new OleDbConnection(baglanti);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT adi,soyadi,tc,adres,telno,sigorta FROM Hastalar ORDER BY tc", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data_hasta.DataSource = dt; 
            // datagridin başlıklarını düzenler
            data_hasta.Columns["tc"].HeaderText = "TC NO";
            data_hasta.Columns["adi"].HeaderText = "ADI";
            data_hasta.Columns["soyadi"].HeaderText = "SOYADI";
            data_hasta.Columns["adres"].HeaderText = "ADRESİ";
            data_hasta.Columns["telno"].HeaderText = "TELELFON NO";
            data_hasta.Columns["sigorta"].HeaderText = "SİGORTA DURUMU";
            con.Close();
        }
        public HastaAnaSayfa()
        {
            InitializeComponent();
        }

        private void HastaAnaSayfa_Load(object sender, EventArgs e)
        {
            Listele();
        }
        // txt_hastaAra textbox ına girilen her değerde girilen değere göre arama yapar ve datagrid e atar
        private void txt_hastaAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txt_hastaAra.Text;
            OleDbConnection con = new OleDbConnection(baglanti);

            if (aranan.Length >= 1)
            {
                try
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM Hastalar WHERE tc LIKE @tcno", con);
                    cmd.Parameters.AddWithValue("@tcno", aranan + "%");

                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);

                    data_hasta.DataSource = tablo;
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

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_hastaAra.Visible = false;
            Listele();
        }
        // datagrid de seçili satırı siler
        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_hasta.SelectedRows.Count > 0)// datagrid de seçiili satır varmı kontrol eder
                {
                    DialogResult sonuc;
                    sonuc = MessageBox.Show("KAYDI SİLMEK İSTİYORMUSUNUZ", "KAYIT SİLME", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.OK)  // messagebox ta verilen uyarıda ok tuşuna basıldı ise çalışır
                    {
                        string barkod = data_hasta.SelectedRows[0].Cells["tc"].Value.ToString();
                        using (OleDbConnection con = new OleDbConnection(baglanti))
                        {
                            con.Open();
                            string sorgu = "DELETE FROM Hastalar WHERE tc=@tc";
                            using (OleDbCommand sil = new OleDbCommand(sorgu, con))
                            {
                                sil.Parameters.AddWithValue("@tc", barkod);
                                int sayac = sil.ExecuteNonQuery();
                                if (sayac > 0)
                                {
                                    MessageBox.Show("KAYI BAŞARLI BİR ŞEKİLDE SİLİNDİ");
                                    Listele();
                                }
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
                MessageBox.Show("SİLME İŞLEMİ SIRASINDA BİR HATA OLUŞTU");
            }
        }

        private void btn_hastaAra_Click(object sender, EventArgs e)
        {
            if (pnl_hastaAra.Visible == true)
                pnl_hastaAra.Visible = false;
            else
                pnl_hastaAra.Visible = true;
        }

        private void btn_panelkapa_Click(object sender, EventArgs e)
        {
            txt_hastaAra.Clear();
            pnl_hastaAra.Visible = false;
        }
    }
}
