using System;

namespace State
{
    /// <summary>
    /// State: patrón de diseño de comportamiento
    /// 
    /// Sirve para usar comportamientro en nuestros objetos.
    /// 
    /// Se define por su nombre, state. Forma que dependiendo 
    /// el estado del objeto el objeto va a actuar de una forma.
    /// 
    /// Contexto: objeto que tiene estado.
    /// Interface: representación de las clases que van a implementar los estados.
    /// abajo: Clases que implementan el estado.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ConsumerContext consumerContext = new ConsumerContext();
            Console.WriteLine(consumerContext.GetState());

            consumerContext.Request(100);
            Console.WriteLine(consumerContext.GetState());

            consumerContext.Request(50);
            Console.WriteLine($"Amount={consumerContext.Residue}");
            Console.WriteLine(consumerContext.GetState());


            consumerContext.Request(100);
            Console.WriteLine($"Amount={consumerContext.Residue}");
            Console.WriteLine(consumerContext.GetState());

            consumerContext.Request(50);
            Console.WriteLine($"Amount={consumerContext.Residue}");
            Console.WriteLine(consumerContext.GetState());

            consumerContext.Request(50);
            Console.WriteLine(consumerContext.GetState());
        }
    }
}
