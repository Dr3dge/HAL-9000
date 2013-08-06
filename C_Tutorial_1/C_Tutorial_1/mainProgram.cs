using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HAL_9000;

namespace HAL_9000
{
    class mainProgram
    {
        static void Main(string[] args)
        {
            Console.Title = "HAL-9000";

            Writting.startWrite();

            Cont:
            Writting.reboot();
            goto Main;

            Main:
            Workings.Program();

            string yesNo = Console.ReadLine();

            if (yesNo == "y" || yesNo == "Y" || yesNo == "yes" || yesNo == "Yes")
            {
                goto End;
            }
            else if (yesNo == "n" || yesNo == "N" || yesNo == "no" || yesNo == "No")
            {
                goto Cont;
            }

            End:
            Writting.terminated();
            Console.ReadKey();
        }
    }
}