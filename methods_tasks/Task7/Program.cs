using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            ArrayMake(a, b);
        }

        static void ArrayMake(int a, int b)
        {
            Console.WriteLine(Math.Pow(a, b));
        }
    }
}
