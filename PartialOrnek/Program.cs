using System;

namespace PartialOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen(5,10);
            dikdortgen.BilgileriYazdir();
            Console.ReadKey();
        }
    }
}
