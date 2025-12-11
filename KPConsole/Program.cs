using System;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WebGrease.Css.Ast.Selectors;
using Microsoft.Ajax.Utilities;
using System.Collections;
using Newtonsoft.Json;
using System.Net;

namespace KPConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("KP : Hello World !");


            /////KP : Question : 0
            ///Console.WriteLine("KP : Hello Kailash World!");
            // Getting the string form of the current date
            // in a format, i.e, 07/27/2024 07:29:00 AM          
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:sss tt");
            String input = "KP : Today's Date : " + currentDate;
            Console.WriteLine(input);


            ////Microsoft .NET  Data-Types int & Strings  : Immutable
            Console.WriteLine("KP : Microsoft .NET Data-Types int & Strings ' : " + 10 + 20);
            Console.WriteLine(10 + 20 + "KP : Microsoft .NET Data-Types int & Strings ' : " + 10 + 20);
            Console.WriteLine(10 + 20 + "KP : Microsoft .NET  Data-Types int & Strings ' : " + 10 + 20 + 'a' + "bcd");

            //bool iskpWUSemaphoreFileRead = readkpWUSemaphoreFile();
            //Console.WriteLine("KP : iskpWUSemaphoreFileRead =  " + iskpWUSemaphoreFileRead);

            Console.ReadLine();
            ///////KP : Question : 0

        }

        static void Main00(string[] args)
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


        //static void Main()
        //{
        //    //    ////KP : Console WriteLine
        //    Console.WriteLine("KP : Hello Kailash World!");

        //    //    ////KP : Console Wait to ReadLine
        //    Console.ReadLine();
        //}


        static bool TestFunction(String input)
        {

            Console.WriteLine(input);

            ///////*/////KP : Question : PrintFizzBuzz
            Int64 n = 20;
            //PrintFizzBuzz(n);
            FizzBuzz.PrintFizzBuzz(n);
            FizzBuzz.PrintFizzBuzzComplex(n);
            /////////KP : Question : PrintFizzBuzz///*/


            /////////*/////KP : Question : Interview Questions
            InterviewQuestions.PrintInterviewQuestions();
            /////////*/////KP : Question : Interview Questions
            /////////


            ///////////*/////KP : Question : Interview Questions : DemoEnum
            DemoEnum.PrintDemoEnum();
            ///////////*/////KP : Question : Interview Questions : DemoEnum
            /////////


            /////////*/////KP : Question : Interview Questions : DemoStatic
            DemoStatic t = new DemoStatic();
            t.Print();
            /////////*/////KP : Question : Interview Questions : DemoStatic
            ///////


            /////*/////KP : Question : Interview Questions : PrintValue
            Console.WriteLine("KP : InterviewQuestion : What is the Ouput of the PrintValue Program ? ");
            PrintValue t1 = new PrintValue();
            t1.Print();
            /////*/////KP : Question : Interview Questions : PrintValue
            ///


            /////*/////KP : Question : Interview Questions : Print Fibonacci Series
            Console.WriteLine("KP : InterviewQuestion : Print Fibonacci Series for n Elements ");
            //Int64 n = 25;
            Fibonacci.PrintFibonacciSeries(n);

            /////*/////KP : Question : Interview Questions : Print Fibonacci Series
            ///



            ///////*/////KP : Question : PrintIntegers.PrintIntegerValue()
            PrintIntegers.PrintIntegerValue();
            Console.WriteLine("KP : PrintIntegers.GetEven() : Even Numbers : [ " + String.Join(", ", PrintIntegers.GetEven(n).ToArray()) + " ]");
            Console.WriteLine("KP : PrintIntegers.GetOdd()  : Odd Numbers  : [ " + String.Join(", ", PrintIntegers.GetOdd(n).ToArray()) + " ]");
            /////////KP : Question : PrintIntegers.PrintIntegerValue()///*/




            return true;
        }

        static bool readkpWUSemaphoreFile()
        {
            bool iskpWUSemaphoreFileRead = false;

            //// KP : Read a Legacy C File and Fix the Bug : 
            String line;
            try
            {

                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string kpWUSemaphoreFilePath = null;

                Console.WriteLine("Current Working Directory: basePath : " + basePath);

                string currentDirectory = Directory.GetCurrentDirectory();
                Console.WriteLine("Current Working Directory: " + currentDirectory);



                // Get the current working directory
                //string currentDirectory = Directory.GetCurrentDirectory();
                Console.WriteLine($"Current Directory: {currentDirectory}");

                // Split the directory path using the platform-specific directory separator character
                string[] directoryParts = currentDirectory.Split(Path.DirectorySeparatorChar);

                Console.WriteLine("\nDirectory Parts:");
                foreach (string part in directoryParts)
                {
                    if (!string.IsNullOrEmpty(part)) // Filter out empty strings that might result from splitting
                    {
                        Console.WriteLine(part);
                    }
                }


                // Remove the last 3 folders from the directory path using the platform-specific directory separator character
                string[] kpWUSemaphoreFilePathDirParts = currentDirectory.Split(Path.DirectorySeparatorChar).Take(directoryParts.Length - 3).ToArray(); ;
                Console.WriteLine("\nKPWUSemaphoreFilePathDirectory Parts:");
                foreach (string part in kpWUSemaphoreFilePathDirParts)
                {
                    if (!string.IsNullOrEmpty(part)) // Filter out empty strings that might result from splitting
                    {
                        //Console.WriteLine(part);
                        //kpWUSemaphoreFilePath = kpWUSemaphoreFilePath + @"\" + part;
                        kpWUSemaphoreFilePath += part + @"\";
                        Console.WriteLine(kpWUSemaphoreFilePath);
                    }
                }


                string sourcePath = kpWUSemaphoreFilePath + "\\KPWUSemaphore.txt";

                //Pass the file path and file name to the StreamReader constructor
                //StreamReader sr = new StreamReader("C:\\Projects\\KPWebProjects\\KPConsole\\KPWUSemaphore.txt");

                StreamReader sr = new StreamReader(kpWUSemaphoreFilePath + "\\KPWUSemaphore.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();

                iskpWUSemaphoreFileRead = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            return iskpWUSemaphoreFileRead;

        }
    }
}

