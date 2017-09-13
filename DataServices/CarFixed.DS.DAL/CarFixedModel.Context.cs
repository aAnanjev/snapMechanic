﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarFixed.DS.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    using CarFixed.DS.DM;
    
    public partial class CarFixedEntities : DbContext
    {
        public CarFixedEntities()
            : base("name=CarFixedEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BasicCategory> BasicCategories { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<CarFixedUser> CarFixedUsers { get; set; }
        public virtual DbSet<Quote> Quotes { get; set; }
        public virtual DbSet<QuoteItemAdvRepair> QuoteItemAdvRepairs { get; set; }
        public virtual DbSet<QuoteItemAdvService> QuoteItemAdvServices { get; set; }
        public virtual DbSet<QuoteItemBasic> QuoteItemBasics { get; set; }
        public virtual DbSet<QuoteUrgency> QuoteUrgencies { get; set; }
        public virtual DbSet<GarageService> GarageServices { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Garage> Garages { get; set; }
        public virtual DbSet<QuoteGarageOption> QuoteGarageOptions { get; set; }
        public virtual DbSet<BasicSubCategoryGroup> BasicSubCategoryGroups { get; set; }
        public virtual DbSet<BasicSubCategoryRepairRef> BasicSubCategoryRepairRefs { get; set; }
        public virtual DbSet<BasicSubCategory> BasicSubCategories { get; set; }
    
        public virtual ObjectResult<GarageSelectByQuoteDistance_Result> GarageSelectByQuoteDistance(Nullable<int> quoteID, Nullable<double> radius)
        {
            var quoteIDParameter = quoteID.HasValue ?
                new ObjectParameter("QuoteID", quoteID) :
                new ObjectParameter("QuoteID", typeof(int));
    
            var radiusParameter = radius.HasValue ?
                new ObjectParameter("Radius", radius) :
                new ObjectParameter("Radius", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GarageSelectByQuoteDistance_Result>("GarageSelectByQuoteDistance", quoteIDParameter, radiusParameter);
        }
    }
}
