﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProduceJam.Data;

#nullable disable

namespace ProduceJam.Migrations
{
    [DbContext(typeof(ProduceJamContext))]
    [Migration("20250316130925_changes")]
    partial class changes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProduceJam.Models.LastWeek", b =>
                {
                    b.Property<string>("Commodity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CorronationCommonPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CrossRoadsCommonPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PapineCommonPrice")
                        .HasColumnType("decimal(18,2)");

                    b.ToTable("StoredWeek1");
                });

            modelBuilder.Entity("ProduceJam.Models.ShoppingListObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Commodity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ShoppingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ShoppingListObject");
                });
#pragma warning restore 612, 618
        }
    }
}
