using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NainaarKovil.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //DetailsWorship
        public ActionResult Worshipdetails()
        {
            ViewBag.Message = "Worship Details.";

            return View();
        }

        //DetailsWorship
        public ActionResult Beliefs()
        {
            ViewBag.Message = "Beliefs.";

            return View();
        }

        //DetailsWorship
        public ActionResult ESeva()
        {
            ViewBag.Message = "ESeva.";

            return View();
        }

        //DetailsWorship
        public ActionResult Festives()
        {
            ViewBag.Message = "Festives.";

            return View();
        }

        //DetailsWorship
        public ActionResult Gallery()
        {
            ViewBag.Message = "Gallery.";

            return View();
        }

        //DetailsWorship
        public ActionResult History()
        {
            ViewBag.Message = "History.";

            return View();
        }

        //DetailsWorship
        public ActionResult HollyWells()
        {
            ViewBag.Message = "HollyWells.";

            return View();
        }

        //DetailsWorship
        public ActionResult NearbyTemples()
        {
            ViewBag.Message = "NearbyTemples.";

            return View();
        }

        //Tender
        public ActionResult Tender()
        {
            ViewBag.Message = "Tender.";

            return View();
        }

        //Timings
        public ActionResult Timings()
        {
            ViewBag.Message = "Timings.";

            return View();
        }

        //Admin
        public ActionResult Admin()
        {
            ViewBag.Message = "Admin.";

            return View();
        }

    }
}