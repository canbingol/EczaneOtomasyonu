﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyon.Forms.İlaç
{
    internal interface Iilaçİşlemleri
    {
        void AlanlariTemizle(TextBox txtfiyat, TextBox txtad, TextBox txtfirma, NumericUpDown txtadet,  TextBox txtbarkod);
        void HataMesajlariGoster(TextBox txtfiyat ,TextBox txtad , TextBox txtfirma,  ComboBox txtkategori, TextBox txtbarkod, Label adhata, Label firmaHata, Label adetHata, Label kategorihata, Label barkodhata, Label fiyathat);
        int  İlaçvarmı(string barkod);
    }
}
