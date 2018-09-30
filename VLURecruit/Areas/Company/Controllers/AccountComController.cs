using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VLURecruit.Areas.Company.Controllers
{
    public class AccountComController : Controller
    {
        // GET: Company/Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}