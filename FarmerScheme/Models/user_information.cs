//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FarmerScheme.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class user_information
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user_information()
        {
            this.bid_history = new HashSet<bid_history>();
            this.crops = new HashSet<crop>();
            this.insurances = new HashSet<insurance>();
            this.land_details = new HashSet<land_details>();
        }
    
        public int userid { get; set; }
        public bool user_type { get; set; }
        public string username { get; set; }
        public string phone_no { get; set; }
        public string email_id { get; set; }
        public string password { get; set; }
        public string home_address { get; set; }
        public string account_no { get; set; }
        public string ifsc_code { get; set; }
        public string pan { get; set; }
        public string aadhar { get; set; }
        public bool certificate { get; set; }
        public bool aas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bid_history> bid_history { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<crop> crops { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<insurance> insurances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<land_details> land_details { get; set; }
    }
}
