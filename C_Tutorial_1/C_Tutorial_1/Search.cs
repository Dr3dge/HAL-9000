using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HAL_9000
{
    class searchGoogle
    {
        public static void chrome()
        {
            Console.WriteLine("What do you wish to search?");
            string searchInput = Console.ReadLine();
            string search = searchInput.Replace(" ", "+");

            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "https://www.google.com.au/search?q=" + search);
        }
        public static void firefox()
        {
            Console.WriteLine("What do you wish to search?");
            string searchInput = Console.ReadLine();
            string search = searchInput.Replace(" ", "+");

            Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", "https://www.google.com.au/search?q=" + search);
        }
    }
    class searchYoutube
    {
        public static void chrome()
        {
            Console.WriteLine("What do you wish to search?");
            string searchInput = Console.ReadLine();
            string search = searchInput.Replace(" ", "+");

            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "https://www.youtube.com/results?search_query=" + search);
        }
        public static void firefox()
        {
            Console.WriteLine("What do you wish to search?");
            string searchInput = Console.ReadLine();
            string search = searchInput.Replace(" ", "+");

            Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", "https://www.youtube.com/results?search_query=" + search);
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
            string path;
            string userName = Environment.UserName;
            string toFind = Console.ReadLine();

            if (toFind == "word" || toFind == "Word" || toFind == "microsoft word" || toFind == "Microsoft word" || toFind == "Microsoft Word")
            {
                programPlaces.Word();
            }
            else if (toFind == "microsoft powerpoint" || toFind == "Microsoft Powerpoint" || toFind == "Microsoft PowerPoint")
            {
                programPlaces.powerPoint();
            }
            else if (toFind == "microsoft onenote" || toFind == "Microsoft Onenote" || toFind == "Microsoft OneNote")
            {
                programPlaces.oneNote();
            }
            else if (toFind == "microsoft excel" || toFind == "Microsoft Excel")
            {
                programPlaces.Excel();
            }
            else if (toFind == "notepad" || toFind == "Notepad")
            {
                try
                {
                    programPlaces.notepadPP();
                }
                catch
                {
                    programPlaces.Notepad();
                }
            }
            else if (toFind == "cmd" || toFind == "CMD" || toFind == "console" || toFind == "Console")
            {
                programPlaces.CMD();
            }
            else
            {
                try
                {
                    path = @"C:\Users\" + userName + "\\Desktop\\";
                    try
                    {
                        Process.Start(toFind + ".lnk*");
                    }
                    catch
                    {
                        Process.Start(toFind + ".appref-ms*");
                    }
                    Console.WriteLine(toFind + " launched");
                    goto End;
                }
                catch
                {
                    Writting.Searching();
                }

                try
                {
                    path = @"D:\Users\" + userName + "\\Desktop\\";
                    try
                    {
                        Process.Start(toFind + ".lnk*");
                    }
                    catch
                    {
                        Process.Start(toFind + ".appref-ms*");
                    }
                    Console.WriteLine(toFind + " launched");
                    goto End;
                }
                catch
                {
                    Writting.Searching();
                }

                try
                {
                    path = @"C:\Users\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\";
                    try
                    {
                        string searchPattern = toFind + ".lnk*";
                        DirectoryInfo di = new DirectoryInfo(path);

                        FileInfo[] files =
                            di.GetFiles(searchPattern, SearchOption.AllDirectories);

                        foreach (FileInfo file in files)
                        {
                            string progRun = (file.FullName.ToString());
                            Process.Start(progRun);
                        }
                    }
                    catch
                    {
                        string searchPattern = toFind + ".appref-ms*";
                        DirectoryInfo di = new DirectoryInfo(path);

                        FileInfo[] files =
                            di.GetFiles(searchPattern, SearchOption.AllDirectories);

                        foreach (FileInfo file in files)
                        {
                            string progRun = (file.FullName.ToString());
                            Process.Start(progRun);
                        }
                    }
                    Console.WriteLine(toFind + " launched");
                    goto End;
                }
                catch
                {
                    Writting.Searching();
                }

                try
                {
                    path = @"D:\Users\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\";
                    try
                    {
                        string searchPattern = toFind + ".lnk*";
                        DirectoryInfo di = new DirectoryInfo(path);

                        FileInfo[] files =
                            di.GetFiles(searchPattern, SearchOption.AllDirectories);

                        foreach (FileInfo file in files)
                        {
                            string progRun = (file.FullName.ToString());
                            Process.Start(progRun);
                        }
                    }
                    catch
                    {
                        string searchPattern = toFind + ".appref-ms*";
                        DirectoryInfo di = new DirectoryInfo(path);

                        FileInfo[] files =
                            di.GetFiles(searchPattern, SearchOption.AllDirectories);

                        foreach (FileInfo file in files)
                        {
                            string progRun = (file.FullName.ToString());
                            Process.Start(progRun);
                        }
                    }
                    Console.WriteLine(toFind + " launched");
                    goto End;
                }
                catch
                {
                    Writting.Searching();
                }

                try
                {
                    path = @"C:\Users\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\";
                    try
                    {
                        string searchPattern = toFind + ".lnk*";
                        DirectoryInfo di = new DirectoryInfo(path);

                        FileInfo[] files =
                            di.GetFiles(searchPattern, SearchOption.AllDirectories);

                        foreach (FileInfo file in files)
                        {
                            string progRun = (file.FullName.ToString());
                            Process.Start(progRun);
                        }
                    }
                    catch
                    {
                        string searchPattern = toFind + ".appref-ms*";
                        DirectoryInfo di = new DirectoryInfo(path);

                        FileInfo[] files =
                            di.GetFiles(searchPattern, SearchOption.AllDirectories);

                        foreach (FileInfo file in files)
                        {
                            string progRun = (file.FullName.ToString());
                            Process.Start(progRun);
                        }
                    }
                    Console.WriteLine(toFind + " launched");
                    goto End;
                }
                catch
                {
                    Writting.Searching();
                }

                try
                {
                    path = @"D:\Users\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\";
                    try
                    {
                        string searchPattern = toFind + ".lnk*";
                        DirectoryInfo di = new DirectoryInfo(path);

                        FileInfo[] files =
                            di.GetFiles(searchPattern, SearchOption.AllDirectories);

                        foreach (FileInfo file in files)
                        {
                            string progRun = (file.FullName.ToString());
                            Process.Start(progRun);
                        }
                    }
                    catch
                    {
                        string searchPattern = toFind + ".appref-ms*";
                        DirectoryInfo di = new DirectoryInfo(path);

                        FileInfo[] files =
                            di.GetFiles(searchPattern, SearchOption.AllDirectories);

                        foreach (FileInfo file in files)
                        {
                            string progRun = (file.FullName.ToString());
                            Process.Start(progRun);
                        }
                    }
                    Console.WriteLine(toFind + " launched");
                    goto End;
                }
                catch
                {
                    Writting.Searching();
                }

                try
                {
                    path = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs";
                    try
                    {
                        string searchPattern = toFind + ".lnk*";
                        DirectoryInfo di = new DirectoryInfo(path);

                        FileInfo[] files =
                            di.GetFiles(searchPattern, SearchOption.AllDirectories);

                        foreach (FileInfo file in files)
                        {
                            string progRun = (file.FullName.ToString());
                            Process.Start(progRun);
                        }
                    }
                    catch
                    {
                        string searchPattern = toFind + ".appref-ms*";
                        DirectoryInfo di = new DirectoryInfo(path);

                        FileInfo[] files =
                            di.GetFiles(searchPattern, SearchOption.AllDirectories);

                        foreach (FileInfo file in files)
                        {
                            string progRun = (file.FullName.ToString());
                            Process.Start(progRun);
                        }
                    }
                    Console.WriteLine(toFind + " launched");
                    goto End;
                }
                catch
                {
                    Writting.Searching();
                }

                try
                {
                    path = @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs"; 

                    try
                    {
                        string searchPattern = toFind + ".lnk*";
                        DirectoryInfo di = new DirectoryInfo(path);

                        FileInfo[] files =
                            di.GetFiles(searchPattern, SearchOption.AllDirectories);

                        foreach (FileInfo file in files)
                        {
                            string progRun = (file.FullName.ToString());
                            Process.Start(progRun);
                        }
                    }
                    catch
                    {
                        string searchPattern = toFind + ".appref-ms*";
                        DirectoryInfo di = new DirectoryInfo(path);

                        FileInfo[] files =
                            di.GetFiles(searchPattern, SearchOption.AllDirectories);

                        foreach (FileInfo file in files)
                        {
                            string progRun = (file.FullName.ToString());
                            Process.Start(progRun);
                        }
                    }
                    Console.WriteLine(toFind + " launched");
                    goto End;
                }
                catch
                {
                    Writting.Searching();
                }

                try
                {
                    path = @"C:\Program Files\";
                    string searchPattern = toFind + ".exe*";

                    DirectoryInfo di = new DirectoryInfo(path);

                    FileInfo[] files =
                        di.GetFiles(searchPattern, SearchOption.AllDirectories);

                    foreach (FileInfo file in files)
                    {
                        string progRun = (file.FullName.ToString());
                        Process.Start(progRun);
                        Console.WriteLine(toFind + " launched");
                    }
                }
                catch
                {
                    Writting.sorryDave();
                }
            End: ;
            }
        }
    }
}
