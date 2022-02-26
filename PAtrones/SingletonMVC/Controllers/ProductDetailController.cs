using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools.Earn;

namespace PatterDesigns.Controllers
{
    public class ProductDetailController : Controller
    {
        private EarnFactory _localEarnFactory;
        private ForeignEarnFactory _foreignEarnFactory;


        public ProductDetailController(LocalEarnFactory localEarnFactory, ForeignEarnFactory foreignEarnFactory)
        {
            _localEarnFactory = localEarnFactory;
            _foreignEarnFactory = foreignEarnFactory;
        }

        public IActionResult Index(decimal total)
        {
            // factories

            // productts
            var localEarn = _localEarnFactory.GetEarn();
            var foreignEarn = _foreignEarnFactory.GetEarn();

            //total
            ViewBag.totalLocal = total + localEarn.Earn(total);
            ViewBag.totalForeign = total + foreignEarn.Earn(total);

            return View();
        }
    }
}
