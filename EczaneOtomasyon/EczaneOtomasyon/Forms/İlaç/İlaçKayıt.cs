using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyon.Forms.İlaç
{
    public partial class İlaçKayıt : Form, IVeriİslemleri
    {
        public İlaçKayıt()
        {
            InitializeComponent();
        }

        public void AlanlariTemizle(TextBox txtTcno, TextBox txtAd, TextBox txtSoyad, TextBox txtTelNo, TextBox txtAdres)
        {
          
        }

        public void HataMesajlariGoster(TextBox txtTcno, TextBox txtAd, TextBox txtSoyad, TextBox txtTelNo, TextBox txtAdres, Label lblTcHata, Label lblAdHata, Label lblSoyadHata, Label lblTelHata, Label lblAdresHata)
        {
            
        }
    }
}
