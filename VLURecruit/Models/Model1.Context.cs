﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VLURecruit.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class jobeeEntities : DbContext
    {
        public jobeeEntities()
            : base("name=jobeeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Company_Info> Company_Info { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Recruitment> Recruitments { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Sections_Recruitment> Sections_Recruitment { get; set; }
        public virtual DbSet<Staff_Info> Staff_Info { get; set; }
        public virtual DbSet<Status_Account> Status_Account { get; set; }
        public virtual DbSet<Status_Recruitment> Status_Recruitment { get; set; }
        public virtual DbSet<Student_Info> Student_Info { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Tags_Recruitments> Tags_Recruitments { get; set; }
        public virtual DbSet<Time> Times { get; set; }
        public virtual DbSet<Times_Recruitment> Times_Recruitment { get; set; }
    }
}