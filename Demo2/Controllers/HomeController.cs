﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Demo2.Models;

namespace Demo2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<CKController> _logger;

        public HomeController(ILogger<CKController> logger)
        {
            _logger = logger;
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
