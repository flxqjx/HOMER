﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IP_Boss.UserSystem.WebApp.Controllers
{
    public class OptionsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}
