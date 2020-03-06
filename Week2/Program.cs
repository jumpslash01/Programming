using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Username then Password");
            string a = (Console.ReadLine());
            string b = (Console.ReadLine());
               
            if (a == "test")
            {
                if (b == "password")
                
                    Console.WriteLine("login successful!");
            }
            else Console.WriteLine("Login Failed");

        }
    }
}
