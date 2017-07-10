using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IP_Boss.UserSystem.WebApp.Controllers
{
    public class CommonViewsController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Error_One()
        {
            return View();
        }

        public ActionResult Error_Two()
        {
            return View();
        }

        public ActionResult LockScreen()
        {
            return View();
        }

        public ActionResult PasswordRecovery()
        {
            return View();
        }

    }
}
