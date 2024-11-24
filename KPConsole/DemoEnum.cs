using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPConsole
{
    class DemoEnum
    {

        /// <summary>
        /// KP : Class Constructor : DemoEnum !
        /// </summary>
        public DemoEnum()
        {
            Console.WriteLine("KP : DemoEnum !");
        }

        public enum Department { Electronics, ComputerScience, ComputationalEngineering, Mechanical, Chemical, Civil}

        public static void PrintDemoEnum()
        {

            // Getting the string form of the current date
            // in a format, i.e, 07/27/2024 07:29:00 AM          
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:sss tt");
            String input = "KP : Today's Date : " + currentDate;
            Console.WriteLine("KP : PrintDemoEnum ! : Today's Date : " + currentDate);

            ///Department
            Department department = Department.ComputationalEngineering;

            switch (department)
            {
                case Department.Electronics:
                    Console.WriteLine("KP : PrintDemoEnum ! : Department : " + Department.Electronics); 
                    break;
                case Department.ComputerScience:
                    Console.WriteLine("KP : PrintDemoEnum ! : department : " + Department.ComputerScience);
                    break;
                case Department.ComputationalEngineering:
                    Console.WriteLine("KP : PrintDemoEnum ! : department : " + Department.ComputationalEngineering);
                    break;
                case Department.Mechanical:
                    Console.WriteLine("KP : PrintDemoEnum ! : department : " + Department.Mechanical);
                    break;
                case Department.Chemical:
                    Console.WriteLine("KP : PrintDemoEnum ! : department : " + Department.Chemical);
                    break;
                case Department.Civil:
                    Console.WriteLine("KP : PrintDemoEnum ! : department : " + Department.Civil);
                    break;
            }

        }

    }
}
