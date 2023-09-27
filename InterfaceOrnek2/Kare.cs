using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek2
{
    class Kare : ISekil
    {
        public int kenar;

        public string SekilIsmi => "Kare";

        public int AlanHesapla()
        {
            int alan = kenar * kenar;
            return alan;
        }

        public int CevreHesapla()
        {
            int cevre = 4 * kenar;
            return cevre;
        }
    }
}
