using System;

namespace Week3 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");

            /*
            for (int x = 1; x < 101; x++) {
                int b = 0;

                int div_1 = x % 3;
                int div_2 = x % 5;

                if(div_1 == 0){b = b + 1;}
                if(div_2 == 0){b = b + 2 ;}

                if(b == 1)
                {Console.WriteLine("Fizz");}
                else if(b == 2){Console.WriteLine("Buzz");}
                else if(b == 3){Console.WriteLine("FizzBuzz");}
                else {Console.WriteLine(x);}


                if (div_1 == 0 && div_2 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (div_1 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (div_2 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else{
                    Console.WriteLine (x);
                }
            */

            int count = 0;
            int div_3 = 3;
            int div_5 = 5;
            int multi_1 = 1;
            int multi_2 = 1;
                        

            while (count < 101) {
                if (count == div_3 * multi_1 && count == div_5 * multi_2)
                {
                    Console.WriteLine("FizzBuzz");
                    multi_1++ ;
                    multi_2++ ;
                    }
                    else if (count == (div_3 * multi_1)) 
                    {
                        Console.WriteLine("Fizz");
                        multi_1++ ;
                    }
                        else if (count == (div_5 * multi_2))
                        {
                            Console.WriteLine("buzz");
                            multi_2++ ;    
                        }
                            else {Console.WriteLine(count);}
                            count++;




            }

        }

    }
}