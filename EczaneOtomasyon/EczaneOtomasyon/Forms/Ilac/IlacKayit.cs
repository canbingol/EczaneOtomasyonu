using EczaneOtomasyon.Forms.Hasta;
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

namespace EczaneOtomasyon.Forms.İlaç
{
    public partial class IlacKayit : Form, IilacIslemleri
    {
        public IlacKayit()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb");

        // ilaç kaydetme işlemleri
        private void btn_ilaçKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // textboxlardan veriler çekiliyor
                string ad = txt_ilacAd.Text;
                string adet = txt_adet.Text;
                string kategori = txt_kategori.Text;
                DateTime sonKullanma = txt_sontarih.Value.Date;
                string barkod = txt_barkod.Text;
                double fiyat = Convert.ToDouble(txt_fiyat.Text);
                // textboxlardan alınan verilern boş olup olmadığını kontrol eder
                if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(adet) || string.IsNullOrEmpty(kategori) || sonKullanma == null || string.IsNullOrEmpty(barkod))
                {
                    MessageBox.Show("Lütfen bütün satırları doldurun", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HataMesajlariGoster(txt_barkod, txt_ilacAd, txt_kategori, txt_barkod, lbl_hataIlacAd, lbl_hataIlacKategori, lbl_hataIlacBarkod, lbl_hataIlacFiyat);
                }
                else if (txt_barkod.Text.Length != 13)
                {
                    MessageBox.Show("Ltfen borkodu 13 haneli olarak giriniz");
                    HataMesajlariGoster(txt_barkod, txt_ilacAd, txt_kategori, txt_barkod, lbl_hataIlacAd, lbl_hataIlacKategori, lbl_hataIlacBarkod, lbl_hataIlacFiyat);
                }
                else if (Ilacvarmi(txt_barkod.Text) != 0) // girilen barkodun kayıtlı olup olmaddığını kontrol eder
                {
                    MessageBox.Show("Bu ilaç zaten Kayıtlı", " Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AlanlariTemizle(txt_barkod, txt_ilacAd, txt_adet, txt_barkod);
                }
                else
                {
                    con.Open();
                    OleDbCommand ilaçEkle = new OleDbCommand("INSERT INTO Ilaclar (isim,  adet, kategori, fiyat, sontarih, barkod ) VALUES (@p1, @p3, @p4,  @p5, @p6,@p7)", con);
                    ilaçEkle.Parameters.AddWithValue("@p1", ad);
                    ilaçEkle.Parameters.AddWithValue("@p3", adet);
                    ilaçEkle.Parameters.AddWithValue("@p4", kategori);
                    ilaçEkle.Parameters.AddWithValue("@p4", fiyat);
                    ilaçEkle.Parameters.AddWithValue("@p6", sonKullanma);
                    ilaçEkle.Parameters.AddWithValue("@p7", barkod);

                    int sayac = ilaçEkle.ExecuteNonQuery();
                    con.Close();
                    HastaAnaSayfa anaSayfa = new HastaAnaSayfa();
                    anaSayfa.Listele();
                    AlanlariTemizle(txt_barkod, txt_ilacAd, txt_adet, txt_barkod);

                    if (sayac > 0)
                        MessageBox.Show("Kayıt başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Kayıt eklenemedi", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    AlanlariTemizle(txt_barkod, txt_ilacAd, txt_adet, txt_fiyat); txt_kategori.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AlanlariTemizle(txt_barkod, txt_ilacAd, txt_adet, txt_barkod);
            }
        }

        #region Iİlaçİşlemleri metodları
        // girlen label ların görünürlüğünü textboxın durumuna göre değiştirir
        public void HataMesajlariGoster(TextBox txtfiyat, TextBox txtad, ComboBox txtkategori, TextBox txtbarkod, Label adhata, Label kategorihata, Label barkodhata, Label fiyathat)
        {
            if (string.IsNullOrEmpty(txtfiyat.Text))
                lbl_hataIlacFiyat.Visible = true;
            else
                lbl_hataIlacFiyat.Visible = false;

            if (string.IsNullOrEmpty(txt_ilacAd.Text))
                lbl_hataIlacAd.Visible = true;
            else
                lbl_hataIlacAd.Visible = false;

            if (string.IsNullOrEmpty(txtkategori.Text))
                lbl_hataIlacKategori.Visible = true;
            else
                lbl_hataIlacKategori.Visible = false;

            if (string.IsNullOrEmpty(txtbarkod.Text))
                lbl_hataIlacBarkod.Visible = true;
            else
                lbl_hataIlacBarkod.Visible = false;
        }
        // girilen textboxları temizler
        public void AlanlariTemizle(TextBox txtfiyat, TextBox txtad, NumericUpDown txtadet, TextBox txtbarkod)
        {
            txtfiyat.Clear();
            txtad.Clear();
            txtadet.Value = 1;
            txtbarkod.Clear();
        }
        // verilen barkodun kayıtlı olup olmadığını kontrol eder
        public int Ilacvarmi(string barkod)
        {
            con.Open();
            OleDbCommand tcVarmı = new OleDbCommand("SELECT COUNT(*) FROM Ilaclar WHERE barkod  = @barkod", con);
            tcVarmı.Parameters.AddWithValue("@barkod", barkod);
            int count = (int)tcVarmı.ExecuteScalar();
            con.Close();
            return count;
        }
        #endregion
        #region TextBox metodları

        // textBoxların değişimini kontrol eden metod

        new void MouseHover(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.None;
            txt.BackColor = Color.Silver;
            txt.ForeColor = Color.DodgerBlue;
        }
        new void MouseLeave(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.BackColor = Color.White;
            txt.ForeColor = Color.Black;
        }
        private void txt_ilaçAd_MouseHover(object sender, EventArgs e)
        {
            MouseHover(txt_ilacAd);
        }

        private void txt_ilaçAd_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(txt_ilacAd);
        }

        private void txt_barkod_MouseHover(object sender, EventArgs e)
        {
            MouseHover(txt_barkod);
        }

        private void txt_barkod_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(txt_barkod);
        }

        private void txt_fiyat_MouseHover(object sender, EventArgs e)
        {
            MouseHover(txt_fiyat);
        }

        private void txt_fiyat_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(txt_fiyat);
        }
        #endregion

    }
}

