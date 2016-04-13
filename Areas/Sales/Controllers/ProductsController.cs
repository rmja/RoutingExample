using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingExample.Areas.Sales.Controllers
{
    [Area("Sales")]
    public class ProductsController : Controller
    {
        public IActionResult Index(string manufacturer)
        {
            return View();
        }

        public IActionResult Details(string manufacturer, int id)
        {
            return View();
        }
    }
}
