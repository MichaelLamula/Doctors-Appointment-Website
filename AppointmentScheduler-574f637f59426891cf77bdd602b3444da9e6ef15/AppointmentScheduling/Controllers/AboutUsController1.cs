﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentScheduling.Controllers
{
    public class AboutUsController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}