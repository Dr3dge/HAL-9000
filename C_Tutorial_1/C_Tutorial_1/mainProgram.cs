using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using HAL_9000;
using System.IO;
using System.Diagnostics;
using HAL_9000_Writting;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;

namespace HAL_9000
{
    class mainProgram
    {
        [STAThread]
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                if (arg.Equals("/console"))
                {
                    AllocConsole();
                    mainHALInitiate();
                }
                else if (arg.Equals("/reopen"))
                {
                    AllocConsole();
                    halRestarter();
                }
            }
            if (!args.Equals(null))
            {
                Thread startHAL = new Thread(halStarter);
                startHAL.Start();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new HAL_9000.SystemTray());
            }
            //Thread Listener = new Thread(listenerProcess);

            //Listener.Start();
        }

        public static void halRestarter()
        {
            Console.Title = "HAL-9000";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Writting.startWrite();

            Program();
        }
        public static void halStarter()
        {
            ProcessStartInfo HALConsole = new ProcessStartInfo();
            HALConsole.FileName = "C:\\Program FIles\\HAL-9000\\HAL-9000.exe";
            HALConsole.Arguments = "/console";
            HALConsole.WindowStyle = ProcessWindowStyle.Normal;
            Process.Start(HALConsole);
        }
        public static void mainHALInitiate()
        {
            Console.Title = "HAL-9000";

            Writting.Initialization();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Writting.startWrite();

            Program();
        }

        /*static void listenerProcess(object obj)
        {
            Socket socket;
            byte[] buffer;
            int offset;
            int size;
            int timeout;
            int startTickCount = Environment.TickCount;
            int bytesReceived = 0;  
            do
            {
                if (Environment.TickCount > startTickCount + timeout)
                    throw new Exception("Timeout.");
                try
                {
                    bytesReceived += socket.Receive(buffer, offset + bytesReceived, size - bytesReceived, SocketFlags.None);
                }
                catch (SocketException ex)
                {
                    if (ex.SocketErrorCode == SocketError.WouldBlock ||
                        ex.SocketErrorCode == SocketError.IOPending ||
                        ex.SocketErrorCode == SocketError.NoBufferSpaceAvailable)
                    {
                        // socket buffer is probably empty, wait and try again
                        Thread.Sleep(30);
                    }
                    else
                        throw ex;  // any serious error occurr
                }
            } while (bytesReceived < size);
        }*/

        static void Program()
        {
            Main:
            HAL_9000_Workings.Program();

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
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        
    }
}
