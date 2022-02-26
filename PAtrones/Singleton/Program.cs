using System;

namespace Singleton
{

    /*
     singleton: es un patrón de diseño creacional. Nos ayuda a crear objetos.

    Técnica.
     */
    class Program
    {
        static void Main(string[] args)
        {
            var logger = Log.Instance;

            logger.save("Hola mundo!");
            logger.save("Estoy haciendo mi primer singleton en C#");

            var a = Log.Instance;
            var b = Log.Instance;

            Console.WriteLine(a == b);

        }
    }
}
