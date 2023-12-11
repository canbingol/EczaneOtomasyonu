using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyon.Forms.Satış
{
    public partial class SatışAnaSayfa : Form
    {
        public SatışAnaSayfa()
        {
            InitializeComponent();
        }

        private void BTN_Click(object sender, EventArgs e)
        {
            ReçeteSeç reçete = new ReçeteSeç();
            reçete.TopLevel = false;
            reçete.AutoScroll = true;
            panel1.Controls.Add(reçete);
            reçete.Show();
        }
    }
}
