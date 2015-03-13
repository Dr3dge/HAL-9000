using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HAL_9000
{
    class downloadHandler
    {
        public static void Handler()
        {
            string downloads = @"HAL's Downloads";
            bool IsExists = Directory.Exists(downloads);
            if (!IsExists) Directory.CreateDirectory(downloads);
        }
    }
}
