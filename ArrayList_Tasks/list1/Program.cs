using System;
using System.Collections.Generic;

namespace list1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter in 5 digits: ");

            List<int> numsList = new List<int>();
            for (int x = 0; x < 5; x++)
            {
                numsList.Add(int.Parse(Console.ReadLine()));
            }
            for (int x = 0; x < numsList.Count; x++)
            {
                Console.WriteLine(numsList[x]);
            }

            Console.WriteLine("Please search for a digit: ");

            int digi = int.Parse(Console.ReadLine());
            bool numbcheck = false;

            for (int x = 0; x < numsList.Count; x++)
            {
                if (digi == numsList[x])
                {
                    numbcheck = true;
                }
            }

            if (numbcheck == true)
            {
                Console.WriteLine("This number " + digi + " is contained in the list.");
            }
            else
            {
                Console.WriteLine("This number " + digi + " is NOT contained in the list.");
            }

        }
    }
}
