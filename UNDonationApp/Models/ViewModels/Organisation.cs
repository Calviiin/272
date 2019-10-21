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
    public class Organisation
    {
        [Required]
        [Key]

        public int Organisation_ID { get; set; }
        public string Organisation_Name { get; set; }
        public string Organisation_Address { get; set; }

        [ForeignKey("Campaign")]
        public int Camp_ID { get; set; }
        public Campaign Campaign { get; set; }

        [ForeignKey("City")]
        public int City_ID { get; set; }
        public City City { get; set; }



    }
}