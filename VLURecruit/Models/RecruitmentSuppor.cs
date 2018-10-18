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
        [Required(ErrorMessage = "Hãy nhập tiêu đề")]
        public string title { get; set; }
        [Display(Name ="Mức Lương Thấp Nhất")]
        public Nullable<int> Salary_from { get; set; }
        [Display(Name = "Mức Lương Cao Nhất")]
        public Nullable<int> Salary_to { get; set; }
        [Display(Name ="Ngày Bắt Đầu Tuyển Dụng")]
        [Required(ErrorMessage = "Hãy nhập ngày bắt đầu tuyển dụng")]
        public System.DateTime Recruiting_dates { get; set; }
        [Display(Name = "Ngày Hết Hạn Tuyển Dụng")]
        [Required(ErrorMessage = "Hãy nhập ngày hết hạn tuyển dụng")]
        public System.DateTime Expire_date { get; set; }

        [Display(Name ="nơi làm việc")]
        [Required(ErrorMessage = "Hãy chọn nơi làm việc")]
        public int Districts_id { get; set; }

        [Display(Name = "Full Time")]
        public bool Is_Full_Time { get; set; }
        [Display(Name = "Part Time")]
        public bool Is_Part_Time { get; set; }
        [Display(Name = "Intership")]
        public bool Is_Intership { get; set; }
        [AllowHtml]
        [Required (ErrorMessage ="Hãy nhập mô tả công việc")]
        [Display(Name ="Mô tả công việc")]
        public string Mo_ta_Chi_Tiet { get; set; }
        [AllowHtml]
        [Display(Name = "Kỹ Năng Yêu Cầu")]
        [Required(ErrorMessage = "Hãy nhập Kỹ Năng Yêu Cầu")]
        public string Ky_Nang_Cong_Viec { get; set; }
        [AllowHtml]
        [Required(ErrorMessage = "Hãy nhập Phúc Lợi")]
        [Display(Name = "Phúc Lợi")]
        public string Phuc_Loi { get; set; }
        [AllowHtml]
        [Display(Name = "Tùy Chọn")]
        public string Tuy_Chon { get; set; }

        public int[] recttag { get; set; }
    }
}