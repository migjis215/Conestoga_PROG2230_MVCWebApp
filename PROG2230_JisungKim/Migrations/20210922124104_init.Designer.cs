﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PROG2230_JisungKim.Models;

namespace PROG2230_JisungKim.Migrations
{
    [DbContext(typeof(TransactionRecordContext))]
    [Migration("20210922124104_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PROG2230_JisungKim.Models.TransactionRecord", b =>
                {
                    b.Property<int>("TransactionRecordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Quantity")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<double?>("SharePrice")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<string>("TickerSymbol")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransactionRecordId");

                    b.ToTable("TransactionRecords");

                    b.HasData(
                        new
                        {
                            TransactionRecordId = 1,
                            CompanyName = "Microsoft",
                            Quantity = 100,
                            SharePrice = 123.45,
                            TickerSymbol = "MSFT"
                        },
                        new
                        {
                            TransactionRecordId = 2,
                            CompanyName = "Google",
                            Quantity = 100,
                            SharePrice = 2701.7600000000002,
                            TickerSymbol = "GOOG"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
