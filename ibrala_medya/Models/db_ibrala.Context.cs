﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ibrala_medya.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_ibralamedyaEntities3 : DbContext
    {
        public db_ibralamedyaEntities3()
            : base("name=db_ibralamedyaEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<anaicerik> anaicerik { get; set; }
        public DbSet<calisanlarimiz> calisanlarimiz { get; set; }
        public DbSet<galeri> galeri { get; set; }
        public DbSet<hakkimizda> hakkimizda { get; set; }
        public DbSet<hizmetlerimiz> hizmetlerimiz { get; set; }
        public DbSet<iletisim> iletisim { get; set; }
        public DbSet<referanslar> referanslar { get; set; }
    }
}
