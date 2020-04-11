using System;
using System.Collections.Generic;

namespace list3
{
    class Program
    {
        static void Main(string[] args)
        {
            //INITIALIZE
            string input = Console.ReadLine();
            List<string> stringList = new List<string>();
            
            //READ INPUTS
            while (input != "stop")
            {
                stringList.Add(input);
                input = Console.ReadLine();
            }
            
            //OUTPUT 
            stringList.Reverse();
            foreach(string name in stringList)
            {
                Console.WriteLine(name);
            }

        }
    }
}
