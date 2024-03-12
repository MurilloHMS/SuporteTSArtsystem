﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsApp1.Databases;

#nullable disable

namespace WinFormsApp1.Migrations
{
    [DbContext(typeof(SuporteContext))]
    [Migration("20240312195150_AlterarIdCliente")]
    partial class AlterarIdCliente
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WinFormsApp1.Models.Cliente", b =>
                {
                    b.Property<int>("CLINID_CLI")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CLINID_CLI"));

                    b.Property<string>("CLICAPE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CLICCNPJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CLICDES")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CLICRZS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CLINID_CLI");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Conexoes", b =>
                {
                    b.Property<int>("CONNID_CON")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CONNID_CON"));

                    b.Property<int?>("CONCCLICLINID_CLI")
                        .HasColumnType("int");

                    b.Property<string>("CONCDESC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CONCIPCON")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CONCSENART")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CONCSENTS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CONCTIP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CONCTIPCO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CONCUSRART")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CONCUSRTS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CONNIDCLI")
                        .HasColumnType("int");

                    b.HasKey("CONNID_CON");

                    b.HasIndex("CONCCLICLINID_CLI");

                    b.ToTable("Conexoes");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Conexoes", b =>
                {
                    b.HasOne("WinFormsApp1.Models.Cliente", "CONCCLI")
                        .WithMany("Conexao")
                        .HasForeignKey("CONCCLICLINID_CLI");

                    b.Navigation("CONCCLI");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Cliente", b =>
                {
                    b.Navigation("Conexao");
                });
#pragma warning restore 612, 618
        }
    }
}
