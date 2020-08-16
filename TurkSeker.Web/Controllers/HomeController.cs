using System.Web.Mvc;

namespace TurkSeker.Web.Controllers
{

    [Authorize(Roles = "Admin,Kullanici")]
    public class HomeController :  Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    
        public ActionResult TumVeriler()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       
    }
}