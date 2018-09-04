﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using easy_tickets.Data;

namespace easytickets.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180904032410_ShowActVirtual")]
    partial class ShowActVirtual
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("easy_tickets.DataModels.Act", b =>
                {
                    b.Property<int>("ActID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Details");

                    b.Property<string>("Name");

                    b.HasKey("ActID");

                    b.ToTable("Acts");

                    b.HasData(
                        new { ActID = 1, Details = "Metal Royalty", Name = "Metallica" },
                        new { ActID = 2, Details = "Live adaptation of popular kid's cartoon", Name = "PAW Patrol" },
                        new { ActID = 3, Details = "Mainstream pop-punk rock", Name = "Fallout Boy" },
                        new { ActID = 4, Details = "Radio rapper", Name = "Machine Gun Kelley" },
                        new { ActID = 5, Details = "Jam band pioneer", Name = "Beck" },
                        new { ActID = 6, Details = "Country legend", Name = "Alan Jackson" },
                        new { ActID = 7, Details = "Power pop", Name = "Justin Timberlake" },
                        new { ActID = 8, Details = "Pop Rock revival", Name = "Panic! At the Disco" },
                        new { ActID = 9, Details = "Hardcore rock", Name = "Two Feet" },
                        new { ActID = 10, Details = "Pop royalty", Name = "Elton John" },
                        new { ActID = 11, Details = "Modern broadway", Name = "The Play That Goes Wrong" },
                        new { ActID = 12, Details = "Modern Bluegrass", Name = "Lake Street Dive" },
                        new { ActID = 13, Details = "Alternative", Name = "Kalbells" },
                        new { ActID = 14, Details = "Funk Rock", Name = "Here Come the Mummies!" }
                    );
                });

            modelBuilder.Entity("easy_tickets.DataModels.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Capacity");

                    b.Property<string>("Name");

                    b.HasKey("LocationID");

                    b.ToTable("Locations");

                    b.HasData(
                        new { LocationID = 1, Capacity = 14620, Name = "Pinnacle Bank Arena" },
                        new { LocationID = 2, Capacity = 5500, Name = "Pinewood Bowl Theater" },
                        new { LocationID = 3, Capacity = 18100, Name = "CHI Health Center Omaha" },
                        new { LocationID = 4, Capacity = 2596, Name = "Orpheum Theater" },
                        new { LocationID = 5, Capacity = 470, Name = "Slowdown" }
                    );
                });

            modelBuilder.Entity("easy_tickets.DataModels.Show", b =>
                {
                    b.Property<int>("ShowID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("LocationID");

                    b.Property<string>("Name");

                    b.HasKey("ShowID");

                    b.HasIndex("LocationID");

                    b.ToTable("Shows");

                    b.HasData(
                        new { ShowID = 1, Date = new DateTime(2018, 9, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), LocationID = 1, Name = "Metallica at PBA!" },
                        new { ShowID = 2, Date = new DateTime(2018, 9, 22, 14, 0, 0, 0, DateTimeKind.Unspecified), LocationID = 1, Name = "PAW Patrol LIVE! Race to the Rescue" },
                        new { ShowID = 3, Date = new DateTime(2018, 9, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), LocationID = 1, Name = "PAW Patrol LIVE! Race to the Rescue" },
                        new { ShowID = 4, Date = new DateTime(2018, 9, 6, 16, 0, 0, 0, DateTimeKind.Unspecified), LocationID = 1, Name = "Fallout Boy Mania Tour" },
                        new { ShowID = 5, Date = new DateTime(2018, 9, 6, 19, 0, 0, 0, DateTimeKind.Unspecified), LocationID = 2, Name = "The Beck Live Experience" },
                        new { ShowID = 6, Date = new DateTime(2018, 9, 21, 21, 0, 0, 0, DateTimeKind.Unspecified), LocationID = 3, Name = "Alan Jackson: Honky Tonk Highway Tour" },
                        new { ShowID = 7, Date = new DateTime(2018, 12, 8, 21, 0, 0, 0, DateTimeKind.Unspecified), LocationID = 3, Name = "Justin Timberlake - The Man Of The Woods Tour" },
                        new { ShowID = 8, Date = new DateTime(2019, 2, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), LocationID = 3, Name = "Panic! At the Disco: Pray for the Wicked Tour" },
                        new { ShowID = 9, Date = new DateTime(2019, 2, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), LocationID = 3, Name = "Elton John: Farewell Yellow Brick Road" },
                        new { ShowID = 10, Date = new DateTime(2018, 11, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), LocationID = 4, Name = "The Play That Goes Wrong" },
                        new { ShowID = 11, Date = new DateTime(2018, 11, 2, 19, 30, 0, 0, DateTimeKind.Unspecified), LocationID = 4, Name = "The Play That Goes Wrong" },
                        new { ShowID = 12, Date = new DateTime(2018, 11, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), LocationID = 4, Name = "The Play That Goes Wrong" },
                        new { ShowID = 13, Date = new DateTime(2018, 11, 3, 19, 30, 0, 0, DateTimeKind.Unspecified), LocationID = 4, Name = "The Play That Goes Wrong" },
                        new { ShowID = 14, Date = new DateTime(2018, 11, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), LocationID = 4, Name = "The Play That Goes Wrong" },
                        new { ShowID = 15, Date = new DateTime(2018, 11, 4, 19, 30, 0, 0, DateTimeKind.Unspecified), LocationID = 4, Name = "The Play That Goes Wrong" },
                        new { ShowID = 16, Date = new DateTime(2018, 9, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), LocationID = 5, Name = "All Ages Tuesday" },
                        new { ShowID = 17, Date = new DateTime(2018, 9, 13, 19, 0, 0, 0, DateTimeKind.Unspecified), LocationID = 5, Name = "Here Come the Mummies Spooktacular" }
                    );
                });

            modelBuilder.Entity("easy_tickets.DataModels.ShowAct", b =>
                {
                    b.Property<int>("ShowID");

                    b.Property<int>("ActID");

                    b.HasKey("ShowID", "ActID");

                    b.HasIndex("ActID");

                    b.ToTable("ShowActs");

                    b.HasData(
                        new { ShowID = 1, ActID = 1 },
                        new { ShowID = 2, ActID = 2 },
                        new { ShowID = 3, ActID = 2 },
                        new { ShowID = 4, ActID = 3 },
                        new { ShowID = 4, ActID = 4 },
                        new { ShowID = 5, ActID = 5 },
                        new { ShowID = 6, ActID = 6 },
                        new { ShowID = 7, ActID = 7 },
                        new { ShowID = 8, ActID = 8 },
                        new { ShowID = 8, ActID = 9 },
                        new { ShowID = 9, ActID = 10 },
                        new { ShowID = 10, ActID = 11 },
                        new { ShowID = 11, ActID = 11 },
                        new { ShowID = 12, ActID = 11 },
                        new { ShowID = 13, ActID = 11 },
                        new { ShowID = 14, ActID = 11 },
                        new { ShowID = 15, ActID = 11 },
                        new { ShowID = 16, ActID = 12 },
                        new { ShowID = 16, ActID = 13 },
                        new { ShowID = 17, ActID = 14 }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("easy_tickets.DataModels.Show", b =>
                {
                    b.HasOne("easy_tickets.DataModels.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("easy_tickets.DataModels.ShowAct", b =>
                {
                    b.HasOne("easy_tickets.DataModels.Act", "Act")
                        .WithMany("ShowActs")
                        .HasForeignKey("ActID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("easy_tickets.DataModels.Show", "Show")
                        .WithMany("ShowActs")
                        .HasForeignKey("ShowID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}