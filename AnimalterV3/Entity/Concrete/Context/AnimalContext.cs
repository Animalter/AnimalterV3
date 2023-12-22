﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;

namespace AnimalterV3.Entity.Concrete.Context
{
    public class AnimalContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-1P4I2CF\SQLEXPRESS;Database=Animalter;Trusted_connection=true;TrustServerCertificate=true");
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdoptionStatus> AdoptionStatuses { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Genus> Genus { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<Typee> Types { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        public DbSet<UserTbl> UserTbls { get; set; }
        public DbSet<RoleTbl> RoleTbls { get; set; }
        public DbSet<UserRoleTbl> UserRoles { get; set; }
    }
}