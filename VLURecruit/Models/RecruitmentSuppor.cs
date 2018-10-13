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
        [AllowHtml]
        [Required]
        public string Mo_ta_Chi_Tiet { get; set; }
        [AllowHtml]
        public string Ky_Nang_Cong_Viec { get; set; }
        [AllowHtml]
        public string Phuc_Loi { get; set; }
        [AllowHtml]
        public string Tuy_Chon { get; set; }

        public int[] recttag { get; set; }
    }
}