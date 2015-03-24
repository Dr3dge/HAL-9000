using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using HAL_9000_Writting;

namespace HAL_9000
{
    class addToStartup
    {
        public static void registerInStartup()
        {
            WshShell shell = new WshShell();
            IWshShortcut HAL_9000;
            try
            {
                HAL_9000 = (IWshShortcut)shell.CreateShortcut("%APPDATA%\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\HAL_9000.lnk");
                try
                {
                    HAL_9000.TargetPath = @"C:\Program Files\HAL-9000\HAL-9000.exe";
                    HAL_9000.Description = "Run HAL-9000";
                    HAL_9000.Save();
                }
                catch
                {
                    Writting.halIsMissing();
                }
            }
            catch
            {
                HAL_9000 = (IWshShortcut)shell.CreateShortcut("%APPDATA%\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\HAL_9000.lnk");
                try
                {
                    HAL_9000.TargetPath = @"C:\Program Files\HAL-9000\HAL-9000.exe";
                    HAL_9000.Description = "Run HAL-9000";
                    HAL_9000.Save();
                }
                catch
                {
                    Writting.halIsMissing();
                }
            }
        }
    }
}