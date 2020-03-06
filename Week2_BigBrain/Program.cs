using System;
using System.Collections.Generic;

namespace Week2_BigBrain {
    class Program {
        static void Main (string[] args) {

            List<User> users = new List<User>();

            users.Add(new User("tim", "password1"));
            users.Add(new User("bob", "password2"));
            users.Add(new User("fred", "password3"));
            users.Add(new User("bill", "password4"));
  
            Console.WriteLine("Username");
            string userInput = Console.ReadLine();

            Console.WriteLine("Password");
            string passInput = Console.ReadLine();
           
           
            User currentUser = users.Find(i => i.username == userInput);

            if (currentUser == null || currentUser.password != passInput)
            {
                Console.WriteLine("Invalid Login");
            }
            else
            {   
                Console.WriteLine("Login Successful");
            }


            /*
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
            */
        }
    }
}