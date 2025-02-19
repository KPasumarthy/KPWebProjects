﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KPConsole
{
    class InterviewQuestions
    {

        /// <summary>
        /// KP : Class Constructor : InterviewQuestions !
        /// </summary>
        public InterviewQuestions()
        {
            Console.WriteLine("KP : InterviewQuestions !");
        }


        public static void PrintInterviewQuestions()
        {

            // Getting the string form of the current date
            // in a format, i.e, 07/27/2024 07:29:00 AM          
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:sss tt");
            String input = "KP : Today's Date : " + currentDate;
            Console.WriteLine("KP : InterviewQuestions ! : Today's Date : " + currentDate);


            ///*/////KP : Question : PrintFizzBuzz
            Int64 n = 15;
            //PrintFizzBuzz(n);
            FizzBuzz.PrintFizzBuzz(n);
            FizzBuzz.PrintFizzBuzzComplex(n);
            /////KP : Question : PrintFizzBuzz///*/
            ///



            ///////*/////KP : Question : Interview Questions : DemoEnum
            DemoEnum.PrintDemoEnum();
            ///////*/////KP : Question : Interview Questions : DemoEnum
            /////



            /////*/////KP : Question : Interview Questions : DemoStatic
            Console.WriteLine("KP : InterviewQuestion : What is the Ouput of the DemoStatic Program ? ");
            DemoStatic t = new DemoStatic();
            t.Print();
            /////*/////KP : Question : Interview Questions : DemoStatic
            ///




            /* KP : Hacker Rank Questions : Q & A 
            Alex works at a clothing store.There is a large pile of socks that must be paired by color for sale.Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.

            For example, there are  socks with colors.There is one pair of color  and one of color . There are three odd socks left, one of each color. The number of pairs is .

            Function Description

            Complete the sockMerchant function in the editor below.It must return an integer representing the number of matching pairs of socks that are available.

            sockMerchant has the following parameter(s):

            n: the number of socks in the pile
            ar: the colors of each sock
            Input Format

            The first line contains an integer , the number of socks represented in .
            The second line contains  space-separated integers describing the colors of the socks in the pile.

            Constraints

             where
            Output Format

            Return the total number of matching pairs of socks that Alex can sell.

            Sample Input

            9
            10 20 20 10 10 30 50 10 20
            Sample Output

            3
            Explanation

            sock.png

            Alex can match three pairs of socks.
            /* KP : Hacker Rank Questions : Q & A */
        }


    }
}

