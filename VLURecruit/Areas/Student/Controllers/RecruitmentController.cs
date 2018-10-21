using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using VLURecruit.Models;

namespace VLURecruit.Areas.Student.Controllers
{
    public class RecruitmentController : Controller
    {
        EJobEntities model = new EJobEntities();

        // GET: Student/Recruitment
        public ActionResult ListOfRecruitment()
        {
            var day = DateTime.Now;
            List<object> list = new List<object>();
            var recruitment = model.Recruitments.ToList().Where(x => x.Expire_date >= day && x.Status_id==2 && x.Is_Show==true).OrderByDescending(x => x.Id);
            //var userId = User.Identity.GetUserId();
            //ViewBag.Name = model.Student_Info.FirstOrDefault(x => x.Account_Id == userId).Student_Name;
            return View(recruitment);
        }
    }
}