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
    public class BeerWithBrandStrategy : IBeerStrategy
    {
        public void Add(FormBeerViewModel beerVm, IUnitOfWork unitOfwork)
        {
            var beer = new Beer()
            {
                Name = beerVm.Name,
                Style = beerVm.Style,
            };

            var brand = new Brand();
            brand.Name = beerVm.OtherBrand;
            brand.BrandId = Guid.NewGuid();

            unitOfwork.Brands.Add(brand);
            beer.BrandId = brand.BrandId;
            unitOfwork.Beers.Add(beer);

            unitOfwork.Save();
        }

    }
}
