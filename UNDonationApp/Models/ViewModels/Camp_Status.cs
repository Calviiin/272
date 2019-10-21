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
    public class Camp_Status
    {
        [Required]
        [Key]
        public int Camp_Status_Status_ID { get; set; }
        public string Camp_Status_Description { get; set; }

    }
}