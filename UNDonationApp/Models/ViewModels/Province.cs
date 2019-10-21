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
    public class Province
    {
        [Required]
        [Key]
        public int Province_ID { get; set; }
        public string Province_Name { get; set; }

    }
}