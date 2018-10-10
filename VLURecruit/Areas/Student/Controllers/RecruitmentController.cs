using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VLURecruit.Areas.Student.Controllers
{
    public class RecruitmentController : Controller
    {
        // GET: Student/Recruitment
        public ActionResult ListOfRecruitment()
        {
            return View();
        }
    }
}