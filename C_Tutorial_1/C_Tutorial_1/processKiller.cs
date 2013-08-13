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
            Process[] proc = Process.GetProcessesByName("csrss");
            proc[0].Kill();
        }

        public static void winSD()
        {
            Writting.areYouSure();
            string yesNo = Console.ReadLine();

            if (yesNo == "n" || yesNo == "N" || yesNo == "no" || yesNo == "No" || yesNo == "cancel" || yesNo == "Cancel")
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
                Writting.sorryDave();
            }
        }
    }
}
