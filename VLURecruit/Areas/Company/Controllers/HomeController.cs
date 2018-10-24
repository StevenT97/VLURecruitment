using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VLURecruit.Areas.Company.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "Company")]
        // GET: Company/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}