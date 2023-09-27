using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek2
{
    public interface ISekil
    {
        public string SekilIsmi { get; }
        int AlanHesapla();
        int CevreHesapla();
    }
}
