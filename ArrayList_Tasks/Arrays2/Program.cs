using System;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            int[] testarray = { 34, 5, 67, 1, 99, 34, 44, 78, 34, 0 };
            foreach (int i in testarray)
            {
                sum = sum + i; 
            }
            Console.WriteLine(sum);
        }
    }
}
