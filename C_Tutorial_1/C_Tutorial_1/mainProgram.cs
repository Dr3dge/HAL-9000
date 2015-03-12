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

            Writting.Initialization();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Writting.startWrite();

            Program();
        }

        static void Program()
        {
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
