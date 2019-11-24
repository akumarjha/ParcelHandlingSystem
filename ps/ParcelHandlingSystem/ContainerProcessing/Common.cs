using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcelHandlingSystem
{
    public static class Common
    {
        public static string ApplicationPath
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
                //string workingDirectory = Environment.CurrentDirectory;
                ////MessageBox.Show();
                //string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
                //return projectDirectory;
            }
        }
    }
}
