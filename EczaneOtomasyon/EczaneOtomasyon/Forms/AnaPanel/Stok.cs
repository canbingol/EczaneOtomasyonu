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
    public partial class Stok : Form
    {
        string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb";
        int kapasite = AnaPanel.kapasite;
        public Stok()
        {
            InitializeComponent();
        }

        private void Stok_Load(object sender, EventArgs e)
        {
            IlacListesi();
            IlacArama("Antibiyotik", bar_antibiyotik, lbl_antibiyotikOran);
            IlacArama("Antidepresan", bar_antidepresan, lbl_antidepresanOran);
            IlacArama("Alerji İlacı", bar_alerji, lbl_alerjiOran);
            IlacArama("Diyabet İlacı", bar_diyabet, lbl_diyabetOran);
            IlacArama("Ağrı Kesici", bar_agriKesici, lbl_agriOran);
            IlacArama("Kalp İlacı", bar_kalp, lbl_kalpOran);
            IlacArama("Tansiyon İlacı", bar_tansiyon, lbl_tansiyonOran);
            IlacArama("Diğer", bar_diger, lbl_digerOran);
        }

        void IlacArama(string kategori, ProgressBar bar, Label lbl)
        {
            using (OleDbConnection con = new OleDbConnection(baglantı))
            {
                string sorgu = $"SELECT SUM(adet) FROM İlaçlar Where kategori=@kategori ";
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    cmd.Parameters.AddWithValue("@kategori", kategori);
                    object sonuc = cmd.ExecuteScalar();
                    int toplam = (sonuc == DBNull.Value || sonuc == null) ? 0 : Convert.ToInt32(sonuc);
                    int oran = (toplam * 100) / kapasite;
                    bar.Value = toplam;
                    lbl.Text = "%" + oran;
                }
            }
        }
        void IlacListele(string sec)
        {
            using (OleDbConnection con = new OleDbConnection(baglantı))
            {
                string sorgu = $"SELECT * FROM İlaçlar Where kategori=@kategori ";
                con.Open();
                OleDbCommand cmd = new OleDbCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@kategori", sec);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable tablo = new DataTable();
                da.Fill(tablo) ; 
                datagrid_ilac.DataSource= tablo;
            }
        }
        void IlacListesi()
        {
            using (OleDbConnection con = new OleDbConnection(baglantı))
            {
                string sorgu = $"SELECT * FROM İlaçlar";
                con.Open();
                OleDbCommand cmd = new OleDbCommand(sorgu, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                datagrid_ilac.DataSource = tablo;
            }
        }

        private void lbl_agriKesici_DoubleClick(object sender, EventArgs e)
        {
            IlacListele("Ağrı Kesici");
        }

        private void lbl_antibiyotik_DoubleClick(object sender, EventArgs e)
        {
            IlacListele("Antibiyotik");
        }

        private void lbl_alerji_DoubleClick(object sender, EventArgs e)
        {
            IlacListele("Alerji İlacı");
        }

        private void lbl_antidepresan_DoubleClick(object sender, EventArgs e)
        {
            IlacListele("Antidepresan");
        }

        private void lbl_diyabet_DoubleClick(object sender, EventArgs e)
        {
            IlacListele("Diyabet İlacı");
        }

        private void lbl_kalp_DoubleClick(object sender, EventArgs e)
        {
            IlacListele("Kalp İlacı");
        }

        private void lbl_tansiyon_DoubleClick(object sender, EventArgs e)
        {
            IlacListele("Tansiyon İlacı");
        }

        private void lbl_diger_DoubleClick(object sender, EventArgs e)
        {
            IlacListele("Diğer");
        }
    }
}
