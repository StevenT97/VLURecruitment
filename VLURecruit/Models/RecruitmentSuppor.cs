using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VLURecruit.Models
{
    public class RecruitmentSuppor:Recruitment
    {
        [Display(Name ="Tiêu đề")]
        public string title { get; set; }
        [Display(Name ="Mức Lương")]
        public Nullable<int> Salary { get; set; }
        [Display(Name ="Ngày Hết Hạn")]
        public Nullable<System.DateTime> Expire_date { get; set; }

        
        
        public int Districts_id { get; set; }

        [Display(Name = "Full Time")]
        public bool Is_Full_Time { get; set; }
        [Display(Name = "Part Time")]
        public bool Is_Part_Time { get; set; }
        [Display(Name = "Intership")]
        public bool Is_Intership { get; set; }
        [AllowHtml]
        [Required]
        [Display(Name ="Mô tả công việc")]
        public string Mo_ta_Chi_Tiet { get; set; }
        [AllowHtml]
        [Display(Name = "Kỹ Năng Yêu Cầu")]
        public string Ky_Nang_Cong_Viec { get; set; }
        [AllowHtml]
        [Display(Name = "Phúc Lợi")]
        public string Phuc_Loi { get; set; }
        [AllowHtml]
        [Display(Name = "Tùy Chọn")]
        public string Tuy_Chon { get; set; }

        public int[] recttag { get; set; }
    }
}