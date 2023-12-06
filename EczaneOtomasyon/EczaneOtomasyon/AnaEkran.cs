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

        

        private void btn_hastaİşlemleri_Click(object sender, EventArgs e)
        {
            Forms.Hasta.HastaAnaSayfa anaSayfa = new Forms.Hasta.HastaAnaSayfa();
            anaSayfa.TopLevel = false;
            anaSayfa.AutoScroll = true;
            panel_göster.Controls.Add(anaSayfa);
            anaSayfa.Show();
        }

        private void btn_ilaçİşlemleri_Click(object sender, EventArgs e)
        {
            Forms.İlaç.İlaçAnaSayfa ilaç = new Forms.İlaç.İlaçAnaSayfa();
            ilaç.TopLevel = false;
            ilaç.AutoScroll = true;
            panel_göster.Controls.Add(ilaç);
            ilaç.Show();
            
        }
    }
}
