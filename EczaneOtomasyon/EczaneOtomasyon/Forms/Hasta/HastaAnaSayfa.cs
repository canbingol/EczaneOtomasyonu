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

        public void Listele()
        {
            OleDbConnection con = new OleDbConnection(baglanti);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Adı,Soyadı,Tc,Adres,Telno,sigorta FROM Hastalar ORDER BY Tc", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data_hasta.DataSource = dt; 
            data_hasta.Columns["Tc"].HeaderText = "TC NO";
            data_hasta.Columns["Adı"].HeaderText = "ADI";
            data_hasta.Columns["Soyadı"].HeaderText = "SOYADI";
            data_hasta.Columns["Adres"].HeaderText = "ADRESİ";
            data_hasta.Columns["Telno"].HeaderText = "TELELFON NO";
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

        private void txt_hastaAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txt_hastaAra.Text;
            OleDbConnection con = new OleDbConnection(baglanti);

            if (aranan.Length >= 1)
            {
                try
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM Hastalar WHERE Tc LIKE @tcno", con);
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

        private void btn_sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (data_hasta.SelectedRows.Count > 0)
                {
                    DialogResult sonuc;
                    sonuc = MessageBox.Show("KAYDI SİLMEK İSTİYORMUSUNUZ", "KAYIT SİLME", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (sonuc == DialogResult.OK)
                    {
                        string barkod = data_hasta.SelectedRows[0].Cells["Tc"].Value.ToString();
                        using (OleDbConnection con = new OleDbConnection(baglanti))
                        {
                            con.Open();
                            string sorgu = "DELETE FROM Hastalar WHERE Tc=@tc";
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
