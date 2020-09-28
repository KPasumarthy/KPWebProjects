using System;
using System.Threading;


namespace KPSemaphore
{
    class Program
    {
        //KP : Semaphore Threads
        static Semaphore semaphore = null;
        static int count = 0;
        static int numOfThreads = 3;

        static void Main(string[] args)
        {
            Console.WriteLine("KP : Hello World Multi-Threading : Semaphores!");

            try
            {
                semaphore = Semaphore.OpenExisting("KP : Multi-Threading : Semaphore = " + ++count);
            }
            catch (Exception ex)
            {
                ///semaphore = new Semaphore( 3, 3,"KP : Multi-Threading : Semaphore = " + ++count);
                semaphore = new Semaphore(numOfThreads, numOfThreads, "KP : Multi-Threading : Semaphore = " + ++count);
                
                //throw;
            }

            Console.WriteLine("KP : Multi-Threading : Acquiring a Semaphore!");
            semaphore.WaitOne();

            ///KP : This area can be accessed only by numOfThreads=3'
            Console.WriteLine("KP : This area can only be Accessed & Aquired by numOfThreads =  " + numOfThreads);
            Console.ReadLine();
            
        }
    }
}
