﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElaneDaneshgah
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_elanEntities : DbContext
    {
        public db_elanEntities()
            : base("name=db_elanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_classroom> tb_classroom { get; set; }
        public virtual DbSet<tb_exception> tb_exception { get; set; }
        public virtual DbSet<tb_teacher> tb_teacher { get; set; }
        public virtual DbSet<tb_teacher_course> tb_teacher_course { get; set; }
        public virtual DbSet<tb_term> tb_term { get; set; }
        public virtual DbSet<tbl_course> tbl_course { get; set; }
    }
}
