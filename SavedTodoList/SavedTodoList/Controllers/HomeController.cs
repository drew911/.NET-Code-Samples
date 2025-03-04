﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SavedTodoList.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SavedTodoList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        int number = 0;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            number++;
        }

        public IActionResult Index()
        {
            return View();
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
