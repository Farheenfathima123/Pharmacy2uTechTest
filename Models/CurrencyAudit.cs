//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pharmacy2uTechTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CurrencyAudit
    {
        public int Id { get; set; }
        public string CurrencyType { get; set; }
        public decimal ActualAmount { get; set; }
        public Nullable<decimal> ConvertedAmount { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
    }
}