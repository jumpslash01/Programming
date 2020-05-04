using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("The fibonacci series of " + a + " is: ");
            ArrayMake(a);
        }

        static void ArrayMake(int target)
        {
            int num1 = 0;
            int num2 = 1;
            int result = num1 + num2;

            Console.Write(num1 + " ");

            while(result < target)
            {
                Console.Write(result + " ");
                result = num1 + num2;
                num1 = num2;
                num2 = result;
                
            }
        }
    }
}
