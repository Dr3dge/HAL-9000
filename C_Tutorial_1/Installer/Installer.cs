using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using IWshRuntimeLibrary;

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
                    Console.WriteLine();
                    Console.WriteLine("This program is already installed");
                    Console.WriteLine();
                    Console.ReadKey();
                }
                else
                {
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
