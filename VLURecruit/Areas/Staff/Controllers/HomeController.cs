using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VLURecruit.Areas.Staff.Controllers
{
    [Authorize(Roles ="Staff")]
    public class HomeController : Controller
    {
        // GET: Staff/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}