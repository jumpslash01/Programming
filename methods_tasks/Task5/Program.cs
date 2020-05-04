using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int[] numbers = new int[5];

            numbers[0] = int.Parse(Console.ReadLine());
            numbers[1] = int.Parse(Console.ReadLine());
            numbers[2] = int.Parse(Console.ReadLine());
            numbers[3] = int.Parse(Console.ReadLine());
            numbers[4] = int.Parse(Console.ReadLine());

            for(int i= 0; i < numbers.Length; i++){
                total = total + numbers[i];
            }

            Console.WriteLine(total);
        }
    }
}
