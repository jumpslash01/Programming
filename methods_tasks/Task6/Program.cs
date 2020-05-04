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
            Console.WriteLine("Now the 1st number is " + b + ", and the 2nd number is " + a);
        }
    }
}
