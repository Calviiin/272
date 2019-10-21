using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Donation_RE.Models.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Donation_RE.Models.ViewModels
{
    public class Payment_Method 
    {
        [Required]
        [Key]

        public int Method_ID { get; set; }
        public virtual string Method_Description { get; set; }

    }
}