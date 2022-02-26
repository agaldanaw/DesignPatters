using DesignPatters.Models.Data;
using DesignPatters.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PatterDesigns.Models.ViewModels;
using PatterDesigns.Strategies;
using PatterDesigns.Strategies.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools.Generator;

namespace PatterDesigns.Controllers
{
    public class BeerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public BeerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<BeerViewModel> beers = from b in _unitOfWork.Beers.Get()
                                      select new BeerViewModel()
                                      {
                                          BeerId = b.BeerId,
                                          Name = b.Name,
                                          Style = b.Style
                                      };

            return View(beers);
        }

        [HttpGet]
        public IActionResult Add()
        {
            GetBrandsData();
            return View();
        }


        [HttpPost]
        public IActionResult Add(FormBeerViewModel beerVM)
        {
            if(!ModelState.IsValid)
            {
                GetBrandsData();
                return View("Add", beerVM);
            }

            var context = beerVM.BrandId.HasValue ?
                new BeerContext(new BeerStrategy()) :
                new BeerContext(new BeerWithBrandStrategy());
            context.Add(beerVM, _unitOfWork);
            return View();
        }

        #region HELPERS
        private void GetBrandsData()
        {
            var brands = _unitOfWork.Brands.Get();
            ViewBag.Brands = new SelectList(brands, "BrandId", "Name");
        }
        #endregion
    }
}
