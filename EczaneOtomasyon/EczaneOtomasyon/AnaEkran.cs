using EczaneOtomasyon.Forms.Hasta;
using EczaneOtomasyon.Forms.İlaç;
using EczaneOtomasyon.Forms.Reçete;
using EczaneOtomasyon.Forms.Stok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyon
{
    public partial class AnaEkran : Form
    {
        static public int kapasite = 3000;
        public AnaEkran()
        {
            InitializeComponent();
            panelAyarları();
        }

        #region Tıklama işlemleri 
        private void btn_hastaİşlemleri_Click(object sender, EventArgs e)
        {
            AltMenüSakla();
            AltFormGöster(new Forms.Hasta.HastaAnaSayfa());
            AltMenüGöster(pnl_hasta);
        }

        private void btn_anaSayfa_Click_1(object sender, EventArgs e)
        {
            AltMenüSakla();
        }
        private void btn_hastaKaydet_Click(object sender, EventArgs e)
        {
            AltFormİşlemGöster(new HastaKayıt());
        }

        private void btn_ilaçİşlemleri_Click(object sender, EventArgs e)
        {
            AltMenüSakla();
            AltFormGöster(new İlaçAnaSayfa());
            AltMenüGöster(pnl_ilaç);
        }
        private void btn_reçeteİşlemleri_Click(object sender, EventArgs e)
        {
            AltFormGöster(new ReçeteAnaSayfa());

            AltMenüSakla();

        }

        private void btn_stokİşlemleri_Click(object sender, EventArgs e)
        {
            AltMenüSakla();
            AltFormGöster(new StokAnaSayfa());
            AltMenüSakla();

        }

        private void btn_satış_Click(object sender, EventArgs e)
        {
            AltMenüSakla();

        }
        #endregion

        #region panel metodları
        void panelAyarları()
        {
            pnl_ilaç.Visible = false;
            pnl_hasta.Visible = false;
        }
        void AltMenüSakla()
        {
            if (pnl_hasta.Visible == true)
                pnl_hasta.Visible = false;
            if (pnl_ilaç.Visible == true)
                pnl_ilaç.Visible = false;
            if (pnl_işlemler.Visible == true)
                pnl_işlemler.Visible = false;
        }
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

        void AltFormİşlemGöster(Form altForm)
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
            altForm.BringToFront();
            altForm.Show();
        }



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

        private void btn_stokİşlemleri_MouseHover(object sender, EventArgs e)
        {
            MouseHover(btn_stokİşlemleri);
        }

        private void btn_stokİşlemleri_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(btn_stokİşlemleri);
        }

        private void btn_satış_MouseHover(object sender, EventArgs e)
        {
            MouseHover(btn_satış);
        }

        private void btn_satış_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(btn_satış);
        }


        #endregion

        private void btn_EkranKapat_Click(object sender, EventArgs e)
        {
            pnl_işlemler.Controls.Clear();
            pnl_işlemler.Visible = false;
        }

        private void btn_hastaGüncelle_Click(object sender, EventArgs e)
        {
            AltFormİşlemGöster(new HastaGüncelle());

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
            AltFormİşlemGöster(new İlaçKayıt());

        }

        private void btn_ilaçGüncelle_Click(object sender, EventArgs e)
        {
            AltFormİşlemGöster(new İlaçGüncelle());

        }
        İlaçAnaSayfa ilaç = new İlaçAnaSayfa();
        private void btn_ilaçListele_Click(object sender, EventArgs e)
        {
            ilaç.Listele();
            if (pnl_işlemler.Visible == true)
                pnl_işlemler.Visible = false;

        }
    }
}
