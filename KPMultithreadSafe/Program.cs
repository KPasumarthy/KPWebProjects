using System;
using System.Threading;

namespace KPMultithreadSafe
{
    class Program
    {

       static Math objMath = new Math();
        static void Main(string[] args)
        {
            Console.WriteLine("KP : Hello World  Multi-Threading with Locks & Monitor!");

            Thread t1 = new Thread(objMath.Divide);
            t1.Start();             //KP : Child Thread

            objMath.Divide();       //KP : Main Thread
            Console.ReadLine();

        }

     
    }
}
