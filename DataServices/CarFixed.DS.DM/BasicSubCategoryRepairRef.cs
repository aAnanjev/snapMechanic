//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarFixed.DS.DM
{
    using System;
    using System.Collections.Generic;
    
    public partial class BasicSubCategoryRepairRef
    {
        public int BasicSubCategoryRepairRefID { get; set; }
        public int BasicSubCategoryID { get; set; }
        public string RepairRef { get; set; }
    
        public virtual BasicSubCategory BasicSubCategory { get; set; }
    }
}
