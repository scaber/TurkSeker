using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurkSeker.Dal;
using TurkSeker.Dal.Db;

namespace TurkSeker.Web.Controllers
{
    public class AdminController : Controller
    {
          private UserManager<Kullanici> userManager;
        public AdminController()
        {
            var UserStore = new UserStore<Kullanici>(new ModelTurkSeker());
            userManager = new UserManager<Kullanici>(UserStore);
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View(userManager.Users);
        }
    }
}