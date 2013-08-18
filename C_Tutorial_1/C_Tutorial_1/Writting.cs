using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HAL_9000
{
    public class Writting
    {
        public static void startWrite()
        {
            Console.WriteLine("Program Execute");
            Console.WriteLine("................");
            Console.WriteLine("................");
            Console.WriteLine("................");
            Console.WriteLine("................");
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
            Console.WriteLine("I'm sorry Dave, I'm afraid I can't do that.");
        }
        public static void help()
        {
            Console.WriteLine();
            Console.WriteLine("Help              -       Displays this help message");
            Console.WriteLine("Install help      -       Displays what programs can be installed");
            Console.WriteLine("Websites help     -       Displays what websites can be opened");
            Console.WriteLine("# Between 1 & 10  -       Pick a number and hope that it's the winning one");
            Console.WriteLine("Hello             -       Say hello to your friendly HAL-9000");
            Console.WriteLine("How are you       -       Ask HAL-9000 how he is doing");
            Console.WriteLine("Random            -       HAL-9000 can generate a random number or password");
            Console.WriteLine("Circle            -       Want a circle calculated for you? HAL-9000 can do it");
            Console.WriteLine("Cylinder          -       Want a cylinder calculated for you? Can do it too!");
            Console.WriteLine("Internet          -       Opens your internet browser");
            Console.WriteLine("Google            -       Search Google for something");
            Console.WriteLine("Search Youtube    -       Search Youtube for something");
            Console.WriteLine("CMD               -       Opens the command line");
            Console.WriteLine("Add to startup    -       Makes it so HAL-9000 starts with your computer");
            Console.WriteLine("Run               -       Run a program of your choosing (WIP)");
            Console.WriteLine("Close             -       Closes the specified process");
            Console.WriteLine("Kill              -       Kills Windows");
            Console.WriteLine("Shutdown          -       Shuts down Windows");
            Console.WriteLine("Stop              -       Tells HAL-9000 that you are finished");
            Console.WriteLine();
        }
        public static void installHelp()
        {
            Console.WriteLine();
            Console.WriteLine("Install VLC       -       Downloads and installs VLC Media Player for you");
            Console.WriteLine("Install Chrome    -       Downloads and installs Googel Chrome for you");
            Console.WriteLine("Install winRAR    -       Downloads and installs winRAR for you");
            Console.WriteLine("Install Notepad++ -       Downloads and installs Notepad++ for you");
            Console.WriteLine("Install GIMP      -       Downloads and installs GIMP 2 for you");
            Console.WriteLine("Install ASC       -       Downloads and installs Iobit Advanced SystemCare");
            Console.WriteLine("Install AVG       -       Downloads and installs AVG Antivirus Free for you");
            Console.WriteLine("Install Java      -       Downloads and installs Java for you");
            Console.WriteLine();
        }
        public static void websitesHelp()
        {
            Console.WriteLine();
            Console.WriteLine("Website           -       Launches the desired website");
            Console.WriteLine();
        }
    }
}