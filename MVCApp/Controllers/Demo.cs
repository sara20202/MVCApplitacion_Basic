﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp.Controllers
{
    public class Demo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MoreInfo()
        {
            return View();
        }
    }
}
