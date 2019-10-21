using System;
using System.Collections.Generic;
using Donation_RE.Models.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Donation_RE.Models;

namespace Donation_RE.Models.ViewModels
{
    public class Campaign
    {
       [Required]
       [Key]
        public int Camp_ID { get; set; }
        public string Camp_Name { get; set; }
        public string Description { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public double Goal { get; set; }

        [ForeignKey("Camp_Status")]
        public int Camp_Status_ID { get; set; }
        public Camp_Status Camp_Status { get; set; }

    }

}