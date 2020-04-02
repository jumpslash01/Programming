using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter number");
            int x = int.Parse(Console.ReadLine());

            for (int row = 0; row < x; row++)
            {
                for (int column = row; column < x; column++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
