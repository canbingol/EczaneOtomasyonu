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
    public partial class HastaGuncelle : Form, IHastaİslemleri
    {
        // yapıcı metod 
        public HastaGuncelle()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb");

        // hasta güncelleme işlemleri
        private void btn_hastaGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string tcNo = txt_tcNo.Text;
                string ad = txt_ad.Text;
                string soyad = txt_soyad.Text;
                string telNo = txt_telNo.Text;
                string adres = txt_adres.Text;
                string sigorta =cmbbox_sigorta.Text;
                // textboxlarda boş değer varmı kontrol edilir
                if (string.IsNullOrEmpty(tcNo) || string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(telNo) || string.IsNullOrEmpty(adres)|| string.IsNullOrEmpty(sigorta))
                {
                    MessageBox.Show("Lütfen bütün satırları doldurun", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HataMesajlariGoster(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres, lbl_guncelleAdHata, lbl_gucelleTcHata, lbl_guncelleSoyadHata, lbl_guncelleTelHata, lbl_guncelleAdresHata);
                }
                else if (txt_tcNo.Text.Length != 11)
                {
                    MessageBox.Show("Ltfen Tc noyu 11 haneli olarak giriniz");
                    HataMesajlariGoster(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres, lbl_guncelleAdHata, lbl_gucelleTcHata, lbl_guncelleSoyadHata, lbl_guncelleTelHata, lbl_guncelleAdresHata);
                }
                //int türünde olan TcVarmi metodu çagırılarak girilen tc no nun daha önce kayıtlı olup olmadığını kontrol eder
                else if (TcVarmi(txt_tcNo.Text) == 0)
                {
                    MessageBox.Show("Bu hasta Kayıtlı değil lütfen önce kayıt oluşturun", " Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AlanlariTemizle(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres);
                }
                // güncelleme işlemleri yapılır
                else
                {
                    con.Open();
                    OleDbCommand hastaEkle = new OleDbCommand("UPDATE  Hastalar SET  adi =@p1, soyadi=@p2, adres=@p3, telno=@p4  WHERE  tc=@p5", con);
                    hastaEkle.Parameters.AddWithValue("@p1", ad);
                    hastaEkle.Parameters.AddWithValue("@p2", soyad);
                    hastaEkle.Parameters.AddWithValue("@p3", adres);
                    hastaEkle.Parameters.AddWithValue("@p4", telNo);
                    hastaEkle.Parameters.AddWithValue("@p5", tcNo);
                    hastaEkle.Parameters.AddWithValue("@sigorta", sigorta);

                    int sayac = hastaEkle.ExecuteNonQuery();
                    con.Close();
                    HastaAnaSayfa anaSayfa = new HastaAnaSayfa();
                    anaSayfa.Listele();
                    AlanlariTemizle(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres);

                    if (sayac > 0) // kayıt güncellendi ise çaalışır
                    {
                        MessageBox.Show("Kayıt başarıyla güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        anaSayfa.btn_listele.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt güncellenemedi", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        AlanlariTemizle(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AlanlariTemizle(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres);
            }
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
        #region IHastaIslemleri metodları
        // girilen tc no daha önce kayıtlı mı kontrol eder
        public int TcVarmi(string tcno)
        {
            con.Open();
            OleDbCommand tcVarmi = new OleDbCommand("SELECT COUNT(*) FROM Hastalar WHERE Tc = @Tc", con);
            tcVarmi.Parameters.AddWithValue("@Tc", tcno);
            int count = (int)tcVarmi.ExecuteScalar();
            con.Close();
            return count;
        }
        // parametre olarak verilen textboxların içini temizler
        public void AlanlariTemizle(System.Windows.Forms.TextBox txtTcno, System.Windows.Forms.TextBox txtAd, System.Windows.Forms.TextBox txtSoyad, System.Windows.Forms.TextBox txtTelNo, System.Windows.Forms.TextBox txtAdres)
        {
            txtTcno.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelNo.Clear();
            txtAdres.Clear();
        }
        // parametre olarak verilen label lerin görünürlüğünü ayarlar
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

        private void HastaGüncelle_Load(object sender, EventArgs e)
        {
            cmbbox_sigorta.Text = "YOK";
        }
    }
}

