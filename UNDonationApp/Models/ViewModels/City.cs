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
    public class City
    {
        [Required]
        [Key]
        public int City_ID { get; set; }
        public string City_Name { get; set; }

        [ForeignKey("Province_ID")]
        public int Province_ID { get; set; }
        public Province Province { get; set; }
    }
}