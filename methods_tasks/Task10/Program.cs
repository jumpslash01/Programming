using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number chain");
            string chain = Console.ReadLine();
            double total = 0;
            
            for(int i = 0; i<chain.Length;i++){
                char x = chain[i];
                total = total + Char.GetNumericValue(x);
            }

            Console.WriteLine(total);

        }
    }
}
