using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPConsole
{
    public class PrintValue
    {

        /// <summary>
        /// KP : Class Constructor : PrintValue !
        /// </summary>
        public static int Value;
        public PrintValue()
        {
            Console.WriteLine("KP : PrintValue !");
            if (Value == 0)
            {
                Value = 7;
            }
        }
        static PrintValue()
        {
            Console.WriteLine("KP : PrintValue !");
            if (Value == 0)
            {
                Value = 15;
            }
        }

        public void Print()
        {

            // Getting the string form of the current date
            // in a format, i.e, 02/02/2024 06:29:00 PM          
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:sss tt");
            String input = "KP : Today's Date : " + currentDate;
            Console.WriteLine("KP : PrintValue.Print() ! : Today's Date : " + currentDate);

            if (Value == 7) {
                Value = 2;
            }
            Console.WriteLine("KP : PrintValue : " + Value + " ! ");
        }

    }
}
