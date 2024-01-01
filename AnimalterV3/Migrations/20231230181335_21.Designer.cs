﻿// <auto-generated />
using System;
using AnimalterV3.Entity.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimalterV3.Migrations
{
    [DbContext(typeof(AnimalContext))]
    [Migration("20231230181335_21")]
    partial class _21
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("Mail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.AdoptionStatus", b =>
                {
                    b.Property<int>("AdoptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdoptionId"));

                    b.Property<DateTime?>("AdoptionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AdoptionId");

                    b.HasIndex("AnimalId");

                    b.HasIndex("UserId");

                    b.ToTable("AdoptionStatuses");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnimalId"));

                    b.Property<bool>("AdoptionState")
                        .HasColumnType("bit");

                    b.Property<string>("AnimaiImageUrl")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AnimalAbout")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("AnimalAgeMouth")
                        .HasColumnType("int");

                    b.Property<int>("AnimalAgeYear")
                        .HasColumnType("int");

                    b.Property<string>("AnimalGender")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AnimalName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("GenusId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("AnimalId");

                    b.HasIndex("GenusId");

                    b.HasIndex("TypeId");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CustomerMail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerPhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Customername")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.Genus", b =>
                {
                    b.Property<int>("GenusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenusId"));

                    b.Property<string>("Genuss")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TypeeId")
                        .HasColumnType("int");

                    b.HasKey("GenusId");

                    b.HasIndex("TypeeId");

                    b.ToTable("Genus");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.PetOwner", b =>
                {
                    b.Property<int>("PetownerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PetownerId"));

                    b.Property<DateTime?>("AdoptionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("AdoptionStatusId")
                        .HasColumnType("int");

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("PetownerId");

                    b.ToTable("petOwners");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.RoleTbl", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("RoleTbls");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.Typee", b =>
                {
                    b.Property<int>("TypeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeeId"));

                    b.Property<string>("Typeee")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TypeeId");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.UserOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("OperationClaimId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserOperationClaims");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.UserRoleTbl", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserRoleID")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.UserTbl", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("UserTbls");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.AdoptionStatus", b =>
                {
                    b.HasOne("AnimalterV3.Entity.Concrete.Animal", "Animal")
                        .WithMany("AdoptionStatuses")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnimalterV3.Entity.Concrete.UserTbl", "userTbl")
                        .WithMany("AdoptionStatusess")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("userTbl");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.Animal", b =>
                {
                    b.HasOne("AnimalterV3.Entity.Concrete.Genus", "Genus")
                        .WithMany("Animals")
                        .HasForeignKey("GenusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnimalterV3.Entity.Concrete.Typee", "Typeee")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genus");

                    b.Navigation("Typeee");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.Genus", b =>
                {
                    b.HasOne("AnimalterV3.Entity.Concrete.Typee", null)
                        .WithMany("GenusList")
                        .HasForeignKey("TypeeId");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.UserRoleTbl", b =>
                {
                    b.HasOne("AnimalterV3.Entity.Concrete.RoleTbl", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnimalterV3.Entity.Concrete.UserTbl", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.Animal", b =>
                {
                    b.Navigation("AdoptionStatuses");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.Genus", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.RoleTbl", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.Typee", b =>
                {
                    b.Navigation("GenusList");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.UserTbl", b =>
                {
                    b.Navigation("AdoptionStatusess");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
