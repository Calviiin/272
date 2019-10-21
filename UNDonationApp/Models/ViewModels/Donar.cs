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
    public class Donar
    {
        [Required]
        [Key]

        public int Donar_ID { get; set; }
        public string Donar_Name { get; set; }
        public string Donar_Surname { get; set; }
        public string Donar_Email { get; set; }
        public string Donar_Cell { get; set; }
        public string Donar_Address { get; set; }

        [ForeignKey("City")]
        public int City_ID { get; set; }
        public City City { get; set; }

    }
}