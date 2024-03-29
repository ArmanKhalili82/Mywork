﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models.Data;

#nullable disable

namespace Models.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Tehran"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            Name = "Shiraz"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 1,
                            Name = "Tabriz"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 2,
                            Name = "Paris"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 2,
                            Name = "Lyon"
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 3,
                            Name = "NewYork"
                        },
                        new
                        {
                            Id = 7,
                            CountryId = 3,
                            Name = "Washington DC"
                        });
                });

            modelBuilder.Entity("Models.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Iran"
                        },
                        new
                        {
                            Id = 2,
                            Name = "France"
                        },
                        new
                        {
                            Id = 3,
                            Name = "US"
                        });
                });

            modelBuilder.Entity("Models.Models.City", b =>
                {
                    b.HasOne("Models.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });
#pragma warning restore 612, 618
        }
    }
}
