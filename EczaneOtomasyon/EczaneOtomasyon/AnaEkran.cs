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
        }
        Forms.Hasta.HastaAnaSayfa hasta = new Forms.Hasta.HastaAnaSayfa();
        Forms.İlaç.İlaçAnaSayfa ilaç = new Forms.İlaç.İlaçAnaSayfa();
        Forms.Stok.StokAnaSayfa stok = new Forms.Stok.StokAnaSayfa();

        private void btn_hastaİşlemleri_Click(object sender, EventArgs e)
        {
            panel_göster.Controls.Clear();
            hasta.TopLevel = false;
            hasta.AutoScroll = true;
            panel_göster.Controls.Add(hasta);
            ilaç.Hide();
            stok.Hide();
            hasta.Show();
        }

        private void btn_ilaçİşlemleri_Click(object sender, EventArgs e)
        {
            panel_göster.Controls.Clear();
            ilaç.TopLevel = false;
            ilaç.AutoScroll = true;
            panel_göster.Controls.Add(ilaç);
            hasta.Hide();
            stok.Hide();
            ilaç.Show();
        }
        private void btn_Stokİşlemleri_Click(object sender, EventArgs e)
        {
            panel_göster.Controls.Clear();
            stok.TopLevel = false;
            stok.AutoScroll = true;
            panel_göster.Controls.Add(stok);
            hasta.Hide();
            ilaç.Hide();
            stok.Show();
        }
        private void btn_çıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Buton kontrolleri
        new void MouseHover(Button btn)
        {
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }
        new void MouseLeave(Button btn)
        {
            btn.BackColor = Color.DodgerBlue;
            btn.ForeColor = Color.White;
        }

        private void btn_anaPanel_MouseHover(object sender, EventArgs e)
        {
            MouseHover(btn_anaPanel);
        }

        private void btn_anaPanel_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(btn_anaPanel);
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

        private void btn_Stokİşlemleri_MouseHover(object sender, EventArgs e)
        {
            MouseHover(btn_Stokİşlemleri);
        }

        private void btn_Stokİşlemleri_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(btn_Stokİşlemleri);
        }

        private void btn_satışİşlemleri_MouseHover(object sender, EventArgs e)
        {
            MouseHover(btn_satışİşlemleri);
        }

        private void btn_satışİşlemleri_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave(btn_satışİşlemleri);
        }
        #endregion


    }
}
