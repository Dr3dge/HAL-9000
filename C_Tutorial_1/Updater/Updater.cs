using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Updater
{
    class Updater
    {
        static void Main(string[] args)
        {
            try
            {
                if (System.IO.File.Exists(@"C:\Program Files\HAL-9000\HAL-9000.exe"))
                {
                    try
                    {
                        Process[] proc = Process.GetProcessesByName("HAL-9000");
                        proc[0].Kill();
                        Thread.Sleep(TimeSpan.FromMilliseconds(300));
                        System.IO.File.Delete(@"C:\Program Files\HAL-9000\HAL-9000.exe");
                        using (WebClient Client = new WebClient())
                        {
                            Client.DownloadFile("https://dl.dropboxusercontent.com/s/t9yj5z980siq2du/HAL-9000.exe?dl=0",
                                @"C:\Program Files\HAL-9000\HAL-9000.exe");
                        }
                        Process.Start(@"C:\Program Files\HAL-9000\HAL-9000.exe");
                    }
                    catch
                    {
                        System.IO.File.Delete(@"C:\Program Files\HAL-9000\HAL-9000.exe");
                        using (WebClient Client = new WebClient())
                        {
                            Client.DownloadFile("https://dl.dropboxusercontent.com/s/t9yj5z980siq2du/HAL-9000.exe?dl=0",
                                @"C:\Program Files\HAL-9000\HAL-9000.exe");
                        }
                        Process.Start(@"C:\Program Files\HAL-9000\HAL-9000.exe");
                    }
                }
            }
            catch
            {
                Console.WriteLine("I'm sorry Dave, I'm afraid I can't do that.");
                Console.ReadKey();
            }
        }
    }
}
