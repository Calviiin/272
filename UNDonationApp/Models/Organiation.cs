//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UNDonationApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Organiation
    {
        public int Organisation_ID { get; set; }
        public string Organisation_Name { get; set; }
        public string Organisation_Address { get; set; }
        public Nullable<int> Campaign_ID { get; set; }
        public Nullable<int> City_ID { get; set; }
        public string NGO_Num { get; set; }
    
        public virtual Campaign Campaign { get; set; }
        public virtual City City { get; set; }
    }
}
