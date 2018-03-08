using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novelis
{
    class Novelis
    {
        public static string Filepath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Novelis\\";

        public static void CheckFilepathExists(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
    }
}
