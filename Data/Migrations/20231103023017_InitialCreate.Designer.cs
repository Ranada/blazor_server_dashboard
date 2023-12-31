﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blazor_server_dashboard.Data;

#nullable disable

namespace blazor_server_dashboard.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231103023017_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.2.23480.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("blazor_server_dashboard.Data.Models.TaskModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AssignedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssignedTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CompletionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Priority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tasks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ce3c917f-7d3c-41cd-8c1f-8d4593053093"),
                            AssignedBy = "Keisha Weiland",
                            AssignedTo = "Katelyn Pham",
                            Description = "Fix security vulnerability",
                            DueDate = new DateTime(2024, 12, 13, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(3416),
                            Priority = "medium",
                            StartDate = new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(3416)
                        },
                        new
                        {
                            Id = new Guid("9189defa-bb7e-47ca-96e1-f41ca1948bd6"),
                            AssignedBy = "Keisha Weiland",
                            AssignedTo = "Billy Dietz",
                            Description = "Fix security vulnerability",
                            DueDate = new DateTime(2025, 1, 4, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(3972),
                            Priority = "high",
                            StartDate = new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(3972)
                        },
                        new
                        {
                            Id = new Guid("625ce82d-896f-4ac1-a43e-0573ad36411c"),
                            AssignedBy = "Diane Basham",
                            AssignedTo = "Neil Ranada",
                            Description = "Review code",
                            DueDate = new DateTime(2024, 2, 22, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4034),
                            Priority = "low",
                            StartDate = new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4034)
                        },
                        new
                        {
                            Id = new Guid("ad25424d-9d4a-45d6-9dc5-1eceecb0f838"),
                            AssignedBy = "Katelyn Pham",
                            AssignedTo = "Diane Basham",
                            Description = "Sign security agreements",
                            DueDate = new DateTime(2024, 9, 11, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4089),
                            Priority = "high",
                            StartDate = new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4089)
                        },
                        new
                        {
                            Id = new Guid("83697a92-a49e-498b-bc72-e07f6f18963d"),
                            AssignedBy = "Keisha Weiland",
                            AssignedTo = "Tammy Wescott",
                            Description = "Complete cybersecurity training",
                            DueDate = new DateTime(2024, 11, 28, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4137),
                            Priority = "medium",
                            StartDate = new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4137)
                        },
                        new
                        {
                            Id = new Guid("187ee924-d6b9-4f5e-a421-ccb937de901f"),
                            AssignedBy = "Tammy Wescott",
                            AssignedTo = "Tammy Wescott",
                            Description = "Review code",
                            DueDate = new DateTime(2024, 10, 5, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4236),
                            Priority = "low",
                            StartDate = new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4236)
                        },
                        new
                        {
                            Id = new Guid("b49484c4-e1eb-4e13-8005-117d472d9f2e"),
                            AssignedBy = "Diane Basham",
                            AssignedTo = "Billy Dietz",
                            Description = "Review and approve security plan",
                            DueDate = new DateTime(2025, 2, 25, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4291),
                            Priority = "high",
                            StartDate = new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4291)
                        },
                        new
                        {
                            Id = new Guid("6a056730-b742-44bd-9758-0907368353cf"),
                            AssignedBy = "Neil Ranada",
                            AssignedTo = "Neil Ranada",
                            Description = "Sign security agreements",
                            DueDate = new DateTime(2024, 7, 7, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4341),
                            Priority = "low",
                            StartDate = new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4341)
                        },
                        new
                        {
                            Id = new Guid("ffdc6120-ffb5-47c3-a0c3-e6d8d71db07a"),
                            AssignedBy = "Keisha Weiland",
                            AssignedTo = "Diane Basham",
                            Description = "Sign security agreements",
                            DueDate = new DateTime(2024, 11, 3, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4388),
                            Priority = "high",
                            StartDate = new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4388)
                        },
                        new
                        {
                            Id = new Guid("21d637eb-b0c5-4290-8962-0765baedf7be"),
                            AssignedBy = "Diane Basham",
                            AssignedTo = "Billy Dietz",
                            Description = "Audit security program",
                            DueDate = new DateTime(2024, 11, 1, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4434),
                            Priority = "high",
                            StartDate = new DateTime(2023, 11, 2, 22, 30, 17, 75, DateTimeKind.Local).AddTicks(4434)
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
