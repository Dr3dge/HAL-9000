using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace HAL_9000
{
    class addToStartup
    {
        public static void registerInStartup()
        {
            WshShell shell = new WshShell();
            string userName;
            IWshShortcut HAL_9000;
            userName = Environment.UserName;
            try
            {
                HAL_9000 = (IWshShortcut)shell.CreateShortcut("C:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\HAL_9000.lnk");
                HAL_9000.TargetPath = Application.ExecutablePath;
                HAL_9000.Description = "Run HAL-9000";
                HAL_9000.Save();
            }
            catch
            {
                HAL_9000 = (IWshShortcut)shell.CreateShortcut("D:\\Users\\" + userName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\HAL_9000.lnk");
                HAL_9000.TargetPath = Application.ExecutablePath;
                HAL_9000.Description = "Run HAL-9000";
                HAL_9000.Save();
            }
        }
    }
}