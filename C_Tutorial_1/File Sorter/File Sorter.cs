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
        static void Main(string[] args)
        {
            string[] files;
            string fileType;
            char driveLetter;
            string currentDrive;
            string driveList = null;
            string placementDirectory;

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
                Console.WriteLine("What type of file do you want to sort?");
            TypeStart:
                Console.Write("Please write the file type as '.xxx': ");
                fileType = Console.ReadLine().ToLower();
                Console.WriteLine();
                if (fileType.Contains("."))
                {
                    fileType.Replace(".", "*.");

                PlacementStart:
                    Console.WriteLine("Where is the directory you want to copy the files to?");
                    placementDirectory = Console.ReadLine();
                    Console.WriteLine();
                    if (Directory.Exists(placementDirectory))
                    {
                        Console.WriteLine("Searching for and sorting files now...");

                        files = Directory.GetFiles(driveLetter + ":\\", fileType, SearchOption.AllDirectories);

                        if (files != null)
                        {
                            foreach (string file in files)
                            {
                                File.Copy(Directory.GetParent(file) + file, "C:\\Users\\" + Environment.UserName + "\\Music\\");
                            }
                        }
                    }
                    else if (!Directory.Exists(placementDirectory))
                    {
                        Console.WriteLine("Please enter a valid location to place the files.");
                        goto PlacementStart;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid file type");
                    Console.ReadKey();
                    Console.WriteLine();
                    goto TypeStart;
                }
            }
            else if (!driveList.Contains(driveLetter))
            {
                Console.WriteLine("Please enter a valid drive letter");
                goto DriveStart;
            }
        }
    }
}
