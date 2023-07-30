﻿// <auto-generated />
using System;
using LEKSupply.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LEKSupply.Migrations
{
    [DbContext(typeof(LEKSupplyDbContext))]
    [Migration("20230730051106_add-novas-mercadorias-test")]
    partial class addnovasmercadoriastest
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

                    b.Property<int>("IdMercadoria")
                        .HasColumnType("int")
                        .HasColumnName("IdMercadoria");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Local");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext")
                        .HasColumnName("Nome");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("Quantidade");

                    b.Property<string>("Status")
                        .HasColumnType("longtext")
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("Entrada");
                });

            modelBuilder.Entity("LEKSupply.Models.Mercadoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("Codigo")
                        .HasColumnType("longtext")
                        .HasColumnName("Codigo");

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

                    b.Property<string>("Status")
                        .HasColumnType("longtext")
                        .HasColumnName("Status");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Tipo");

                    b.HasKey("Id");

                    b.ToTable("Mercadoria");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Codigo = "c38d0c3e-bc5a-4aa9-b5d2-5bf6e5988ae5",
                            Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ",
                            Fabricante = "Dell",
                            Nome = "Mouse",
                            Status = "A",
                            Tipo = "Eletrônicos"
                        },
                        new
                        {
                            Id = 2,
                            Codigo = "1ee6eef9-4f3f-4219-ac5b-78f3e083448f",
                            Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ",
                            Fabricante = "Dell",
                            Nome = "Teclado",
                            Status = "A",
                            Tipo = "Eletrônicos"
                        },
                        new
                        {
                            Id = 3,
                            Codigo = "bb0b9445-8a81-4d4e-bf84-58c73df4cac4",
                            Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ",
                            Fabricante = "Dell",
                            Nome = "Fone de ouvido",
                            Status = "A",
                            Tipo = "Eletrônicos"
                        },
                        new
                        {
                            Id = 4,
                            Codigo = "95fe3e3d-8ef4-4aa3-a897-7154ee77be44",
                            Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ",
                            Fabricante = "Leader",
                            Nome = "Camiseta",
                            Status = "A",
                            Tipo = "Roupas"
                        },
                        new
                        {
                            Id = 5,
                            Codigo = "0bb0de1b-a2da-4302-9b91-de9a2d9ab327",
                            Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ",
                            Fabricante = "Leader",
                            Nome = "Bermuda",
                            Status = "A",
                            Tipo = "Roupas"
                        },
                        new
                        {
                            Id = 6,
                            Codigo = "61fc0000-626d-4a00-8b5c-bca4b7d4fca7",
                            Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ",
                            Fabricante = "Leader",
                            Nome = "Blusa",
                            Status = "A",
                            Tipo = "Roupas"
                        },
                        new
                        {
                            Id = 7,
                            Codigo = "16803e47-f2d8-453e-b4cf-9ee699f2a22e",
                            Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ",
                            Fabricante = "Hasbro",
                            Nome = "Carrinho de corrrida",
                            Status = "A",
                            Tipo = "Brinquedos"
                        },
                        new
                        {
                            Id = 8,
                            Codigo = "f788f813-511f-40bf-b239-5464d88f52b0",
                            Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ",
                            Fabricante = "Hasbro",
                            Nome = "Boneco de ação",
                            Status = "A",
                            Tipo = "Brinquedos"
                        },
                        new
                        {
                            Id = 9,
                            Codigo = "5fd95085-f329-452b-a8a8-15d80f74ea35",
                            Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ",
                            Fabricante = "Hasbro",
                            Nome = "Casinha de brinquedo",
                            Status = "A",
                            Tipo = "Brinquedos"
                        },
                        new
                        {
                            Id = 10,
                            Codigo = "b0ccf2b8-02eb-45d0-aef7-5b8ccfc23a56",
                            Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ",
                            Fabricante = "Lays",
                            Nome = "Batatatinhas",
                            Status = "A",
                            Tipo = "Alimentos"
                        },
                        new
                        {
                            Id = 11,
                            Codigo = "8924d0c4-5b58-4abe-80b9-168393e59523",
                            Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ",
                            Fabricante = "Nestle",
                            Nome = "kit kat",
                            Status = "A",
                            Tipo = "Alimentos"
                        },
                        new
                        {
                            Id = 12,
                            Codigo = "0530dc7b-e4dd-4d7b-bcf8-749e912b0fa1",
                            Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ",
                            Fabricante = "Lacta",
                            Nome = "Sonho de Valsa",
                            Status = "A",
                            Tipo = "Alimentos"
                        },
                        new
                        {
                            Id = 13,
                            Codigo = "29c7ed42-31b2-4d4e-b001-d99da52e59a9",
                            Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ",
                            Fabricante = "Philips",
                            Nome = "Lampada",
                            Status = "A",
                            Tipo = "Materiais de construção"
                        },
                        new
                        {
                            Id = 14,
                            Codigo = "11358381-7154-4743-89f4-21428fc15572",
                            Descricao = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam tincidunt ultricies congue. ",
                            Fabricante = "Pial",
                            Nome = "Tomada",
                            Status = "A",
                            Tipo = "Materiais de construção"
                        });
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

                    b.Property<int>("IdEntrada")
                        .HasColumnType("int")
                        .HasColumnName("IdEntrada");

                    b.Property<int?>("IdMercadoria")
                        .HasColumnType("int")
                        .HasColumnName("IdMercadoria");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Local");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext")
                        .HasColumnName("Nome");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("Quantidade");

                    b.Property<string>("Status")
                        .HasColumnType("longtext")
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("Saida");
                });
#pragma warning restore 612, 618
        }
    }
}
