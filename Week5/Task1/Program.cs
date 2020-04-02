using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 5; row++)
            {
                for (int column = row; column < 5; column++)
                {
                   Console.Write("x");
                }
                Console.WriteLine();
    
            }
            Console.ReadKey();
        }
    }
}
