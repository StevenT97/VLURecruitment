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
    
    public partial class Recruitment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recruitment()
        {
            this.Tags_Recruitments = new HashSet<Tags_Recruitments>();
        }
    
        public int Id { get; set; }
        public string title { get; set; }
        public Nullable<int> Salary_from { get; set; }
        public Nullable<int> Salary_to { get; set; }
        public int Nums_view { get; set; }
        public System.DateTime Expire_date { get; set; }
        public System.DateTime Recruiting_dates { get; set; }
        public int Districts_id { get; set; }
        public bool Is_Full_Time { get; set; }
        public bool Is_Part_Time { get; set; }
        public bool Is_Intership { get; set; }
        public int Company_id { get; set; }
        public int Status_id { get; set; }
        public System.DateTime Created_date { get; set; }
        public Nullable<System.DateTime> Updated_date { get; set; }
        public string Job_Description { get; set; }
        public string Required_Skills { get; set; }
        public string Job_Benefits { get; set; }
        public string Job_Optional { get; set; }
    
        public virtual Company_Info Company_Info { get; set; }
        public virtual District District { get; set; }
        public virtual Status_Recruitment Status_Recruitment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tags_Recruitments> Tags_Recruitments { get; set; }
    }
}
