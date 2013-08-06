using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace HAL_9000
{
    class Websites
    {
        public static void chromeFB()
        {
            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "www.facebook.com");
        }
        public static void chromeYT()
        {
            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "www.youtube.com");
        }
        public static void chromeTW()
        {
            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "www.twitter.com");
        }
        public static void chromeTU()
        {
            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "www.tumblr.com");
        }
        public static void firefoxFB()
        {
            Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", "www.facebook.com");
        }
        public static void firefoxYT()
        {
            Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", "www.youtube.com");
        }
        public static void firefoxTW()
        {
            Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", "www.twitter.com");
        }
        public static void firefoxTU()
        {
            Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", "www.tumblr.com");
        }
    }
}
