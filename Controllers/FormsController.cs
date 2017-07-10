using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IP_Boss.UserSystem.WebApp.Controllers
{
    public class FormsController : Controller
    {

        public ActionResult FormsElements()
        {
            return View();
        }

        public ActionResult FormsExtended()
        {
            return View();
        }

        public ActionResult TextEditor()
        {
            return View();
        }

        public ActionResult Wizard()
        {
            return View();
        }

        public ActionResult Validation()
        {
            return View();
        }

    }
}
