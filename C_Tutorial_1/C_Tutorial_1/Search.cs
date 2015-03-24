using HAL_9000_Writting;
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
            string preSearch = Workings.userInput.Replace("google ", "");
            string search = preSearch.Replace(" ", "+");

            try
            {
                Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "https://www.google.com.au/search?q=" + search);
            }
            catch
            {
                try
                {
                    Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://www.google.com.au/search?q=" + search);
                }
                catch
                {
                    Writting.sorryDave();
                }
            }
        }
        public static void firefox()
        {
            string preSearch = Workings.userInput.Replace("google ", "");
            string search = preSearch.Replace(" ", "+");

            try
            {
                Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", "https://www.google.com.au/search?q=" + search);
            }
            catch
            {
                try
                {
                    Process.Start(@"C:\Program Files (x86)\Mozilla Firefox\firefox.exe", "https://www.google.com.au/search?q=" + search);
                }
                catch
                {
                    Writting.sorryDave();
                }
            }
        }
    }
    class searchYoutube
    {
        public static void chrome()
        {
            string preSearch = Workings.userInput.Replace("youtube ", "");
            string search = preSearch.Replace(" ", "+");

            try
            {
                Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "https://www.youtube.com/results?search_query=" + search);
            }
            catch
            {
                try
                {
                    Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "https://www.youtube.com/results?search_query=" + search);
                }
                catch
                {
                    Writting.sorryDave();
                }
            }
        }
        public static void firefox()
        {
            string preSearch = Workings.userInput.Replace("youtube ", "");
            string search = preSearch.Replace(" ", "+");

            try
            {
                Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", "https://www.youtube.com/results?search_query=" + search);
            }
            catch
            {
                try
                {
                    Process.Start(@"C:\Program Files (x86)\Mozilla Firefox\firefox.exe", "https://www.youtube.com/results?search_query=" + search);
                }
                catch
                {
                    Writting.sorryDave();
                }
            }
        }
    }
    class Websites
    {
        public static void website()
        {
            try
            {
                string website = Workings.userInput.Replace("website ", "");
                try
                {
                    Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", website);
                    Writting.siteLaunched();
                }
                catch
                {
                    Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", website);
                    Writting.siteLaunched();
                }
            }
            catch
            {
                Writting.sorryDave();
            }
        }
        public static void goTo()
        {
            try
            {
                string website = Workings.userInput.Replace("goto ", "");
                try
                {
                    Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", website);
                    Writting.siteLaunched();
                }
                catch
                {
                    Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", website);
                    Writting.siteLaunched();
                }
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
            string toFind = Workings.userInput.Replace("run ", "");
            string path;
            string userName = Environment.UserName;

            if (toFind.Contains("word") == true)
            {
                programPlaces.Word();
            }
            else if (toFind.Contains("powerpoint") == true)
            {
                programPlaces.powerPoint();
            }
            else if (toFind.Contains("onenote") == true)
            {
                programPlaces.oneNote();
            }
            else if (toFind.Contains("excel") == true)
            {
                programPlaces.Excel();
            }
            else if (toFind.Contains("notepad") == true)
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
            else if (toFind == "cmd" || toFind == "console")
            {
                programPlaces.CMD();
            }
            else if (toFind == "steam")
            {
                programPlaces.Steam();
            }
            else
            {
                try
                {
                    path = @"C:\\Users\\" + userName + "\\Desktop\\";
                    try
                    {
                        Process.Start(path + toFind + ".lnk");
                    }
                    catch
                    {
                        Process.Start(path + toFind + ".appref-ms");
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
                    path = @"D:\\Users\\" + userName + "\\Desktop\\";
                    try
                    {
                        Process.Start(path + toFind + ".lnk");
                    }
                    catch
                    {
                        Process.Start(path + toFind + ".appref-ms");
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
                        string searchPattern = toFind + ".lnk";
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
                        string searchPattern = toFind + ".appref-ms";
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
                        string searchPattern = toFind + ".lnk";
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
                        string searchPattern = toFind + ".appref-ms";
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
                        string searchPattern = toFind + ".lnk";
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
                        string searchPattern = toFind + ".appref-ms";
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
                        string searchPattern = toFind + ".lnk";
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
                        string searchPattern = toFind + ".appref-ms";
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
                        string searchPattern = toFind + ".lnk";
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
                        string searchPattern = toFind + ".appref-ms";
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
                        string searchPattern = toFind + ".lnk";
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
                        string searchPattern = toFind + ".appref-ms";
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
                    string searchPattern = toFind + ".exe";

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
