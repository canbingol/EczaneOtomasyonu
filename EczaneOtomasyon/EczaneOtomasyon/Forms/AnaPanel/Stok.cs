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
        string baglanti = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb";
        int kapasite = AnaPanel.kapasite;
        public Stok()
        {
            InitializeComponent();
        }

        private void Stok_Load(object sender, EventArgs e)
        {
       
            IlacListesi();   // ilaclar tablosundan bütün verileri çeker ve datagrid e atar
            // bütün kategirilere göre tolam ilaç sayısını alır ve prosessbar lara atar
            IlacArama("Antibiyotik", bar_antibiyotik, lbl_antibiyotikOran);
            IlacArama("Antidepresan", bar_antidepresan, lbl_antidepresanOran);
            IlacArama("Alerji İlacı", bar_alerji, lbl_alerjiOran);
            IlacArama("Diyabet İlacı", bar_diyabet, lbl_diyabetOran);
            IlacArama("Ağrı Kesici", bar_agriKesici, lbl_agriOran);
            IlacArama("Kalp İlacı", bar_kalp, lbl_kalpOran);
            IlacArama("Tansiyon İlacı", bar_tansiyon, lbl_tansiyonOran);
            IlacArama("Diğer", bar_diger, lbl_digerOran);
        }
        // parametre olarak girilen kategoriye göre prosessbar a değer atar
        void IlacArama(string kategori, ProgressBar bar, Label lbl)
        {
            using (OleDbConnection con = new OleDbConnection(baglanti))
            {
                string sorgu = $"SELECT SUM(adet) FROM Ilaclar Where kategori=@kategori ";
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
        // girilen parametreye göre kategoriden veri çekip datagrid e atar
        void IlacListele(string sec)
        {
            using (OleDbConnection con = new OleDbConnection(baglanti))
            {   
                string sorgu = $"SELECT * FROM Ilaclar Where kategori=@kategori ";
                con.Open();
                OleDbCommand cmd = new OleDbCommand(sorgu, con);
                cmd.Parameters.AddWithValue("@kategori", sec);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable tablo = new DataTable();
                da.Fill(tablo) ; 
                datagrid_ilac.DataSource= tablo;
                datagrid_ilac.Columns["isim"].HeaderText = "İSİM";
                datagrid_ilac.Columns["kategori"].HeaderText = "KATEGORİ";
                datagrid_ilac.Columns["fiyat"].HeaderText = "FİYAT";
                datagrid_ilac.Columns["barkod"].HeaderText = "BARKOD";
                datagrid_ilac.Columns["adet"].HeaderText = "ADET";
            }
        }
        // ilaclar tablosundan bütün verileri çeker ve datagrid e atar
        void IlacListesi()
        {
            using (OleDbConnection con = new OleDbConnection(baglanti))
            {
                string sorgu = $"SELECT * FROM Ilaclar";
                con.Open();
                OleDbCommand cmd = new OleDbCommand(sorgu, con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                datagrid_ilac.DataSource = tablo;
                datagrid_ilac.Columns["isim"].HeaderText = "İSİM";
                datagrid_ilac.Columns["kategori"].HeaderText = "KATEGORİ";
                datagrid_ilac.Columns["fiyat"].HeaderText = "FİYAT";
                datagrid_ilac.Columns["barkod"].HeaderText = "BARKOD";
                datagrid_ilac.Columns["adet"].HeaderText = "ADET";
            }
        }
        // label lara çitf tıklama olayları
        #region label çift tıklama
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
        #endregion
    }
}
