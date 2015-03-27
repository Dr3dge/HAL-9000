using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HALSync
{
    public partial class HALSync : Form
    {
        public static string directoryToWatch = @"C:\Users\" + Environment.UserName + "\\HALSync";
        public HALSync()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            if (!Directory.Exists(directoryToWatch))
            {
                Directory.CreateDirectory(directoryToWatch);
            }
            else if (Directory.Exists(directoryToWatch))
            {
                createFileWatcher();
            }
        }
        public void createFileWatcher()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = directoryToWatch;
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            watcher.Changed += new FileSystemEventHandler(onChanged);
            watcher.Created += new FileSystemEventHandler(onChanged);
            watcher.Deleted += new FileSystemEventHandler(onChanged);
            watcher.Renamed += new RenamedEventHandler(onChanged);

            watcher.EnableRaisingEvents = true;
        }
        public static void onChanged(object source, FileSystemEventArgs e)
        {

        }
    }
}