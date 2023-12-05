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
    public partial class HastaGüncelle : Form
    {
        public HastaGüncelle()
        {
            InitializeComponent();
        }

        private void txt_tcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb");
        private void btn_hastaGüncelle_Click(object sender, EventArgs e)
        {
            HastaMetod metod = new HastaMetod();
            try
            {
                string tcNo = txt_tcNo.Text;
                string ad = txt_ad.Text;
                string soyad = txt_soyad.Text;
                string telNo = txt_adres.Text;
                DateTime dogumTarihi = dogumtarihi.Value.Date;
                string adres = txt_adres.Text;

                if (string.IsNullOrEmpty(tcNo) || string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(telNo) || dogumTarihi == null || string.IsNullOrEmpty(adres))
                {
                    MessageBox.Show("Lütfen bütün satırları doldurun", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    metod.HataMesajları(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres, lbl_gücelleTcHata, lbl_güncelleAdHata, lbl_güncelleSoyadHata, lbl_güncelleTelHata, lbl_güncelleAdresHata);


                }
                else if (tcNo.Length != 11)
                {

                    MessageBox.Show("Ltfen TC  kimlik numarınızı 11 haneli olarak giriniz");
                    metod.HataMesajları(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres, lbl_gücelleTcHata, lbl_güncelleAdHata, lbl_güncelleSoyadHata, lbl_gücelleTcHata, lbl_güncelleAdresHata);

                }

                else if (metod.TcVarmı(txt_tcNo.Text) == 0)
                {
                    MessageBox.Show("GİRİLEN TC NO İLE KAYITLI HASTA BULUNAMADI !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    metod.HataMesajları(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres, lbl_gücelleTcHata, lbl_güncelleAdHata, lbl_güncelleSoyadHata, lbl_gücelleTcHata, lbl_güncelleAdresHata);

                }
                else
                {
                    conn.Open();

                    OleDbCommand hastaGuncelle = new OleDbCommand("UPDATE Hastalar SET Adı = @p1, Soyadı = @p2, Adres = @p5, Telno = @p3, Dogumtarihi = @p4 WHERE tcno = @p6", conn);
                    hastaGuncelle.Parameters.AddWithValue("@p1", ad);
                    hastaGuncelle.Parameters.AddWithValue("@p2", soyad);
                    hastaGuncelle.Parameters.AddWithValue("@p3", telNo);
                    hastaGuncelle.Parameters.AddWithValue("@p4", dogumTarihi);
                    hastaGuncelle.Parameters.AddWithValue("@p5", adres);
                    hastaGuncelle.Parameters.AddWithValue("@p6", tcNo);

                    metod.Temizle(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres);

                    int sayac = hastaGuncelle.ExecuteNonQuery();
                    conn.Close();
                    if (sayac > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        metod.Temizle(txt_tcNo, txt_ad, txt_soyad, txt_telNo, txt_adres);

                    }
                    else
                    {
                        MessageBox.Show("Kayıt güncellenemedi", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

