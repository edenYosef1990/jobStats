﻿// <auto-generated />
using System;
using JobsStats.API.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobsStats.API.Migrations
{
    [DbContext(typeof(JobStatsDbContext))]
    [Migration("20221005200508_changed_job_identification")]
    partial class changed_job_identification
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JobsStats.API.DB.Models.JobWatchesPerDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfWatches")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JobWatchesPerDays");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2022, 10, 5, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4468),
                            JobId = 0,
                            NumberOfWatches = 58
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2022, 10, 5, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4501),
                            JobId = 1,
                            NumberOfWatches = 46
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2022, 10, 5, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4504),
                            JobId = 2,
                            NumberOfWatches = 22
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2022, 10, 5, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4506),
                            JobId = 3,
                            NumberOfWatches = 58
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2022, 10, 6, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4551),
                            JobId = 0,
                            NumberOfWatches = 35
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2022, 10, 7, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4555),
                            JobId = 0,
                            NumberOfWatches = 29
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2022, 10, 8, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4557),
                            JobId = 0,
                            NumberOfWatches = 46
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2022, 10, 8, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4559),
                            JobId = 1,
                            NumberOfWatches = 35
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2022, 10, 9, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4561),
                            JobId = 0,
                            NumberOfWatches = 53
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2022, 10, 9, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4564),
                            JobId = 1,
                            NumberOfWatches = 69
                        },
                        new
                        {
                            Id = 11,
                            Date = new DateTime(2022, 10, 9, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4566),
                            JobId = 2,
                            NumberOfWatches = 46
                        },
                        new
                        {
                            Id = 12,
                            Date = new DateTime(2022, 10, 10, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4567),
                            JobId = 0,
                            NumberOfWatches = 21
                        },
                        new
                        {
                            Id = 13,
                            Date = new DateTime(2022, 10, 10, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4569),
                            JobId = 1,
                            NumberOfWatches = 1
                        },
                        new
                        {
                            Id = 14,
                            Date = new DateTime(2022, 10, 10, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4570),
                            JobId = 2,
                            NumberOfWatches = 13
                        },
                        new
                        {
                            Id = 15,
                            Date = new DateTime(2022, 10, 10, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4572),
                            JobId = 3,
                            NumberOfWatches = 16
                        },
                        new
                        {
                            Id = 16,
                            Date = new DateTime(2022, 10, 10, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4574),
                            JobId = 4,
                            NumberOfWatches = 24
                        },
                        new
                        {
                            Id = 17,
                            Date = new DateTime(2022, 10, 10, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4576),
                            JobId = 5,
                            NumberOfWatches = 67
                        },
                        new
                        {
                            Id = 18,
                            Date = new DateTime(2022, 10, 10, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4578),
                            JobId = 6,
                            NumberOfWatches = 49
                        },
                        new
                        {
                            Id = 19,
                            Date = new DateTime(2022, 10, 11, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4580),
                            JobId = 0,
                            NumberOfWatches = 54
                        },
                        new
                        {
                            Id = 20,
                            Date = new DateTime(2022, 10, 12, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4582),
                            JobId = 0,
                            NumberOfWatches = 17
                        },
                        new
                        {
                            Id = 21,
                            Date = new DateTime(2022, 10, 12, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4584),
                            JobId = 1,
                            NumberOfWatches = 19
                        },
                        new
                        {
                            Id = 22,
                            Date = new DateTime(2022, 10, 12, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4585),
                            JobId = 2,
                            NumberOfWatches = 40
                        },
                        new
                        {
                            Id = 23,
                            Date = new DateTime(2022, 10, 12, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4587),
                            JobId = 3,
                            NumberOfWatches = 3
                        },
                        new
                        {
                            Id = 24,
                            Date = new DateTime(2022, 10, 13, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4589),
                            JobId = 0,
                            NumberOfWatches = 3
                        },
                        new
                        {
                            Id = 25,
                            Date = new DateTime(2022, 10, 13, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4590),
                            JobId = 1,
                            NumberOfWatches = 50
                        },
                        new
                        {
                            Id = 26,
                            Date = new DateTime(2022, 10, 14, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4592),
                            JobId = 0,
                            NumberOfWatches = 15
                        },
                        new
                        {
                            Id = 27,
                            Date = new DateTime(2022, 10, 14, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4594),
                            JobId = 1,
                            NumberOfWatches = 9
                        },
                        new
                        {
                            Id = 28,
                            Date = new DateTime(2022, 10, 14, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4596),
                            JobId = 2,
                            NumberOfWatches = 9
                        },
                        new
                        {
                            Id = 29,
                            Date = new DateTime(2022, 10, 14, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4597),
                            JobId = 3,
                            NumberOfWatches = 7
                        },
                        new
                        {
                            Id = 30,
                            Date = new DateTime(2022, 10, 14, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4599),
                            JobId = 4,
                            NumberOfWatches = 63
                        },
                        new
                        {
                            Id = 31,
                            Date = new DateTime(2022, 10, 14, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4600),
                            JobId = 5,
                            NumberOfWatches = 47
                        },
                        new
                        {
                            Id = 32,
                            Date = new DateTime(2022, 10, 15, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4602),
                            JobId = 0,
                            NumberOfWatches = 12
                        },
                        new
                        {
                            Id = 33,
                            Date = new DateTime(2022, 10, 16, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4605),
                            JobId = 0,
                            NumberOfWatches = 10
                        },
                        new
                        {
                            Id = 34,
                            Date = new DateTime(2022, 10, 16, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4607),
                            JobId = 1,
                            NumberOfWatches = 51
                        },
                        new
                        {
                            Id = 35,
                            Date = new DateTime(2022, 10, 16, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4609),
                            JobId = 2,
                            NumberOfWatches = 24
                        },
                        new
                        {
                            Id = 36,
                            Date = new DateTime(2022, 10, 17, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4611),
                            JobId = 0,
                            NumberOfWatches = 67
                        },
                        new
                        {
                            Id = 37,
                            Date = new DateTime(2022, 10, 17, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4613),
                            JobId = 1,
                            NumberOfWatches = 3
                        },
                        new
                        {
                            Id = 38,
                            Date = new DateTime(2022, 10, 17, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4614),
                            JobId = 2,
                            NumberOfWatches = 9
                        },
                        new
                        {
                            Id = 39,
                            Date = new DateTime(2022, 10, 17, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4616),
                            JobId = 3,
                            NumberOfWatches = 22
                        },
                        new
                        {
                            Id = 40,
                            Date = new DateTime(2022, 10, 17, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4618),
                            JobId = 4,
                            NumberOfWatches = 35
                        },
                        new
                        {
                            Id = 41,
                            Date = new DateTime(2022, 10, 18, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4620),
                            JobId = 0,
                            NumberOfWatches = 48
                        },
                        new
                        {
                            Id = 42,
                            Date = new DateTime(2022, 10, 18, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4621),
                            JobId = 1,
                            NumberOfWatches = 8
                        },
                        new
                        {
                            Id = 43,
                            Date = new DateTime(2022, 10, 18, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4623),
                            JobId = 2,
                            NumberOfWatches = 1
                        },
                        new
                        {
                            Id = 44,
                            Date = new DateTime(2022, 10, 19, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4625),
                            JobId = 0,
                            NumberOfWatches = 69
                        },
                        new
                        {
                            Id = 45,
                            Date = new DateTime(2022, 10, 19, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4626),
                            JobId = 1,
                            NumberOfWatches = 65
                        },
                        new
                        {
                            Id = 46,
                            Date = new DateTime(2022, 10, 19, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4628),
                            JobId = 2,
                            NumberOfWatches = 47
                        },
                        new
                        {
                            Id = 47,
                            Date = new DateTime(2022, 10, 19, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4629),
                            JobId = 3,
                            NumberOfWatches = 65
                        },
                        new
                        {
                            Id = 48,
                            Date = new DateTime(2022, 10, 19, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4631),
                            JobId = 4,
                            NumberOfWatches = 38
                        },
                        new
                        {
                            Id = 49,
                            Date = new DateTime(2022, 10, 20, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4633),
                            JobId = 0,
                            NumberOfWatches = 39
                        },
                        new
                        {
                            Id = 50,
                            Date = new DateTime(2022, 10, 20, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4635),
                            JobId = 1,
                            NumberOfWatches = 35
                        },
                        new
                        {
                            Id = 51,
                            Date = new DateTime(2022, 10, 20, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4636),
                            JobId = 2,
                            NumberOfWatches = 9
                        },
                        new
                        {
                            Id = 52,
                            Date = new DateTime(2022, 10, 20, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4638),
                            JobId = 3,
                            NumberOfWatches = 54
                        },
                        new
                        {
                            Id = 53,
                            Date = new DateTime(2022, 10, 21, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4640),
                            JobId = 0,
                            NumberOfWatches = 65
                        },
                        new
                        {
                            Id = 54,
                            Date = new DateTime(2022, 10, 21, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4642),
                            JobId = 1,
                            NumberOfWatches = 40
                        },
                        new
                        {
                            Id = 55,
                            Date = new DateTime(2022, 10, 21, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4643),
                            JobId = 2,
                            NumberOfWatches = 46
                        },
                        new
                        {
                            Id = 56,
                            Date = new DateTime(2022, 10, 21, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4645),
                            JobId = 3,
                            NumberOfWatches = 10
                        },
                        new
                        {
                            Id = 57,
                            Date = new DateTime(2022, 10, 23, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4647),
                            JobId = 0,
                            NumberOfWatches = 61
                        },
                        new
                        {
                            Id = 58,
                            Date = new DateTime(2022, 10, 23, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4649),
                            JobId = 1,
                            NumberOfWatches = 56
                        },
                        new
                        {
                            Id = 59,
                            Date = new DateTime(2022, 10, 23, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4650),
                            JobId = 2,
                            NumberOfWatches = 4
                        },
                        new
                        {
                            Id = 60,
                            Date = new DateTime(2022, 10, 24, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4652),
                            JobId = 0,
                            NumberOfWatches = 51
                        },
                        new
                        {
                            Id = 61,
                            Date = new DateTime(2022, 10, 25, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4654),
                            JobId = 0,
                            NumberOfWatches = 35
                        },
                        new
                        {
                            Id = 62,
                            Date = new DateTime(2022, 10, 25, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4656),
                            JobId = 1,
                            NumberOfWatches = 30
                        },
                        new
                        {
                            Id = 63,
                            Date = new DateTime(2022, 10, 25, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4657),
                            JobId = 2,
                            NumberOfWatches = 60
                        },
                        new
                        {
                            Id = 64,
                            Date = new DateTime(2022, 10, 26, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4659),
                            JobId = 0,
                            NumberOfWatches = 43
                        },
                        new
                        {
                            Id = 65,
                            Date = new DateTime(2022, 10, 27, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4661),
                            JobId = 0,
                            NumberOfWatches = 46
                        },
                        new
                        {
                            Id = 66,
                            Date = new DateTime(2022, 10, 29, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4664),
                            JobId = 0,
                            NumberOfWatches = 36
                        },
                        new
                        {
                            Id = 67,
                            Date = new DateTime(2022, 10, 30, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4665),
                            JobId = 0,
                            NumberOfWatches = 66
                        },
                        new
                        {
                            Id = 68,
                            Date = new DateTime(2022, 10, 31, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4667),
                            JobId = 0,
                            NumberOfWatches = 11
                        },
                        new
                        {
                            Id = 69,
                            Date = new DateTime(2022, 10, 31, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4669),
                            JobId = 1,
                            NumberOfWatches = 62
                        },
                        new
                        {
                            Id = 70,
                            Date = new DateTime(2022, 10, 31, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4671),
                            JobId = 2,
                            NumberOfWatches = 65
                        },
                        new
                        {
                            Id = 71,
                            Date = new DateTime(2022, 10, 31, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4672),
                            JobId = 3,
                            NumberOfWatches = 27
                        },
                        new
                        {
                            Id = 72,
                            Date = new DateTime(2022, 11, 1, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4674),
                            JobId = 0,
                            NumberOfWatches = 4
                        },
                        new
                        {
                            Id = 73,
                            Date = new DateTime(2022, 11, 2, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4676),
                            JobId = 0,
                            NumberOfWatches = 24
                        },
                        new
                        {
                            Id = 74,
                            Date = new DateTime(2022, 11, 2, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4677),
                            JobId = 1,
                            NumberOfWatches = 69
                        },
                        new
                        {
                            Id = 75,
                            Date = new DateTime(2022, 11, 3, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4679),
                            JobId = 0,
                            NumberOfWatches = 43
                        },
                        new
                        {
                            Id = 76,
                            Date = new DateTime(2022, 11, 3, 23, 5, 8, 242, DateTimeKind.Local).AddTicks(4680),
                            JobId = 1,
                            NumberOfWatches = 35
                        });
                });
#pragma warning restore 612, 618
        }
    }
}