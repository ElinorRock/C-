﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MYAPPEntities : DbContext
    {
        public MYAPPEntities()
            : base("name=MYAPPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DepartmentTable> DepartmentTable { get; set; }
        public virtual DbSet<EmployeeTable> EmployeeTable { get; set; }
        public virtual DbSet<ShiftTable> ShiftTable { get; set; }
        public virtual DbSet<UserTable> UserTable { get; set; }
        public virtual DbSet<EmployeeShiftTable> EmployeeShiftTable { get; set; }
    }
}
