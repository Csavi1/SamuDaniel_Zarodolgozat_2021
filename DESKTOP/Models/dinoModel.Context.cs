﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dinobazis.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dinoContext : DbContext
    {
        public dinoContext()
            : base("name=dinoContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<dinok> dinok { get; set; }
        public virtual DbSet<felfedezok> felfedezok { get; set; }
        public virtual DbSet<felhasznalok> felhasznalok { get; set; }
        public virtual DbSet<taplalkozasi_forma> taplalkozasi_forma { get; set; }
    }
}
