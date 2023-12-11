using EczaneOtomasyon.Forms.Hasta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyon.Forms.İlaç
{
    public partial class İlaçAnaSayfa : Form
    {
        string baglantı = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb";

        public İlaçAnaSayfa()
        {
            InitializeComponent();
        }
        public void Listele(string command)
        {
            OleDbConnection con = new OleDbConnection(baglantı);
            OleDbCommand cmd = new OleDbCommand(command, con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data_ilaçlar.DataSource = dt;
        }
        public void Listele()
        {
            OleDbConnection con = new OleDbConnection(baglantı);
            OleDbCommand cmd = new OleDbCommand("SELECT isim, kategori, fiyat, barkod, adet FROM İlaçlar", con);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            data_ilaçlar.DataSource = dt;
        }
        private void İlaçAnaSayfa_Load(object sender, EventArgs e)
        {
            Listele("SELECT isim, kategori, fiyat, barkod, adet FROM İlaçlar");
        }

        private void btn_ilaçkaydet_Click(object sender, EventArgs e)
        {
            if (panel_ilaçAnaSayfa.Visible == false)
                panel_ilaçAnaSayfa.Visible = true;
            İlaçKayıt kayıt = new İlaçKayıt();
            kayıt.TopLevel = false;
            kayıt.AutoScroll = true;
            panel_ilaçAnaSayfa.Controls.Clear();
            panel_ilaçAnaSayfa.Controls.Add(kayıt);
            kayıt.Show();
        }

        private void btn_ilaçGüncelle_Click(object sender, EventArgs e)
        {
            if (panel_ilaçAnaSayfa.Visible == false)
                panel_ilaçAnaSayfa.Visible = true;
            İlaçGüncelle güncelle = new İlaçGüncelle();
            güncelle.TopLevel = false;
            güncelle.AutoScroll = true;
            panel_ilaçAnaSayfa.Controls.Clear();
            panel_ilaçAnaSayfa.Controls.Add(güncelle);
            güncelle.Show();
        }

        #region kategoriye göre ilaç listeleme buton işlemleri 

        private void btn_ağrıKesici_Click(object sender, EventArgs e)
        {
            Listele("SELECT isim, kategori, fiyat, barkod, adet FROM İlaçlar WHERE Kategori = 'Ağrı Kesici'");
        }

        private void btn_kalp_Click(object sender, EventArgs e)
        {
            Listele("SELECT isim, kategori, fiyat, barkod, adet FROM İlaçlar WHERE Kategori = 'Kalp İlacı'");

        }

        private void btn_alerji_Click(object sender, EventArgs e)
        {
            Listele("SELECT isim, kategori, fiyat, barkod, adet FROM İlaçlar WHERE Kategori = 'Alerji İlacı'");

        }

        private void btn_antibiyotik_Click(object sender, EventArgs e)
        {
            Listele("SELECT isim, kategori, fiyat, barkod, adet FROM İlaçlar WHERE Kategori = 'Antibiyotik'");

        }

        private void btn_diyabetİlaçları_Click(object sender, EventArgs e)
        {
            Listele("SELECT isim, kategori, fiyat, barkod, adet FROM İlaçlar WHERE Kategori = 'Diyabet İlacı'");

        }

        private void btn_tansiyon_Click(object sender, EventArgs e)
        {
            Listele("SELECT isim, kategori, fiyat, barkod, adet FROM İlaçlar WHERE Kategori = 'Tansiyon İlacı'");

        }

        private void btn_depresan_Click(object sender, EventArgs e)
        {
            Listele("SELECT isim, kategori, fiyat, barkod, adet FROM İlaçlar WHERE Kategori = 'Antidepresan'");

        }

        private void btn_diğer_Click(object sender, EventArgs e)
        {
            Listele("SELECT isim, kategori, fiyat, barkod, adet FROM İlaçlar WHERE Kategori = 'Diğer'");

        }

        #endregion

        private void txt_listele_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }

}
