using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingExample.Areas.Support.Controllers
{
    [Area("Support")]
    public class TicketsController : Controller
    {
        public IActionResult Index(string manufacturer)
        {
            return View();
        }
    }
}
