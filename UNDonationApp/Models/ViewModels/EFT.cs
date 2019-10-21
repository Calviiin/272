using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Donation_RE.Models.ViewModels
{
    public class EFT: Payment
    {

        public string Bank_Name{ get; set; }
        public int Account_Number { get; set; }
    }
}