﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class erationEntities28 : DbContext
    {
        public erationEntities28()
            : base("name=erationEntities28")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<quota> quotas { get; set; }
        public virtual DbSet<stock> stocks { get; set; }
        public virtual DbSet<ttlsale> ttlsales { get; set; }
    }
}
