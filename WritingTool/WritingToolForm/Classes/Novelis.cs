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

        public static bool CheckFilepathExists(string path, bool create = false)
        {
            if(!Directory.Exists(path))
            {
                return false;
            }
            if (!Directory.Exists(path) && create)
            {
                Directory.CreateDirectory(path);
                return true;
            } else
            {
                return true;
            }
        }
    }
}
