using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VLURecruit.Models;
using VLURecruit.Areas.Company.Models;

namespace VLURecruit.Areas.Company.Controllers
{
    public class RecruitmentController : Controller
    {
        // GET: Company/Recruitment
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Recruitment rec,string Name_Time)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Check()
        {
            var db = new jobeeEntities();

            return View();
        }
    }
}