using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pharmacy2uTechTest.ViewModels
{
    public class CurrencyAuditModel
    {
        public int ID { get; set; }

        [Display(Name = "Currency Type")]
        [Required(ErrorMessage = "Please select a value")]
        public string CurrencyType { get; set; }

        [Required (ErrorMessage = "Please enter a value")]
        [DataType(DataType.Currency, ErrorMessage = "Invalid Input")]
        [Display(Name = "Enter the amount to convert (GBP)")]
        [DisplayFormat(DataFormatString = "{0:N}", ApplyFormatInEditMode = true)]
        public decimal ActualAmount { get; set; }
        public decimal ConvertedAmount { get; set; }
        public System.DateTime DateAdded { get; set; }
        public Nullable<bool> IsDeleted { get; set; }

    }
    public enum Currency
    {
        USD,
        AUD,
        EUR
    }
}