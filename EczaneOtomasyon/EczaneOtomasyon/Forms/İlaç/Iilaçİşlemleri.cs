using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyon.Forms.İlaç
{
    internal interface Iilaçİşlemleri
    {
        void AlanlariTemizle(TextBox txtfiyat, TextBox txtad,  NumericUpDown txtadet,  TextBox txtbarkod);
        void HataMesajlariGoster(TextBox txtfiyat ,TextBox txtad ,   ComboBox txtkategori, TextBox txtbarkod, Label adhata, Label kategorihata, Label barkodhata, Label fiyathat);
        int  İlaçvarmı(string barkod);
    }
}
