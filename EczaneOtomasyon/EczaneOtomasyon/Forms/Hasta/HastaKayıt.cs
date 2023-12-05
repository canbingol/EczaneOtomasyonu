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
    public partial class HastaKayıt : Form

    {
        public HastaKayıt()
        {
            InitializeComponent();
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
                    OleDbCommand hastaEkle = new OleDbCommand("INSERT INTO Hastalar (Adı, Soyadı, Tc, Adres, Telno, Dogumtarihi) VALUES (@ad, @soyad,@tcno, @adres,  @telno, @dogumtarihi)", con);
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

        private void btn_KayıtKapat_Click(object sender, EventArgs e)
        {
            HastaAnaSayfa anaSayfa = new HastaAnaSayfa();
            anaSayfa.panel_işlemler.Visible = false;
        }
    }
}
