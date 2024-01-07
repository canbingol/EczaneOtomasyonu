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
            OleDbCommand cmd = new OleDbCommand("SELECT Adı,Soyadı,Tc,Adres,Telno,sigorta FROM Hastalar", con);
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

    }
}
