using System;

namespace Builder
{
    /// <summary>
    /// Builder: patrón de diseño creacional
    /// Constructor
    /// 
    /// Tiene el objetivo de crear objetos complejos.
    /// Su constructor es enorme? sirve este patrón.
    /// 
    /// Product: objeto creado
    /// ConcreteBuilder: crea el objeto en diferentes ordenes, pasos, depende el objeto, implementa IBuider, cómo crear el objeto
    /// IBuilder: organización de los concreteBuilder
    /// Director: Se encarga de decirle al builder el orden el cual crear el objeto, los pasos.
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new PreparedAlcoholicDrinkConcreteBuilder();
            var barmanDirector = new BarmanDirector(builder);

            barmanDirector.PrepareMargarita();

            var preparedDrink = builder.GetPreparedDrink();
            Console.WriteLine(preparedDrink.Result);

            barmanDirector.PreparePineapleCream();

            var preparedDrink2 = builder.GetPreparedDrink();
            Console.WriteLine(preparedDrink2.Result);

        }
    }
}
