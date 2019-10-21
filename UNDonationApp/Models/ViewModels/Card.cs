using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UNDonationApp.Models;

namespace UNDonationApp.ViewModels
{
    public abstract class Card : Payment
    {
        public int Card_Number { get; set; }
        public int CVV { get; set; }
        public string Card_Holder { get; set; }
    }
}