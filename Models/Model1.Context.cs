﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class testdbEntities : DbContext
    {
        public testdbEntities()
            : base("name=testdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<image_tbl> image_tbl { get; set; }
        public DbSet<nametb> nametbs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<tbl_activity> tbl_activity { get; set; }
        public DbSet<tbl_name_conact> tbl_name_conact { get; set; }
    }
}
