using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System.Web.Mvc;
using TurkSeker.Dal;
using TurkSeker.Dal.Db;
using TurkSeker.Dto.Parameters;
using System.Web;
using System.Web.Security;
using System;

namespace TurkSeker.Web.Controllers.Api
{
    [AllowAnonymous]
    public class KullanicisController : Controller
    {
        private readonly UserManager<Kullanici> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public KullanicisController()
        {
            var UserStore = new UserStore<Kullanici>(new ModelTurkSeker());
            userManager = new UserManager<Kullanici>(UserStore);

            var RoleStore = new RoleStore<IdentityRole>(new ModelTurkSeker());
            roleManager = new RoleManager<IdentityRole>(RoleStore);

        }


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Login(PmLoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = userManager.Find(model.UserName, model.Password);
                if (user == null)
                {
                    ModelState.AddModelError("", "Yanlış Kullanıcı Adı veya Parola");
                }
                else
                {
                    int timeout = 525600;
                    var ticket = new FormsAuthenticationTicket(model.UserName, true, timeout);
                    string encrypted = FormsAuthentication.Encrypt(ticket);
                    var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encrypted);
                    cookie.Expires = DateTime.Now.AddMinutes(timeout);
                    cookie.HttpOnly = true;
                    Response.Cookies.Add(cookie);

                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }

                    //return Redirect(string.IsNullOrEmpty(returnUrl) ? "/" : returnUrl);

                }



            }
            ViewBag.returnUrl = returnUrl;

            return View(model);
        }


        public ActionResult Register()
        {


            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Register(PmRegister model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Kullanici user = new Kullanici();
                    user.UserName = model.UserName;

                    
                    string name = "Admin";

                    //Create Role Admin if it does not exist
                    if (!roleManager.RoleExists(name))
                    {
                        var roleresult = roleManager.Create(new IdentityRole(name));
                    }
                     

                    var result = userManager.Create(user, model.Password);

                    if (result.Succeeded)
                    {
                        userManager.AddToRole(user.Id, name);
                        return RedirectToAction("Login");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error);
                        }
                    }
                }

                return View(model);
            }
            catch (System.Exception e)
            {

                throw;
            }
        } 
        [HttpPost]
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Kullanicis");
        }
    }
}
