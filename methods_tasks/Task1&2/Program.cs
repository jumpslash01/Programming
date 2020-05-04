using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input name: ");
            string a = Console.ReadLine();
            DoStuff(a);
        }
        static void DoStuff(string x)
        {
            Console.WriteLine("Welcome Friend " + x);
            Console.WriteLine("Have a nice day");
        }
    }
}
