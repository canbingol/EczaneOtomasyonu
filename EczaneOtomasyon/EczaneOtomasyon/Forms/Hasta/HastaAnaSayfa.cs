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
            data_hasta.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12, FontStyle.Bold);
            data_hasta.DefaultCellStyle.Font = new Font("Century Gothic", 10);
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
    }
}
