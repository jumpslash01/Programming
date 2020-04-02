using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            Console.WriteLine("Please enter number");
            int lines = int.Parse(Console.ReadLine());


            for (int row = 0; row < lines; row++)
            {
                for (int column = 0; column < x; column++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
                x++;
            }
        }
    }
}
