using System;

namespace AbstractOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            // abstract class ya da interface den nesne oluşturulamaz.
            // AbstractClass abs = new AbstractClass();

            Turetilmis turetilmis = new Turetilmis();
            Console.WriteLine(turetilmis.IkiSayiTopla(4, 5));
            Console.WriteLine(turetilmis.IkiSayiCarp(4, 5));
            Console.ReadKey();
        }
    }
}
