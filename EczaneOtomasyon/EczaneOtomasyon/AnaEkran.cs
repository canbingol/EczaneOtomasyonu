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
        public AnaEkran()
        {
            InitializeComponent();
        }
        Forms.Hasta.HastaAnaSayfa hasta = new Forms.Hasta.HastaAnaSayfa();
        Forms.İlaç.İlaçAnaSayfa ilaç = new Forms.İlaç.İlaçAnaSayfa();


        private void btn_hastaİşlemleri_Click(object sender, EventArgs e)
        {
            panel_göster.Controls.Clear();

            hasta.TopLevel = false;
            hasta.AutoScroll = true;
            panel_göster.Controls.Add(hasta);

            ilaç.Hide();
            hasta.Show();
        }

        private void btn_ilaçİşlemleri_Click(object sender, EventArgs e)
        {
            panel_göster.Controls.Clear();

            ilaç.TopLevel = false;
            ilaç.AutoScroll = true;
            panel_göster.Controls.Add(ilaç);

            hasta.Hide();
            ilaç.Show();
        }

    }
}
