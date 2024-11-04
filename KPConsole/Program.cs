using System;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WebGrease.Css.Ast.Selectors;
using Microsoft.Ajax.Utilities;
using System.Collections;

namespace KPConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KP : Hello Kailash World!");

            ///*/////KP : Question : PrintFizzBuzz
            //Int64 n = 15;
            ////PrintFizzBuzz(n);
            //FizzBuzz.PrintFizzBuzz(n);
            //FizzBuzz.PrintFizzBuzzComplex(n);
            ///////KP : Question : PrintFizzBuzz///*/

            ///Question : ????
            ///

            String input = "{{{{(}}]]]}}{{}}}";
            bool output = TestFunction(input);

            ////KP : Console Wait to ReadLine
            Console.ReadLine();
        }


        static bool TestFunction(String input)
        {

            Console.WriteLine(input);

            return true;

        }


    }
}
