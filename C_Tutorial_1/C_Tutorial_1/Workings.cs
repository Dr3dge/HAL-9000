using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HAL_9000;
using System.Diagnostics;
using System.Net;
using System.Globalization;

namespace HAL_9000
{
    class Workings
    {
        public static string name = "Dave"; // Sets the default name to refer to the person as
        public static string userInput = null;
        public static void Program()
        {

            int guess;

            Main:
            userInput = Console.ReadLine().ToLower(); // If the user input is then it will change any capitals to lowercase
            try
            {
                guess = Convert.ToInt32(userInput); // Tries to convert the user input to a number
            }
            catch (FormatException)
            {
                guess = 9502; // If the user's input cannot be changed into a number, it reports nothing to the guessing game
            }
            catch (Exception)
            {
                guess = 0; // If the number cannot be processed, an error message is returned
            }

            while (true)
            {
                Random numberRand = new Random(); // Creates a random number in case of need

                int number = numberRand.Next(0, 11); // Randomises the number betweeb 1 and 10

                if (userInput.Contains("set name to") == true)
                {
                    name = userInput.Replace("set name to ","");
                    name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());
                    Writting.nameSet();
                } 
                else if (userInput.Contains("set name") == true)
                {
                    name = userInput.Replace("set name ", ""); // Removes "set name" from the string, leaving the desired name
                    name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower()); // Changes the name to all lowercase, then changing the first letter to uppercase
                    Writting.nameSet();
                }
                else if (userInput.Contains("my name is") == true)
                {
                    name = userInput.Replace("my name is ", ""); // Removes "my name is" from the string, leaving the desired name
                    name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower()); // Changes the name to all lowercase, then changing the first letter to uppercase
                    Writting.nameSet();
                }
                else if (userInput == "my name is not dave" || userInput == "im not dave")
                {
                    Writting.whatIsYourName();
                    name = Console.ReadLine(); // Sets the user's name to what the user writes
                    Writting.nameSet();
                }
                else if (userInput == "error test") // Function to test error message
                {
                    Writting.sorryDave();
                }
                else if (guess == number) // Guessing game functions
                {
                    Writting.winRepl();
                }
                else if (guess < number) // Guessing game functions
                {
                    Writting.wrongRepl();
                }
                // else if (userInput == "arduino")
                // {
                //     Arduino.Start(); // Will be used for handling interactions with an Arduino
                // }
                else if (userInput == "hello" || userInput == "hi" || userInput == "hey")
                {
                    Writting.sayHello();
                }
                else if (userInput == "how are you")
                {
                    Writting.iAmGood();
                    userInput = Console.ReadLine().ToLower();
                    if (userInput.Contains("good") == true)
                    {
                        Writting.thatsGood();
                    }
                    else if (userInput.Contains("great") == true)
                    {
                        Writting.thatsGood();
                    }
                    else if (userInput.Contains("bad") == true)
                    {
                        Writting.notSoGood();
                    }
                    else if (userInput.Contains("not good") == true)
                    {
                        Writting.notSoGood();
                    }
                    else if (userInput.Contains("terrible") == true)
                    {
                        Writting.notSoGood();
                    }
                    else if (userInput.Contains("eh") == true)
                    {
                        Writting.justAlright();
                    }
                    else if (userInput.Contains("alright") == true)
                    {
                        Writting.justAlright();
                    }
                }
                else if (userInput == "stop" || userInput == "end" || userInput == "terminate" || userInput == "exit")
                {
                    Console.Clear();
                    break;
                }
                else if (userInput == "circle")
                {
                    circleAreaCalc.Calculate();
                }
                else if (userInput == "cylinder")
                {
                    cylinderCalc.Calculate();
                }
                else if (userInput == "internet")
                {
                    try
                    {
                        programPlaces.Chrome();
                        Writting.chromeStarted();
                    }
                    catch
                    {
                        programPlaces.Firefox();
                        Writting.firefoxStarted();
                    }
                }
                else if (userInput == "install chrome")
                {
                    try
                    {
                    downloadHandler.Handler();
                    WebClient Client = new WebClient();
                    Client.DownloadFile("https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7BB3008FA8-ACE4-549A-37A5-DE431BE99A20%7D%26lang%3Den%26browser%3D4%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26brand%3DCHMA%26installdataindex%3Ddefaultbrowser/update2/installers/ChromeSetup.exe",
                            @"HAL's Downloads\ChromeSetup.exe");

                    Process.Start(@"HAL's Downloads\\ChromeSetup.exe");
                    }
                    catch
                    {
                        Writting.sorryDave();
                    }
                }
                else if (userInput == "install winrar")
                {
                    try
                    {
                    downloadHandler.Handler();
                    WebClient Client = new WebClient();
                    Client.DownloadFile("http://www.rarlab.com/rar/wrar521.exe",
                            @"HAL's Downloads\wrar50b7.exe");

                    Process.Start(@"HAL's Downloads\\wrar521.exe");
                    }
                    catch
                    {
                        Writting.sorryDave();
                    }
                }
                else if (userInput == "install notepad++")
                {
                    try
                    {
                    downloadHandler.Handler();
                    WebClient Client = new WebClient();
                    Client.DownloadFile("http://dl.notepad-plus-plus.org/downloads/6.x/6.7.5/npp.6.7.5.Installer.exe",
                            @"HAL's Downloads\npp.Installer.exe");

                    Process.Start(@"HAL's Downloads\\npp.Installer.exe");
                    }
                    catch
                    {
                        Writting.sorryDave();
                    }
                }
                else if (userInput == "install vlc")
                {
                    try
                    {
                    downloadHandler.Handler();
                    WebClient Client = new WebClient();
                    Client.DownloadFile("https://get.videolan.org/vlc/2.2.0/win32/vlc-2.2.0-win32.exe",
                            @"HAL's Downloads\vlc.exe");

                    Process.Start(@"HAL's Downloads\\vlc.exe");
                    }
                    catch
                    {
                        Writting.sorryDave();
                    }
                }
                else if (userInput == "install gimp")
                {
                    try
                    {
                    downloadHandler.Handler();
                    WebClient Client = new WebClient();
                    Client.DownloadFile("http://download.gimp.org/pub/gimp/v2.8/windows/gimp-2.8.14-setup-1.exe",
                            @"HAL's Downloads\gimp.exe");

                    Process.Start(@"HAL's Downloads\\gimp.exe");
                    }
                    catch
                    {
                        Writting.sorryDave();
                    }
                }
                else if (userInput == "install asc")
                {
                    try
                    {
                    downloadHandler.Handler();
                    WebClient Client = new WebClient();
                    Client.DownloadFile("http://download.iobit.com/advanced_systemcare_installer.exe",
                            @"HAL's Downloads\advanced_systemcare_installer.exe");

                    Process.Start(@"HAL's Downloads\\advanced_systemcare_installer.exe");
                    }
                    catch
                    {
                        Writting.sorryDave();
                    }
                }
                else if (userInput == "install java")
                {
                    try
                    {
                    downloadHandler.Handler();
                    WebClient Client = new WebClient();
                    Client.DownloadFile("http://javadl.sun.com/webapps/download/AutoDL?BundleId=79071",
                            @"HAL's Downloads\java.exe");

                    Process.Start(@"HAL's Downloads\\java.exe");
                    }
                    catch
                    {
                        Writting.sorryDave();
                    }
                }
                else if (userInput == "install avg")
                {
                    try
                    {
                    downloadHandler.Handler();
                    WebClient Client = new WebClient();
                    Client.DownloadFile("http://software-files-a.cnet.com/s/software/14/10/54/26/avg_free_stb_all_5751p1_177.exe",
                            @"HAL's Downloads\avg_free.exe");

                    Process.Start(@"HAL's Downloads\\avg_free.exe");
                    }
                    catch
                    {
                        Writting.sorryDave();
                    }
                }
                else if (userInput == "install visual studio")
                {
                    try
                    {
                        downloadHandler.Handler();
                        WebClient Client = new WebClient();
                        Client.DownloadFile("http://download.microsoft.com/download/9/6/4/96442E58-C65C-4122-A956-CCA83EECCD03/wdexpress_full.exe",
                                @"HAL's Downloads\wdexpress_full.exe");

                        Process.Start(@"HAL's Downloads\\wdexpress_full.exe");
                    }
                    catch
                    {
                        Writting.sorryDave();
                    }
                }
                else if (userInput == "install steam")
                {
                    try
                    {
                        downloadHandler.Handler();
                        WebClient Client = new WebClient();
                        Client.DownloadFile("http://media.steampowered.com/client/installer/SteamSetup.exe",
                                @"HAL's Downloads\SteamSetup.exe");

                        Process.Start(@"HAL's Downloads\\SteamSetup.exe");
                    }
                    catch
                    {
                        Writting.sorryDave();
                    }
                }
                else if (userInput == "install git" || userInput == "github")
                {
                    try
                    {
                        downloadHandler.Handler();
                        WebClient Client = new WebClient();
                        Client.DownloadFile("https://github-windows.s3.amazonaws.com/GitHubSetup.exe",
                                @"HAL's Downloads\GitHubSetup.exe");

                        Process.Start(@"HAL's Downloads\\GitHubSetup.exe");
                    }
                    catch
                    {
                        Writting.sorryDave();
                    }
                }
                else if (userInput == "install bittorrent")
                {
                    try
                    {
                        downloadHandler.Handler();
                        WebClient Client = new WebClient();
                        Client.DownloadFile("http://download-new.utorrent.com/endpoint/bittorrent/os/win/track/stable",
                                @"HAL's Downloads\BitTorrent.exe");

                        Process.Start(@"HAL's Downloads\\BitTorrent.exe");
                    }
                    catch
                    {
                        Writting.sorryDave();
                    }
                }
                else if (userInput == "install vm" || userInput == "install virtual machine" || userInput == "install virtual box")
                {
                    try
                    {
                        downloadHandler.Handler();
                        WebClient Client = new WebClient();
                        Client.DownloadFile("http://download.virtualbox.org/virtualbox/4.3.24/VirtualBox-4.3.24-98716-Win.exe",
                                @"HAL's Downloads\VirtualBox.exe");

                        Process.Start(@"HAL's Downloads\\VirtualBox.exe");
                    }
                    catch
                    {
                        Writting.sorryDave();
                    }
                }
                else if (userInput == "goto" || userInput == "website")
                {
                    Websites.gotoWebsite();
                }
                else if (userInput.Contains("google") == true)
                {
                    try
                    {
                        searchGoogle.chrome();
                        Writting.googleSearched();
                    }
                    catch
                    {
                        searchGoogle.firefox();
                        Writting.googleSearched();
                    }
                }
                else if (userInput.Contains("youtube") == true)
                {
                    try
                    {
                        searchYoutube.chrome();
                        Writting.youtubeSearched();
                    }
                    catch
                    {
                        searchYoutube.firefox();
                        Writting.youtubeSearched()
                    }
                }
                else if (userInput == "run" || userInput == "open")
                {
                    searchPrograms.findPrograms();
                }
                else if (userInput == "close")
                {
                    processKiller.Kill();
                }
                else if (userInput == "random")
                {
                    Generate.Random();
                }
                else if (userInput == "add to startup" || userInput == "autorun")
                {
                    addToStartup.registerInStartup();
                    Writting.startupAdd();
                }
                else if (userInput.Contains("username") == true)
                {
                    Username.getUsername();
                }
                else if (userInput == "help")
                {
                    Writting.help();
                }
                else if (userInput == "install help")
                {
                    Writting.installHelp();
                }
                else if (userInput == "web help" || userInput == "website help")
                {
                    Writting.websitesHelp();
                }
                else if (userInput == "arduino help")
                {
                    Writting.arduinoHelp();
                }
                else if (userInput == "kill")
                {
                    processKiller.winKill();
                }
                else if (userInput == "shutdown")
                {
                    processKiller.winSD();
                }
                else if (guess == 0)
                {
                    Writting.sorryDave();
                }
                else if (guess == 9502)
                {
                    Writting.nothing();
                }
                else
                {
                    Writting.sorryDave();
                }
                goto Main;
            }
            Writting.areYouSure();
        }
    }
}
