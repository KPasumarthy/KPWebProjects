using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KPConsole
{
    class PrintIntegers
    {

        public static void PrintIntegerValue()
        {
            Console.WriteLine("KP : PrintIntegers.PrintIntegerValue () ");
            int x = 5;
            int y = 10;
            Console.WriteLine($"KP : PrintIntegers.PrintIntegerValue() : Sum : {Add(x, y)}");


            //    ////KP : Console Wait to ReadLine
            //Console.ReadLine();
        }

        public static List<int> GetEven(Int64 n)
        {
            // Initialize the list of numbers
            List<int> listofNumbers = Enumerable.Range(1, (int)n).ToList();

            // Filter even numbers
            var listofallEvenNumbers = (from m in listofNumbers
                                        where m % 2 == 0
                                        orderby m
                                        select m).ToList();

            return listofallEvenNumbers;
        }

        public static List<int> GetOdd(Int64 n)
        {
            // Initialize the list of numbers
            List<int> listofNumbers = Enumerable.Range(1, (int)n).ToList();

            // Filter Odd numbers
            var listofallOddNumbers = (from m in listofNumbers
                                        where m % 2 != 0
                                        orderby m
                                        select m).ToList();

            return listofallOddNumbers;
        }

        static int Add(int a, int b)
        {
            a = 20;
            return a + b;
        }

    }
}
