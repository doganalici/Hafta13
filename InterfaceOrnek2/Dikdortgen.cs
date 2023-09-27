using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek2
{
    public class Dikdortgen : ISekil
    {
        public int UKenar;
        public int KKenar;

        public string SekilIsmi =>"Dikdörtgen";

        public int AlanHesapla()
        {
            int alan = UKenar * KKenar;
            return alan;
        }

        public int CevreHesapla()
        {
            int cevre = 2 * (KKenar + UKenar);
            return cevre;
        }
    }
}
