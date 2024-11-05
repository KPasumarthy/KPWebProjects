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

            ///Question
            ///

            // Getting the string form of the current date
            // in a format, i.e, 12/04/2021 07:12 PM          
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            String input = "KP: Today's Date : " + currentDate;
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



///*/////KP : Question : PrintFizzBuzz
//Int64 n = 15;
////PrintFizzBuzz(n);
//FizzBuzz.PrintFizzBuzz(n);
//FizzBuzz.PrintFizzBuzzComplex(n);
///////KP : Question : PrintFizzBuzz///*/
