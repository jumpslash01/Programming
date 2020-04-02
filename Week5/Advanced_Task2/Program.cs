using System;

namespace programming
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int x = (lines * 2) - 1;
            int space = lines;
            int xmax = x;
            int spacemax = space;

            while(lines > 0)
            {
                while(space > lines)
                {
                    Console.Write(" ");
                    space = space - 1;
                }
                while(x > 0)
                {
                    Console.Write("x");
                    x = x - 1;
                }
                Console.WriteLine();
                lines = lines - 1;

                xmax = xmax - 2;
                x = xmax;
                space = spacemax;
            }  
        }
    }
}
