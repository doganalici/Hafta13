using System;

namespace StaticOrnek1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            Console.WriteLine(Test.statik);
            Test test1 = new Test();
            Test test2 = new Test();
            Console.WriteLine(Test.statik);

            Test.statik = 0;
            Console.WriteLine(Test.statik);
            Console.ReadKey();
        }
    }
}
