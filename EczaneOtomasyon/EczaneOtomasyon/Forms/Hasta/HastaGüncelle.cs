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

namespace EczaneOtomasyon.Forms.Hasta
{
    public partial class HastaGüncelle : Form, IHastaİslemleri
    {
        // yapıcı metod 
        public HastaGüncelle()
        {
            InitializeComponent();
            txt_tcNo.TextChanged += TextBox_TextChanged;
            txt_ad.TextChanged += TextBox_TextChanged;
            txt_soyad.TextChanged += TextBox_TextChanged;
            txt_adres.TextChanged += TextBox_TextChanged;
            txt_telNo.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // TextBox'lardaki değerleri kontrol et
            string deger1 = txt_tcNo.Text;
            string deger2 = txt_ad.Text;
            string deger3 = txt_soyad.Text;
            string deger4 = txt_adres.Text;
            string deger5 = txt_telNo.Text;


            // Eğer herhangi bir TextBox boşsa, arka plan rengini kırmızı yap; aksi halde beyaz yap
            if (string.IsNullOrEmpty(deger1) || string.IsNullOrEmpty(deger2) ||
                string.IsNullOrEmpty(deger3) || string.IsNullOrEmpty(deger4) || string.IsNullOrEmpty(deger5))
            {
                btn_hastaGüncelle.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                btn_hastaGüncelle.BackColor = System.Drawing.Color.White;
            }
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb");
        private void btn_hastaGüncelle_Click(object sender, EventArgs e)
        {

            HastaMetod metod = new HastaMetod();
            try
            {
                string tcNo = txt_tcNo.Text;
                string ad = txt_ad.Text;
                string soyad = txt_soyad.Text;
                string telNo = txt_telNo.Text;
                DateTime dogumTarihi = dogumtarihi.Value.Date;
                string adres = txt_adres.Text;

                if (string.IsNullOrEmpty(tcNo) || string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(telNo) || dogumTarihi == null || string.IsNullOrEmpty(adres))
                {
                    MessageBox.Show("Lütfen bütün satırları doldurun", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HataMesajlariGoster(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres, lbl_gücelleTcHata, lbl_güncelleAdHata, lbl_güncelleSoyadHata, lbl_güncelleTelHata, lbl_güncelleAdresHata);


                }
                else if (tcNo.Length != 11)
                {

                    MessageBox.Show("Ltfen TC  kimlik numarınızı 11 haneli olarak giriniz");
                    HataMesajlariGoster(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres, lbl_gücelleTcHata, lbl_güncelleAdHata, lbl_güncelleSoyadHata, lbl_gücelleTcHata, lbl_güncelleAdresHata);

                }

                else if (TcVarmi(txt_tcNo.Text) == 0)
                {
                    MessageBox.Show("GİRİLEN TC NO İLE KAYITLI HASTA BULUNAMADI !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HataMesajlariGoster(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres, lbl_gücelleTcHata, lbl_güncelleAdHata, lbl_güncelleSoyadHata, lbl_gücelleTcHata, lbl_güncelleAdresHata);

                }
                else
                {
                    con.Open();

                    OleDbCommand hastaGuncelle = new OleDbCommand("UPDATE Hastalar SET adı = @p1, soyadı = @p2, adres = @p3, Telno = @p4, dogumtarihi = @p5 WHERE tc = @p6", con);
                    hastaGuncelle.Parameters.AddWithValue("@p1", ad);
                    hastaGuncelle.Parameters.AddWithValue("@p2", soyad);
                    hastaGuncelle.Parameters.AddWithValue("@p6", tcNo);
                    hastaGuncelle.Parameters.AddWithValue("@p3", adres);
                    hastaGuncelle.Parameters.AddWithValue("@p4", telNo);
                    hastaGuncelle.Parameters.AddWithValue("@p5", dogumTarihi);

                    //    metod.Temizle(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres);
                    if (con.State == ConnectionState.Open)
                    {
                        // Bağlantı açık
                        MessageBox.Show("Veritabanı bağlantısı açık.");
                    }
                    else
                    {
                        // Bağlantı kapalı
                        MessageBox.Show("Veritabanı bağlantısı kapalı.");
                    }

                    int sayac = hastaGuncelle.ExecuteNonQuery();
                    con.Close();
                    if (sayac > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AlanlariTemizle(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres);

                    }
                    else
                    {
                        MessageBox.Show("Kayıt güncellenemedi", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        AlanlariTemizle(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres);

                    }

                }
            }

            catch (OleDbException sqlEx)
            {
                MessageBox.Show("SQL Hatası: " + sqlEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AlanlariTemizle(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres);
            }


        }
        private void btn_EkranKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #region  textBox kontrolleri
        private void txt_telNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
        private void txt_tcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
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

        private void txt_tcNo_MouseHover(object sender, EventArgs e)
        {
            MouseHover(txt_tcNo);
        }

        private void txt_tcNo_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(txt_tcNo);
        }

        private void txt_ad_MouseHover(object sender, EventArgs e)
        {
            MouseHover(txt_ad);
        }

        private void txt_ad_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(txt_ad);
        }

        private void txt_soyad_MouseHover(object sender, EventArgs e)
        {
            MouseHover(txt_soyad);
        }

        private void txt_soyad_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(txt_soyad);
        }

        private void txt_telNo_MouseHover(object sender, EventArgs e)
        {
            MouseHover(txt_telNo);
        }

        private void txt_telNo_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(txt_telNo);
        }

        private void txt_adres_MouseHover(object sender, EventArgs e)
        {
            MouseHover(txt_adres);
        }

        private void txt_adres_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(txt_adres);
        }

        #endregion
        #region IHastaİşlemleri metodları
        public int TcVarmi(string tcno)
        {
            con.Open();
            OleDbCommand tcVarmı = new OleDbCommand("SELECT COUNT(*) FROM Hastalar WHERE Tc = @Tc", con);
            tcVarmı.Parameters.AddWithValue("@Tc", tcno);
            int count = (int)tcVarmı.ExecuteScalar();
            con.Close();
            return count;
        }
        public void AlanlariTemizle(System.Windows.Forms.TextBox txtTcno, System.Windows.Forms.TextBox txtAd, System.Windows.Forms.TextBox txtSoyad, System.Windows.Forms.TextBox txtTelNo, System.Windows.Forms.TextBox txtAdres)
        {
            txtTcno.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelNo.Clear();
            txtAdres.Clear();
        }

        public void HataMesajlariGoster(System.Windows.Forms.TextBox txtTcno, System.Windows.Forms.TextBox txtAd, System.Windows.Forms.TextBox txtSoyad, System.Windows.Forms.TextBox txtTelNo, System.Windows.Forms.TextBox txtAdres, Label lblTcHata, Label lblAdHata, Label lblSoyadHata, Label lblTelHata, Label lblAdresHata)
        {
            if (string.IsNullOrEmpty(txtTcno.Text))
                lblTcHata.Visible = true;
            else
                lblTcHata.Visible = false;

            if (string.IsNullOrEmpty(txtAd.Text))
                lblAdHata.Visible = true;
            else
                lblAdHata.Visible = false;

            if (string.IsNullOrEmpty(txtSoyad.Text))
                lblSoyadHata.Visible = true;
            else
                lblSoyadHata.Visible = false;

            if (string.IsNullOrEmpty(txtTelNo.Text))
                lblTelHata.Visible = true;
            else
                lblTelHata.Visible = false;

            if (string.IsNullOrEmpty(txtAdres.Text))
                lblAdresHata.Visible = true;
            else
                lblAdresHata.Visible = false;
        }
        #endregion
    }
}

