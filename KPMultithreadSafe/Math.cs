using System;
using System.Collections.Generic;
using System.Text;

namespace KPMultithreadSafe
{
    class Math
    {

        public int Num1;
        public int Num2;

        Random obj = new Random();

        public void Divide()
        {

            int count = 0;
            for (long i = 0; i < 10; i++)
            {
                lock (this)     //KP : Lock thread, makes the Tread Safe!!
                {
                    Num1 = obj.Next(1, 2);
                    Num2 = obj.Next(1, 2);
                    int result = Num1 / Num2;

                    Console.WriteLine("KP : Child Thread Safe using 'lock' : Thread Loop Count = " + 
                                        ++count +  " Num1 = " + Num1 + " Num2 = " + Num2);

                    Num1 = 0;
                    Num2 = 0;
                }
            }
        }
    }
}


/***
 * 
 * 1) Safety of a multi-threaded environment is ensured using the keyword 'lock'.
 * 2) Using the technique of 'lock' we can ensure thread-safety, but it has a limitation.
 * 3) Keyword 'lock' can ensure safety of multi-threaded environment only inside internal applications.
 ***/