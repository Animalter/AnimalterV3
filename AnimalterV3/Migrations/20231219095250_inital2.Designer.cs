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
    [Migration("20231219095250_inital2")]
    partial class inital2
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

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("AdoptionId");

                    b.HasIndex("AnimalId");

                    b.HasIndex("CustomerId");

                    b.ToTable("AdoptionStatuses");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnimalId"));

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

                    b.Property<string>("AnmalGenus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("GenusId")
                        .HasColumnType("int");

                    b.HasKey("AnimalId");

                    b.HasIndex("GenusId");

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

                    b.Property<int?>("TypeeTypeId")
                        .HasColumnType("int");

                    b.HasKey("GenusId");

                    b.HasIndex("TypeeTypeId");

                    b.ToTable("Genus");
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

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.Typee", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeId"));

                    b.Property<string>("Typeee")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TypeId");

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

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.AdoptionStatus", b =>
                {
                    b.HasOne("AnimalterV3.Entity.Concrete.Animal", "Animal")
                        .WithMany("AdoptionStatuses")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnimalterV3.Entity.Concrete.Customer", "Customer")
                        .WithMany("AdoptionStatuses")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.Animal", b =>
                {
                    b.HasOne("AnimalterV3.Entity.Concrete.Genus", "Genus")
                        .WithMany("Animals")
                        .HasForeignKey("GenusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genus");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.Genus", b =>
                {
                    b.HasOne("AnimalterV3.Entity.Concrete.Typee", null)
                        .WithMany("GenusList")
                        .HasForeignKey("TypeeTypeId");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.Animal", b =>
                {
                    b.Navigation("AdoptionStatuses");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.Customer", b =>
                {
                    b.Navigation("AdoptionStatuses");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.Genus", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("AnimalterV3.Entity.Concrete.Typee", b =>
                {
                    b.Navigation("GenusList");
                });
#pragma warning restore 612, 618
        }
    }
}
