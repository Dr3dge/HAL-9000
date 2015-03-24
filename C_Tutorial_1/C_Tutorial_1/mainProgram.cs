using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using HAL_9000;
using System.IO;
using System.Diagnostics;
using HAL_9000_Writting;

namespace HAL_9000
{
    class mainProgram
    {
        static void Main(string[] args)
        {
            Console.Title = "HAL-9000";

            Writting.Initialization();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Writting.startWrite();

            Program();
        }

        static void Program()
        {
            if (File.Exists(@"C:\Program Files\HAL-9000\SystemTray Handler.exe"))
            {
                Process.Start(@"C:\Program Files\HAL-9000\SystemTray Handler.exe");
            }
            Main:
            Workings.Program();

            string yesNo = Console.ReadLine().ToLower();

            if (yesNo.Contains("n") == true)
            {
                goto Cont;
            }
            else
            {
                goto End;
            }
        
            Cont:
            Writting.reboot();
            goto Main;

            End:
            Writting.terminated();
            Console.ReadKey();
        }
    }
}
