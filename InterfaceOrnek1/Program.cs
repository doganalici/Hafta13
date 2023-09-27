using System;

namespace InterfaceOrnek1
{
    class Program
    {
        static void PrintInfo(IInfo kisi)
        {
            Console.WriteLine("---- KİŞİ BİLGİLERİ -----\n");
            Console.WriteLine($"Adı  : {kisi.GetName()}");
            Console.WriteLine($"Yaşı : {kisi.GetAge()}");
        }
        static void Main(string[] args)
        {
            Test test = new Test();
            test.Name = "Doğan";
            test.Age = 25;
            PrintInfo(test);

            Console.WriteLine("\n--------------------------\n");

            Detay detay = new Detay();
            detay.FirstName = "Doğan";
            detay.LastName = "ALICI";
            detay.Age = 25;

            PrintInfo(detay);
            Console.ReadKey();
        }
    }
}
