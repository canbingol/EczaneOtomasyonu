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

    public partial class AnaPanel : Form
    {
        string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb";
        int deger;
        public AnaPanel()
        {
            InitializeComponent();
        }

        void ToplamDeger(string sorgu, Label lbl)
        {
            using (OleDbConnection con = new OleDbConnection(baglantı))
            {
                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    con.Open();
                    deger = Convert.ToInt32(cmd.ExecuteScalar());
                    lbl.Text = deger.ToString();
                }
            }
        }

        private void AnaPanel_Load(object sender, EventArgs e)
        {
            lbl_aktifKullanıcı.Text = Login.aktifKullanıcı.ToUpper();
            ToplamDeger("SELECT COUNT(*) FROM Hastalar", lbl_hasta);
            ToplamDeger("SELECT COUNT(*) FROM İlaçlar", lbl_ilaçSayısı);
            ToplamDeger("SELECT SUM(adet) FROM İlaçlar", lbl_toplamİlaç);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ToplamDeger("SELECT COUNT(*) FROM Hastalar", label1);

        }
    }
}
