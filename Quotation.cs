using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Quotation
    {
        [Key]
        [Required]
         public string Quotation_No { get; set; }
        [Required]
        [Display(Name = "Enquiry No")]
        public string Enquiry_No { get; set; }
        [Required]
        public DateTime Quotation_Date { get; set; }
        public string Quotation_Type { get; set; }
        [Required]
        public string Quotation_PaymentTerms { get; set; }
        [Required]
        public string Quotation_DeliveryEstimate { get; set; }
        [Required]
        public string Quotation_Validity { get; set; }
        [Required]
        public double Quotation_CourierCharges { get; set; }

        public string? Quotation_Year { get; set; }
        [Required]
        public DateTime Quotation_AddedOn { get; set; }
        public DateTime? Quotation_UpdatedOn { get; set; }
        public string? Quotation_Operation { get; set; }
        public bool? Quotation_Flag { get; set; }
        public double? Quotation_TaxableAmount { get; set; }
        public double? Quotation_CGSTPercent { get; set; }
        public double? Quotation_SGSTPercent { get; set; }
        public double? Quotation_IGSTPercent { get; set; }
        public double? Quotation_CGSTAmount { get; set; }
        public double? Quotation_SGSTAmount { get; set; }
        public double? Quotation_IGSTAmount { get; set; }
        public double? Quotation_GSTPercent { get; set; }
        public double? Quotation_GSTAmount { get; set; }
        public double? Quotation_TotalAmount { get; set; }


    }
}


