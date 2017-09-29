using Prosjektoppgave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prosjektoppgave.Controllers
{
    public class HomeController : Controller
    {
        private DB db = new DB();

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetOrigin(string term)
        {
            List<string> origins;
            origins = db.Routes.Where(x => x.origin.StartsWith(term))
                .Select(y => y.origin).ToList();
            
            return Json(origins.Distinct(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetDestination(string term)
        {
            List<string> destinations;
            destinations = db.Routes.Where(x => x.destination.StartsWith(term))
                .Select(y => y.destination).ToList();

            return Json(destinations.Distinct(), JsonRequestBehavior.AllowGet);
        }
    }
}