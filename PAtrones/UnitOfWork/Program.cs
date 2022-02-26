using Repository.Models;
using System;

namespace UnitOfWork
{
    class Program
    {
        /// <summary>
        /// UnitOfwork: con un conjunto de peticiones a db podemos agruparlas y mandarlas juntas
        /// ahorrando solicitudes en cada iteracción.
        /// 
        /// Agrupa los repositorios, para trabajarlos como una unidad de trabajo.
        /// ORganizar repository.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine(Guid.NewGuid().ToString("N"));

            using (var context = new DesignPatternsContext())
            {
                var unitOfWork = new UnitOfWork(context);
                var beer = new Beer();
                beer.Name = "Poker 4";
                beer.Style = "Lager";
                unitOfWork.Beers.Add(beer);

                foreach (var beerDb in unitOfWork.Beers.Get())
                {
                    Console.WriteLine(beerDb.Name);
                }

                var brand = new Brand();
                brand.Name = "Brand 2";
                unitOfWork.Brands.Add(brand);

                unitOfWork.Save();
                foreach (var brandDb in unitOfWork.Brands.Get())
                {
                    Console.WriteLine(brandDb.Name);
                }

                

            }
            Console.WriteLine("Hello World!");
        }
    }
}
