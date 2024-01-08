using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EczaneOtomasyon.Forms.AnaPanel
{
    public partial class HastaProfil : Form
    {
        public HastaProfil()
        {
            InitializeComponent();
        }
        private string baglanti = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb";

        private string  sigorta;

        private void txt_girilenTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        string tc;
        private void btn_hastaBul_Click(object sender, EventArgs e)
        {
            pnl_hastabilgi.Visible = true;
            HastaBul();
            ReceteListele();
        }

        void HastaBul()
        {
            tc = txt_girilenTc.Text;
            try
            {
                if (string.IsNullOrEmpty(tc))
                {
                    MessageBox.Show("ÖNCE HASTA TC Sİ GİRİNİZ");
                }
                else
                {
                    if (tc.Length != 11)
                    {
                        MessageBox.Show("HASTA TC SİNİ 11 HANELİ OLARAK GİRİNİZ");

                    }
                    else
                    {
                        using (OleDbConnection con = new OleDbConnection(baglanti))
                        {
                            string sorgu = "SELECT Adı,Soyadı,Adres,Telno,sigorta FROM Hastalar WHERE Tc=@tc";
                            con.Open();
                            using (OleDbCommand hastaBul = new OleDbCommand(sorgu, con))
                            {
                                hastaBul.Parameters.AddWithValue("@tc", tc);
                                using (OleDbDataReader hastaOku = hastaBul.ExecuteReader())
                                {
                                    if (hastaOku.Read())
                                    {
                                        lbl_hastaTc.Text = tc;
                                        lbl_hastaAd.Text = hastaOku["Adı"].ToString().ToUpper();
                                        lbl_hastaSoyad.Text = hastaOku["Soyadı"].ToString().ToUpper();
                                        lbl_hastaAdres.Text = hastaOku["Adres"].ToString().ToUpper();
                                        lbl_hastaTelno.Text = hastaOku["Telno"].ToString();
                                        sigorta = hastaOku["sigorta"].ToString();
                                        if (sigorta == "False")
                                        {
                                            lbl_hastaSigorta.Text = "YOK";
                                        }
                                        else
                                        {
                                            lbl_hastaSigorta.Text = "VAR";

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("GİRİLEN KİMLİK NUMRASINA GÖRE KAYIT BULUNAMADI");

                                    }
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("HATA OLUŞTU LÜTFEN TAKRAR DENEYİN");

            }

        }
        void ReceteListele()
        {
            using (OleDbConnection con = new OleDbConnection(baglanti))
            {
                string sorgu = "SELECT * FROM Reçeteler WHERE Tc=@tc";
                OleDbCommand receteBul = new OleDbCommand(sorgu, con);
                    receteBul.Parameters.AddWithValue("@tc",tc);
                OleDbDataAdapter da = new OleDbDataAdapter(receteBul);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                datagrid_hastarecete.DataSource = tablo;
            }
        }
    }
}

