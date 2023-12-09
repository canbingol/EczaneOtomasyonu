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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EczaneOtomasyon.Forms.Reçete
{
    public partial class ReçeteAnaSayfa : Form
    {
        void Listele()
        {

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb")
)
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT Tc FROM Hastalar", con))
                {
                    con.Open();

                    // Verileri oku
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        // ComboBox'a verileri ekle
                        while (reader.Read())
                        {
                            
                        }
                    }
                }
            }
        }
        public ReçeteAnaSayfa()
        {
            InitializeComponent();
        }

        private void ReçeteAnaSayfa_Load(object sender, EventArgs e)
        {
            Listele();

        }

    }
}
