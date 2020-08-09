using Owin;

namespace TurkSeker.Web.App_Start
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888

            //app.UseCookieAuthentication(new CookieAuthenticationOptions
            //{
            //    AuthenticationType= DefaultAuthenticationTypes.ApplicationCookie,
            //    LoginPath= new PathString("/Account/Login")

            //});
        }
    }
}