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
    
    public partial class Company_Photos
    {
        public int ID { get; set; }
        public string Image_Name { get; set; }
        public string Path { get; set; }
        public int Company_ID { get; set; }
        public System.DateTime date_Created { get; set; }
        public Nullable<System.DateTime> date_Updated { get; set; }
    
        public virtual Company_Info Company_Info { get; set; }
    }
}
