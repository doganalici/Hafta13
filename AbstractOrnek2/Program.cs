using System;

namespace AbstractOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Derived derived = new Derived();
            var derived = new Derived();
            derived.AbstractMetot();
            Console.WriteLine($"X : {derived.X}");
            Console.WriteLine($"Y : {derived.Y}");

            Console.ReadKey();
        }
    }
}
