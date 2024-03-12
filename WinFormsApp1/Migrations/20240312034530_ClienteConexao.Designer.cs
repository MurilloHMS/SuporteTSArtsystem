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
    [Migration("20240312034530_ClienteConexao")]
    partial class ClienteConexao
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

                    b.Property<string>("CONCDES")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CONCIPCON")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CONCTIP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClienteCLINID_CLI")
                        .HasColumnType("int");

                    b.HasKey("CONNID_CON");

                    b.HasIndex("ClienteCLINID_CLI");

                    b.ToTable("Conexoes");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Conexoes", b =>
                {
                    b.HasOne("WinFormsApp1.Models.Cliente", "Cliente")
                        .WithMany("Conexao")
                        .HasForeignKey("ClienteCLINID_CLI");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("WinFormsApp1.Models.Cliente", b =>
                {
                    b.Navigation("Conexao");
                });
#pragma warning restore 612, 618
        }
    }
}
