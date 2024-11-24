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
            // in a format, i.e, 07/27/2024 07:29:00 AM          
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:sss tt");
            String input = "KP : Today's Date : " + currentDate;
            bool output = TestFunction(input);

            ////KP : Console Wait to ReadLine
            Console.ReadLine();
        }

        static bool TestFunction(String input)
        {

            Console.WriteLine(input);

            /////*/////KP : Question : PrintFizzBuzz
            //Int64 n = 15;
            ////PrintFizzBuzz(n);
            //FizzBuzz.PrintFizzBuzz(n);
            //FizzBuzz.PrintFizzBuzzComplex(n);
            ///////KP : Question : PrintFizzBuzz///*/


            ///*/////KP : Question : Interview Questions
            InterviewQuestions.PrintInterviewQuestions();
            ///*/////KP : Question : Interview Questions
            ///


            ///////*/////KP : Question : Interview Questions : DemoStatic
            //DemoStatic t = new DemoStatic();
            //t.Print();
            ///////*/////KP : Question : Interview Questions : DemoStatic
            /////


            return true;
        }

    }
}




