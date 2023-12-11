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
    public partial class İlaçGüncelle : Form, Iilaçİşlemleri
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb");


        public İlaçGüncelle()
        {
            InitializeComponent();
            txt_fiyat.TextChanged += TextBox_TextChanged;
            txt_adet.TextChanged += TextBox_TextChanged;
            txt_barkod.TextChanged += TextBox_TextChanged;
            txt_ilaçAd.TextChanged += TextBox_TextChanged;
            txt_kategori.TextChanged += TextBox_TextChanged;
        }

        private void btn_ilaçGüncelle_Click(object sender, EventArgs e)
        {

            try
            {
                string ad = txt_ilaçAd.Text;
                string adet = txt_adet.Text;
                string kategori = txt_kategori.Text;
                DateTime sonKullanma = txt_sontarih.Value.Date;
                string barkod = txt_barkod.Text;
                double fiyat = Convert.ToDouble(txt_fiyat.Text);
                if (txt_barkod.Text.Length != 13)
                {
                    MessageBox.Show("Ltfen borkodu 13 haneli olarak giriniz");
                    HataMesajlariGoster(txt_barkod, txt_ilaçAd, txt_kategori, txt_barkod, lbl_hataİlaçAd, lbl_hataİlaçKategori, lbl_hataİlaçBarkod, lbl_hataİlaçFiyat);

                }
                else if (İlaçvarmı(txt_barkod.Text) == 0)
                {
                    MessageBox.Show("Bu ilaç Kayıtlı değil lütfen önce kayıt oluşturun", " Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //   metod.HataMesajları(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres, lbl_kayıtTcHata, lbl_kayıtAdHata, lbl_hayıtSoyadHata, lbl_kayıtTelHata, lbl_kayıtAdresHata);
                    AlanlariTemizle(txt_barkod, txt_ilaçAd, txt_adet, txt_barkod);

                }


                else if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(adet) || string.IsNullOrEmpty(kategori) || sonKullanma == null || string.IsNullOrEmpty(barkod))
                {

                    MessageBox.Show("Lütfen bütün satırları doldurun", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HataMesajlariGoster(txt_barkod, txt_ilaçAd, txt_kategori, txt_barkod, lbl_hataİlaçAd, lbl_hataİlaçKategori, lbl_hataİlaçBarkod, lbl_hataİlaçFiyat);

                }
                else
                {
                    con.Open();
                    OleDbCommand ilaçEkle = new OleDbCommand("UPDATE  İlaçlar SET  isim =@p1, üretici=@p2, adet=@p3, kategori=@p4, fiyat=@p5, sontarih=@p6 WHERE barkod=@p7", con);
                    ilaçEkle.Parameters.AddWithValue("@p1", ad);
                    ilaçEkle.Parameters.AddWithValue("@p3", adet);
                    ilaçEkle.Parameters.AddWithValue("@p4", kategori);
                    ilaçEkle.Parameters.AddWithValue("@p5", fiyat);
                    ilaçEkle.Parameters.AddWithValue("@p6", sonKullanma);
                    ilaçEkle.Parameters.AddWithValue("@p7", barkod);

                    int sayac = ilaçEkle.ExecuteNonQuery();
                    con.Close();
                    HastaAnaSayfa anaSayfa = new HastaAnaSayfa();
                    anaSayfa.Listele();
                    AlanlariTemizle(txt_barkod, txt_ilaçAd, txt_adet, txt_barkod);

                    if (sayac > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt güncellenemedi", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        AlanlariTemizle(txt_barkod, txt_ilaçAd, txt_adet, txt_barkod);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AlanlariTemizle(txt_barkod, txt_ilaçAd, txt_adet, txt_barkod);

            }


        }

        #region Iİlaçİşlemleri metodları
        public void HataMesajlariGoster(TextBox txtfiyat, TextBox txtad, ComboBox txtkategori, TextBox txtbarkod, Label adhata, Label kategorihata, Label barkodhata, Label fiyathat)
        {
            if (string.IsNullOrEmpty(txtfiyat.Text))
                lbl_hataİlaçFiyat.Visible = true;
            else
                lbl_hataİlaçFiyat.Visible = false;

            if (string.IsNullOrEmpty(txt_ilaçAd.Text))
                lbl_hataİlaçAd.Visible = true;
            else
                lbl_hataİlaçAd.Visible = false;


            if (string.IsNullOrEmpty(txtkategori.Text))
                lbl_hataİlaçKategori.Visible = true;
            else
                lbl_hataİlaçKategori.Visible = false;

            if (string.IsNullOrEmpty(txtbarkod.Text))
                lbl_hataİlaçBarkod.Visible = true;
            else
                lbl_hataİlaçBarkod.Visible = false;
        }

        public void AlanlariTemizle(TextBox txtfiyat, TextBox txtad, NumericUpDown txtadet, TextBox txtbarkod)
        {
            txtfiyat.Clear();
            txtad.Clear();
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

        #region TextBox metodları
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
        private void txt_kategori_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Kullanıcının klavye girişini engeller

        }
        // textBoxların değişimini kontrol eden metod
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // TextBox'lardaki değerleri kontrol et
            string deger1 = txt_ilaçAd.Text;
            string deger2 = txt_adet.Text;
            string deger3 = txt_barkod.Text;
            string deger5 = txt_kategori.Text;
            string deger6 = txt_fiyat.Text;
            // Eğer herhangi bir TextBox boşsa, arka plan rengini kırmızı yap; aksi halde beyaz yap
            if (string.IsNullOrEmpty(deger1) || string.IsNullOrEmpty(deger2) || string.IsNullOrEmpty(deger6) ||
                string.IsNullOrEmpty(deger3) || string.IsNullOrEmpty(deger5))
            {
                btn_ilaçGüncelle.BackColor = System.Drawing.Color.Red;
                btn_ilaçGüncelle.Text = "BÜTÜN ALANLARI DOLDURUN";

            }
            else
            {
                btn_ilaçGüncelle.BackColor = System.Drawing.Color.White;
                btn_ilaçGüncelle.Text = "İLAÇ GÜNCELLE";
            }
        }
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
        private void btn_KayıtKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_ilaçAd_MouseHover(object sender, EventArgs e)
        {
            MouseHover(txt_ilaçAd);
        }

        private void txt_ilaçAd_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(txt_ilaçAd);
        }



        private void txt_fiyat_MouseHover(object sender, EventArgs e)
        {
            MouseHover(txt_fiyat);
        }

        private void txt_fiyat_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(txt_fiyat);
        }

        private void txt_barkod_MouseHover(object sender, EventArgs e)
        {
            MouseHover(txt_barkod);
        }

        private void txt_barkod_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(txt_barkod);
        }

        #endregion

        void Borkodvarmı()
        {
            if (İlaçvarmı(txt_barkod.Text) != 0)
            {
                lbl_ad.Visible = true; txt_ilaçAd.Visible = true;
                lbl_adet.Visible = true; txt_adet.Visible = true;
                lbl_kategori.Visible = true; txt_kategori.Visible = true;
                lbl_fiyat.Visible = true; txt_fiyat.Visible = true;
                lbl_tarih.Visible = true; txt_sontarih.Visible = true;
                btn_ilaçGüncelle.Visible = true; btn_barkodBul.Visible = false;
            }
        }
       
        private void btn_barkodBul_Click(object sender, EventArgs e)
        {
            Borkodvarmı();
        }

        private void İlaçGüncelle_Load(object sender, EventArgs e)
        {
            MessageBox.Show(" GÜNCELLEMEK İSTEDİĞİNİZ HASTANIN TC NOSUNU GİRİNİZ");
        }
    }


}
