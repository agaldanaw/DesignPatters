using System;

namespace DependencyInjection
{
    /*
     Inyección de dependencias: es de os patrones más utilizados

    LTrata sobrte quitar la responsabilidad de una clase de crar objetos a partir de otras clases. No sabe como crear objetos, solo se le inyecta el objeto una vez creado.

    se inyecta en un método o en un constructor.

    Resuelve principio solid: Inversion de dependencia

     */
    class Program
    {
        static void Main(string[] args)
        {
            var beer = new Beer("pikantus", "Erdinger");
            var drikWithBeer = new DrinkWithBeer(10, 1, beer);
            drikWithBeer.Build();
        }
    }
}
