using Repository.Implementation;
using Repository.Interface;
using Repository.Models;
using System;
using System.Linq;

namespace Repository
{
    class Program
    {
        /// <summary>
        /// Repository: hacer intermediaron entre manejo de datos y dominio. Manejo de la data
        /// Trasnparente al framework. EntityFramework.
        /// ORM mapeo de base de datos para usarlo como orientado a objetos.
        /// Es un patrón estructural.
        /// 
        /// La aplicación no debe de enterarse si vamos a los datos y donde están esos datos.
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            using (var context = new DesignPatternsContext())
            {
                var beerRepository = new Repository<Beer>(context);
                var beer = new Beer();
                beer.Name = "Poker 2";
                beer.Style = "Lager";
                beerRepository.Add(beer);
                beerRepository.Save();
                
                foreach(var beerDb in beerRepository.Get())
                {
                    Console.WriteLine(beerDb.Name);
                }
            }
        }
    }
}
