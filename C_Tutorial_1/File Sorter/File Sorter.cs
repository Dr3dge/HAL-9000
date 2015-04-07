using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace File_Sorter
{
    class FileSorter
    {
        public static string[] fileType = { };
        public static char driveLetter;
        public static string presetSelect;
        public static string presetCustom;
        public static string currentDrive;
        public static string driveList;
        public static string placementDirectory;
        public static Queue<string> searchPaths = new Queue<string>();
        static void Main()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            Console.WriteLine("These are the drives avalible for scanning");
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine(drive.Name);
                currentDrive = drive.Name;
                driveList += currentDrive.ToLower() + " ";
            }

        DriveStart:
            Console.Write("Please select the dist to scan for files: ");
            driveLetter = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine();
            if (driveList.Contains(driveLetter))
            {
                Console.WriteLine("Do you wish to use a preset file type?");
                Console.WriteLine("[P] Preset File Types");
                Console.WriteLine("[C] Custom File Type");
                Console.Write("Please select which you wish to use: [P/C]");
            PresetCustomSelect:
                char presetOrCustom = Console.ReadKey().KeyChar;
                presetCustom = presetOrCustom.ToString();
                Console.WriteLine();
                if (presetCustom == "p")
                {
                    Console.WriteLine("Which Preset files do you want to use?");
                    Console.WriteLine("[M] Music and Audio files");
                    Console.WriteLine("[V] Video files");
                    Console.WriteLine("[T] Text files");
                    Console.WriteLine("[A] Archive files (zip, rar, 7zip, ect.)");
                PresetSelect:
                    Console.Write("Please select which you wish to use: [M/V/T/A]");
                    char presetSelectChar = Console.ReadKey().KeyChar;
                    presetSelect = presetSelectChar.ToString();
                    Console.WriteLine();
                    if (presetSelect == "m")
                    {
                        string[] fileType = { ".mp3", ".flac", ".wma", ".wav", ".aac", ".raw" };
                    }
                    else if (presetSelect == "v")
                    {
                        string[] fileType = { ".mp4", ".flv", ".avi", ".wmv", ".mov", ".m4p", ".mpg", ".mpg2", ".mkv" };
                    }
                    else if (presetSelect == "t")
                    {
                        string[] fileType = { ".txt", ".cfg", ".nfo", ".log", ".doc", ".docx", ".text" };
                    }
                    else if (presetSelect == "a")
                    {
                        string[] fileType = { ".zip", ".rar", ".7z", ".iso", ".tar", ".gz", ".dmg", ".zipx" };
                    }
                    else
                    {
                        Console.WriteLine("Please select a valid option");
                        goto PresetSelect;
                    }
                    FileSearch();
                }
                else if (presetCustom == "c")
                {
                    Console.WriteLine("What type of file do you want to sort?");
                TypeSelect:
                    Console.Write("Please write the file type as '.xxx': ");
                    string fileTypeInput = Console.ReadLine().ToLower();
                    string[] fileType = { fileTypeInput };
                    Console.WriteLine();
                    if (fileType.Contains("."))
                    {
                        FileSearch();
                    }
                    else
                    {
                        goto TypeSelect;
                    }
                }
                else if (!presetOrCustom.Equals("p") || !presetOrCustom.Equals("c"))
                {
                    Console.Write("Please enter a valid option: ");
                    goto PresetCustomSelect;
                }
            }
            else if (!driveList.Contains(driveLetter))
            {
                Console.WriteLine("Please enter a valid drive letter");
                goto DriveStart;
            }
            Console.WriteLine("I have moved or copied all the files I could");
            Console.ReadKey();
        }
        static void FileSearch()
        {
        PlacementStart:
            Console.WriteLine("Where is the directory you want to copy the files to?");
            placementDirectory = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (Directory.Exists(placementDirectory))
            {
            moveCopyStart:
                Console.WriteLine("Do you wish to Move or Copy these files?");
                string moveOrCopy = Console.ReadLine().ToLower();
                if (moveOrCopy == "move" || moveOrCopy == "copy")
                {
                    Console.WriteLine("Searching for and sorting files now...");

                    string searchLocationStart = driveLetter + ":\\";
                    searchPaths.Enqueue(searchLocationStart);

                    while (searchPaths.Count > 0)
                    {
                        var directory = searchPaths.Dequeue();

                        try
                        {
                        GetFile:
                            string[] files = Directory.GetFiles(directory);
                            foreach (string file in Directory.GetFiles(directory))
                            {
                                Console.WriteLine("Scanning " + file);
                                foreach (string type in fileType)
                                {
                                    if (file.Contains(type))
                                    {
                                        if (moveOrCopy == "move")
                                        {
                                            Console.WriteLine("Moving " + file);
                                            File.Move(file, placementDirectory + Path.GetFileName(file));
                                            goto GetFile;
                                        }
                                        else if (moveOrCopy == "copy")
                                        {
                                            Console.WriteLine("Copying " + file);
                                            File.Copy(file, placementDirectory + Path.GetFileName(file));
                                            goto GetFile;
                                        }
                                    }
                                }
                            }
                            foreach (var subDirectory in Directory.GetDirectories(directory))
                            {
                                searchPaths.Enqueue(subDirectory);
                            }
                        }
                        catch
                        {
                            Console.WriteLine("There was an error acessing a file or folder");
                            Console.WriteLine("Continuing...");
                        }
                    }
                }
                else if (moveOrCopy != "move" || moveOrCopy != "copy")
                {
                    Console.WriteLine("Please select a valid option");
                    goto moveCopyStart;
                }
            }
            else if (!Directory.Exists(placementDirectory))
            {
                Console.WriteLine("Please enter a valid location to place the files.");
                goto PlacementStart;
            }
        }
    }
}

