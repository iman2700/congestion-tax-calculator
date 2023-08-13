﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace congestion.calculator.Migrations
{
    [DbContext(typeof(TimeAmountDbContext))]
    [Migration("20230813085007_CreateTimeAmountTable")]
    partial class CreateTimeAmountTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("congestion.calculator.entity.FreeDate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("FreeDates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2013, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2013, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2013, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2013, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2013, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2013, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2013, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2013, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2013, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            Date = new DateTime(2013, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            Date = new DateTime(2013, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13,
                            Date = new DateTime(2013, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            Date = new DateTime(2013, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 15,
                            Date = new DateTime(2013, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 16,
                            Date = new DateTime(2013, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("congestion.calculator.entity.TimeAmount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("TimeAmounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 8,
                            Currency = "SEK",
                            EndTime = new TimeSpan(0, 6, 29, 0, 0),
                            StartTime = new TimeSpan(0, 6, 0, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            Amount = 13,
                            Currency = "SEK",
                            EndTime = new TimeSpan(0, 6, 59, 0, 0),
                            StartTime = new TimeSpan(0, 6, 30, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            Amount = 18,
                            Currency = "SEK",
                            EndTime = new TimeSpan(0, 7, 59, 0, 0),
                            StartTime = new TimeSpan(0, 7, 0, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            Amount = 13,
                            Currency = "SEK",
                            EndTime = new TimeSpan(0, 8, 29, 0, 0),
                            StartTime = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            Amount = 8,
                            Currency = "SEK",
                            EndTime = new TimeSpan(0, 14, 59, 0, 0),
                            StartTime = new TimeSpan(0, 8, 30, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            Amount = 13,
                            Currency = "SEK",
                            EndTime = new TimeSpan(0, 15, 29, 0, 0),
                            StartTime = new TimeSpan(0, 15, 0, 0, 0)
                        },
                        new
                        {
                            Id = 7,
                            Amount = 18,
                            Currency = "SEK",
                            EndTime = new TimeSpan(0, 16, 59, 0, 0),
                            StartTime = new TimeSpan(0, 15, 30, 0, 0)
                        },
                        new
                        {
                            Id = 8,
                            Amount = 13,
                            Currency = "SEK",
                            EndTime = new TimeSpan(0, 17, 59, 0, 0),
                            StartTime = new TimeSpan(0, 17, 0, 0, 0)
                        },
                        new
                        {
                            Id = 9,
                            Amount = 8,
                            Currency = "SEK",
                            EndTime = new TimeSpan(0, 18, 29, 0, 0),
                            StartTime = new TimeSpan(0, 18, 0, 0, 0)
                        },
                        new
                        {
                            Id = 10,
                            Amount = 0,
                            Currency = "SEK",
                            EndTime = new TimeSpan(0, 23, 59, 0, 0),
                            StartTime = new TimeSpan(0, 18, 30, 0, 0)
                        },
                        new
                        {
                            Id = 11,
                            Amount = 0,
                            Currency = "SEK",
                            EndTime = new TimeSpan(0, 5, 59, 0, 0),
                            StartTime = new TimeSpan(0, 0, 0, 0, 0)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
