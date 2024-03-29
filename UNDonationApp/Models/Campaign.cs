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
    
    public partial class Campaign
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Campaign()
        {
            this.Organiations = new HashSet<Organiation>();
            this.Payments = new HashSet<Payment>();
            this.Cards = new HashSet<Card>();
            this.EFTs = new HashSet<EFT>();
            this.Paypals = new HashSet<Paypal>();
        }
    
        public int Campaign_ID { get; set; }
        public string Campaign_Name { get; set; }
        public string Campaign_Description { get; set; }
        public System.DateTime Campaign_Start_Date { get; set; }
        public System.DateTime Campaign_End_Date { get; set; }
        public decimal Campaign_Goal { get; set; }
        public Nullable<int> Campaign_Status_ID { get; set; }
        public Nullable<decimal> Amount_Received { get; set; }
    
        public virtual Campaign_Status Campaign_Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Organiation> Organiations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Card> Cards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EFT> EFTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paypal> Paypals { get; set; }
    }
}
