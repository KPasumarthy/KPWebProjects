using System;
using System.Collections.Generic;
using System.Text;

namespace KPConsole
{
    class Catalogs
    {
        /// <summary>
        /// KP : Class Constructor : Catalogs !
        /// </summary>
        public Catalogs()
        {
            Console.WriteLine("KP : Catalogs !");
        }

        public static void PrintCatalogs(Int64 n)
        {

            Console.WriteLine("KP : Catalogs : PrintCatalogs !");

            Int64 x = 1;
            while (x <= n)
            {
                Int64 r3 = (Int64)x % 3;
                Int64 r5 = (Int64)x % 5;
                Console.Write(x + " ");
                if (r3 == 0)
                    Console.Write("KP : Catalogs : PrintCatalogs : Fizz");

                if (r5 == 0)
                    Console.Write("KP : Catalogs : PrintCatalogs : Buzz");

                Console.WriteLine();
                x++;
            }
        }


    }
}
