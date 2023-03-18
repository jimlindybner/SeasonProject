using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeasonProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Season(int? temperature)
        {
            if (temperature == null) ViewBag.Temp = "unknown";
            else ViewBag.Temp = temperature;

            if (temperature == null) ViewBag.Season = "unknown";
            else
            {
                //we need to gether season information based on temperature provided
                SeasonController controller = new SeasonController();
                ViewBag.Season = controller.GetSeason((int)temperature);
            }

            return View();
        }
    }
}
