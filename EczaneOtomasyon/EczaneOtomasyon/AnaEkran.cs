using EczaneOtomasyon.Forms.AnaPanel;
using EczaneOtomasyon.Forms.Hasta;
using EczaneOtomasyon.Forms.İlaç;
using EczaneOtomasyon.Forms.Reçete;
using EczaneOtomasyon.Forms.Satış;
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

namespace EczaneOtomasyon
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
            panelAyarları();
        }
        string kullanıcı = Login.aktifKullanici;
       

        #region Tıklama işlemleri 
        private void btn_hastaİşlemleri_Click(object sender, EventArgs e)
        {
            AltMenüSakla(); // alt panell er açık ise kapatır
            AltFormGöster(new HastaAnaSayfa()); // hastaAnaSayfa dan bir nesne üretir ve ekrandaki ana panel e ekler
            AltMenüGöster(pnl_hasta);// hasta butonu altındaki paneli gösterir
        }

        private void btn_anaSayfa_Click_1(object sender, EventArgs e)
        {
            AltMenüSakla();
            AltFormGöster(new AnaPanel());
        }
        private void btn_hastaKaydet_Click(object sender, EventArgs e)
        {
            AltFormİşlemGöster(new HastaKayit());// hastakaydet formunu ana panelşn altındakş panelde gösterir
        }

        private void btn_ilaçİşlemleri_Click(object sender, EventArgs e)
        {
            AltMenüSakla();
            AltFormGöster(new IlacAnaSayfa());
            AltMenüGöster(pnl_ilaç);
        }
        private void btn_reçeteİşlemleri_Click(object sender, EventArgs e)
        {
            AltFormGöster(new Recete());
            AltMenüSakla();
        }
        #endregion

        #region panel metodları
        void panelAyarları()
        {
            pnl_ilaç.Visible = false;
            pnl_hasta.Visible = false;
        }
        // sol tarafta bulunan alt panellerin ve alt panel şlemlerinin göründüğü işlemler panelinin görünürlüğü ayarlanıyor
        void AltMenüSakla()
        {
            if (pnl_hasta.Visible == true)
                pnl_hasta.Visible = false;
            if (pnl_ilaç.Visible == true)
                pnl_ilaç.Visible = false;
            if (pnl_işlemler.Visible == true)
                pnl_işlemler.Visible = false;
        }
        // ilaç ve hasta formlarının alt menülerini gösterme için kullanılır
        void AltMenüGöster(Panel pnl)
        {
            if (pnl.Visible == false)
            {
                AltMenüSakla();
                pnl.Visible = true;
            }
            else
                pnl.Visible = false;
        }
        // ana formların dışında ana formlara bağımlı formları gösterir /hastaAnasayfa-hastagüncelle
        public void AltFormİşlemGöster(Form altForm)
        {
            pnl_işlemler.Controls.Clear();
            if (pnl_işlemler.Visible == false)
            {
                pnl_işlemler.Visible = true;
                pnl_x.Visible = true;
            }

            altForm.TopLevel = false;
            altForm.FormBorderStyle = FormBorderStyle.None;
            altForm.Dock = DockStyle.Fill;
            pnl_işlemler.Controls.Add(altForm);
            pnl_işlemler.Tag = altForm;
            altForm.BringToFront(); // diğer formların önünde olmasını sağlar
            altForm.Show();
        }

        // anaekran içinde diğer formları gösterir
        Form aktifForm = null;
        void AltFormGöster(Form altForm)
        {
            if (aktifForm != null)
                aktifForm.Close();
            if (pnl_işlemler.Visible == true)
                pnl_işlemler.Visible = false;
            aktifForm = altForm;
            altForm.TopLevel = false;
            altForm.FormBorderStyle = FormBorderStyle.None;
            altForm.Dock = DockStyle.Fill;
            pnl_altForm.Controls.Add(altForm);
            pnl_altForm.Tag = altForm;
            altForm.BringToFront();
            altForm.Show();

        }
        #endregion
        // imlecin hareketine göre butonların renkleri değişiyor
        #region Buton renk ayarları
        new void MouseHover(Button btn)
        {
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }
        new void MouseLeave(Button btn)
        {
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.White;
        }
        private void btn_anaSayfa_MouseHover(object sender, EventArgs e)
        {
            MouseHover(btn_anaSayfa);
        }

        private void btn_anaSayfa_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(btn_anaSayfa);
        }

        private void btn_hastaİşlemleri_MouseHover(object sender, EventArgs e)
        {
            MouseHover(btn_hastaİşlemleri);
        }

        private void btn_hastaİşlemleri_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(btn_hastaİşlemleri);
        }

        private void btn_ilaçİşlemleri_MouseHover(object sender, EventArgs e)
        {
            MouseHover(btn_ilaçİşlemleri);
        }

        private void btn_ilaçİşlemleri_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(btn_ilaçİşlemleri);
        }

        private void btn_reçeteİşlemleri_MouseHover(object sender, EventArgs e)
        {
            MouseHover(btn_reçeteİşlemleri);
        }

        private void btn_reçeteİşlemleri_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(btn_reçeteİşlemleri);
        }

        #endregion

        private void btn_EkranKapat_Click(object sender, EventArgs e)
        {
            pnl_işlemler.Controls.Clear();
            pnl_işlemler.Visible = false;
        }

        private void btn_hastaGüncelle_Click(object sender, EventArgs e)
        {
            AltFormİşlemGöster(new HastaGuncelle());
        }

        private void btn_hastaListele_Click(object sender, EventArgs e)
        {
            HastaAnaSayfa anaSayfa = new HastaAnaSayfa();
            anaSayfa.Listele();
            if (pnl_işlemler.Visible == true)
                pnl_işlemler.Visible = false;
        }

        private void btn_ilaçKaydet_Click(object sender, EventArgs e)
        {
            AltFormİşlemGöster(new IlacKayit());

        }

        private void btn_ilaçGüncelle_Click(object sender, EventArgs e)
        {
            AltFormİşlemGöster(new IlacGuncelle());

        }
        IlacAnaSayfa ilaç = new IlacAnaSayfa();
        private void btn_ilaçListele_Click(object sender, EventArgs e)
        {
            ilaç.Listele();
            if (pnl_işlemler.Visible == true)
                pnl_işlemler.Visible = false;

        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            AltMenüSakla();
            AltFormGöster(new AnaPanel());
        }

        private void btn_uygulamaKapat_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("ÇIKIŞ YAPMAK İSTEDİĞİNİZDEN EMİNMİSİNİZ", "ÇIKIŞ", MessageBoxButtons.OKCancel);
            if (sonuc == DialogResult.OK)
            {
                Application.Exit();
            }

        }
        // uygulamayı tam ekran yapar
        private void btn_maksimize_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_satısİslemleri_Click(object sender, EventArgs e)
        {
            AltMenüSakla();
            AltFormGöster(new Satis());
            AltMenüSakla();
        }

        private void lbl_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
