using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IP_Boss.UserSystem.WebApp.Controllers
{
    public class ChartsController : Controller
    {

        public ActionResult ChartJs()
        {
            return View();
        }

        public ActionResult FlotCharts()
        {
            return View();
        }

        public ActionResult InlineGraphs()
        {
            return View();
        }

        public ActionResult Chartist()
        {
            return View();
        }

        public ActionResult C3Charts()
        {
            return View();
        }

    }
}
