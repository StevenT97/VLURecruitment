using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VLURecruit.Models;
using VLURecruit.Areas.Company.Models;
using Microsoft.AspNet.Identity;

namespace VLURecruit.Areas.Company.Controllers
{
    public class RecruitmentController : Controller
    {
        jobeeEntities db = new jobeeEntities();
        // GET: Company/Recruitment
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Districts_id = new SelectList(db.Districts, "ID", "District_Name");
            ViewBag.recttag = new SelectList(db.Tags, "ID", "Name_Tag");
            return View();
        }

        [HttpPost]
        public ActionResult Create(RecruitmentSuppor data)
        {
            if (!ModelState.IsValid)
            {
                return View(data);
            }
            //create new recruitment
            var userId = User.Identity.GetUserId();
            data.Company_id = db.Company_Info.FirstOrDefault(x => x.Id_Account == userId).Id;
            Recruitment nRec = new Recruitment
            {

                Company_id = data.Company_id,
                Nums_view = 0,
                Status_id = 1,
                Districts_id = data.Districts_id,
                title = data.title,
                Expire_date = data.Expire_date,
                Salary = data.Salary,
                Is_Full_Time = data.Is_Full_Time,
                Is_Part_Time = data.Is_Part_Time,
                Is_Intership = data.Is_Intership,
                Job_Description = data.Mo_ta_Chi_Tiet,
                Required_Skills = data.Ky_Nang_Cong_Viec,
                Job_Benefits = data.Phuc_Loi,
                Job_Optional = data.Tuy_Chon,
                Created_date = DateTime.Now,
            };
            db.Recruitments.Add(nRec);
            db.SaveChanges();


            //check tag_recruitment and add to database
            if (data.recttag != null)
            {
                foreach (var item in data.recttag)
                {
                    db.Tags_Recruitments.Add(new Tags_Recruitments
                    {
                        Id_Tags = item,
                        Id_Recruitment = nRec.Id,
                        Craeted_date = DateTime.Now
                    });

                }
                db.SaveChanges();
            }


            return RedirectToAction("Index", "Home", new { area = "Company" });
        }
        public ActionResult ListOfRecruitment()
        {
            return View();
        }
    }
}