﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect_Bota_Rodica.Data;

#nullable disable

namespace Proiect_Bota_Rodica.Migrations
{
    [DbContext(typeof(Proiect_Bota_RodicaContext))]
    [Migration("20240106164909_Produs")]
    partial class Produs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Proiect_Bota_Rodica.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("ClientID")
                        .HasColumnType("int");

                    b.Property<int>("NumarComanda")
                        .HasColumnType("int");

                    b.Property<string>("NumeClient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Proiect_Bota_Rodica.Models.Produs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCreare")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descriere")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.ToTable("Produs");
                });

            modelBuilder.Entity("Proiect_Bota_Rodica.Models.Client", b =>
                {
                    b.HasOne("Proiect_Bota_Rodica.Models.Client", null)
                        .WithMany("Clienti")
                        .HasForeignKey("ClientID");
                });

            modelBuilder.Entity("Proiect_Bota_Rodica.Models.Produs", b =>
                {
                    b.HasOne("Proiect_Bota_Rodica.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Proiect_Bota_Rodica.Models.Client", b =>
                {
                    b.Navigation("Clienti");
                });
#pragma warning restore 612, 618
        }
    }
}
