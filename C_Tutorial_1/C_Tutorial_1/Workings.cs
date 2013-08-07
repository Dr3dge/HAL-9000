using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HAL_9000;
using System.Diagnostics;
using System.Net;

namespace HAL_9000
{
    class Workings
    {
        public static void Program()
        {

            int guess;

            Main:
            string guessInput = Console.ReadLine();
            try
            {
                guess = Convert.ToInt32(guessInput);
            }
            catch (FormatException)
            {
                guess = 9502;
            }
            catch (Exception)
            {
                guess = 0;
            }

            while (true)
            {
                Random numberRand = new Random();

                int number = numberRand.Next(0, 11);

                if (guess == number)
                {
                    Writting.winRepl();
                }
                else if (guess < number)
                {
                    Writting.wrongRepl();
                }
                else if (guessInput == "hello" || guessInput == "hi" || guessInput == "hey" || guessInput == "Hello" || guessInput == "Hi" || guessInput == "Hey")
                {
                    Writting.sayHello();
                }
                else if (guessInput == "how are you" || guessInput == "How are you")
                {
                    Writting.iAmGood();
                }
                else if (guessInput == "good" || guessInput == "Good" || guessInput == "im good" || guessInput == "Im Good" || guessInput == "i'm good" || guessInput == "I'm Good" || guessInput == "i am good" || guessInput == "I am good")
                {
                    Writting.thatsGood();
                }
                else if (guessInput == "close" || guessInput == "stop" || guessInput == "end" || guessInput == "terminate" || guessInput == "exit" || guessInput == "Close" || guessInput == "Stop" || guessInput == "End" || guessInput == "Terminate" || guessInput == "Exit ")
                {
                    break;
                }
                else if (guessInput == "circle" || guessInput == "Circle")
                {
                    circleAreaCalc.Calculate();
                }
                else if (guessInput == "cylinder" || guessInput == "Cylinder")
                {
                    cylinderCalc.Calculate();
                }
                else if (guessInput == "internet" || guessInput == "Internet")
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
                else if (guessInput == "word" || guessInput == "Word")
                {
                    programPlaces.Word();
                    Writting.wordStarted();
                }
                else if (guessInput == "powerpoint" || guessInput == "Powerpoint" || guessInput == "PowerPoint")
                {
                    programPlaces.powerPoint();
                    Writting.ppStarted();
                }
                else if (guessInput == "onenote" || guessInput == "Onenote" || guessInput == "OneNote")
                {
                    programPlaces.oneNote();
                    Writting.oneNoteStarted();
                }
                else if (guessInput == "excel" || guessInput == "Excel")
                {
                    programPlaces.Excel();
                    Writting.excelStarted();
                }
                else if (guessInput == "notepad" || guessInput == "Notepad")
                {
                    try
                    {
                        programPlaces.notepadPP();
                        Writting.notepadPPStarted();
                    }
                    catch
                    {
                        programPlaces.Notepad();
                        Writting.notepadStarted();
                    }
                }
                else if (guessInput == "cmd" || guessInput == "CMD" || guessInput == "console" || guessInput == "Console")
                {
                    programPlaces.CMD();
                    Writting.cmdStarted();
                }
                else if (guessInput == "install chrome" || guessInput == "Install Chrome")
                {
                    downloadHandler.Handler();
                    WebClient Client = new WebClient();
                    Client.DownloadFile("https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7BB3008FA8-ACE4-549A-37A5-DE431BE99A20%7D%26lang%3Den%26browser%3D4%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26brand%3DCHMA%26installdataindex%3Ddefaultbrowser/update2/installers/ChromeSetup.exe",
                            @"HAL's Downloads\ChromeSetup.exe");

                    Process.Start(@"HAL's Downloads\\ChromeSetup.exe");
                }
                else if (guessInput == "install winRAR" || guessInput == "install winrar" || guessInput == "Install winRAR")
                {
                    downloadHandler.Handler();
                    WebClient Client = new WebClient();
                    Client.DownloadFile("http://www.rarlab.com/rar/wrar50b7.exe",
                            @"HAL's Downloads\wrar50b7.exe");

                    Process.Start(@"HAL's Downloads\\wrar50b7.exe");
                }
                else if (guessInput == "install notepad++" || guessInput == "Install Notepad++")
                {
                    downloadHandler.Handler();
                    WebClient Client = new WebClient();
                    Client.DownloadFile("http://download.tuxfamily.org/notepadplus/6.4.3/npp.6.4.3.Installer.exe",
                            @"HAL's Downloads\npp.6.4.3.Installer.exe");

                    Process.Start(@"HAL's Downloads\\npp.6.4.3.Installer.exe");
                }
                else if (guessInput == "install vlc" || guessInput == "Install VLC")
                {
                    downloadHandler.Handler();
                    WebClient Client = new WebClient();
                    Client.DownloadFile("http://vlc.mirror.uber.com.au/vlc/2.0.8/win32/vlc-2.0.8-win32.exe",
                            @"HAL's Downloads\vlc-2.0.8-win32.exe");

                    Process.Start(@"HAL's Downloads\\vlc-2.0.8-win32.exe");
                }
                else if (guessInput == "install gimp" || guessInput == "Install GIMP")
                {
                    downloadHandler.Handler();
                    WebClient Client = new WebClient();
                    Client.DownloadFile("http://aarnet.dl.sourceforge.net/project/gimp-win/GIMP%20%2B%20GTK%2B%20%28stable%20release%29/GIMP%202.8.6/gimp-2.8.6-setup.exe",
                            @"HAL's Downloads\gimp-2.8.6-setup.exe");

                    Process.Start(@"HAL's Downloads\\gimp-2.8.6-setup.exe");
                }
                else if (guessInput == "install asc" || guessInput == "Install ASC")
                {
                    downloadHandler.Handler();
                    WebClient Client = new WebClient();
                    Client.DownloadFile("http://download.iobit.com/advanced_systemcare_installer.exe",
                            @"HAL's Downloads\advanced_systemcare_installer.exe");

                    Process.Start(@"HAL's Downloads\\advanced_systemcare_installer.exe");
                }
                else if (guessInput == "install java" || guessInput == "Install Java")
                {
                    downloadHandler.Handler();
                    WebClient Client = new WebClient();
                    Client.DownloadFile("http://javadl.sun.com/webapps/download/AutoDL?BundleId=79071",
                            @"HAL's Downloads\java.exe");

                    Process.Start(@"HAL's Downloads\\java.exe");
                }
                else if (guessInput == "install avg" || guessInput == "Install AVG")
                {
                    downloadHandler.Handler();
                    WebClient Client = new WebClient();
                    Client.DownloadFile("http://af-download.avg.com/filedir/inst/avg_free_stb_all_2013_3345_free.exe",
                            @"HAL's Downloads\avg_free.exe");

                    Process.Start(@"HAL's Downloads\\avg_free.exe");
                }
                else if (guessInput == "goto" || guessInput == "Goto" || guessInput == "website" || guessInput == "Website")
                {
                    Websites.gotoWebsite();
                }
                else if (guessInput == "google" || guessInput == "Google")
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
                else if (guessInput == "search youtube" || guessInput == "Search youtube" || guessInput == "Search Youtube")
                {
                    try
                    {
                        searchYoutube.chrome();
                        Writting.youtubeSearched();
                    }
                    catch
                    {
                        searchYoutube.firefox();
                        Writting.youtubeSearched();
                    }
                }
                else if (guessInput == "run" || guessInput == "Run")
                {
                    searchPrograms.findPrograms();
                }
                else if (guessInput == "kill" || guessInput == "Kill")
                {
                    processKiller.Kill();
                }
                else if (guessInput == "random" || guessInput == "Random")
                {
                    Generate.Random();
                }
                else if (guessInput == "add to startup" || guessInput == "Add to startup" || guessInput == "autorun" || guessInput == "Autorun")
                {
                    addToStartup.registerInStartup();
                    Writting.startupAdd();
                }
                else if (guessInput == "username" || guessInput == "Username" || guessInput == "current username" || guessInput == "Current username" || guessInput == "Current Username")
                {
                    Username.getUsername();
                }
                else if (guessInput == "help" || guessInput == "Help")
                {
                    Writting.help();
                }
                else if (guessInput == "install help" || guessInput == "Install help" || guessInput == "Install Help")
                {
                    Writting.installHelp();
                }
                else if (guessInput == "web help" || guessInput == "Web help" || guessInput == "website help" || guessInput == "Website help" || guessInput == "Website Help")
                {
                    Writting.websitesHelp();
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
