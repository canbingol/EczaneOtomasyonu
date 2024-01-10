using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyon.Forms.Hasta
{
    internal interface IHastaİslemleri
    {
        void AlanlariTemizle(TextBox txtTcno, TextBox txtAd, TextBox txtSoyad, TextBox txtTelNo, TextBox txtAdres);
        void HataMesajlariGoster(TextBox txtTcno, TextBox txtAd, TextBox txtSoyad, TextBox txtTelNo, TextBox txtAdres, Label lblTcHata, Label lblAdHata, Label lblSoyadHata, Label lblTelHata, Label lblAdresHata);
        int TcVarmi(string tcno);
    }
}
