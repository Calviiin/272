using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Donation_RE.Models;
using Donation_RE.Models.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Donation_RE.Models.ViewModels
{
    public class Payment
    {
        [Required]
        [Key]

        public int Payment_ID { get; set; }
        public DateTime Payment_Date { get; set; }
        public double Payment_Amount { get; set; }

        [ForeignKey("Donar")]
        public int Donar_ID { get; set; }
        public Donar Donar { get; set; }


        [ForeignKey("Campaign")]
        public int Campaign_ID { get; set; }
        public Campaign Campaign { get; set; }

        [ForeignKey("Payment_Mathod")]
        public int Method_ID { get; set; }
        public Payment_Method Payment_Method { get; set; }
    }
}