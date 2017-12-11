using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Safe_Places.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult GetInvolved()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Archive()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Report()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}