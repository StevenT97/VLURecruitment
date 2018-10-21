using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VLURecruit.Models;

namespace VLURecruit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            EJobEntities db = new EJobEntities();
            var model = db.Recruitments.Where(x => x.Status_id==2 && x.Is_Show==true).ToList();
            ViewBag.count = model.Count();
            return View(model);
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
        

    }
}