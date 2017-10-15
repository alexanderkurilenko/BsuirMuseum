using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BsuirMuseum.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TimeLine()
        {
            return View();
        }

        public ActionResult Symbols()
        {
            return View();
        }
    }
}