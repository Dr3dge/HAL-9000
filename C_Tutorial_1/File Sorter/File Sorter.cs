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
            string fileType;
            char driveLetter;
            string currentDrive;
            string driveList = null;
            string placementDirectory;
            var searchPaths = new Queue<string>();

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
                                    string[] files = Directory.GetFiles(directory);
                                    foreach (string file in Directory.GetFiles(directory))
                                    {
                                        if (file.Contains(fileType))
                                        {
                                            Console.WriteLine(file);
                                            if (moveOrCopy == "move")
                                            {
                                                File.Move(file, placementDirectory + Path.GetFileName(file));
                                            }
                                            else if (moveOrCopy == "copy")
                                            {
                                                File.Copy(file, placementDirectory + Path.GetFileName(file));
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
            Console.WriteLine("I have moved or copied all the files I could");
            Console.ReadKey();
        }
    }
}
