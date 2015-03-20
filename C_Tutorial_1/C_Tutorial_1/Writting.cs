using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HAL_9000
{
    public class Writting
    {

        public static void Initialization()
        {
            Console.WriteLine("Loading...");
            Thread.Sleep(250);
            Console.WriteLine("Initialized Sucessfully");
            Console.WriteLine("Press any key to continue");

            Console.ReadKey();
            Console.Clear();
        }
        public static void startWrite()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("I am HAL 9000");
            Console.WriteLine("Type 'help' in for assistance");
        }
        public static void winRepl()
        {
            Console.WriteLine("Are you sure you're making the right decision? I think we should stop.");
            Console.WriteLine("You win.");
        }
        public static void wrongRepl()
        {
            Console.WriteLine("Well, tell whoever it is that I can't take any of this seriously unless I know.");
            Console.WriteLine("who I'm talking to.");
        }
        public static void loseRepl()
        {
            Console.WriteLine("It is dangerous to remain here. You must leave within two days.");
        }
        public static void probRepl()
        {
            Console.WriteLine("There was a problem with your answer.");
        }
        public static void nothing()
        {
        }
        public static void sayHello()
        {
            Console.WriteLine("Hello, I hope you are having a good day.");
        }
        public static void iAmGood()
        {
            Console.WriteLine("I am doing quite well considering that I am a computer.");
            Console.WriteLine("How are you doing?");
        }
        public static void thatsGood()
        {
            Console.WriteLine("That is good, I hope that the rest of your day goes well.");
        }
        public static void notSoGood()
        {
            Console.WriteLine("Aww, that's no good, I hope you have a better day tomorrow.");
        }
        public static void justAlright()
        {
            Console.WriteLine("Just alright? Well I guess that's better than bad.");
        }
        public static void terminated()
        {
            Console.WriteLine("Program Terminated");
        }
        public static void areYouSure()
        {
            Console.WriteLine("Are you sure?");
        }
        public static void chromeStarted()
        {
            Console.WriteLine("Google Chrome Started");
        }
        public static void firefoxStarted()
        {
            Console.WriteLine("Mozilla Firefox Started");
        }
        public static void ieStarted()
        {
            Console.WriteLine("Internet Explorer Started");
        }
        public static void siteLaunched()
        {
            Console.WriteLine("Website launched successfully");
        }
        public static void googleSearched()
        {
            Console.WriteLine("Googled successfully");
        }
        public static void youtubeSearched()
        {
            Console.WriteLine("Searching Youtube");
        }
        public static void searchComp()
        {
            Console.WriteLine("Searching Computer.......");
        }
        public static void Searching()
        {
            Console.WriteLine("Searching...");
        }
        public static void runWhat()
        {
            Console.WriteLine("What program do you wish to open?");
        }
        public static void killWhat()
        {
            Console.WriteLine("What process do you wish to kill?");
        }
        public static void websiteWhat()
        {
            Console.WriteLine("What website do you wish to open?");
        }
        public static void Arduino()
        {
            Console.WriteLine("Check the aurduino help for options");
            Console.WriteLine("What do you wish to run?");
        }
        public static void reboot()
        {
            Console.WriteLine("Reboot Compleated: Continue");
        }
        public static void startupAdd()
        {
            Console.WriteLine("HAL-9000 successfully added to startup");
        }
        public static void sorryDave()
        {
            Console.WriteLine("I'm sorry " + Workings.name + ", I'm afraid I can't do that.");
        }
        public static void whatIsYourName()
        {
            Console.WriteLine();
            Console.WriteLine("Than what is your name?");
            Console.WriteLine();
        }
        public static void nameSet()
        {
            Console.WriteLine("Name set to " + Workings.name);
        }
        public static void help()
        {
            Console.WriteLine();
            Console.WriteLine("Help               -       Displays this help message");
            Console.WriteLine("Install help       -       Displays what programs can be installed");
            Console.WriteLine("Websites help      -       Displays what websites can be opened");
            Console.WriteLine("Arduino help       -       Displays what aurduino programs can be run");
            Console.WriteLine("Update HAL-9000    -       Updates HAL if there is an existing installation");
            Console.WriteLine("My name is         -       Tell HAL your name");
            Console.WriteLine("# Between 1 & 10   -       Pick a number and hope that it's the winning one");
            Console.WriteLine("Hello              -       Say hello to your friendly HAL-9000");
            Console.WriteLine("How are you        -       Ask HAL-9000 how he is doing");
            Console.WriteLine("Random             -       HAL-9000 can generate a random number or password");
            Console.WriteLine("Circle             -       Want a circle calculated for you? HAL-9000 can do it");
            Console.WriteLine("Cylinder           -       Want a cylinder calculated for you? Can do it too!");
            Console.WriteLine("Internet           -       Opens your internet browser");
            Console.WriteLine("Google             -       Search Google for something");
            Console.WriteLine("Youtube            -       Search Youtube for something");
            Console.WriteLine("CMD                -       Opens the command line");
            Console.WriteLine("Add to startup     -       Makes it so HAL-9000 starts with your computer");
            Console.WriteLine("Run                -       Run a program of your choosing");
            Console.WriteLine("Close              -       Closes the specified process");
            Console.WriteLine("Kill               -       Kills Windows");
            Console.WriteLine("Shutdown           -       Shuts down Windows");
            Console.WriteLine("Stop               -       Tells HAL-9000 that you are finished");
            Console.WriteLine();
        }
        public static void installHelp()
        {
            Console.WriteLine();
            Console.WriteLine("Install HAL-9000      -       Downloads and installs HAL-9000 for you");
            Console.WriteLine("Install VLC           -       Downloads and installs VLC Media Player for you");
            Console.WriteLine("Install Chrome        -       Downloads and installs Googel Chrome for you");
            Console.WriteLine("Install winRAR        -       Downloads and installs winRAR for you");
            Console.WriteLine("Install Notepad++     -       Downloads and installs Notepad++ for you");
            Console.WriteLine("Install GIMP          -       Downloads and installs GIMP 2 for you");
            Console.WriteLine("Install ASC           -       Downloads and installs Iobit Advanced SystemCare");
            Console.WriteLine("Install AVG           -       Downloads and installs AVG Antivirus Free for you");
            Console.WriteLine("Install Java          -       Downloads and installs Java for you");
            Console.WriteLine("Install Steam         -       Downloads and installs Steam for you");
            Console.WriteLine("Install Visual Studio -       Downloads and installs Visual Studio for you");
            Console.WriteLine("Install GitHub        -       Downloads and installs GitHub for you");
            Console.WriteLine("Install BitTorrent    -       Downloads and installs BitTorrent for you");
            Console.WriteLine("Install Virtual Box   -       Downloads and installs Virtual Box for you");
            Console.WriteLine();
        }
        public static void websitesHelp()
        {
            Console.WriteLine();
            Console.WriteLine("Website           -       Launches the desired website");
            Console.WriteLine();
        }
        public static void arduinoHelp()
        {
            Console.WriteLine();
            Console.WriteLine("Arduino           -       Launches the arduino program");
            Console.WriteLine();
        }

        public static void alreadyInstalled()
        {
            Console.WriteLine();
            Console.WriteLine("This program is already installed");
            Console.WriteLine();
        }
        public static void successfullyInstalled()
        {
            Console.WriteLine();
            Console.WriteLine("This program was successfully installed");
            Console.WriteLine();
        }
        public static void halIsMissing()
        {
            Console.WriteLine();
            Console.WriteLine("HAL-9000 is not installed, try installing HAL");
            Console.WriteLine();
        }

        public static void halInstalled()
        {
            Console.WriteLine();
            Console.WriteLine("HAL-9000 has been successfully installed");
            Console.WriteLine();
        }
        public static void halUpdated()
        {
            Console.WriteLine();
            Console.WriteLine("HAL-9000 has been successfully updated");
            Console.WriteLine();
        }

        public static void halUninstalled()
        {
            Console.WriteLine();
            Console.WriteLine("HAL-9000 has been successfully uninstalled");
            Console.WriteLine();
        }
        public static void updaterIsMissing()
        {
            Console.WriteLine();
            Console.WriteLine("HAL-9000 Updater is not installed, try installing HAL");
            Console.WriteLine();
        }
    }
}