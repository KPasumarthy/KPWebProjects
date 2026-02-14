using System;
using System.Collections.Generic;
using System.Text;

namespace KPConsole
{
    class RefOutParam
    {
        /// <summary>
        /// KP : Class Constructor : RefOutParam !
        /// </summary>
        public RefOutParam()
        {
            Console.WriteLine("KP : RefOutParam !");
 
        }

        public static void PrintRefOutParam()
        {
            int a = 5;          // Must be initialized
            RefMethod(ref a);   // 'a' is 6 after the call

            int b;              // Can be uninitialized
            OutMethod(out b);   // 'b' is 10 after the call
        }

        public static void RefMethod(ref int x)
        {
            Console.WriteLine(x); // Valid: x is initialized
            x = x + 1;            // Valid: Can modify the value
        }

        public static void OutMethod(out int x)
        {
            //Console.WriteLine(x); // Error: Cannot read before assignment
            x = 10;                 // Must assign a value before returning
        }

    }
}
