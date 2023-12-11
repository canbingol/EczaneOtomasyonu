using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyon.Forms.Stok
{
    public partial class StokAnaSayfa : Form
    {


        public StokAnaSayfa()
        {
            InitializeComponent();
           
        }

        private void StokAnaSayfa_Load(object sender, EventArgs e)
        {
            Toplamİlaç();
            
        }
        void Toplamİlaç()
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb"))
            {
                // Bağlantıyı açma
                con.Open();

                // SQL komutu ve bağlantı
                using (OleDbCommand command = new OleDbCommand("SELECT SUM(adet) AS toplamIlac FROM İlaçlar", con))
                {
                    // Komutu çalıştırma ve sonucu al
                    object result= command.ExecuteScalar();

                    // Eğer sonuç varsa
                    if (result != null )
                    {
                        lbl_toplamAdet.Text = result.ToString();
                        int deger = Convert.ToUInt16(lbl_toplamAdet.Text);
                        pBar.Value = deger;
                        pBar.Text =deger.ToString()+"%";
                        bar.Value = deger;
                        
                    }
                    else
                    {
                        Console.WriteLine("Sonuç bulunamadı.");
                    }
                }
            }
        }


    }
}
