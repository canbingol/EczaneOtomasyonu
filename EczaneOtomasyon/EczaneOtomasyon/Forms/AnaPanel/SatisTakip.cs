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

namespace EczaneOtomasyon.Forms.AnaPanel
{
    public partial class SatisTakip : Form
    {
        string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb";

        public SatisTakip()
        {
            InitializeComponent();
        }

        void BugunSatisListele()
        {
            DateTime bugun = DateTime.Today;
            string tarihParams = bugun.Day.ToString() + "." + bugun.Month.ToString() + "." + bugun.Year.ToString();
            using (OleDbConnection con =new OleDbConnection(baglantı))
            {
                string sorgu = $"SELECT * FROM Satislar WHERE SatisTarihi = @satis";
               OleDbCommand satisOku = new OleDbCommand(sorgu, con);
                satisOku.Parameters.AddWithValue("@satis",tarihParams);
                OleDbDataAdapter da = new OleDbDataAdapter(satisOku);
                DataTable table = new DataTable();
                da.Fill(table);
                dataGrid_satis.DataSource= table;
            }
        }
        void HaftaSatisListele()
        {
            DateTime satisTarihi = DateTime.Now.AddDays(-7);
            string satisTarihiFiltreMetin = satisTarihi.ToString("d.M.yyyy");
            string tarihParams = satisTarihi.Day.ToString() + "." + satisTarihi.Month.ToString() + "." + satisTarihi.Year.ToString();

            using (OleDbConnection con =new OleDbConnection(baglantı))
            {
                string sorgu = $"SELECT * FROM Satislar WHERE SatisTarihi > @satis";
               OleDbCommand satisOku = new OleDbCommand(sorgu, con);
                satisOku.Parameters.AddWithValue("@satis",tarihParams);
                OleDbDataAdapter da = new OleDbDataAdapter(satisOku);
                DataTable table = new DataTable();
                da.Fill(table);
                dataGrid_satis.DataSource= table;
            }
        }

        private void SatisTakip_Load(object sender, EventArgs e)
        {
            
        }

        private void combobox_zaman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_zaman.SelectedIndex==0)
            {
                BugunSatisListele();
            }
            if (combobox_zaman.SelectedIndex==1)
            {
                HaftaSatisListele();
            }
        }
    }
}
