﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrowdfundingPlatform.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities1 : DbContext
    {
        public Entities1()
            : base("name=Entities1")
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
        public virtual DbSet<AttachmentDto> AttachmentDtoes { get; set; }
        public virtual DbSet<FundingPackageDto> FundingPackageDtoes { get; set; }
        public virtual DbSet<ProjectCategoryDto> ProjectCategoryDtoes { get; set; }
        public virtual DbSet<ProjectCommentDto> ProjectCommentDtoes { get; set; }
        public virtual DbSet<ProjectDTO> ProjectDTOes { get; set; }
        public virtual DbSet<ProjectStatsDto> ProjectStatsDtoes { get; set; }
        public virtual DbSet<ProjectUpdateDto> ProjectUpdateDtoes { get; set; }
        public virtual DbSet<UserFundingDTO> UserFundingDTOes { get; set; }
    }
}
