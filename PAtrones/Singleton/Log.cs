using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Log
    {
        private readonly static Log _instance = new Log();
        private string _path = "log.txt";

        private Log() { }

        public static Log Instance
        {
            get
            {
                return _instance;
            }
        }

        public void save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }

    }
}
