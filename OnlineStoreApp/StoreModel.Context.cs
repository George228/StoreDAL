﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineStoreApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OnlineStoreEntities : DbContext
    {
        public OnlineStoreEntities() : base("name=OnlineStoreEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C_order_> C_order_ { get; set; }
        public virtual DbSet<discount> discounts { get; set; }
        public virtual DbSet<product_id> product_id { get; set; }
        public virtual DbSet<user_id> user_id { get; set; }
    }
}
