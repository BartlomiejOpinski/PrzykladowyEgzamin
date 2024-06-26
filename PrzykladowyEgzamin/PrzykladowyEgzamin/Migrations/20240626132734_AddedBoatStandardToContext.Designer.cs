﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrzykladowyEgzamin.Context;

#nullable disable

namespace PrzykladowyEgzamin.Migrations
{
    [DbContext(typeof(BoatsContext))]
    [Migration("20240626132734_AddedBoatStandardToContext")]
    partial class AddedBoatStandardToContext
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClientReservation", b =>
                {
                    b.Property<int>("ClientsIdClient")
                        .HasColumnType("int");

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.HasKey("ClientsIdClient", "IdClient");

                    b.HasIndex("IdClient");

                    b.ToTable("ClientReservation");
                });

            modelBuilder.Entity("PrzykladowyEgzamin.Models.BoatStandard", b =>
                {
                    b.Property<int>("IdBoatStandard")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdBoatStandard"));

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdBoatStandard");

                    b.ToTable("BoatStandards");
                });

            modelBuilder.Entity("PrzykladowyEgzamin.Models.Client", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdClient"));

                    b.Property<DateOnly>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("IdClientCategory")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Pesel")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdClient");

                    b.HasIndex("IdClientCategory");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("PrzykladowyEgzamin.Models.ClientCategory", b =>
                {
                    b.Property<int>("IdClientCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdClientCategory"));

                    b.Property<int>("DiscountPerc")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdClientCategory");

                    b.ToTable("ClientCategories");
                });

            modelBuilder.Entity("PrzykladowyEgzamin.Models.Reservation", b =>
                {
                    b.Property<int>("IdReservation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReservation"));

                    b.Property<string>("CancelReason")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<bool>("Fulfilled")
                        .HasColumnType("bit");

                    b.Property<int>("IdBoatStandard")
                        .HasColumnType("int");

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int>("NumOfBoats")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int?>("SailboatIdSailboat")
                        .HasColumnType("int");

                    b.HasKey("IdReservation");

                    b.HasIndex("IdBoatStandard");

                    b.HasIndex("SailboatIdSailboat");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("PrzykladowyEgzamin.Models.Sailboat", b =>
                {
                    b.Property<int>("IdSailboat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSailboat"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("IdBoatStandard")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("IdSailboat");

                    b.HasIndex("IdBoatStandard");

                    b.ToTable("Sailboats");
                });

            modelBuilder.Entity("ClientReservation", b =>
                {
                    b.HasOne("PrzykladowyEgzamin.Models.Client", null)
                        .WithMany()
                        .HasForeignKey("ClientsIdClient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrzykladowyEgzamin.Models.Reservation", null)
                        .WithMany()
                        .HasForeignKey("IdClient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PrzykladowyEgzamin.Models.Client", b =>
                {
                    b.HasOne("PrzykladowyEgzamin.Models.ClientCategory", "ClientCategory")
                        .WithMany()
                        .HasForeignKey("IdClientCategory")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClientCategory");
                });

            modelBuilder.Entity("PrzykladowyEgzamin.Models.Reservation", b =>
                {
                    b.HasOne("PrzykladowyEgzamin.Models.BoatStandard", "BoatStandard")
                        .WithMany()
                        .HasForeignKey("IdBoatStandard")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrzykladowyEgzamin.Models.Sailboat", null)
                        .WithMany("Reservations")
                        .HasForeignKey("SailboatIdSailboat");

                    b.Navigation("BoatStandard");
                });

            modelBuilder.Entity("PrzykladowyEgzamin.Models.Sailboat", b =>
                {
                    b.HasOne("PrzykladowyEgzamin.Models.BoatStandard", "BoatStandard")
                        .WithMany()
                        .HasForeignKey("IdBoatStandard")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoatStandard");
                });

            modelBuilder.Entity("PrzykladowyEgzamin.Models.Sailboat", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
