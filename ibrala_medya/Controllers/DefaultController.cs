using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ibrala_medya.Models;

namespace ibrala_medya.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        public ActionResult Index()
        {
            return View();
        }
        [Route("hakkimizda")]
        public ActionResult hakkimizda()
        {
            using (db_ibralamedyaEntities3 db = new db_ibralamedyaEntities3())
            {
                var model = db.hakkimizda.Where(x => x.aktif_pasif == true).ToList();
                return View(model);
            }

        }
        [Route("hizmetler")]
        public ActionResult hizmetler()
        {
            using (db_ibralamedyaEntities3 db = new db_ibralamedyaEntities3())
            {
                var model = db.hizmetlerimiz.Where(x => x.aktif_pasif == true).ToList();
                return View(model);
            }

        }
        [Route("referanslar")]
        public ActionResult referanslar()
        {
            return View();
        }
        [Route("calisan/{id}")]
        public ActionResult calisanlar(int id)
        {
            using (db_ibralamedyaEntities3 db = new db_ibralamedyaEntities3())
            {
                var model = db.calisanlarimiz.Where(x => x.aktif_pasif == true && x.cid == id).FirstOrDefault();
                if (model == null)
                {
                    return HttpNotFound();
                }
                return View(model);
            }
        }
        [Route("galeri")]
        public ActionResult galeri()
        {
            return View();
        }
        [Route("iletisim")]
        public ActionResult iletisim()
        {
            return View();
        }
    }
}