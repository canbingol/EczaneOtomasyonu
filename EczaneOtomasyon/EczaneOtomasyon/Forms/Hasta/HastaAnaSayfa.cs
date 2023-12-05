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

        private void btn_hastaListele_Click(object sender, EventArgs e)
        {
            if (panel_işlemler.Visible == true)
                panel_işlemler.Visible = false;
            Listele();
        }

        private void btn_hastaKaydet_Click(object sender, EventArgs e)
        {
            panel_işlemler.Visible = true;
            HastaKayıt kayıt = new HastaKayıt();
            kayıt.TopLevel = false;
            kayıt.AutoScroll = true;
            panel_işlemler.Controls.Add(kayıt);
            kayıt.Show();
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

                    // SQL enjeksiyonunu önlemek için parametreli sorgu kullan
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM Hastalar WHERE Tc LIKE @tcno", con);
                    cmd.Parameters.AddWithValue("@tcno", aranan + "%");

                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);

                    data_hasta.DataSource = tablo;
                }
                catch (OleDbException ex)
                {
                    // Veritabanı ile ilgili hataları ele al
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                Listele(); // Listele() fonksiyonu, tüm kayıtları listeler; uygulandığından emin olun
            }


        }

        private void txt_hastaAra_Click(object sender, EventArgs e)
        {
            txt_hastaAra.Text = string.Empty;
        }

        private void btn_hastaGüncelle_Click(object sender, EventArgs e)
        {
            if (panel_işlemler.Visible == false)
                panel_işlemler.Visible = true;

            HastaGüncelle hasta = new HastaGüncelle();
            hasta.TopLevel = false;
            hasta.AutoScroll = true;
            panel_işlemler.Controls.Add(hasta);
            hasta.Show();
        }
    }
}
