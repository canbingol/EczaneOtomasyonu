using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace EczaneOtomasyon
{
    public partial class Login : Form
    {
        string connection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=EczaneVeri.accdb";

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Giriş_Click(object sender, EventArgs e)
        {
            string kullanıcıAdı = txt_KullanıcıAdı.Text;
            string parola = txt_Parola.Text;

            using (OleDbConnection con = new OleDbConnection(connection))
            {
                con.Open();
                using (OleDbCommand cmd = new OleDbCommand("Select * from kullanıcılar where kullanıcıAdı=@kullanıcıAdı and parola =@parola", con))
                {
                    cmd.Parameters.AddWithValue("@Username", kullanıcıAdı);
                    cmd.Parameters.AddWithValue("@Password", parola);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Kullanıcı doğrulandı, giriş yapabilirsiniz.
                            MessageBox.Show("Giriş başarılı!");
                            AnaEkran anaEkran = new AnaEkran();
                            anaEkran.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Kullanıcı doğrulanamadı, hata mesajı gösterin.
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                        }
                    }
                }


            }
        }
    }
}
