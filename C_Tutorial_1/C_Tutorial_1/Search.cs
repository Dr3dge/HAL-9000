using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace HAL_9000
{
    class searchGoogle
    {
        public static void chrome()
        {
            Console.WriteLine("What do you wish to search?");
            string search = Console.ReadLine();

            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "https://www.google.com.au/search?q=" + search);
        }
        public static void firefox()
        {
            Console.WriteLine("What do you wish to search?");
            string search = Console.ReadLine();

            Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", "https://www.google.com.au/search?q=" + search);
        }
    }
    class searchYoutube
    {
        public static void chrome()
        {
            Console.WriteLine("What do you wish to search?");
            string search = Console.ReadLine();

            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "www.youtube.com/results?search_query=" + search);
        }
        public static void firefox()
        {
            Console.WriteLine("What do you wish to search?");
            string search = Console.ReadLine();

            Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", "www.youtube.com/results?search_query=" + search);
        }
    }
    class Websites
    {
        public static void gotoWebsite()
        {
            Writting.websiteWhat();
            string website = Console.ReadLine();

            try
            {
                Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", website);
                Writting.siteLaunched();
            }
            catch (FileNotFoundException)
            {
                Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", website);
                Writting.siteLaunched();
            }
            catch
            {
                Writting.sorryDave();
            }
        }
    }
    class searchPrograms
    {
        public static void findPrograms()
        {
            Writting.runWhat();
            string userName = Environment.UserName;
            string toFind = Console.ReadLine();

            try
            {
                DirectoryInfo path = new DirectoryInfo(@"C:\Users\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs");
                Process.Start(path + "\\" + toFind + "\\" + toFind + ".lnk");
                goto End;
            }
            catch
            {
                Writting.Searching();
            }

            try
            {
                DirectoryInfo path = new DirectoryInfo(@"D:\Users\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs");
                Process.Start(path + "\\" + toFind + "\\" + toFind + ".lnk");
                goto End;
            }
            catch
            {
                Writting.Searching();
            }

            try
            {
                DirectoryInfo path = new DirectoryInfo(@"C:\Users\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs");
                Process.Start(path + toFind + ".lnk");
                goto End;
            }
            catch
            {
                Writting.Searching();
            }

            try
            {
                DirectoryInfo path = new DirectoryInfo(@"D:\Users\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs");
                Process.Start(path + toFind + ".lnk");
                goto End;
            }
            catch
            {
                Writting.Searching();
            }

            try
            {
                DirectoryInfo path = new DirectoryInfo(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs");
                Process.Start(path + "\\" + toFind + "\\" + toFind + ".lnk");
                goto End;
            }
            catch
            {
                Writting.Searching();
            }

            try
            {
                DirectoryInfo path = new DirectoryInfo(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs");
                Process.Start(path + "\\" + toFind + ".lnk");
                goto End;
            }
            catch
            {
                Writting.Searching();
            }

            try
            {
                DirectoryInfo path = new DirectoryInfo(@"C:\Users\" + userName + "\\Desktop");
                Process.Start(path + toFind + ".lnk");
                goto End;
            }
            catch
            {
                Writting.Searching();
            }

            try
            {
                DirectoryInfo path = new DirectoryInfo(@"D:\Users\" + userName + "\\Desktop");
                Process.Start(path + toFind + ".lnk");
                goto End;
            }
            catch
            {
                Writting.Searching();
            }

            try
            {
                DirectoryInfo path = new DirectoryInfo(@"C:\Program Files");
                Process.Start(path + "\\" + toFind + "\\" + toFind + ".exe");
                goto End;
            }
            catch
            {
                Writting.sorryDave();
            }
        End: ;
        }
    }
}
