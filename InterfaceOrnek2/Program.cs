using System;

namespace InterfaceOrnek2
{
    class Program
    {

        static void BilgileriGetir(ISekil sekil)
        {
            Console.WriteLine("**** ŞEKİL BİLGİLERİ ****");
            Console.WriteLine(sekil.SekilIsmi);
            Console.WriteLine($"Çevre : {sekil.CevreHesapla()}");
            Console.WriteLine($"Alan  : {sekil.AlanHesapla()}");
        }
        static void Main(string[] args)
        {
            
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KKenar = 3;
            dikdortgen.UKenar = 5;
            BilgileriGetir(dikdortgen);

            Console.WriteLine("---------------------------");
            Kare kare = new Kare();
            kare.kenar = 6;
            BilgileriGetir(kare);
            Console.WriteLine("---------------------------");

            Ucgen ucgen = new Ucgen()
            {
                Kenar1 = 6,
                Kenar2 = 8,
                Kenar3 = 10,
                Yukseklik = 12
            };
            ucgen.AlanHesapla();
            ucgen.CevreHesapla();
            BilgileriGetir(ucgen);
            Console.ReadKey();
        }
    }
}
