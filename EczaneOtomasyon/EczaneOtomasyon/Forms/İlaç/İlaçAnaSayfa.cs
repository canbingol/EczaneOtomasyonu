using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyon.Forms.İlaç
{
    public partial class İlaçAnaSayfa : Form
    {
        string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb";
        İlaçKayıt kayıt = new İlaçKayıt();
        public İlaçAnaSayfa()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            OleDbConnection con = new OleDbConnection(connection);
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM İlAÇLAR",con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data_ilaçlar.DataSource = dt;
        }
        private void İlaçAnaSayfa_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_ilaçkaydet_Click(object sender, EventArgs e)
        {
            kayıt.Show();
        }

        private void txt_listele_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
