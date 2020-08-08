using Microsoft.AspNet.OData;
using System.Data;
using System.Linq;
using System.Web.Http;
using TurkSeker.Dal;
using TurkSeker.Dal.Db;

namespace TurkSeker.Web.Controllers.Api
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using TurkSeker.Dal.Db;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Kullanici>("Kullanicis");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class KullanicisController : ODataController
    {
        private ModelTurkSeker db = new ModelTurkSeker();

        // GET: odata/Kullanicis
        [EnableQuery]
        [HttpGet]
        public IQueryable<Kullanici> Get()
        {
            var veri = db.Kullanici;
            return veri;
        }

        // GET: odata/Kullanicis(5)
        [EnableQuery]
        public SingleResult<Kullanici> GetKullanici([FromODataUri] int key)
        {
            return SingleResult.Create(db.Kullanici.Where(kullanici => kullanici.ID == key));
        }

        //// PUT: odata/Kullanicis(5)
        //public IHttpActionResult Put([FromODataUri] int key, Delta<Kullanici> patch)
        //{
        //    Validate(patch.GetEntity());

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    Kullanici kullanici = db.Kullanici.Find(key);
        //    if (kullanici == null)
        //    {
        //        return NotFound();
        //    }

        //    patch.Put(kullanici);

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!KullaniciExists(key))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return Updated(kullanici);
        //}

        //// POST: odata/Kullanicis
        //public IHttpActionResult Post(Kullanici kullanici)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Kullanici.Add(kullanici);
        //    db.SaveChanges();

        //    return Created(kullanici);
        //}

        //// PATCH: odata/Kullanicis(5)
        //[AcceptVerbs("PATCH", "MERGE")]
        //public IHttpActionResult Patch([FromODataUri] int key, Delta<Kullanici> patch)
        //{
        //    Validate(patch.GetEntity());

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    Kullanici kullanici = db.Kullanici.Find(key);
        //    if (kullanici == null)
        //    {
        //        return NotFound();
        //    }

        //    patch.Patch(kullanici);

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!KullaniciExists(key))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return Updated(kullanici);
        //}

        //// DELETE: odata/Kullanicis(5)
        //public IHttpActionResult Delete([FromODataUri] int key)
        //{
        //    Kullanici kullanici = db.Kullanici.Find(key);
        //    if (kullanici == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Kullanici.Remove(kullanici);
        //    db.SaveChanges();

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KullaniciExists(int key)
        {
            return db.Kullanici.Count(e => e.ID == key) > 0;
        }
    }
}
