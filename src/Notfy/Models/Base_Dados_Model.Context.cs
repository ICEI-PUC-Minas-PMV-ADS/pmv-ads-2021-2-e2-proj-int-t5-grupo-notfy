﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Notfy.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BD_NOTFYEntities : DbContext
    {
        public BD_NOTFYEntities()
            : base("name=BD_NOTFYEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Notificacao> Notificacao { get; set; }
        public virtual DbSet<Notificando> Notificando { get; set; }
        public virtual DbSet<Notificador> Notificador { get; set; }
    }
}