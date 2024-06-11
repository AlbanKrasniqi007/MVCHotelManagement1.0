using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHotelManagement1._0.Controllers
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

        public ActionResult Service()
        {
            ViewBag.Message = "Your service page.";

            return View();
        }

        public ActionResult Room()
        {
            ViewBag.Message = "Your Room page.";

            return View();
        }

        public ActionResult Booking()
        {
            ViewBag.Message = "Your Booking page.";

            return View();
        }
    }
}