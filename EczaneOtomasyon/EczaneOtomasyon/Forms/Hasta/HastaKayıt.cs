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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace EczaneOtomasyon.Forms.Hasta
{
    public partial class HastaKayıt : Form
    {
        public HastaKayıt()
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
                btn_hastaKaydet.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                btn_hastaKaydet.BackColor = System.Drawing.Color.White;
            }
        }
        HastaMetod metod = new HastaMetod();
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb");
        private void btn_hastaKaydet_Click(object sender, EventArgs e)
        {

            try
            {

                string tcNo = txt_tcNo.Text;
                string ad = txt_ad.Text;
                string soyad = txt_soyad.Text;
                string telNo = txt_tcNo.Text;
                DateTime dogumTarihi = dogumtarihi.Value.Date;
                string adres = txt_adres.Text;



                if (string.IsNullOrEmpty(tcNo) || string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(telNo) || dogumTarihi == null || string.IsNullOrEmpty(adres))
                {


                    MessageBox.Show("Lütfen bütün satırları doldurun", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    metod.HataMesajları(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres, lbl_kayıtTcHata, lbl_kayıtAdHata, lbl_hayıtSoyadHata, lbl_kayıtTelHata, lbl_kayıtAdresHata);


                }
                else if (tcNo.Length != 11)
                {
                    MessageBox.Show("Ltfen TC  kimlik numarınızı 11 haneli olarak giriniz");
                    metod.HataMesajları(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres, lbl_kayıtTcHata, lbl_kayıtAdHata, lbl_hayıtSoyadHata, lbl_kayıtTelHata, lbl_kayıtAdresHata);

                }
                else if (metod.TcVarmı(txt_tcNo.Text) != 0)
                {
                    MessageBox.Show("Bu hasta zaten Kayıtlı", " Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //   metod.HataMesajları(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres, lbl_kayıtTcHata, lbl_kayıtAdHata, lbl_hayıtSoyadHata, lbl_kayıtTelHata, lbl_kayıtAdresHata);
                    metod.Temizle(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres);

                }

                else
                {
                    con.Open();
                    OleDbCommand hastaEkle = new OleDbCommand("INSERT INTO Hastalar (adı, soyadı, tc, adres, telno, dogumtarihi) VALUES (@ad, @soyad,@tcno, @adres,  @telno, @dogumtarihi)", con);
                    hastaEkle.Parameters.AddWithValue("@ad", ad);
                    hastaEkle.Parameters.AddWithValue("@soyad", soyad);
                    hastaEkle.Parameters.AddWithValue("@tcno", tcNo);
                    hastaEkle.Parameters.AddWithValue("@adres", adres);
                    hastaEkle.Parameters.AddWithValue("@telno", telNo);
                    hastaEkle.Parameters.AddWithValue("@dogumtarihi", dogumTarihi);

                    int sayac = hastaEkle.ExecuteNonQuery();
                    con.Close();
                    HastaAnaSayfa anaSayfa = new HastaAnaSayfa();
                    anaSayfa.Listele();
                    metod.Temizle(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres);

                    if (sayac > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kayıt eklenemedi", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        metod.Temizle(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                metod.Temizle(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres);

            }

        }
        private void btn_KayıtKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #region textbox işlemleri

        private void txt_tcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txt_telNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        new void MouseHover(System.Windows.Forms.TextBox txt)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.BackColor = Color.Silver;
            txt.ForeColor = Color.DodgerBlue;
        }
        new void MouseLeave(System.Windows.Forms.TextBox txt)
        {
            txt.BorderStyle = BorderStyle.None;
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

        private void txt_adres_MouseHover(object sender, EventArgs e)
        {
            MouseHover(txt_adres);
        }

        private void txt_adres_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(txt_adres);
        }

        private void txt_telNo_MouseHover(object sender, EventArgs e)
        {
            MouseHover(txt_telNo);
        }

        private void txt_telNo_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(txt_telNo);
        }
        #endregion
        private void HastaKayıt_Load(object sender, EventArgs e)
        {
        }
    }
}
