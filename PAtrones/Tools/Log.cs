using System;
using System.IO;

namespace Tools
{
    /* no puede heredar, para esto agrego sealed */
    public sealed class Log
    {
        private static Log _instance = null;
        private string _path;
        private static object _protected = new object();

        private Log(string path) 
        {
            _path = path;
        }

        //si trabajo con hilos, puedo manejar algo para proteger y que solo se cree una instancia
        /// <summary>
        /// con lock protegemos con hilos, para que el primer  hilo sea el único que se ejecute,
        /// luego otro se ejecuta va a esperar a que temrine que se ejecute
        /// </summary>
        /// <param name="_path"></param>
        /// <returns></returns>

        public static Log GetInstance(string _path)
        {
            lock(_protected)
            {
                if (_instance == null)
                {
                    _instance = new Log(_path);
                }
            }

            return _instance;
        }

        public void save(string message)
        {
            File.AppendAllText(_path, $"Message={message}, Date={DateTime.UtcNow}{Environment.NewLine}");
        }

    }
}
