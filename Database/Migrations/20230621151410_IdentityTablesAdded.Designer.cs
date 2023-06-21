﻿// <auto-generated />
using System;
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230621151410_IdentityTablesAdded")]
    partial class IdentityTablesAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Custom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("FeatureApp.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sku")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a5dfab4c-9e7b-4dda-b4a7-1387645e228f"),
                            CreatedBy = new Guid("45165d20-08b1-460a-adcc-5d35e829ebcf"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2686),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "Grunge Skater Jeans",
                            Price = 68m,
                            Sku = "AWMGSJ"
                        },
                        new
                        {
                            Id = new Guid("385acc17-77a3-48e7-a54b-2a55d19ca490"),
                            CreatedBy = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "Polo Shirt",
                            Price = 35m,
                            Sku = "AWMPS"
                        },
                        new
                        {
                            Id = new Guid("ab422ac4-6c9e-425c-afd5-75a33a613296"),
                            CreatedBy = new Guid("d79f2348-c0e6-4277-805c-62836d642193"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2700),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "Skater Graphic T-Shirt",
                            Price = 33m,
                            Sku = "AWMSGT"
                        },
                        new
                        {
                            Id = new Guid("d810b38d-4776-404c-b9b8-61efde8c3b7f"),
                            CreatedBy = new Guid("461fc088-5561-4ada-ad33-ee80e6d5a794"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2704),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "Slicker Jacket",
                            Price = 125m,
                            Sku = "AWMSJ"
                        },
                        new
                        {
                            Id = new Guid("97c5c1ac-bff9-451d-a8c3-a2a332324028"),
                            CreatedBy = new Guid("d50d5a96-4132-4cea-878c-917e76b47fe2"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2712),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "Thermal Fleece Jacket",
                            Price = 60m,
                            Sku = "AWMTFJ"
                        },
                        new
                        {
                            Id = new Guid("b0d5a1b6-c347-4de1-b33e-e1a5d6f3b402"),
                            CreatedBy = new Guid("f20fd41e-bc91-4317-b897-46b466e0188a"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2715),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "Unisex Thermal Vest",
                            Price = 95m,
                            Sku = "AWMUTV"
                        },
                        new
                        {
                            Id = new Guid("8be7a4b9-3aec-4e6d-bec9-04b506cddcc3"),
                            CreatedBy = new Guid("2206460a-08a6-4a05-8665-97af481c73b1"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2770),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "V-Neck Pullover",
                            Price = 65m,
                            Sku = "AWMVNP"
                        },
                        new
                        {
                            Id = new Guid("aabc4689-24f9-4c5b-a2e5-e5f73ff679d2"),
                            CreatedBy = new Guid("330466d1-ea1c-4cf0-a012-1ed8062d58a6"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2774),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "V-Neck Sweater",
                            Price = 65m,
                            Sku = "AWMVNS"
                        },
                        new
                        {
                            Id = new Guid("6558c9d8-d197-43c8-9249-5449edc63947"),
                            CreatedBy = new Guid("92a329a1-6b46-41c7-ab0d-5aea81007e24"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2781),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "V-Neck T-Shirt",
                            Price = 17m,
                            Sku = "AWMVNT"
                        },
                        new
                        {
                            Id = new Guid("8bdaebc1-547e-47b1-a354-ee6a5d6d5827"),
                            CreatedBy = new Guid("6fe9a226-26bb-4b73-9967-cde14a612cf7"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2785),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "Bamboo Thermal Ski Coat",
                            Price = 99m,
                            Sku = "AWWBTSC"
                        },
                        new
                        {
                            Id = new Guid("c7559679-8c41-4118-9f85-94c89e568ad1"),
                            CreatedBy = new Guid("7ec95042-7236-4228-9866-1278be75c281"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2789),
                            Description = "",
                            IsAvailable = false,
                            IsNew = false,
                            Name = "Cross-Back Training Tank",
                            Price = 0m,
                            Sku = "AWWCTT"
                        },
                        new
                        {
                            Id = new Guid("927fe8f6-a4c2-4501-a5c5-01151567be4d"),
                            CreatedBy = new Guid("065a17fb-b13c-4ffc-834a-00763931da2f"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2793),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "Grunge Skater Jeans",
                            Price = 68m,
                            Sku = "AWWGSJ"
                        },
                        new
                        {
                            Id = new Guid("f055affd-a166-4736-8bf4-7893bb54449e"),
                            CreatedBy = new Guid("ebba854d-1508-4b9d-9bca-67f9846e94be"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2802),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "Slicker Jacket",
                            Price = 125m,
                            Sku = "AWWSJ"
                        },
                        new
                        {
                            Id = new Guid("15e8f0e6-4939-4d78-9f0c-7eadad4ab6b0"),
                            CreatedBy = new Guid("d3ac1cb2-442d-4d77-8f9e-d527766e7820"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2806),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "Stretchy Dance Pants",
                            Price = 55m,
                            Sku = "AWWSDP"
                        },
                        new
                        {
                            Id = new Guid("0e0d8863-3b7d-495b-ad99-0d7ba36b35c7"),
                            CreatedBy = new Guid("e3fc4112-6e4e-45aa-9993-44e86226c715"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2810),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "Ultra-Soft Tank Top",
                            Price = 22m,
                            Sku = "AWWUTT"
                        },
                        new
                        {
                            Id = new Guid("5aef10a9-8588-4669-a2c0-7f98975603a7"),
                            CreatedBy = new Guid("fcb8cd33-1324-422b-b910-b96c40553461"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2815),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "Unisex Thermal Vest",
                            Price = 95m,
                            Sku = "AWWUTV"
                        },
                        new
                        {
                            Id = new Guid("60ada22c-df87-42c8-9959-2aff0528943d"),
                            CreatedBy = new Guid("99d3eb12-dae4-4a35-bea0-99db2203a4bf"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2822),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "V-Next T-Shirt",
                            Price = 17m,
                            Sku = "AWWVNT"
                        },
                        new
                        {
                            Id = new Guid("8b7a42bc-7048-4cff-a281-cfa304f6c7cc"),
                            CreatedBy = new Guid("e947ec40-5b72-4cdb-87b6-c3292049edc7"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2827),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "Blueberry Mineral Water",
                            Price = 2.8m,
                            Sku = "MWB"
                        },
                        new
                        {
                            Id = new Guid("3ac135ae-c046-4a07-b8f9-9fd64e171ec2"),
                            CreatedBy = new Guid("b0edd2dc-3b46-4a47-9481-ae71f1c460ec"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2831),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "Lemon-Lime Mineral Water",
                            Price = 2.8m,
                            Sku = "MWLL"
                        },
                        new
                        {
                            Id = new Guid("8a529a9c-b446-494d-9af0-562e2ab06ab5"),
                            CreatedBy = new Guid("781c9292-fce8-43f5-ab80-cbbe08e5252a"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2835),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "Orange Mineral Water",
                            Price = 2.8m,
                            Sku = "MWO"
                        },
                        new
                        {
                            Id = new Guid("60c23758-b27c-4b36-af56-0a494594c540"),
                            CreatedBy = new Guid("ae81d85d-11f8-43ee-9fe3-f1b72e0c7d82"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2843),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "Peach Mineral Water",
                            Price = 2.8m,
                            Sku = "MWP"
                        },
                        new
                        {
                            Id = new Guid("1dbab901-c31e-4531-9518-955d2e9658cd"),
                            CreatedBy = new Guid("29ad9322-cca9-45a7-8726-6526c9111d3d"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2846),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "Raspberry Mineral Water",
                            Price = 2.8m,
                            Sku = "MWR"
                        },
                        new
                        {
                            Id = new Guid("5fc00846-0ad7-4d82-b1bf-dd88f747b4b6"),
                            CreatedBy = new Guid("8fdb2302-2524-4293-9e34-44a816cb91d1"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2850),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "Strawberry Mineral Water",
                            Price = 2.8m,
                            Sku = "MWS"
                        },
                        new
                        {
                            Id = new Guid("29c730ec-6870-49fb-8e97-312366b91966"),
                            CreatedBy = new Guid("466775ba-34d4-4654-9ea6-9796e09d228e"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2854),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "In the Kitchen with H+ Sport",
                            Price = 24.99m,
                            Sku = "PITK"
                        },
                        new
                        {
                            Id = new Guid("4635e8b8-1647-462b-b2a8-71fc71f13bde"),
                            CreatedBy = new Guid("49a9873d-d0f4-4b91-b5fa-873ac8dd1ce6"),
                            CreatedDate = new DateTime(2023, 6, 21, 20, 14, 10, 423, DateTimeKind.Local).AddTicks(2862),
                            Description = "",
                            IsAvailable = true,
                            IsNew = false,
                            Name = "Calcium 400 IU (150 tablets)",
                            Price = 9.99m,
                            Sku = "SC400"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}