﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagement.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SchoolManagementEntities1 : DbContext
    {
        public SchoolManagementEntities1()
            : base("name=SchoolManagementEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Class_Section> Class_Section { get; set; }
        public virtual DbSet<ClassPeriodAcademic> ClassPeriodAcademics { get; set; }
        public virtual DbSet<ClassRoutineAcademic> ClassRoutineAcademics { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<SchoolDetail> SchoolDetails { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Stream> Streams { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserSubscriptionPlanDetail> UserSubscriptionPlanDetails { get; set; }
        public virtual DbSet<StudentAttandance> StudentAttandances { get; set; }
        public virtual DbSet<ClassTeacherAcademic> ClassTeacherAcademics { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<StudentFeeAccounting> StudentFeeAccountings { get; set; }
        public virtual DbSet<StudentFeeInstallment> StudentFeeInstallments { get; set; }
        public virtual DbSet<StudentInstallment> StudentInstallments { get; set; }
        public virtual DbSet<Expens> Expenses { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<SchoolStaff> SchoolStaffs { get; set; }
    }
}