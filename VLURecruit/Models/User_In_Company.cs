//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VLURecruit.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_In_Company
    {
        public string Account_id { get; set; }
        public int Company_id { get; set; }
        public int Status_id { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Company_Info Company_Info { get; set; }
        public virtual Status_Account Status_Account { get; set; }
    }
}
