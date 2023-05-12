﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SAD.Data;

#nullable disable

namespace SAD.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230510143545_SlotTime")]
    partial class SlotTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "78bf8cbe-1f70-4d6d-890b-247bc57e6150",
                            ConcurrencyStamp = "231728ec-ceef-4de5-8c95-7f82a488cc0d",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "ecfbe7ad-bb6b-49e6-ac2b-6359a73fbf02",
                            ConcurrencyStamp = "68144efc-092a-403e-a7fe-3c276de06a72",
                            Name = "Tutor",
                            NormalizedName = "TUTOR"
                        },
                        new
                        {
                            Id = "2e97d46f-5885-4d65-aa2f-29e7e2d323fd",
                            ConcurrencyStamp = "2a956498-1cb2-4a0f-8d27-236a95c6e820",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "143d3180-1104-46f0-8646-62d630056f42",
                            RoleId = "78bf8cbe-1f70-4d6d-890b-247bc57e6150"
                        },
                        new
                        {
                            UserId = "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb",
                            RoleId = "2e97d46f-5885-4d65-aa2f-29e7e2d323fd"
                        },
                        new
                        {
                            UserId = "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd",
                            RoleId = "ecfbe7ad-bb6b-49e6-ac2b-6359a73fbf02"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SAD.Models.BookingModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeSlot")
                        .HasColumnType("TEXT");

                    b.Property<string>("TutorId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TutorId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("SAD.Models.CustomUserModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Available")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("teacherCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "143d3180-1104-46f0-8646-62d630056f42",
                            About = "",
                            AccessFailedCount = 0,
                            Available = true,
                            ConcurrencyStamp = "231728ec-ceef-4de5-8c95-7f82a488cc0d",
                            Email = "admin@admin.com",
                            EmailConfirmed = false,
                            FName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHaWqdcdOtNGNuFRjcHQF31/eKUAr9Q7sGq4oF8EUzNPRiTXUgIDJlercpAVKmAwvg==",
                            PhoneNumberConfirmed = false,
                            SName = "Admin",
                            SecurityStamp = "785855ac-69bd-48a4-815d-3abf34aa527c",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com",
                            teacherCode = "059bcac3-c3e4-46ee-be7b-7cb28240fb9e"
                        },
                        new
                        {
                            Id = "2e172219-ecdf-45c7-8ea2-8f76bd3a59eb",
                            About = "",
                            AccessFailedCount = 0,
                            Available = true,
                            ConcurrencyStamp = "2a956498-1cb2-4a0f-8d27-236a95c6e820",
                            Email = "student@student.com",
                            EmailConfirmed = false,
                            FName = "Student",
                            LockoutEnabled = false,
                            NormalizedEmail = "STUDENT@STUDENT.COM",
                            NormalizedUserName = "STUDENT@STUDENT.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEK1/ipAYxc6bXsn5KlbDJPoCsW7bsY7naVO8ykantqfkaDYiOK6TMLbTCNGlwnUfbg==",
                            PhoneNumberConfirmed = false,
                            SName = "Student",
                            SecurityStamp = "fefc9ded-3982-4f95-85e2-c5ef4fcc045b",
                            TwoFactorEnabled = false,
                            UserName = "student@student.com",
                            teacherCode = "37808cb2-59aa-424a-aa88-0baca97b079e"
                        },
                        new
                        {
                            Id = "e13adf95-ebab-4419-ad3e-0d3a5fbb69cd",
                            About = "I am an experienced teacher with 10 years of experience in teaching Math and Science.",
                            AccessFailedCount = 0,
                            Available = true,
                            ConcurrencyStamp = "68144efc-092a-403e-a7fe-3c276de06a72",
                            Email = "tutor@tutor.com",
                            EmailConfirmed = false,
                            FName = "Tutor",
                            LockoutEnabled = false,
                            NormalizedEmail = "TUTOR@TUTOR.COM",
                            NormalizedUserName = "TUTOR@TUTOR.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECICzHQLt2Aoe6UY33cb+DggrzIx0c2E8zg146HXN4TEJQRp8kloHB3ekKvvO4RH+g==",
                            PhoneNumberConfirmed = false,
                            SName = "Tutor",
                            SecurityStamp = "25be22c6-cc1f-49a3-b5e0-771df1995926",
                            TwoFactorEnabled = false,
                            UserName = "tutor@tutor.com",
                            teacherCode = "1234567890"
                        });
                });

            modelBuilder.Entity("SAD.Models.FollowModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FollowerId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FollowingId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FollowerId");

                    b.HasIndex("FollowingId");

                    b.ToTable("Follow");
                });

            modelBuilder.Entity("SAD.Models.TutorAvailability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("End")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Start")
                        .HasColumnType("TEXT");

                    b.Property<string>("TutorId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TutorAvailabilities");
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
                    b.HasOne("SAD.Models.CustomUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SAD.Models.CustomUserModel", null)
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

                    b.HasOne("SAD.Models.CustomUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SAD.Models.CustomUserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SAD.Models.BookingModel", b =>
                {
                    b.HasOne("SAD.Models.CustomUserModel", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SAD.Models.CustomUserModel", "Tutor")
                        .WithMany()
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("SAD.Models.FollowModel", b =>
                {
                    b.HasOne("SAD.Models.CustomUserModel", "Follower")
                        .WithMany()
                        .HasForeignKey("FollowerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SAD.Models.CustomUserModel", "Following")
                        .WithMany()
                        .HasForeignKey("FollowingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Follower");

                    b.Navigation("Following");
                });
#pragma warning restore 612, 618
        }
    }
}
