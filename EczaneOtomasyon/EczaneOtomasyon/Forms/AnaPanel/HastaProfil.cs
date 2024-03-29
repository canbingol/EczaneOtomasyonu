﻿using System;
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

        private string sigorta;
        // ilgili textboax a numerik değer dışında giriş engelleniliyor
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
            HastaBul(); // datagrid e hasta bilgileri atanır
            ReceteListele();// hastanın reçeteleri lşsteneleir
        }
        // hastalar tabolundan textbox a girilen değere göre datagrid e değer atanır
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
                            string sorgu = "SELECT adi,soyadi,adres,telno,sigorta FROM Hastalar WHERE tc=@tc";
                            con.Open();
                            using (OleDbCommand hastaBul = new OleDbCommand(sorgu, con))
                            {
                                hastaBul.Parameters.AddWithValue("@tc", tc);
                                using (OleDbDataReader hastaOku = hastaBul.ExecuteReader())
                                {
                                    if (hastaOku.Read()) 
                                    {
                                        lbl_hastaTc.Text = tc;
                                        lbl_hastaAd.Text = hastaOku["adi"].ToString().ToUpper();
                                        lbl_hastaSoyad.Text = hastaOku["soyadi"].ToString().ToUpper();
                                        lbl_hastaAdres.Text = hastaOku["adres"].ToString().ToUpper();
                                        lbl_hastaTelno.Text = hastaOku["telno"].ToString();
                                        sigorta = hastaOku["sigorta"].ToString();
                                        if (sigorta == "False")
                                            lbl_hastaSigorta.Text = "YOK";
                                        else
                                            lbl_hastaSigorta.Text = "VAR";
                                    }
                                    else
                                        MessageBox.Show("GİRİLEN KİMLİK NUMRASINA GÖRE KAYIT BULUNAMADI");
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
        // recetelre tablosundan girilen tc noya göre veri çekilip datagrid e atanaır
        void ReceteListele()
        {
            using (OleDbConnection con = new OleDbConnection(baglanti))
            {
                string sorgu = "SELECT * FROM Receteler WHERE tc=@tc";
                OleDbCommand receteBul = new OleDbCommand(sorgu, con);
                receteBul.Parameters.AddWithValue("@tc", tc);
                OleDbDataAdapter da = new OleDbDataAdapter(receteBul);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                
            }
        }
        // receteler tablosundan bütün veriler çeker
        void Listele()
        {
            using (OleDbConnection con = new OleDbConnection(baglanti))
            {
                string sorgu = "SELECT * FROM Receteler";
                OleDbCommand receteBul = new OleDbCommand(sorgu, con);
                OleDbDataAdapter da = new OleDbDataAdapter(receteBul);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                datagrid_hastarecete.DataSource = tablo;
                
            }
        }
        private void HastaProfil_Load(object sender, EventArgs e)
        {
            Listele();  // receteler tablosundan bütün veriler çeker
        }
    }
}

