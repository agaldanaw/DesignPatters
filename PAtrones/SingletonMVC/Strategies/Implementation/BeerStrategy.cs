using DesignPatters.Models.Data;
using DesignPatters.Repository;
using PatterDesigns.Models.ViewModels;
using PatterDesigns.Strategies.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatterDesigns.Strategies.Implementation
{
    public class BeerStrategy : IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVm, IUnitOfWork unitOfwork)
        {
            var beer = new Beer()
            {
                Name = beerVm.Name,
                Style = beerVm.Style,
                BrandId = beerVm.BrandId.Value
            };

            unitOfwork.Beers.Add(beer);
            unitOfwork.Beers.Save();
        }
    }
}
