using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool primel = false;

            int x = int.Parse(Console.ReadLine());
            if (x == 2)
                primel = true;
            else
            {
                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        primel = true;
                    }
                }
            }
            if (primel == true)
            {
                Console.WriteLine(x + " is a prime number");
            }
            else Console.WriteLine(x + " is not a prime number");


        }
    }
}
