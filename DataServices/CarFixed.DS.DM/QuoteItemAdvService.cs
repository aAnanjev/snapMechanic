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
    
    public partial class QuoteItemAdvService
    {
        public int QuoteItemAdvServiceID { get; set; }
        public Nullable<int> QuoteID { get; set; }
        public string Description { get; set; }
        public Nullable<int> Miles { get; set; }
        public Nullable<int> Months { get; set; }
        public Nullable<decimal> EstimatedHours { get; set; }
        public Nullable<int> EstimatedMinutes { get; set; }
        public string GReference { get; set; }
    
        public virtual Quote Quote { get; set; }
    }
}
