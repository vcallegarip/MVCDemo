using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Bootstrap_Knockout.Models;

namespace Mvc_Bootstrap_Knockout.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Basic()
        {

            var person = new Person
            {
                FirstName = "Victor",
                LastName = "Callegari"
            };

            return View(person);
        }
    }
}