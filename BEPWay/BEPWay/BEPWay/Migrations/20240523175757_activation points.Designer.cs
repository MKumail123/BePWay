﻿// <auto-generated />
using System;
using BEPWay.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BEPWay.Migrations
{
    [DbContext(typeof(BEPContext))]
    [Migration("20240523175757_activation points")]
    partial class activationpoints
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BEPWay.Models.Domain.Bank", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Banks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("db8eb400-822e-4794-a176-42a3f4f93af6"),
                            AccountNo = "03205001894",
                            AccountTitle = "Taimoor Haider Shah",
                            Active = true,
                            BankName = "Easypaisa",
                            CreatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4778),
                            CreatedBy = "Admin",
                            UpdatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4779),
                            UpdatedBy = "Admin"
                        },
                        new
                        {
                            Id = new Guid("5e89ff39-452a-422b-9a70-de023150e2ec"),
                            AccountNo = "03098379012",
                            AccountTitle = "Nalain Abbas",
                            Active = true,
                            BankName = "Jazzcash",
                            CreatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4785),
                            CreatedBy = "Admin",
                            UpdatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4786),
                            UpdatedBy = "Admin"
                        },
                        new
                        {
                            Id = new Guid("f0f4e275-1de5-41f6-bc13-f66021a7b004"),
                            AccountNo = "01210010080914760010",
                            AccountTitle = "Sohail Ahmed",
                            Active = true,
                            BankName = "Allied Bank",
                            CreatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4791),
                            CreatedBy = "Admin",
                            UpdatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4791),
                            UpdatedBy = "Admin"
                        },
                        new
                        {
                            Id = new Guid("605c64c8-ed72-4f57-af1f-a700f35355e6"),
                            AccountNo = "03098379012",
                            AccountTitle = "Nalain Abbas",
                            Active = true,
                            BankName = "Sadapay",
                            CreatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4795),
                            CreatedBy = "Admin",
                            UpdatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4796),
                            UpdatedBy = "Admin"
                        });
                });

            modelBuilder.Entity("BEPWay.Models.Domain.Commission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LevelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Precentage")
                        .HasColumnType("real");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserPackageId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LevelId");

                    b.HasIndex("UserPackageId");

                    b.ToTable("Commissions");
                });

            modelBuilder.Entity("BEPWay.Models.Domain.Level", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Levels");
                });

            modelBuilder.Entity("BEPWay.Models.Domain.Package", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Points")
                        .HasColumnType("float");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Packages");

                    b.HasData(
                        new
                        {
                            Id = new Guid("07da424c-1b7f-407e-be59-908884b25015"),
                            Active = true,
                            Amount = 1500,
                            CreatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4667),
                            CreatedBy = "Admin",
                            Name = "Basic Friendly",
                            Points = 15.0,
                            UpdatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4678),
                            UpdatedBy = "Admin",
                            Value = 7.5
                        },
                        new
                        {
                            Id = new Guid("b2f21012-62cf-4467-bc68-ad40d81ccd4c"),
                            Active = true,
                            Amount = 5250,
                            CreatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4685),
                            CreatedBy = "Admin",
                            Name = "Advance Pro Bundle",
                            Points = 52.5,
                            UpdatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4686),
                            UpdatedBy = "Admin",
                            Value = 26.25
                        },
                        new
                        {
                            Id = new Guid("fb9081b9-eedd-4db5-a868-ea512d15374c"),
                            Active = true,
                            Amount = 9000,
                            CreatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4691),
                            CreatedBy = "Admin",
                            Name = "Premium Max Bundle",
                            Points = 90.0,
                            UpdatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4692),
                            UpdatedBy = "Admin",
                            Value = 45.0
                        },
                        new
                        {
                            Id = new Guid("e911932a-0de2-4d8d-9ccd-5950b91d79cd"),
                            Active = true,
                            Amount = 19000,
                            CreatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4695),
                            CreatedBy = "Admin",
                            Name = "Alpha Leadership Bundle",
                            Points = 190.0,
                            UpdatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4696),
                            UpdatedBy = "Admin",
                            Value = 95.0
                        });
                });

            modelBuilder.Entity("BEPWay.Models.Domain.Refference", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RefferalUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Refferences");
                });

            modelBuilder.Entity("BEPWay.Models.Domain.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a5bc3de4-862e-475a-897c-67edfdd6b20e"),
                            Active = true,
                            CreatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4830),
                            CreatedBy = "Admin",
                            Name = "Admin",
                            UpdatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4831),
                            UpdatedBy = "Admin"
                        },
                        new
                        {
                            Id = new Guid("cb9ff0ab-26b7-43f2-a655-76f97ea65e63"),
                            Active = true,
                            CreatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4836),
                            CreatedBy = "Admin",
                            Name = "Customer",
                            UpdatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4837),
                            UpdatedBy = "Admin"
                        });
                });

            modelBuilder.Entity("BEPWay.Models.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("CNIC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cdab35de-e131-484c-9b33-8cb210af0beb"),
                            Active = true,
                            CNIC = "123132433231",
                            CreatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4863),
                            CreatedBy = "Admin",
                            DateOfBirth = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4861),
                            Email = "admin@gmail.com",
                            FatherName = "Admin",
                            MobileNo = "03005019767",
                            Name = "Admin",
                            Password = "Admin",
                            UpdatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4864),
                            UpdatedBy = "Admin",
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("BEPWay.Models.Domain.UserPackage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ActivationPoints")
                        .HasColumnType("int");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PackageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PackageId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPackages");
                });

            modelBuilder.Entity("BEPWay.Models.Domain.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b360eb40-3220-4a22-b5d9-d6b4625fda08"),
                            Active = true,
                            CreatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4890),
                            CreatedBy = "Admin",
                            RoleId = new Guid("a5bc3de4-862e-475a-897c-67edfdd6b20e"),
                            UpdatedAt = new DateTime(2024, 5, 23, 22, 57, 56, 364, DateTimeKind.Local).AddTicks(4891),
                            UpdatedBy = "Admin",
                            UserId = new Guid("cdab35de-e131-484c-9b33-8cb210af0beb")
                        });
                });

            modelBuilder.Entity("BEPWay.Models.Domain.Commission", b =>
                {
                    b.HasOne("BEPWay.Models.Domain.Level", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BEPWay.Models.Domain.UserPackage", "UserPackage")
                        .WithMany()
                        .HasForeignKey("UserPackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Level");

                    b.Navigation("UserPackage");
                });

            modelBuilder.Entity("BEPWay.Models.Domain.Refference", b =>
                {
                    b.HasOne("BEPWay.Models.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BEPWay.Models.Domain.UserPackage", b =>
                {
                    b.HasOne("BEPWay.Models.Domain.Package", "Package")
                        .WithMany()
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BEPWay.Models.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Package");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BEPWay.Models.Domain.UserRole", b =>
                {
                    b.HasOne("BEPWay.Models.Domain.Role", "Role")
                        .WithOne("UserRole")
                        .HasForeignKey("BEPWay.Models.Domain.UserRole", "RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BEPWay.Models.Domain.User", "User")
                        .WithOne("UserRole")
                        .HasForeignKey("BEPWay.Models.Domain.UserRole", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BEPWay.Models.Domain.Role", b =>
                {
                    b.Navigation("UserRole")
                        .IsRequired();
                });

            modelBuilder.Entity("BEPWay.Models.Domain.User", b =>
                {
                    b.Navigation("UserRole")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
