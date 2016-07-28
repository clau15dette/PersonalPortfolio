using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sharonportfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult Contact()
        {
          return View();
        }

        public ActionResult Aboutme()
        {
            return View();
        }

        public ActionResult Portfolio()
        {
            return View();
        }

        public ActionResult JSexercises()
        {
            return View();
        }

       public ActionResult Resume()
        {
            return View();
        }
    }
}