﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SNGMTTNanoTracker.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabasePokerEntities : DbContext
    {
        public DatabasePokerEntities()
            : base("name=DatabasePokerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Configuracao> Configuracao { get; set; }
        public DbSet<Mesas> Mesas { get; set; }
        public DbSet<Resultados> Resultados { get; set; }
    }
}
