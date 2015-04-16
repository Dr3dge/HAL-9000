using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using IWshRuntimeLibrary;
using System.Diagnostics;
using System.Threading;

namespace Installer
{
    class Installer
    {
        static void Main(string[] args)
        {
            try
            {
                if (System.IO.Directory.Exists(@"C:\Program Files\HAL-9000"))
                {
                    string userInput = null;
                    Console.WriteLine();
                    Console.WriteLine("HAL-9000 is already installed.");
                    Console.Write("Do you wish to reinstall HAL-9000? [Y/N] ");
                    userInput = Console.ReadLine().ToLower();
                    if (userInput == "y" || userInput == "yes")
                    {
                        try
                        {
                            Process[] proc = Process.GetProcessesByName("HAL-9000");
                            proc[0].Kill();
                            Thread.Sleep(TimeSpan.FromMilliseconds(300));
                        }
                        catch
                        { }

                        Thread install1 = new Thread(installHAL9000);
                        Thread install2 = new Thread(installWritting);
                        Thread install3 = new Thread(installUpdater);
                        Thread install4 = new Thread(installFileSorter);
                        install1.Start();
                        install2.Start();
                        install3.Start();
                        install4.Start();

                        Console.WriteLine("Downloading and Installing...");

                        if (System.IO.File.Exists(@"C:\Program Files\HAL-9000\HALSync.exe"))
                        {
                            try
                            {
                                Process[] proc2 = Process.GetProcessesByName("HALSync");
                                proc2[0].Kill();
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
                                System.IO.File.Delete(@"C:\Program Files\HAL-9000\HALSync.exe");
                                using (WebClient Client = new WebClient())
                                {
                                    Client.DownloadFile("https://dl.dropboxusercontent.com/s/46w6a16t1xtp6eh/HALSync.exe?dl=0",
                                        @"C:\Program Files\HAL-9000\HALSync.exe");
                                }
                            }
                        }
                        else
                        {
                            using (WebClient Client = new WebClient())
                                {
                                    Client.DownloadFile("https://dl.dropboxusercontent.com/s/46w6a16t1xtp6eh/HALSync.exe?dl=0",
                                        @"C:\Program Files\HAL-9000\HALSync.exe");
                                }
                        }
                        object shDesktop = (object)"Desktop";
                        WshShell shell = new WshShell();
                        try
                        {
                            if (System.IO.File.Exists((string)shell.SpecialFolders.Item(ref shDesktop) + @"\HAL-9000.lnk"))
                            {
                                System.IO.File.Delete((string)shell.SpecialFolders.Item(ref shDesktop) + @"\HAL-9000.lnk");
                                string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\HAL-9000.lnk";
                                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                                shortcut.Description = "Shortcut for HAL-9000";
                                shortcut.Hotkey = "Ctrl+Shift+H";
                                shortcut.TargetPath = @"C:\Program Files\HAL-9000\HAL-9000.exe";
                                shortcut.Save();
                            }
                            else
                            {
                                string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\HAL-9000.lnk";
                                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                                shortcut.Description = "Shortcut for HAL-9000";
                                shortcut.Hotkey = "Ctrl+Shift+H";
                                shortcut.TargetPath = @"C:\Program Files\HAL-9000\HAL-9000.exe";
                                shortcut.Save();
                            }
                            if (System.IO.File.Exists((string)shell.SpecialFolders.Item(ref shDesktop) + @"\HALSync.lnk"))
                            {
                                System.IO.File.Delete((string)shell.SpecialFolders.Item(ref shDesktop) + @"\HALSync.lnk");
                                string shortcutAddress2 = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\HALSync.lnk";
                                IWshShortcut shortcut2 = (IWshShortcut)shell.CreateShortcut(shortcutAddress2);
                                shortcut2.Description = "Shortcut for HALSync";
                                shortcut2.TargetPath = @"C:\Program Files\HAL-9000\HALSync.exe";
                                shortcut2.Save();
                            }
                            else
                            {
                                string shortcutAddress2 = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\HALSync.lnk";
                                IWshShortcut shortcut2 = (IWshShortcut)shell.CreateShortcut(shortcutAddress2);
                                shortcut2.Description = "Shortcut for HALSync";
                                shortcut2.TargetPath = @"C:\Program Files\HAL-9000\HALSync.exe";
                                shortcut2.Save();
                            }
                        }
                        catch
                        {
                            Console.WriteLine("I'm sorry Dave, I'm afraid I can't do that.");
                        }
                        Console.WriteLine();
                        Console.WriteLine("This program was successfully installed");
                        Console.WriteLine();
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("HAL-9000 has not been reinstalled");
                        Console.WriteLine();
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Downloading and Installing...");
                    Directory.CreateDirectory(@"C:\Program Files\HAL-9000");

                    Thread install1 = new Thread(cleanInstallHAL9000);
                    Thread install2 = new Thread(cleanInstallWritting);
                    Thread install3 = new Thread(cleanInstallUpdater);
                    Thread install4 = new Thread(cleanInstallFileSorter);
                    install1.Start();
                    install2.Start();
                    install3.Start();
                    install4.Start();

                    using (WebClient Client = new WebClient())
                    {
                        Client.DownloadFile("https://dl.dropboxusercontent.com/s/46w6a16t1xtp6eh/HALSync.exe?dl=0",
                            @"C:\Program Files\HAL-9000\HALSync.exe");
                    }

                    object shDesktop = (object)"Desktop";
                    WshShell shell = new WshShell();
                    string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\HAL-9000.lnk";
                    IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                    shortcut.Description = "Shortcut for HAL-9000";
                    shortcut.Hotkey = "Ctrl+Shift+H";
                    shortcut.TargetPath = @"C:\Program Files\HAL-9000\HAL-9000.exe";
                    shortcut.Save();
                    string shortcutAddress2 = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\HALSync.lnk";
                    IWshShortcut shortcut2 = (IWshShortcut)shell.CreateShortcut(shortcutAddress2);
                    shortcut2.Description = "Shortcut for HALSync";
                    shortcut2.TargetPath = @"C:\Program Files\HAL-9000\HALSync.exe";
                    shortcut2.Save();
                    Console.WriteLine();
                    Console.WriteLine("This program was successfully installed");
                    Console.WriteLine();
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("I'm sorry Dave, I'm afraid I can't do that.");
            }
        }
        private static void cleanInstallUpdater(object obj)
        {
            using (WebClient Client = new WebClient())
            {
                Client.DownloadFile("https://dl.dropboxusercontent.com/s/iquqw73byxcmbsv/Updater.exe?dl=0",
                    @"C:\Program Files\HAL-9000\Updater.exe");
            }
        }
        private static void cleanInstallWritting(object obj)
        {
            using (WebClient Client = new WebClient())
            {
                Client.DownloadFile("https://dl.dropboxusercontent.com/s/yzc8m0gbi1la2zk/Writting.dll?dl=0",
                    @"C:\Program Files\HAL-9000\Writting.dll");
            }
        }
        private static void cleanInstallHAL9000(object obj)
        {
            using (WebClient Client = new WebClient())
            {
                Client.DownloadFile("https://dl.dropboxusercontent.com/s/t9yj5z980siq2du/HAL-9000.exe?dl=0",
                    @"C:\Program Files\HAL-9000\HAL-9000.exe");
            }
        }
        private static void cleanInstallFileSorter(object obj)
        {
            using (WebClient Client = new WebClient())
            {
                Client.DownloadFile("https://dl.dropboxusercontent.com/s/fkqg8j0hullykxs/File%20Sorter.exe?dl=00",
                    @"C:\Program Files\HAL-9000\File Sorter.exe");
            }
        }
        private static void installUpdater(object obj)
        {
            try
            {
                System.IO.File.Delete(@"C:\Program Files\HAL-9000\Updater.exe");
                using (WebClient Client = new WebClient())
                {
                    Client.DownloadFile("https://dl.dropboxusercontent.com/s/iquqw73byxcmbsv/Updater.exe?dl=0",
                        @"C:\Program Files\HAL-9000\Updater.exe");
                }
            }
            catch
            {
                using (WebClient Client = new WebClient())
                {
                    Client.DownloadFile("https://dl.dropboxusercontent.com/s/iquqw73byxcmbsv/Updater.exe?dl=0",
                        @"C:\Program Files\HAL-9000\Updater.exe");
                }
            }
        }
        private static void installFileSorter(object obj)
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
            else
            {
                using (WebClient Client = new WebClient())
                {
                    Client.DownloadFile("https://dl.dropboxusercontent.com/s/fkqg8j0hullykxs/File%20Sorter.exe?dl=00",
                        @"C:\Program Files\HAL-9000\File Sorter.exe");
                }
            }
        }
        private static void installWritting(object obj)
        {
            try
            {
                System.IO.File.Delete(@"C:\Program Files\HAL-9000\Writting.dll");
                using (WebClient Client = new WebClient())
                {
                    Client.DownloadFile("https://dl.dropboxusercontent.com/s/yzc8m0gbi1la2zk/Writting.dll?dl=0",
                        @"C:\Program Files\HAL-9000\Writting.dll");
                }
            }
            catch
            {
                using (WebClient Client = new WebClient())
                {
                    Client.DownloadFile("https://dl.dropboxusercontent.com/s/yzc8m0gbi1la2zk/Writting.dll?dl=0",
                        @"C:\Program Files\HAL-9000\Writting.dll");
                }
            }
        }
        private static void installHAL9000(object obj)
        {
            System.IO.File.Delete(@"C:\Program Files\HAL-9000\HAL-9000.exe");
            using (WebClient Client = new WebClient())
            {
                Client.DownloadFile("https://dl.dropboxusercontent.com/s/t9yj5z980siq2du/HAL-9000.exe?dl=0",
                    @"C:\Program Files\HAL-9000\HAL-9000.exe");
            }
        }
    }
}
