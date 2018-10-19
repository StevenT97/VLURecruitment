using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VLURecruit.Models;

namespace VLURecruit.Areas.Staff.Controllers
{
    public class RecruitmentController : Controller
    {
        EJobEntities db = new EJobEntities();

        // GET: Staff/Recruitment
        public ActionResult Approve()
        {
            var model = db.Recruitments.Where(x => x.Status_id == 1).ToList();    
            return View(model);
        }

        //action thuc hien viec xac nhan tin tuyen dung chuyen trang thai tu "chua duyet" sang "da duyet"
        public ActionResult Approved(int id)
        {
            var rec = db.Recruitments.FirstOrDefault(x => x.Id == id);
            rec.Updated_date = DateTime.Now;
            rec.Status_id = 2;
            db.SaveChanges();
            return RedirectToAction("Approve", "Recruitment", new { area = "Staff" });
        }

        //action thuc hien viec show ra list danh sach tin tuyen dung o trang thai "da duyet"
        public ActionResult List()
        {
            var model = db.Recruitments.Where(x => x.Status_id == 2).ToList();
            return View(model);
        }
    }
}