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

namespace EczaneOtomasyon.Forms.Hasta
{
    public partial class HastaAnaSayfa : Form
    {
        string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb";

        public void Listele()
        {
            OleDbConnection con = new OleDbConnection(connection);
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Hastalar", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data_hasta.DataSource = dt;

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
            OleDbConnection con = new OleDbConnection(connection);

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

        private void txt_hastaAra_Click(object sender, EventArgs e)
        {
            txt_hastaAra.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void data_hasta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data_hasta.SelectedRows.Count > 0)
            {
                DataGridViewRow seçiliSatır = data_hasta.SelectedRows[0];

                // İlgili satırdaki verileri alır
                string hastaAdi = seçiliSatır.Cells["Adı"].Value?.ToString(); 
                string hastaSoyAdi = seçiliSatır.Cells["Soyadı"].Value?.ToString(); 
                string hastaTc = seçiliSatır.Cells["Tc"].Value?.ToString(); 
                string hastaAdres = seçiliSatır.Cells["Adres"].Value?.ToString(); 
                string hastaTelNo = seçiliSatır.Cells["TelNo"].Value?.ToString(); 

                // Hasta Güncelle formundaki textbox'lara verileri yazar
                HastaGüncelle hastaGüncelle = new HastaGüncelle();

                hastaGüncelle.txt_ad.Text = hastaAdi;
                hastaGüncelle.txt_soyad.Text = hastaSoyAdi;
                hastaGüncelle.txt_tcNo.Text = hastaTc;
                hastaGüncelle.txt_adres.Text = hastaAdres;
                hastaGüncelle.txt_telNo.Text = hastaTelNo;

                AnaEkran anaEkran = new AnaEkran();
                //  hastaGüncelle.ShowDialog();
                // anaEkran.AltFormİşlemGöster(new HastaGüncelle());

                hastaGüncelle.TopLevel = false;
                hastaGüncelle.FormBorderStyle = FormBorderStyle.None;
                hastaGüncelle.Dock = DockStyle.Fill;
                anaEkran.pnl_işlemler.Controls.Add(hastaGüncelle);
                anaEkran.pnl_işlemler.Tag = hastaGüncelle;
                hastaGüncelle.BringToFront(); // diğer formların önünde olmasını sağlar
                hastaGüncelle.Show();

            }
            else
            {
                MessageBox.Show("Hiç satır seçili değil.");
            }

                
        }
    }
}
