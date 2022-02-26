using DesignPatters.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools.Generator;

namespace PatterDesigns.Controllers
{
    public class GeneratorFileController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly GeneratorConcreteBuilder _generatorConcreteBuilder;

        public GeneratorFileController(IUnitOfWork unitOfWork
            , GeneratorConcreteBuilder generatorConcreteBuilder)
        {
            _unitOfWork = unitOfWork;
            _generatorConcreteBuilder = generatorConcreteBuilder;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateFile(int optionFile)
        {
            try
            {
                var beer = _unitOfWork.Beers.Get();
                List<string> content = beer.Select(x => x.Name).ToList();
                string path = "file_" + DateTime.Now.Ticks + "_" + new Random().Next(1000) + ".txt";

                var generatorDirector = new GeneratorDirector(_generatorConcreteBuilder);

                if (optionFile == 1)
                    generatorDirector.CreateSimpleJsonGenerator(content, path);
                else
                    generatorDirector.CreateSimplePipeGenerator(content, path);

                var generator = _generatorConcreteBuilder.GetGenerator();
                generator.Save();
                return Json("archivo generado");
            }
            catch(Exception ex)
            {
                return BadRequest();
            }

        }
    }
}
