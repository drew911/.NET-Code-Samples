using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RazorApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RazorApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            InformationModel information = new InformationModel();
            information.IsFinished = false;
            return View(information);
        }

        public IActionResult Index(InformationModel model)
        {
            InformationModel information = new InformationModel();
            information.IsFinished = false;
            return View(information);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
