using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OctoDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() => View();

        public ActionResult About()
        {
            ViewBag.Message = "A demo application to show Octopus deploy in action.";

            ViewBag.ShowVariable = "OctoVar: " + Properties.Settings.Default.OctoVar;
                
            ViewBag.ShowGreeting = "Greeting setting: " + Properties.Settings.Default.Greeting;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}