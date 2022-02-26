using DesignPatters.Repository;
using PatterDesigns.Models.ViewModels;
using PatterDesigns.Strategies.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatterDesigns.Strategies
{
    public class BeerContext
    {
        private IBeerStrategy _strategy;

        private IBeerStrategy Strategy
        {
            set
            {
                _strategy = value;
            }
        }

        public BeerContext(IBeerStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Add(FormBeerViewModel beerVm, IUnitOfWork unitOfwork)
        {
            _strategy.Add(beerVm, unitOfwork);
        }

    }
}
