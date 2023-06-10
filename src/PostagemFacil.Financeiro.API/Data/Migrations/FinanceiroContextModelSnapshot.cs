﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PostagemFacil.Financeiro.API.Data;

#nullable disable

namespace PostagemFacil.Financeiro.API.Data.Migrations
{
    [DbContext(typeof(FinanceiroContext))]
    partial class FinanceiroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PostagemFacil.Financeiro.API.Data.Models.PesoLimite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("CustoPostal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PesosLimite");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustoPostal = 0.5m,
                            Descricao = "Até 3kg"
                        },
                        new
                        {
                            Id = 2,
                            CustoPostal = 1m,
                            Descricao = "Entre 3kg e 5kg"
                        },
                        new
                        {
                            Id = 3,
                            CustoPostal = 2m,
                            Descricao = "Entre 5kg e 10kg"
                        });
                });

            modelBuilder.Entity("PostagemFacil.Financeiro.API.Data.Models.TipoCaixa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("CustoPostal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposCaixa");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustoPostal = 1.5m,
                            Descricao = "20cm x 20cm x 20cm"
                        },
                        new
                        {
                            Id = 2,
                            CustoPostal = 2m,
                            Descricao = "40cm x 40cm x 40cm"
                        },
                        new
                        {
                            Id = 3,
                            CustoPostal = 2.5m,
                            Descricao = "60cm x 60cm x 60cm"
                        });
                });

            modelBuilder.Entity("PostagemFacil.Financeiro.API.Data.Models.Transportadora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("FatorPostal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Transportadoras");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FatorPostal = 1m,
                            Nome = "Correios"
                        },
                        new
                        {
                            Id = 2,
                            FatorPostal = 0.95m,
                            Nome = "JadLog"
                        },
                        new
                        {
                            Id = 3,
                            FatorPostal = 1.7m,
                            Nome = "DHL"
                        },
                        new
                        {
                            Id = 4,
                            FatorPostal = 1.5m,
                            Nome = "Fedex"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
