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
    public partial class İlaçKayıt : Form, Iilaçİşlemleri
    {
        public İlaçKayıt()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb");


        private void btn_ilaçKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = txt_ilaçAd.Text;
                string firma = txt_ilaçFirma.Text;
                string adet = txt_adet.Text;
                string kategori = txt_kategori.Text;
                DateTime sonKullanma = txt_sontarih.Value.Date;
                string barkod = txt_barkod.Text;
                double fiyat = Convert.ToDouble(txt_barkod.Text);

                if (string.IsNullOrEmpty(firma) || string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(adet) || string.IsNullOrEmpty(kategori) || sonKullanma == null || string.IsNullOrEmpty(barkod))
                {

                    MessageBox.Show("Lütfen bütün satırları doldurun", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HataMesajlariGoster(txt_barkod, txt_ilaçAd, txt_ilaçFirma, txt_kategori, txt_barkod, lbl_hataİlaçAd, lbl_hataİlaçFirma, lbl_hataİlaçStok, lbl_hataİlaçKategori, lbl_hataİlaçBarkod, lbl_hataİlaçFiyat);

                }
                else if (txt_barkod.Text.Length != 13)
                {
                    MessageBox.Show("Ltfen borkodu 13 haneli olarak giriniz");
                    HataMesajlariGoster(txt_barkod, txt_ilaçAd, txt_ilaçFirma, txt_kategori, txt_barkod, lbl_hataİlaçAd, lbl_hataİlaçFirma, lbl_hataİlaçStok, lbl_hataİlaçKategori, lbl_hataİlaçBarkod, lbl_hataİlaçFiyat);

                }
                else if (İlaçvarmı(txt_barkod.Text) != 0)
                {
                    MessageBox.Show("Bu ilaç zaten Kayıtlı", " Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //   metod.HataMesajları(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres, lbl_kayıtTcHata, lbl_kayıtAdHata, lbl_hayıtSoyadHata, lbl_kayıtTelHata, lbl_kayıtAdresHata);
                    AlanlariTemizle(txt_barkod, txt_ilaçAd, txt_ilaçFirma, txt_adet, txt_barkod);

                }

                else
                {
                    con.Open();
                    OleDbCommand ilaçEkle = new OleDbCommand("INSERT INTO İlaçlar (isim, üretici, adet, kategori, fiyat, sontarih, barkod ) VALUES (@p1, @p2,@p3, @p4,  @p5, @p6,@p7)", con);
                    ilaçEkle.Parameters.AddWithValue("@p1", ad);
                    ilaçEkle.Parameters.AddWithValue("@p2", firma);
                    ilaçEkle.Parameters.AddWithValue("@p3", adet);
                    ilaçEkle.Parameters.AddWithValue("@p4", kategori);
                    ilaçEkle.Parameters.AddWithValue("@p4", fiyat);
                    ilaçEkle.Parameters.AddWithValue("@p6", sonKullanma);
                    ilaçEkle.Parameters.AddWithValue("@p7", barkod);

                    int sayac = ilaçEkle.ExecuteNonQuery();
                    con.Close();
                    HastaAnaSayfa anaSayfa = new HastaAnaSayfa();
                    anaSayfa.Listele();
                    AlanlariTemizle(txt_barkod, txt_ilaçAd, txt_ilaçFirma, txt_adet, txt_barkod);

                    if (sayac > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt eklenemedi", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        AlanlariTemizle(txt_barkod, txt_ilaçAd, txt_ilaçFirma, txt_adet, txt_barkod);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AlanlariTemizle(txt_barkod, txt_ilaçAd, txt_ilaçFirma, txt_adet, txt_barkod);

            }

        }
        #region Iİlaçİşlemleri metodları
        public void HataMesajlariGoster(TextBox txtfiyat, TextBox txtad, TextBox txtfirma, ComboBox txtkategori, TextBox txtbarkod, Label adhata, Label firmaHata, Label adetHata, Label kategorihata, Label barkodhata, Label fiyathat)
        {
            if (string.IsNullOrEmpty(txtfiyat.Text))
                lbl_hataİlaçFiyat.Visible = true;
            else
                lbl_hataİlaçFiyat.Visible = false;

            if (string.IsNullOrEmpty(txt_ilaçAd.Text))
                lbl_hataİlaçAd.Visible = true;
            else
                lbl_hataİlaçAd.Visible = false;

            if (string.IsNullOrEmpty(txtfirma.Text))
                lbl_hataİlaçFirma.Visible = true;
            else
                lbl_hataİlaçFirma.Visible = false;

            if (string.IsNullOrEmpty(txtkategori.Text))
                lbl_hataİlaçKategori.Visible = true;
            else
                lbl_hataİlaçKategori.Visible = false;

            if (string.IsNullOrEmpty(txtbarkod.Text))
                lbl_hataİlaçBarkod.Visible = true;
            else
                lbl_hataİlaçBarkod.Visible = false;
        }

        public void AlanlariTemizle(TextBox txtfiyat, TextBox txtad, TextBox txtfirma, NumericUpDown txtadet, TextBox txtbarkod)
        {
            txtfiyat.Clear();
            txtad.Clear();
            txtfirma.Clear();
            txtadet.Value = 1;
            txtbarkod.Clear();
        }

        public int İlaçvarmı(string barkod)
        {
            con.Open();
            OleDbCommand tcVarmı = new OleDbCommand("SELECT COUNT(*) FROM İlaçlar WHERE barkod  = @barkod", con);
            tcVarmı.Parameters.AddWithValue("@barkod", barkod);
            int count = (int)tcVarmı.ExecuteScalar();
            con.Close();
            return count;
        }
        #endregion

        private void txt_fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt_barkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btn_KayıtKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

