using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek2
{
    public class Ucgen : ISekil
    {
        public int Kenar1;
        public int Kenar2;
        public int Kenar3;
        public int Yukseklik;
        public string SekilIsmi
        {
            get
            {
                return "Üçgen";
            }
        }

        public int AlanHesapla()
        {
            int alan = (Kenar1 * Yukseklik) / 2;
            return alan;
        }

        public int CevreHesapla()
        {
            int cevre = Kenar1 + Kenar2 + Kenar3;
            return cevre;
        }
    }
}
