﻿// <auto-generated />
using LEKSupply.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LEKSupply.Migrations
{
    [DbContext(typeof(LEKSupplyDbContext))]
    [Migration("20230727212927_refactor-tables")]
    partial class refactortables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LEKSupply.Models.Entrada", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("Data")
                        .HasColumnType("longtext")
                        .HasColumnName("Data");

                    b.Property<string>("IdMercadoria")
                        .HasColumnType("longtext")
                        .HasColumnName("IdMercadoria");

                    b.Property<string>("Local")
                        .HasColumnType("longtext")
                        .HasColumnName("Local");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext")
                        .HasColumnName("Nome");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("Quantidade");

                    b.HasKey("Id");

                    b.ToTable("Entrada");
                });

            modelBuilder.Entity("LEKSupply.Models.Mercadoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Descricao");

                    b.Property<string>("Fabricante")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Fabricante");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Nome");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Mercadoria");
                });

            modelBuilder.Entity("LEKSupply.Models.Saida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("Data")
                        .HasColumnType("longtext")
                        .HasColumnName("Data");

                    b.Property<string>("IdMercadoria")
                        .HasColumnType("longtext")
                        .HasColumnName("IdMercadoria");

                    b.Property<string>("Local")
                        .HasColumnType("longtext")
                        .HasColumnName("Local");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext")
                        .HasColumnName("Nome");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("Quantidade");

                    b.HasKey("Id");

                    b.ToTable("Saida");
                });
#pragma warning restore 612, 618
        }
    }
}
