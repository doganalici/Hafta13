using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialOrnek
{
    public partial class Dikdortgen
    {
        public int CevreHesapla()
        {
            return 2 * (en + boy);
        }

        public int AlanHesapla()
        {
            return en * boy;
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine("*** DİKDÖRTGEN BİLGİLERİ ***");
            Console.WriteLine($"En    : {en}, Boy : {boy}");
            Console.WriteLine($"Alan  : {AlanHesapla()}");
            Console.WriteLine($"Çevre : {CevreHesapla()}");
            
        }
    }
}
