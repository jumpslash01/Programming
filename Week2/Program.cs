using System;

namespace Week2 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Please enter Username then Password");
            string a = (Console.ReadLine ());
            string b = (Console.ReadLine ());

            if (a == "Zak") {
                if (b == "1234")
                    Console.WriteLine ("login successful!");
                else Console.WriteLine ("Login Failed");
            } else if (a == "Liz") {
                if (b == "2345")
                    Console.WriteLine ("login successful!");
                else Console.WriteLine ("Login Failed");
            } else if (a == "Dan") {

                if (b == "3564")
                    Console.WriteLine ("login successful!");
                else Console.WriteLine ("Login Failed");
            } else if (a == "Phil") {
                if (b == "4567")
                    Console.WriteLine ("login successful!");
                else Console.WriteLine ("Login Failed");
            } else if (a == "Dirk") {
                if (b == "3546")
                    Console.WriteLine ("login successful!");
                else Console.WriteLine ("Login Failed");
            } else if (a == "Joe") {
                if (b == "4876")
                    Console.WriteLine ("login successful!");
                else Console.WriteLine ("Login Failed");
            } else if (a == "Sally") {
                if (b == "6851")
                    Console.WriteLine ("login successful!");
                else Console.WriteLine ("Login Failed");
            }
        }

    }
}