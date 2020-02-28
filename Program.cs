using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name: ");
            string first = Console.ReadLine();
            Console.WriteLine("Please enter your surname: ");
            string second = Console.ReadLine();
            Console.WriteLine("Enter your student ID: ");
            string ID = Console.ReadLine();


            Console.WriteLine("Enter year of birth: ");
            int birth =  int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the current year: ");
            int year = int.Parse(Console.ReadLine());
            int age = year - birth;


            Console.WriteLine("Hi, " + first + " " + second + ". You are " + age + "!");
            Console.ReadLine();
        }
    }
}
