﻿// <auto-generated />
using System;
using EntityFramework.Models.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFramework.Migrations
{
    [DbContext(typeof(EntityFrameworkContext))]
    [Migration("20240131204725_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityFramework.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<double>("CurrentAttendance")
                        .HasColumnType("float");

                    b.Property<DateTime>("EventDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PerformingActId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductionCompanyId")
                        .HasColumnType("int");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("VenueId")
                        .HasColumnType("int");

                    b.HasKey("EventId");

                    b.HasIndex("PerformingActId");

                    b.HasIndex("ProductionCompanyId");

                    b.HasIndex("VenueId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("EntityFramework.Models.PerformingAct", b =>
                {
                    b.Property<int>("PerformingActId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PerformingActId"));

                    b.Property<double>("AverageAttendance")
                        .HasColumnType("float");

                    b.Property<int>("Manager")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfPerformers")
                        .HasColumnType("int");

                    b.Property<string>("PerformerType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PerformingActId");

                    b.ToTable("PerformingActs");
                });

            modelBuilder.Entity("EntityFramework.Models.ProductionCompany", b =>
                {
                    b.Property<int>("ProductionCompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductionCompanyId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffSize")
                        .HasColumnType("int");

                    b.HasKey("ProductionCompanyId");

                    b.ToTable("ProductionCompany");
                });

            modelBuilder.Entity("EntityFramework.Models.Venue", b =>
                {
                    b.Property<int>("VenueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VenueId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VenueId");

                    b.ToTable("Venue");
                });

            modelBuilder.Entity("EntityFramework.Models.Event", b =>
                {
                    b.HasOne("EntityFramework.Models.PerformingAct", "PerformingAct")
                        .WithMany("Events")
                        .HasForeignKey("PerformingActId");

                    b.HasOne("EntityFramework.Models.ProductionCompany", "ProductionCompany")
                        .WithMany("Events")
                        .HasForeignKey("ProductionCompanyId");

                    b.HasOne("EntityFramework.Models.Venue", "Venue")
                        .WithMany("Events")
                        .HasForeignKey("VenueId");

                    b.Navigation("PerformingAct");

                    b.Navigation("ProductionCompany");

                    b.Navigation("Venue");
                });

            modelBuilder.Entity("EntityFramework.Models.PerformingAct", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("EntityFramework.Models.ProductionCompany", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("EntityFramework.Models.Venue", b =>
                {
                    b.Navigation("Events");
                });
#pragma warning restore 612, 618
        }
    }
}