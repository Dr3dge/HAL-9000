using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
                Console.WriteLine("Downloading and Installing Update...");
                if (Directory.Exists(@"C:\Program Files\HAL-9000"))
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
                if (System.IO.File.Exists(@"C:\Program Files\HAL-9000\SystemTray Handler.exe"))
                {
                    try
                    {
                        Process[] proc = Process.GetProcessesByName("SystemTray Handler");
                        proc[0].Kill();
                        Thread.Sleep(TimeSpan.FromMilliseconds(300));
                        System.IO.File.Delete(@"C:\Program Files\HAL-9000\SystemTray Handler.exe");
                        using (WebClient Client = new WebClient())
                        {
                            Client.DownloadFile("https://dl.dropboxusercontent.com/s/5s39gdhyu4f03j2/SystemTray Handler.exe?dl=0",
                                @"C:\Program Files\HAL-9000\SystemTray Handler.exe");
                        }
                    }
                    catch
                    {
                        System.IO.File.Delete(@"C:\Program Files\HAL-9000\SystemTray Handler");
                        using (WebClient Client = new WebClient())
                        {
                            Client.DownloadFile("https://dl.dropboxusercontent.com/s/5s39gdhyu4f03j2/SystemTray Handler.exe?dl=0",
                                @"C:\Program Files\HAL-9000\SystemTray Handler.exe");
                        }
                    }
                }
                else if (!System.IO.File.Exists(@"C:\Program Files\HAL-9000\SystemTray Handler.exe"))
                {
                    using (WebClient Client = new WebClient())
                    {
                        Client.DownloadFile("https://dl.dropboxusercontent.com/s/5s39gdhyu4f03j2/SystemTray Handler.exe?dl=0",
                            @"C:\Program Files\HAL-9000\SystemTray Handler.exe");
                    }
                }
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
