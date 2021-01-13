using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurkSeker.Dal;
using TurkSeker.Dto.Results;

namespace TurkSeker.Web.Controllers
{
    public class TabloController : Controller
    {
        private ModelTurkSeker db = new ModelTurkSeker();

        // GET: Tablo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int id)
        {


            var veri = (from gm in db.Fabrikas
                        where gm.Id == id
                        select new RsFabrika
                        {
                            FabrikaAdi = gm.FabrikaAdi,
                            Id = gm.Id,

                        }).FirstOrDefault();
            if (id == 1)
            {
                ViewBag.burdurScada = (from a in db.Burdurscadas

                                       select new RsBurdurScada
                                       {
                                           Id = a.Id,
                                           burstandartdeposeviye = a.burstandartdeposeviye,
                                           burortasurupdeposeviye = a.burortasurupdeposeviye,
                                           burkristalyesildeposeviye = a.burkristalyesildeposeviye,
                                           burkristalbeyazdeposeviye = a.burkristalbeyazdeposeviye,
                                           burA1seviye = a.burA1seviye,
                                           burA1Bx = a.burA1Bx,
                                           burA2seviye = a.burA2seviye,
                                           burA2Bx = a.burA2Bx,
                                           burA3seviye = a.burA3seviye,
                                           burA3Bx = a.burA3Bx,
                                           burA4seviye = a.burA4seviye,
                                           burA4Bx = a.burA4Bx,
                                           burA5seviye = a.burA5seviye,
                                           burA5Bx = a.burA5Bx,
                                           burA6seviye = a.burA6seviye,
                                           burA6Bx = a.burA6Bx,
                                           burA7seviye = a.burA7seviye,
                                           burA7Bx = a.burA7Bx,
                                           burKrstaltevsev1 = a.burKrstaltevsev1,
                                           burKrstaltevsev2 = a.burKrstaltevsev2,
                                           burKrstalrefsev1 = a.burKrstalrefsev1,
                                           burKrstalrefsev2 = a.burKrstalrefsev2,
                                           burKrstalrefsev3 = a.burKrstalrefsev3,
                                           burB1seviye = a.burB1seviye,
                                           burB1Bx = a.burB1Bx,
                                           burB2seviye = a.burB2seviye,
                                           burB2Bx = a.burB2Bx,
                                           burB3seviye = a.burB3seviye,
                                           burB3Bx = a.burB3Bx,
                                           burB4seviye = a.burB4seviye,
                                           burB4Bx = a.burB4Bx,
                                           burC1seviye = a.burC1seviye,
                                           burC1Bx = a.burC1Bx,
                                           burC2seviye = a.burC2seviye,
                                           burC2Bx = a.burC2Bx,
                                           burC3seviye = a.burC3seviye,
                                           burC3Bx = a.burC3Bx,
                                           burC4seviye = a.burC4seviye,
                                           burC4Bx = a.burC4Bx,
                                           burC5seviye = a.burC5seviye,
                                           burC5Bx = a.burC5Bx,
                                           burOrtaTevsev = a.burOrtaTevsev,
                                           burOrtaRefsev1 = a.burOrtaRefsev1,
                                           burOrtaRefsev2 = a.burOrtaRefsev2,
                                           burSonTevsev1 = a.burSonTevsev1,
                                           burSonTevsev2 = a.burSonTevsev2,
                                           burDifuzyonKule1sev = a.burDifuzyonKule1sev,
                                           burDifuzyonKule1Devir = a.burDifuzyonKule1Devir,
                                           burDifuzyonKule1Akim = a.burDifuzyonKule1Akim,
                                           burDifuzyonKule2sev = a.burDifuzyonKule2sev,
                                           burDifuzyonKule2Devir = a.burDifuzyonKule2Devir,
                                           burDifuzyonKule2Akim = a.burDifuzyonKule2Akim,
                                           burKiyim1Tonaj = a.burKiyim1Tonaj,
                                           burKiyim2Tonaj = a.burKiyim2Tonaj,
                                           burHaslama1sev = a.burHaslama1sev,
                                           burHaslama2sev = a.burHaslama2sev

                                       }).OrderByDescending(x => x.Id).FirstOrDefault();
            }
            else if (id == 2)
            {
                ViewBag.eregliscada = (from a in db.Eregliscadas

                                       select new RsEregliScada
                                       {
                                           Id = a.Id,
                                           Eregstandartdeposeviye = a.Eregstandartdeposeviye,
                                           Eregortadeposeviye = a.Eregortadeposeviye,
                                           Eregkristalyesildeposeviye = a.Eregkristalyesildeposeviye,
                                           Eregkristalbeyazdeposeviye = a.Eregkristalbeyazdeposeviye,
                                           EregA1seviye = a.EregA1seviye,
                                           EregA1Bx = a.EregA1Bx,
                                           EregA2seviye = a.EregA2seviye,
                                           EregA2Bx = a.EregA2Bx,
                                           EregA3seviye = a.EregA3seviye,
                                           EregA3Bx = a.EregA3Bx,
                                           EregA4seviye = a.EregA4seviye,
                                           EregA4Bx = a.EregA4Bx,
                                           EregA5seviye = a.EregA5seviye,
                                           EregA5Bx = a.EregA5Bx,
                                           EregA6seviye = a.EregA6seviye,
                                           EregA6Bx = a.EregA6Bx,
                                           EregA7seviye = a.EregA7seviye,
                                           EregA7Bx = a.EregA7Bx,
                                           EregA8seviye = a.EregA8seviye,
                                           EregA8Bx = a.EregA8Bx,
                                           EregA9seviye = a.EregA9seviye,
                                           EregA9Bx = a.EregA9Bx,
                                           EregAB10seviye = a.EregAB10seviye,
                                           EregAB10Bx = a.EregAB10Bx,
                                           EregB1seviye = a.EregB1seviye,
                                           EregB1Bx = a.EregB1Bx,
                                           EregB2seviye = a.EregB2seviye,
                                           EregB2Bx = a.EregB2Bx,
                                           EregB3seviye = a.EregB3seviye,
                                           EregB3Bx = a.EregB3Bx,
                                           EregB4seviye = a.EregB4seviye,
                                           EregB4Bx = a.EregB4Bx,
                                           EregB5seviye = a.EregB5seviye,
                                           EregB5Bx = a.EregB5Bx,
                                           EregC1seviye = a.EregC1seviye,
                                           EregC1Bx = a.EregC1Bx,
                                           EregC2seviye = a.EregC2seviye,
                                           EregC2Bx = a.EregC2Bx,
                                           EregC3seviye = a.EregC3seviye,
                                           EregC3Bx = a.EregC3Bx,
                                           EregC4seviye = a.EregC4seviye,
                                           EregC4Bx = a.EregC4Bx,
                                           EregC5seviye = a.EregC5seviye,
                                           EregC5Bx = a.EregC5Bx,
                                           EregC6seviye = a.EregC6seviye,
                                           EregC6Bx = a.EregC6Bx,
                                           EregDifuzyonKule1sev = a.EregDifuzyonKule1sev,
                                           EregDifuzyonKule1Devir = a.EregDifuzyonKule1Devir,
                                           EregDifuzyonKule1Akim = a.EregDifuzyonKule1Akim,
                                           EregDifuzyonKule2sev = a.EregDifuzyonKule2sev,
                                           EregDifuzyonKule2Devir = a.EregDifuzyonKule2Devir,
                                           EregDifuzyonKule2Akim = a.EregDifuzyonKule2Akim,
                                           EregKiyim1Tonaj = a.EregKiyim1Tonaj,
                                           EregKiyim2Tonaj = a.EregKiyim2Tonaj,
                                           EregHaslama1sev = a.EregHaslama1sev,
                                           EregHaslama2sev = a.EregHaslama2sev,
                                           tarih = a.tarih




                                       }).OrderByDescending(x => x.Id).FirstOrDefault();
            }

            return View(veri);
        }


    }
}