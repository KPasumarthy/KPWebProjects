using System;
using System.Threading;

namespace KPMutex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KP : Hello World  Multi-Threading - Mutex!");

            using (var mutex = new Mutex(false, "KP : Multi-Threading : Mutex!")) {
                //KP : If statement is checking if any other instance of the Mutex Thread is running?
                if(mutex.WaitOne(5000, false)) 
                {
                    Console.WriteLine("KP : Multi-Threading : Mutex - Already an Instance of Application is Running!");
                    Console.ReadLine();
                }
                Console.WriteLine("KP : Multi-Threading : Mutex - Application is Running!");
                Console.ReadLine();
            }
        }
    }
}
