using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMvcWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            SampleBDC sampleBDC = new SampleBDC();
            var heading = sampleBDC.GetApplicationHeading();

            ViewBag.Heading = heading;
            return View();
        }
    }
}