namespace Singleton
{
    /*
    En este patrón solo exista una y solo un objeto en nuestra aplicación.
    El objeto es dificil de cerar, tineen mucho rendimiento, una conexión con un tercero, servicio, hardware, etc.
    Pool de conexiones que no necesitamos crear muchos, solo uno.

    ES UNA TËCNICA
     */
    public class Singleton
    {
        private readonly static Singleton _instance = new Singleton();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
