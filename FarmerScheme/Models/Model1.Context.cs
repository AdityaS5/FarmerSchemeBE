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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FarmerSchemeEntities : DbContext
    {
        public FarmerSchemeEntities()
            : base("name=FarmerSchemeEntities")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<bid_history> bid_history { get; set; }
        public virtual DbSet<crop_information> crop_information { get; set; }
        public virtual DbSet<crop> crops { get; set; }
        public virtual DbSet<insurance> insurances { get; set; }
        public virtual DbSet<insurance_claim> insurance_claim { get; set; }
        public virtual DbSet<land_details> land_details { get; set; }
        public virtual DbSet<transaction_history> transaction_history { get; set; }
        public virtual DbSet<user_information> user_information { get; set; }
    }
}
