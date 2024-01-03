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

namespace EczaneOtomasyon.Forms.Satış
{
    public partial class Satış : Form
    {
        string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb";

        public Satış()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void HastaListele()
        {
            using (OleDbConnection con = new OleDbConnection(baglantı))
            {
                string sorgu = "SELECT DISTINCT tc  FROM Reçeteler";
                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    con.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            checklist_hastalar.Items.Add(reader["tc"].ToString());
                        }
                    }
                }
            }
        }
        string tc;
        void ReçeteListele()
        {
            using (OleDbConnection con = new OleDbConnection(baglantı))
            {
                string sorgu = "SELECT  ilac1, ilac2, ilac3, ilac4, ilac5 FROM Reçeteler WHERE  tc=@tc";
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    MessageBox.Show(tc);
                    cmd.Parameters.AddWithValue("@tc", tc);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ilaclar = "";
                            // Her bir ilaç değerini kontrol et, eğer değer "-" ise ListBox'a eklemez
                            // Reçete formunda boş ilaçlar - işareti ile belirtildiği için bu kontrol yapılmakta
                            if (!(reader["ilac1"] is DBNull) && reader["ilac1"].ToString() != "-")
                            {
                                ilaclar+=  reader["ilac1"].ToString()+" - ";
                            }

                            if (!(reader["ilac2"] is DBNull) && reader["ilac2"].ToString() != "-")
                            {
                                ilaclar += reader["ilac2"].ToString() + " - ";
                            }
                            if (!(reader["ilac3"] is DBNull) && reader["ilac3"].ToString() != "-")
                            {
                                ilaclar += reader["ilac3"].ToString()+" - ";
                            }
                            if (!(reader["ilac4"] is DBNull) && reader["ilac4"].ToString() != "-")
                            {
                                ilaclar += reader["ilac4"].ToString() + " - ";
                            }
                            if (!(reader["ilac5"] is DBNull) && reader["ilac5"].ToString() != "-")
                            {
                                ilaclar += reader["ilac5"].ToString() + " - ";
                            }
                            listBox_receteList.Items.Add(ilaclar);
                        }
                    }
                }
            }


        }

        private void btn_hastaSec_Click(object sender, EventArgs e)
        {
            tc = checklist_hastalar.CheckedItems[0].ToString();
            ReçeteListele();
        }

        private void Satış_Load(object sender, EventArgs e)
        {
            HastaListele();
           
        }

        private void checklist_hastalar_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < checklist_hastalar.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    checklist_hastalar.SetItemChecked(i, false);
                }
            }
        }
    }
}
