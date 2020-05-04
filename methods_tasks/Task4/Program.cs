using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            DoStuff(Console.ReadLine());
        }
        static void DoStuff(string text)
        {
            int b = text.Split(' ').Length - 1;

            Console.WriteLine("The number of spaces in the string is " + b);
        }
    }
}
