using System;

namespace Week2_BigBrain {
    class Program {
        static void Main (string[] args) {
            string[] users = { "Zak", "Liz", "Dan", "Phil", "Dirk", "Joe", "Sally" };
            string[] pass = { "1234", "2345", "3564", "4567", "3546", "4876", "6851" };

            string username = Console.ReadLine ();
            string password = Console.ReadLine ();

            foreach (string name in users) {
                if (username == name) {
                    int b = Array.IndexOf (users, username);
                    Console.WriteLine(b);

                    if (password == pass[b]) {
                        Console.WriteLine ("There is a success");
                        System.Environment.Exit (1);
                    }
                }
            }
            Console.WriteLine ("Fail");
        }
    }
}