using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace Updater
{
    class Updater
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Downloading and Installing Update...");

                try
                {
                    Process[] proc = Process.GetProcessesByName("HAL-9000");
                    proc[0].Kill();
                    Thread.Sleep(300);
                }
                catch
                { }

                Thread update1 = new Thread(updateHAL9000);
                Thread update2 = new Thread(updateWritting);
                Thread update3 = new Thread(updateFileSorter);
                Thread remover1 = new Thread(trayRemover);
                update1.Start();
                update2.Start();
                update3.Start();
                remover1.Start();

                if (System.IO.File.Exists(@"C:\Program Files\HAL-9000\HALSync.exe"))
                {
                    try
                    {
                        Process[] proc = Process.GetProcessesByName("HALSync");
                        proc[0].Kill();
                        Thread.Sleep(TimeSpan.FromMilliseconds(300));
                        System.IO.File.Delete(@"C:\Program Files\HAL-9000\HALSync.exe");
                        using (WebClient Client = new WebClient())
                        {
                            Client.DownloadFile("https://dl.dropboxusercontent.com/s/46w6a16t1xtp6eh/HALSync.exe?dl=0",
                                @"C:\Program Files\HAL-9000\HALSync.exe");
                        }
                    }
                    catch
                    {
                        if (System.IO.File.Exists(@"C:\Program Files\HAL-9000\HALSync.exe"))
                        {
                            System.IO.File.Delete(@"C:\Program Files\HAL-9000\HALSync.exe");
                            using (WebClient Client = new WebClient())
                            {
                                Client.DownloadFile("https://dl.dropboxusercontent.com/s/46w6a16t1xtp6eh/HALSync.exe?dl=0",
                                    @"C:\Program Files\HAL-9000\HALSync.exe");
                            }
                        }
                        else
                        {
                            using (WebClient Client = new WebClient())
                            {
                                Client.DownloadFile("https://dl.dropboxusercontent.com/s/46w6a16t1xtp6eh/HALSync.exe?dl=0",
                                    @"C:\Program Files\HAL-9000\HALSync.exe");
                            }
                            object shDesktop = (object)"Desktop";
                            WshShell shell = new WshShell();
                            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\HALSync.lnk";
                            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                            shortcut.Description = "Shortcut for HALSync";
                            shortcut.TargetPath = @"C:\Program Files\HAL-9000\HALSync.exe";
                            shortcut.Save();
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("I'm sorry Dave, I'm afraid I can't do that.");
                Console.ReadKey();
            }
        }
        private static void trayRemover(object obj)
        {
            if (System.IO.File.Exists(@"C:\\Program FIles\HAL-9000\SystemTray Handler.exe"))
            {
                try
                {
                    Process[] proc4 = Process.GetProcessesByName("SystemTray Handler");
                    proc4[0].Kill();
                    Thread.Sleep(TimeSpan.FromMilliseconds(300));
                    System.IO.File.Delete(@"C:\Program Files\HAL-9000\SystemTray Handler.exe");
                }
                catch
                {
                    System.IO.File.Delete(@"C:\Program Files\HAL-9000\SystemTray Handler.exe");
                }
            }
        }
        private static void updateFileSorter(object obj)
        {
            if (System.IO.File.Exists(@"C:\Program Files\HAL-9000\File Sorter.exe"))
            {
                try
                {
                    Process[] proc3 = Process.GetProcessesByName("File Sorter");
                    proc3[0].Kill();
                    Thread.Sleep(TimeSpan.FromMilliseconds(300));
                    System.IO.File.Delete(@"C:\Program Files\HAL-9000\File Sorter.exe");
                    using (WebClient Client = new WebClient())
                    {
                        Client.DownloadFile("https://dl.dropboxusercontent.com/s/fkqg8j0hullykxs/File%20Sorter.exe?dl=00",
                            @"C:\Program Files\HAL-9000\File Sorter.exe");
                    }
                }
                catch
                {
                    System.IO.File.Delete(@"C:\Program Files\HAL-9000\File Sorter.exe");
                    using (WebClient Client = new WebClient())
                    {
                        Client.DownloadFile("https://dl.dropboxusercontent.com/s/fkqg8j0hullykxs/File%20Sorter.exe?dl=00",
                            @"C:\Program Files\HAL-9000\File Sorter.exe");
                    }
                }
            }
            else if (!System.IO.File.Exists(@"C:\Program Files\HAL-9000\File Sorter.exe"))
            {
                using (WebClient Client = new WebClient())
                {
                    Client.DownloadFile("https://dl.dropboxusercontent.com/s/fkqg8j0hullykxs/File%20Sorter.exe?dl=00",
                        @"C:\Program Files\HAL-9000\File Sorter.exe");
                }
            }
        }
        private static void updateWritting(object obj)
        {
            if (System.IO.File.Exists(@"C:\Program Files\HAL-9000\Writting.dll"))
            {
                System.IO.File.Delete(@"C:\Program Files\HAL-9000\Writting.dll");
                using (WebClient Client = new WebClient())
                {
                    Client.DownloadFile("https://dl.dropboxusercontent.com/s/yzc8m0gbi1la2zk/Writting.dll?dl=0",
                        @"C:\Program Files\HAL-9000\Writting.dll");
                }
            }
            else if (!System.IO.File.Exists(@"C:\Program Files\HAL-9000\Writting.dll"))
            {
                using (WebClient Client = new WebClient())
                {
                    Client.DownloadFile("https://dl.dropboxusercontent.com/s/yzc8m0gbi1la2zk/Writting.dll?dl=0",
                        @"C:\Program Files\HAL-9000\Writting.dll");
                }
            }
        }
        private static void updateHAL9000(object obj)
        {
            if (System.IO.File.Exists(@"C:\Program Files\HAL-9000\HAL-9000.exe"))
            {
                System.IO.File.Delete(@"C:\Program Files\HAL-9000\HAL-9000.exe");
                using (WebClient Client = new WebClient())
                {
                    Client.DownloadFile("https://dl.dropboxusercontent.com/s/t9yj5z980siq2du/HAL-9000.exe?dl=0",
                        @"C:\Program Files\HAL-9000\HAL-9000.exe");
                }
                Thread.Sleep(300);
                Process.Start(@"C:\Program Files\HAL-9000\HAL-9000.exe");
            }
        }
    }
}
