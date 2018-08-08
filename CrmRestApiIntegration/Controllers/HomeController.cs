﻿using System.Diagnostics;
using CrmRestApiIntegration.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrmRestApiIntegration.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
