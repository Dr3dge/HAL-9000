using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HAL_9000
{
    class Username
    {
        public static void getUsername()
        {
            string userName;
            userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            Console.WriteLine(userName);
        }
    }
}
