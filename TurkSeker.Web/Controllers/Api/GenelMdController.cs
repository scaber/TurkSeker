using Microsoft.AspNet.OData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurkSeker.Dal;
using TurkSeker.Dal.Db;
using TurkSeker.Dto.Results;

namespace TurkSeker.Web.Controllers.Api
{
    public class GenelMdController : ODataController
    {
        private ModelTurkSeker db = new ModelTurkSeker();

        [EnableQuery]
        [HttpGet]
        public IQueryable<genelmd> Get()
        {
            //var veri = (from gm in db.GenelMd
            //            join f in db.Fabrikas on gm.FabrikaId equals f.Id
            //            select new RsGenelMd
            //            {
            //                Id = gm.Id,
            //                FabrikaId = f.Id,
            //                FabrikaAdi = f.FabrikaAdi,
            //                BugunGelenPancar = gm.BugunGelenPancar,
            //                Bugun_cik_sek = gm.Bugun_cik_sek,
            //                Bugun_kes_pan = gm.Bugun_kes_pan,
            //                Dun_cik_sek = gm.Dun_cik_sek,
            //                Dun_kes_pan = gm.Dun_kes_pan,
            //                Ham_bek_sek = gm.Ham_bek_sek,
            //                KantardakiPancar = gm.KantardakiPancar,
            //                Kayit_tar_saat = gm.Kayit_tar_saat,
            //                Kiyim1_anlik_ton = gm.Kiyim1_anlik_ton,
            //                Kiyim2_anlik_ton = gm.Kiyim2_anlik_ton,
            //                Kiyim3_anlik_ton = gm.Kiyim3_anlik_ton,
            //                Kiyim_polu = gm.Kiyim_polu,
            //                Raf_bek_sek = gm.Raf_bek_sek,
            //                ToplamPancar = gm.ToplamPancar,
            //                Top_bek_sek = gm.Top_bek_sek, 
            //            });
            var veri1 = db.GenelMd;
            return veri1;
        }
    }
}