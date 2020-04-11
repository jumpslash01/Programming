using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = new string[5];
            int x = 0;

            Console.WriteLine("Please enter 5 names");

            while (x < 5)
            {
                cars[x] = Console.ReadLine();
                x++;
            }

            foreach (string i in cars)
            {

                Console.WriteLine("Hello " + i);
            }
        }
    }
}
