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
                if (System.IO.File.Exists(@"C:\Program Files\HAL-9000\HAL-9000.exe"))
                {
                    string userInput = null;
                    Console.WriteLine();
                    Console.WriteLine("HAL-9000 is already installed.");
                    Console.Write("Do you wish to reinstall HAL-9000? [Y/N] ");
                    userInput = Console.ReadLine().ToLower();
                    if (userInput == "y" || userInput == "yes")
                    {
                        Console.WriteLine("Downloading and Installing...");
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
                        }
                        catch
                        {
                            System.IO.File.Delete(@"C:\Program Files\HAL-9000\HAL-9000.exe");
                            using (WebClient Client = new WebClient())
                            {
                                Client.DownloadFile("https://dl.dropboxusercontent.com/s/t9yj5z980siq2du/HAL-9000.exe?dl=0",
                                    @"C:\Program Files\HAL-9000\HAL-9000.exe");
                            }
                        }
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
                        Console.WriteLine();
                        Console.WriteLine("This program was successfully installed");
                        Console.WriteLine();
                        Console.ReadKey();
                        }
                        catch
                        {
                            Console.WriteLine("I'm sorry Dave, I'm afraid I can't do that.");
                        }
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
                    using (WebClient Client = new WebClient())
                    {
                        Client.DownloadFile("https://dl.dropboxusercontent.com/s/t9yj5z980siq2du/HAL-9000.exe?dl=0",
                            @"C:\Program Files\HAL-9000\HAL-9000.exe");
                    }
                    using (WebClient Client = new WebClient())
                    {
                        Client.DownloadFile("https://dl.dropboxusercontent.com/s/iquqw73byxcmbsv/Updater.exe?dl=0",
                            @"C:\Program Files\HAL-9000\Updater.exe");
                    }
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
    }
}
