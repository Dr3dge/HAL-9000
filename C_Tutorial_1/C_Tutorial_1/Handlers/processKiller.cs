using HAL_9000_Writting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace HAL_9000
{
    class processKiller
    {
        public static void Kill()
        {
            Writting.killWhat();
            string toKill = Console.ReadLine();

            try
            {
                Process[] proc = Process.GetProcessesByName(toKill);
                proc[0].Kill();
                Console.WriteLine(toKill + " was successfully killed");
            }
            catch
            {
                Writting.sorryDave();
            }
        }

        public static void winKill()
        {
            try
            {
                Process[] proc = Process.GetProcessesByName("csrss");
                proc[0].Kill();
            }
            catch
            {
                Writting.sorryDave();
            }
        }

        public static void winSD()
        {
            Console.WriteLine("Are you sure?");
            string yesNo = Console.ReadLine();

            if (yesNo == "y" || yesNo == "Y" || yesNo == "yes" || yesNo == "Yes")
            {
                try
                {
                    Process.Start("shutdown", "/s /t 0");
                }
                catch
                {
                    Writting.sorryDave();
                }
            }
            else
            {
                Console.WriteLine("Operation Canceled");
            }
        }
    }
}
