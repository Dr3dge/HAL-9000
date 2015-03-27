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

            //Thread Listener = new Thread(listenerProcess);

            //Listener.Start();
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
            Process[] process = Process.GetProcessesByName("SystemTray Handler");
            if (process.Length == 0)
            {
                if (File.Exists(@"C:\Program Files\HAL-9000\SystemTray Handler.exe"))
                {
                    Process.Start(@"C:\Program Files\HAL-9000\SystemTray Handler.exe");
                }
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
