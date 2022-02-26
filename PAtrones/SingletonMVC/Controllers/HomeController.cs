using DesignPatters.Models.Data;
using DesignPatters.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SingletonMVC.Configuration;
using SingletonMVC.Models;
using System.Diagnostics;
using Tools;

namespace SingletonMVC.Controllers
{
    public class HomeController : Controller
    {
        private Log _logger;
        private readonly IOptions<Myconfig> _config; // este ayuda a la inyección de dependencias de objetos
        private readonly IRepository<Beer> _beerRepository;
        public HomeController(IOptions<Myconfig> config, 
            IRepository<Beer> beer)
        {
            _config = config;
            _logger = Log.GetInstance(_config.Value.PathLog);
            _beerRepository = beer;
        }

        public IActionResult Index()
        {
            _logger.save("Entro a index");

            var beers = _beerRepository.Get();

            return View("Index", beers);
        }

        public IActionResult Privacy()
        {
            _logger.save("Entro a Privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
