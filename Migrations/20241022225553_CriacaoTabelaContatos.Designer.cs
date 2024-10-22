﻿// <auto-generated />
using System;
using API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(AgendaContext))]
    [Migration("20241022225553_CriacaoTabelaContatos")]
    partial class CriacaoTabelaContatos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Entities.Cidade", b =>
                {
                    b.Property<int>("IdCidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCidade"));

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCidade")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCidade");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("API.Entities.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("API.Entities.Espaco", b =>
                {
                    b.Property<int>("IdEspaco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEspaco"));

                    b.Property<int?>("CidadeIdCidade")
                        .HasColumnType("int");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeEspaco")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEspaco");

                    b.HasIndex("CidadeIdCidade");

                    b.ToTable("Espacos");
                });

            modelBuilder.Entity("API.Entities.Proprietario", b =>
                {
                    b.Property<int>("IdProprietario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProprietario"));

                    b.Property<string>("CpfProprietario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailProprietario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnderecoProprietario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NascimentoProprietario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeProprietario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefoneProprietario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProprietario");

                    b.ToTable("Proprietarios");
                });

            modelBuilder.Entity("API.Entities.Reserva", b =>
                {
                    b.Property<int>("IdReserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReserva"));

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("QuantidadeHospede")
                        .HasColumnType("int");

                    b.HasKey("IdReserva");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("API.Entities.Espaco", b =>
                {
                    b.HasOne("API.Entities.Cidade", "Cidade")
                        .WithMany("Espacos")
                        .HasForeignKey("CidadeIdCidade");

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("API.Entities.Cidade", b =>
                {
                    b.Navigation("Espacos");
                });
#pragma warning restore 612, 618
        }
    }
}
