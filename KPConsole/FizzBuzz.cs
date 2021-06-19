using System;
using System.Collections.Generic;
using System.Text;

namespace KPConsole
{
    class FizzBuzz
    {
        /// <summary>
        /// KP : Class Constructor : FizzBuzz !
        /// </summary>
        public FizzBuzz()
        {
            Console.WriteLine("KP : FizzBuzz !");
        }

        public static void PrintFizzBuzz(Int64 n)
        {
            Int64 x = 1;
            while (x <= n)
            {
                Int64 r3 = (Int64)x % 3;
                Int64 r5 = (Int64)x % 5;
                Console.Write(x + " ");
                if (r3 == 0)
                    Console.Write("Fizz");

                if (r5 == 0)
                    Console.Write("Buzz");

                Console.WriteLine();
                x++;
            }
        }

        public static void PrintFizzBuzzComplex(Int64 n)
        {

            Int64 x = 1;
            while (x <= n)
            {
                if (x % 3 == 0 && x % 5 == 0)
                    Console.WriteLine(x + " FizzBuzz");
                else
                {
                    if (x % 3 == 0 && x % 5 != 0)
                        Console.WriteLine(x + " Fizz");
                    else
                    {
                        if (x % 3 != 0 && x % 5 == 0)
                            Console.WriteLine(x + " Buzz");
                        else
                            Console.WriteLine(x);
                    }
                }

                x++;
            }

        }

    }
}
