using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            
            for (int row = 0; row < 5; row++)
            {
                for (int column = 0; column < x; column++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
                x++;
            }
            Console.ReadKey();
        }
    }
}
