using Microsoft.AspNet.OData.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
 
using TurkSeker.Dal.Db;
using Microsoft.AspNet.OData.Builder;
 
namespace TurkSeker.Web.App_Start
{
    public static class ODataConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes(); //This has to be called before the following OData mapping, so also before WebApi mapping
            config.Count().Filter().OrderBy().Expand().Select().MaxTop(null);
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();

          //  builder.EntitySet<Kullanici>("Kullanicis");
            builder.EntitySet<genelmd>("genelmd");
            //Moar!

            config.MapODataServiceRoute("ODataRoute", "api", builder.GetEdmModel());
        }
    }
}