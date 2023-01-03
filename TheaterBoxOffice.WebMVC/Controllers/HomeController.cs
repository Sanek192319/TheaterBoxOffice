using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TheaterBoxOffice.WebMVC.Models;

namespace TheaterBoxOffice.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult MainMenu()
        {
            return View();
        }
    }
}
