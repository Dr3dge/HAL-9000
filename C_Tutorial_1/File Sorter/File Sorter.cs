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
        public static object desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static List<string> fileType = new List<string>();
        public static char driveLetter;
        public static string presetSelect;
        public static string presetCustom;
        public static string currentDrive;
        public static string driveList;
        public static string placementDirectory;
        public static string placementDirectoryDefault;
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
                        fileType.Add(".mp3");
                        fileType.Add(".flac");
                        fileType.Add(".wma");
                        fileType.Add(".wav");
                        fileType.Add(".aac");
                        fileType.Add(".raw");
                        placementDirectoryDefault = desktop + "\\Sorted Audio Files\\";
                    }
                    else if (presetSelect == "v")
                    {
                        fileType.Add(".mp4");
                        fileType.Add(".flv");
                        fileType.Add(".avi");
                        fileType.Add(".wmv");
                        fileType.Add(".mov");
                        fileType.Add(".m4p");
                        fileType.Add(".mpg");
                        fileType.Add(".mpg2");
                        fileType.Add(".mkv");
                        placementDirectoryDefault = desktop + "\\Sorted Video Files\\";

                    }
                    else if (presetSelect == "t")
                    {
                        fileType.Add(".txt");
                        fileType.Add(".cfg");
                        fileType.Add(".nfo");
                        fileType.Add(".log");
                        fileType.Add(".doc");
                        fileType.Add(".docx");
                        fileType.Add(".text");
                        placementDirectoryDefault = desktop + "\\Sorted Text Files\\";
                    }
                    else if (presetSelect == "a")
                    {
                        fileType.Add(".zip");
                        fileType.Add(".rar");
                        fileType.Add(".7z");
                        fileType.Add(".iso");
                        fileType.Add(".tar");
                        fileType.Add(".gz");
                        fileType.Add(".dmg");
                        fileType.Add(".zipx");
                        placementDirectoryDefault = desktop + "\\Sorted Archive Files\\";
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
                    if (fileTypeInput.Contains("."))
                    {
                        fileType.Add(fileTypeInput);
                        Console.WriteLine();
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
            Console.WriteLine("If left blank a folder will be created on the Desktop.");
            placementDirectory = Console.ReadLine().ToLower();
            if (placementDirectory.Length == 0)
            {
                if (!Directory.Exists(placementDirectoryDefault))
                {
                    Directory.CreateDirectory(placementDirectoryDefault);
                    placementDirectory = placementDirectoryDefault;
                }
                else if (Directory.Exists(placementDirectoryDefault))
                {
                    placementDirectory = placementDirectoryDefault;
                }
            }
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
                            string[] files = Directory.GetFiles(directory);
                        GetFile:
                            foreach (string file in Directory.GetFiles(directory))
                            {
                                foreach (string type in fileType)
                                {
                                    if (file.Contains(type.ToString()))
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
                        catch (System.IO.IOException)
                        { }
                        catch (System.UnauthorizedAccessException)
                        { }
                        catch (Exception e)
                        {
                            Console.WriteLine("There was a " + e);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
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
            else if (!Directory.Exists(placementDirectory) && placementDirectory.Length != 0)
            {
                Console.WriteLine("Please enter a valid location to place the files.");
                goto PlacementStart;
            }
        }
    }
}

