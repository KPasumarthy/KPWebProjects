using System;
using System.Collections.Generic;
using System.Text;

namespace KPConsole
{
    class DemoStatic
    {

        public static int Num;

        /// <summary>
        /// KP : Class Constructor : DemoStatic !
        /// </summary>
        public DemoStatic()
        {
            Console.WriteLine("KP : public DemoStatic() ! : Num : " + Num );

            if (Num == 0)
            {
                Num = 5;
            }

            Console.WriteLine("KP : public DemoStatic() ! : Num : " + Num);
        }

        static DemoStatic()
        {
            Console.WriteLine("KP : static DemoStatic ! : Num : " + Num);

            if (Num == 0)
            {
                Num = 10;
            }

            Console.WriteLine("KP : static DemoStatic ! : Num : " + Num);
        }


        public void Print()
        {
            Console.WriteLine("KP : DemoStatic : void Print()! : Num : " + Num);

            if (Num == 5)
            {
                Num = 6;
            }

            Console.WriteLine("KP : DemoStatic : void Print()! : Num : " + Num);
        }

    }
}
