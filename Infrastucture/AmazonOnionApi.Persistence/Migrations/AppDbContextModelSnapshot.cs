﻿// <auto-generated />
using System;
using AmazonOnionApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AmazonOnionApi.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            CreatedDate = new DateTime(2024, 3, 19, 16, 24, 20, 302, DateTimeKind.Local).AddTicks(2),
                            IsDeleted = false,
                            Name = "Movies"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 3, 19, 16, 24, 20, 302, DateTimeKind.Local).AddTicks(479),
                            IsDeleted = false,
                            Name = "Industrial & Garden"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 3, 19, 16, 24, 20, 302, DateTimeKind.Local).AddTicks(495),
                            IsDeleted = true,
                            Name = "Music & Music"
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
                            CreatedDate = new DateTime(2024, 3, 19, 16, 24, 20, 302, DateTimeKind.Local).AddTicks(2759),
                            IsDeleted = false,
                            Name = "Elektrik",
                            ParentId = 0,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 3, 19, 16, 24, 20, 302, DateTimeKind.Local).AddTicks(2761),
                            IsDeleted = false,
                            Name = "Moda",
                            ParentId = 0,
                            Priorty = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 3, 19, 16, 24, 20, 302, DateTimeKind.Local).AddTicks(2762),
                            IsDeleted = false,
                            Name = "Bilgisayar",
                            ParentId = 1,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 3, 19, 16, 24, 20, 302, DateTimeKind.Local).AddTicks(2764),
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
                            CreatedDate = new DateTime(2024, 3, 19, 16, 24, 20, 305, DateTimeKind.Local).AddTicks(8640),
                            Description = "Velit kutusu eaque tempora eaque.",
                            IsDeleted = false,
                            Title = "İnventore."
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 3, 19, 16, 24, 20, 305, DateTimeKind.Local).AddTicks(8760),
                            Description = "Aperiam kapının odit yapacakmış orta.",
                            IsDeleted = true,
                            Title = "Kalemi okuma."
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2024, 3, 19, 16, 24, 20, 305, DateTimeKind.Local).AddTicks(8794),
                            Description = "Ullam orta consequatur sed kalemi.",
                            IsDeleted = false,
                            Title = "Otobüs."
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
                            CreatedDate = new DateTime(2024, 3, 19, 16, 24, 20, 309, DateTimeKind.Local).AddTicks(177),
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Discount = 6.227327467124690m,
                            IsDeleted = false,
                            Price = 160.16m,
                            Title = "Gorgeous Wooden Computer"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 3,
                            CreatedDate = new DateTime(2024, 3, 19, 16, 24, 20, 309, DateTimeKind.Local).AddTicks(204),
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Discount = 2.152338720766730m,
                            IsDeleted = false,
                            Price = 455.61m,
                            Title = "Licensed Soft Bike"
                        });
                });

            modelBuilder.Entity("AmazonOnionApi.Domain.Entities.ProductCategory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategories");
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

            modelBuilder.Entity("AmazonOnionApi.Domain.Entities.ProductCategory", b =>
                {
                    b.HasOne("AmazonOnionApi.Domain.Entities.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AmazonOnionApi.Domain.Entities.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AmazonOnionApi.Domain.Entities.Category", b =>
                {
                    b.Navigation("Details");

                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("AmazonOnionApi.Domain.Entities.Product", b =>
                {
                    b.Navigation("ProductCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
