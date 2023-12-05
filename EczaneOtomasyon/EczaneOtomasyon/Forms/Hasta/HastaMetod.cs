using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyon.Forms.Hasta
{
    internal class HastaMetod
    {
        protected OleDbConnection con;
        public HastaMetod()
        {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb");
        }
        public void Temizle(TextBox txtTcno, TextBox txtAd, TextBox txtSoyad, TextBox txtTelNo, TextBox txtAdres)
        {
            txtTcno.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelNo.Clear();
            txtAdres.Clear();
        }

        public int TcVarmı(string tcno)
        {
            con.Open();
            OleDbCommand tcVarmı = new OleDbCommand("SELECT COUNT(*) FROM Hastalar WHERE Tc = @Tc", con);
            tcVarmı.Parameters.AddWithValue("@Tc", tcno);
            int count = (int)tcVarmı.ExecuteScalar();
            con.Close();
            return count;
        }

        public void HataMesajları(TextBox txtTcno, TextBox txtAd, TextBox txtSoyad, TextBox txtTelNo, TextBox txtAdres, Label lblTcHata, Label lblAdHata, Label lblSoyadHata, Label lblTelHata, Label lblAdresHata)
        {
            if (string.IsNullOrEmpty(txtTcno.Text))
                lblTcHata.Visible = true;
            else
                lblTcHata.Visible = false;

            if (string.IsNullOrEmpty(txtAd.Text))
                lblAdHata.Visible = true;
            else
                lblAdHata.Visible = false;

            if (string.IsNullOrEmpty(txtSoyad.Text))
                lblSoyadHata.Visible = true;
            else
                lblSoyadHata.Visible = false;

            if (string.IsNullOrEmpty(txtTelNo.Text))
                lblTelHata.Visible = true;
            else
                lblTelHata.Visible = false;

            if (string.IsNullOrEmpty(txtAdres.Text))
                lblAdresHata.Visible = true;
            else
                lblAdresHata.Visible = false;
        }
    }
}
