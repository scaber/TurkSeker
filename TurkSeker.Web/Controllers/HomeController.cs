 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurkSeker.Dal;
using TurkSeker.Dal.Db;

namespace TurkSeker.Web.Controllers
{
    public class HomeController :  Controller
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

        public ActionResult TumVeriler()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       
    }
}