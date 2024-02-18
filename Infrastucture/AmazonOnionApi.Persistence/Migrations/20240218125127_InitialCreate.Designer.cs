﻿// <auto-generated />
using System;
using AmazonOnionApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AmazonOnionApi.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240218125127_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AmazonOnionApi.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 2, 18, 15, 51, 27, 102, DateTimeKind.Local).AddTicks(8636),
                            IsDeleted = false,
                            Name = "Tools, Beauty & Baby"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 2, 18, 15, 51, 27, 102, DateTimeKind.Local).AddTicks(8644),
                            IsDeleted = false,
                            Name = "Automotive"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 2, 18, 15, 51, 27, 102, DateTimeKind.Local).AddTicks(8650),
                            IsDeleted = true,
                            Name = "Jewelery"
                        });
                });

            modelBuilder.Entity("AmazonOnionApi.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Priorty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 2, 18, 15, 51, 27, 103, DateTimeKind.Local).AddTicks(1412),
                            IsDeleted = false,
                            Name = "Elektrik",
                            ParentId = 0,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 2, 18, 15, 51, 27, 103, DateTimeKind.Local).AddTicks(1413),
                            IsDeleted = false,
                            Name = "Moda",
                            ParentId = 0,
                            Priorty = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 2, 18, 15, 51, 27, 103, DateTimeKind.Local).AddTicks(1415),
                            IsDeleted = false,
                            Name = "Bilgisayar",
                            ParentId = 1,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 2, 18, 15, 51, 27, 103, DateTimeKind.Local).AddTicks(1416),
                            IsDeleted = false,
                            Name = "Kadın",
                            ParentId = 2,
                            Priorty = 1
                        });
                });

            modelBuilder.Entity("AmazonOnionApi.Domain.Entities.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 2, 18, 15, 51, 27, 105, DateTimeKind.Local).AddTicks(9107),
                            Description = "Aspernatur quis sinema eos esse.",
                            IsDeleted = false,
                            Title = "Lakin."
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 2, 18, 15, 51, 27, 105, DateTimeKind.Local).AddTicks(9142),
                            Description = "Değerli dignissimos aliquid non quia.",
                            IsDeleted = true,
                            Title = "Esse ad."
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2024, 2, 18, 15, 51, 27, 105, DateTimeKind.Local).AddTicks(9175),
                            Description = "Kulu quia ut enim bilgiyasayarı.",
                            IsDeleted = false,
                            Title = "Neque."
                        });
                });

            modelBuilder.Entity("AmazonOnionApi.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CreatedDate = new DateTime(2024, 2, 18, 15, 51, 27, 109, DateTimeKind.Local).AddTicks(3029),
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Discount = 8.742250573358440m,
                            IsDeleted = false,
                            Price = 648.07m,
                            Title = "Incredible Metal Pizza"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 3,
                            CreatedDate = new DateTime(2024, 2, 18, 15, 51, 27, 109, DateTimeKind.Local).AddTicks(3056),
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Discount = 1.912691188977860m,
                            IsDeleted = false,
                            Price = 810.74m,
                            Title = "Generic Frozen Fish"
                        });
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("CategoriesId1")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "CategoriesId1");

                    b.HasIndex("CategoriesId1");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("AmazonOnionApi.Domain.Entities.Detail", b =>
                {
                    b.HasOne("AmazonOnionApi.Domain.Entities.Category", "Category")
                        .WithMany("Details")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("AmazonOnionApi.Domain.Entities.Product", b =>
                {
                    b.HasOne("AmazonOnionApi.Domain.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("AmazonOnionApi.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AmazonOnionApi.Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AmazonOnionApi.Domain.Entities.Category", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
