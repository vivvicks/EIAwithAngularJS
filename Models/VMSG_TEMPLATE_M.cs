//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EIAwithAngular.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VMSG_TEMPLATE_M
    {
        public VMSG_TEMPLATE_M()
        {
            this.VMSG_RELATION = new HashSet<VMSG_RELATION>();
        }
    
        public long Template_Id { get; set; }
        public string Template_Desc { get; set; }
        public string Template_Subject { get; set; }
        public string Template_Data { get; set; }
        public string Image_Path { get; set; }
        public string Content_Type { get; set; }
        public string Mail_Type { get; set; }
        public string createdBy { get; set; }
        public Nullable<System.DateTime> createdOn { get; set; }
        public string updatedBy { get; set; }
        public Nullable<System.DateTime> updatedOn { get; set; }
    
        public virtual ICollection<VMSG_RELATION> VMSG_RELATION { get; set; }
    }
}