using Microsoft.AspNet.OData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TurkSeker.Dal;
using TurkSeker.Dal.Db;
using TurkSeker.Dto.Results;

namespace TurkSeker.Web.Controllers.Api
{
    public class FabrikasController : ODataController
    {
        private ModelTurkSeker db = new ModelTurkSeker();

        [EnableQuery]
        [HttpGet]
        public IQueryable<Fabrika> Get()
        { 
            var veri1 = db.Fabrikas.Include("Genelmds");
            return veri1;
        }
    }
}
