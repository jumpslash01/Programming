using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayMake();
        }
        static void ArrayMake()
        {
            int[] MyArray = { 5, 7, 3, 2, 9 };
            int result = 0;
            foreach (int i in MyArray)
            {
                result = result + i;
            }
            Console.WriteLine(result);
        }
    }
}
