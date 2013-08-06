using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace HAL_9000
{
    class programPlaces
    {
        public static void Chrome()
        {
            try
            {
                Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe");
            }
            catch
            {
                Writting.sorryDave();
            }
        }
        public static void Firefox()
        {
            try
            {
                Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe");
            }
            catch
            {
                Writting.sorryDave();
            }
        }
        public static void Word()
        {
            try
            {
                Process.Start(@"C:\Program Files\Microsoft Office\Office14\WINWORD.exe");
            }
            catch
            {
                Writting.sorryDave();
            }
        }
        public static void powerPoint()
        {
            try
            {
                Process.Start(@"C:\Program Files\Microsoft Office\Office14\POWERPNT.exe");
            }
            catch
            {
                Writting.sorryDave();
            }
        }
        public static void oneNote()
        {
            try
            {
                Process.Start(@"C:\Program Files\Microsoft Office\Office14\ONENOTE.exe");
            }
            catch
            {
                Writting.sorryDave();
            }
        }
        public static void Excel()
        {
            try
            {
                Process.Start(@"C:\Program Files\Microsoft Office\Office14\EXCEL.exe");
            }
            catch
            {
                Writting.sorryDave();
            }
        }
        public static void notepadPP()
        {
            try
            {
                Process.Start(@"C:\Program Files\Notepad++\notepad++.exe");
            }
            catch
            {
                Writting.sorryDave();
            }
        }
        public static void Notepad()
        {
            try
            {
                Process.Start(@"C:\Windows\System32\notepad.exe");
            }
            catch
            {
                Writting.sorryDave();
            }
        }
        public static void CMD()
        {
            try
            {
                Process.Start( @"C:\\Windows\\System32\\cmd.exe");
            }
            catch
            {
                Writting.sorryDave();
            }
        }
    }
}
