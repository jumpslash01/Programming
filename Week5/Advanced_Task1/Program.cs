using System;

namespace Advanced_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            for (int row = 0; row < 6; row++)
            {

                for (int space = 0; space < row; space++)
                {
                    Console.Write(" ");
                }
                for (int column = x; column < 11; column++)
                {
                    Console.Write("x");
                }
                
                Console.WriteLine();
                x = x + 2; 
            }
        }
    }
}
