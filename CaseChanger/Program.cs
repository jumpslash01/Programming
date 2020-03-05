using System;

namespace Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            string text = "";


            while (text != "quit")
            {
                Console.WriteLine("Enter some text: ");
                text = Console.ReadLine();
                int length = text.Length;
                while (a < length)
                {
                    if (Char.IsLower(text[a]))
                    {
                        Console.Write(char.ToUpper(text[a]));
                        a++;
                    }
                    else
                    {
                        Console.Write(char.ToLower(text[a]));
                        a++;
                    }
                }
                a = 0;
                Console.WriteLine();
            }
        }
    }
}
