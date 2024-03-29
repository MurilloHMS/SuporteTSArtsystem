﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuporteArtSystem.Databases;

#nullable disable

namespace SuporteArtSystem.Migrations
{
    [DbContext(typeof(SuporteContext))]
    partial class SuporteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WinFormsApp1.Models.ASENTENT", b =>
                {
                    b.Property<int>("ENTNID_ENT")
                        .HasColumnType("int");

                    b.Property<int>("ENTNID_CEP")
                        .HasColumnType("int");

                    b.Property<string>("ENTCAPELID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENTCCODCPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENTCCOD_RG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENTCENDCOM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENTCE_MAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENTCNOMENT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENTCTIPPES")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("ENTCUSUALT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENTCUSUCAD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ENTDDATALT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ENTDDATCAD")
                        .HasColumnType("datetime2");

                    b.Property<int>("ENTNENDNUM")
                        .HasColumnType("int");

                    b.HasKey("ENTNID_ENT", "ENTNID_CEP");

                    b.ToTable("ASENTENT");
                });

            modelBuilder.Entity("WinFormsApp1.Models.ASENTENT_CON", b =>
                {
                    b.Property<int>("CONNID_CON")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CONNID_CON"));

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

                    b.ToTable("ASENTENT_CON");
                });
#pragma warning restore 612, 618
        }
    }
}
