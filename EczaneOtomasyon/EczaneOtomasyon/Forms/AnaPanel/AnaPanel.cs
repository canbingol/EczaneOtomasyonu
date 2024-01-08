using EczaneOtomasyon.Forms.Satış;
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
        static public int kapasite = 30000;
        string toplamIlac;
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
        void IlacSayisi()
        {
            using (OleDbConnection con = new OleDbConnection(baglantı))
            {
                string sorgu = "SELECT SUM(adet) as ToplamAdet FROM İlaçlar";

                using (OleDbCommand cmd = new OleDbCommand(sorgu, con))
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int toplamAdet = Convert.ToInt32(result);
                        toplamIlac = toplamAdet.ToString();
                    }
                    else
                    {
                        toplamIlac = "0";
                    }
                }
            }
        }
        private void AnaPanel_Load(object sender, EventArgs e)
        {
            bar_dolulukOranı.BackColor = Color.Red;
            IlacSayisi();
            int deger = Convert.ToInt32(toplamIlac);
            int oran = (deger * 100) / kapasite;
            bar_dolulukOranı.Value = deger;
            lbl_doluluk.Text = "ECZANE DOLULUK ORANI -->" + "%" + oran.ToString();
            lbl_aktifKullanıcı.Text = Login.aktifKullanıcı.ToUpper();
            ToplamDeger("SELECT COUNT(*) FROM Hastalar", lbl_hasta);
            ToplamDeger("SELECT COUNT(*) FROM İlaçlar", lbl_ilaçSayısı);
            ToplamDeger("SELECT SUM(adet) FROM İlaçlar", lbl_toplamİlaç);
            ToplamDeger("SELECT COUNT(*) FROM Reçeteler",lbl_recete);
            ToplamCiroAl();
            BugunCiroAl();
        }
        void ToplamCiroAl()
        {
            using (OleDbConnection con = new OleDbConnection(baglantı))
            {
                con.Open();
                string sorgu = "SELECT SUM(ToplamFiyat) FROM Satislar";
                using (OleDbCommand ciro =new OleDbCommand(sorgu,con))
                {
                    object toplam = ciro.ExecuteScalar();
                    int sonuc = (toplam == DBNull.Value || toplam == null) ? 0 : Convert.ToInt32(toplam);
                    lbl_toplamKazanc.Text = sonuc.ToString();
                }
            }
        }
        void BugunCiroAl()
        {
            DateTime bugun = DateTime.Today;
            string tarihParams = bugun.Day.ToString() + "." + bugun.Month.ToString() + "." + bugun.Year.ToString();
            try
            {
                using (OleDbConnection con = new OleDbConnection(baglantı))
                {
                    con.Open();
                    string sorgu = "SELECT SUM(ToplamFiyat) FROM Satislar WHERE SatisTarihi=@tarih";
                    using (OleDbCommand ciro = new OleDbCommand(sorgu, con))
                    {
                        ciro.Parameters.AddWithValue("@tarih", tarihParams);
                         
                        object toplam = ciro.ExecuteScalar();
                        int sonuc = (toplam == DBNull.Value || toplam == null) ? 0 : Convert.ToInt32(toplam);
                        lbl_bugunKazanc.Text = sonuc.ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("BUGÜNÜN KAZANCI YAZILIRKEN HATA OLUŞTU");
            }
            
        }
        Form aktifForm = null;
        void AltFormGöster(Form altForm)
        {
            btn_kapat.Visible = true;
            pnl_alt.Controls.Clear();
            pnl_alt.Visible = true;
            aktifForm = altForm;
            altForm.TopLevel = false;
            altForm.FormBorderStyle = FormBorderStyle.None;
            altForm.Dock = DockStyle.Fill;
            pnl_alt.Controls.Add(altForm);
            pnl_alt.Tag = altForm;
            altForm.BringToFront();
            pnl_alt.Location= new Point(39, 102);
            altForm.Show();

        }
        private void lbl_hastaProfil_DoubleClick(object sender, EventArgs e)
        {
            
            AltFormGöster(new HastaProfil());
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            btn_kapat.Visible = false;
            pnl_alt.Visible = false;
        }

        private void lbl_ilaç_DoubleClick(object sender, EventArgs e)
        {
            AltFormGöster(new Stok());
        }

    }
}
