using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Pharmacy2uTechTest.ViewModels
{
    public class ReportModel
    {
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        [Required(ErrorMessage = "Please select a date")]
        [Display(Name = "From Date")]
        public DateTime FromDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        [Required(ErrorMessage = "Please select a date")]
        [Display(Name = "To Date")]
        public DateTime ToDate { get; set; }
    }
}