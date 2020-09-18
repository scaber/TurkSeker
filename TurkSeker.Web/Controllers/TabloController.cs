using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TurkSeker.Web.Controllers
{
    public class TabloController : Controller
    {
        // GET: Tablo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(string fabrika)
        {
              
            return View();
        }
      

    }
}