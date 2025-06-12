using System;
using System.Collections.Generic;
using System.Text;

namespace KPConsole
{
    class Fibonacci
    {
        /// <summary>
        /// KP : Class Constructor : Fibonacci !
        /// </summary>
        public Fibonacci()
        {
            ///KP : In mathematics, the Fibonacci sequence is a sequence 
            ///in which each element is the sum of the two elements that precede it. 
            ///Numbers that are part of the Fibonacci sequence are known as 
            ///Fibonacci numbers, commonly denoted Fn . 
            ///Many writers begin the sequence with 0 and 1, 
            ///although some authors start it from 1 and 1[1][2] and 
            ///some (as did Fibonacci) from 1 and 2. Starting from 0 and 1, 
            ///the sequence begins
            ///Example : [  0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ... ]
            Console.WriteLine("KP : Fibonacci : Print Fibonacci Series !");
        }

        public static void PrintFibonacciSeries(Int64 n)
        {

            Int64 first  = 0,  second = 1;

            Console.WriteLine("KP : Fibonacci Series " + n + " Elements : " );
            Console.Write    ("     [ ");

            for (Int64 i = 0; i < n; ++i)
            {

                Int64 next = first + second;
                first = second;
                second = next;

                Console.Write(first + ", ");
            }

            Console.Write(" ] ");
            Console.WriteLine("");

        }
        

    }
}
