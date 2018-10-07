using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VLURecruit.Areas.Admin.Controllers
{
    [Authorize(Roles ="Admin")]
    public class HomeController : Controller
    {
        // GET: Admin/Home
        [Authorize(Roles ="Admin")]
        public ActionResult Index()
        {
            return View();
        }
    }
}