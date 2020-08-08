using Microsoft.AspNet.OData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurkSeker.Dal;
using TurkSeker.Dal.Db;

namespace TurkSeker.Web.Controllers.Api
{
    public class GenelMdController : ODataController
    {
        private ModelTurkSeker db = new ModelTurkSeker();

        [EnableQuery]
        [HttpGet]
        public IQueryable<genelmd> Get()
        {
            var veri = db.GenelMd;
            return veri;
        } 
    }
}