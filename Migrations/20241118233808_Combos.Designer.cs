﻿// <auto-generated />
using System;
using EddyCapellan_AP1_P2.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EddyCapellan_AP1_P2.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20241118233808_Combos")]
    partial class Combos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EddyCapellan_AP1_P2.Models.Articulos", b =>
                {
                    b.Property<int>("ArticuloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArticuloId"));

                    b.Property<decimal?>("Costo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Ganancia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ArticuloId");

                    b.ToTable("Articulos");

                    b.HasData(
                        new
                        {
                            ArticuloId = 1,
                            Descripcion = "Monitor"
                        },
                        new
                        {
                            ArticuloId = 2,
                            Descripcion = "Laptop"
                        },
                        new
                        {
                            ArticuloId = 3,
                            Descripcion = "Computadora"
                        });
                });

            modelBuilder.Entity("EddyCapellan_AP1_P2.Models.Combos", b =>
                {
                    b.Property<int>("ComboId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComboId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Precio")
                        .HasColumnType("int");

                    b.Property<bool>("Vendido")
                        .HasColumnType("bit");

                    b.HasKey("ComboId");

                    b.ToTable("Combos");
                });
#pragma warning restore 612, 618
        }
    }
}
