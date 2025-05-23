﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizApp.Repositories.EntityFramework.Concrete.Contexts;

#nullable disable

namespace Repositories.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250324195108_Baskets")]
    partial class Baskets
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiService.Entities.Concrete.AppEntities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("FalseEntryCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBlocked")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2025, 3, 24, 22, 51, 6, 836, DateTimeKind.Local).AddTicks(8760),
                            CreatedUserName = "Seed Data",
                            EmailConfirmed = true,
                            FalseEntryCount = 0,
                            IsActive = true,
                            IsBlocked = false,
                            ModifiedDate = new DateTime(2025, 3, 24, 22, 51, 6, 836, DateTimeKind.Local).AddTicks(8763),
                            ModifiedUserName = "Seed Data",
                            UserEmail = "berkayakar@gmail.com",
                            UserFullName = "Berkay AKAR",
                            UserName = "berkayakar",
                            UserPassword = "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2025, 3, 24, 22, 51, 6, 847, DateTimeKind.Local).AddTicks(3138),
                            CreatedUserName = "Seed Data",
                            EmailConfirmed = true,
                            FalseEntryCount = 0,
                            IsActive = true,
                            IsBlocked = false,
                            ModifiedDate = new DateTime(2025, 3, 24, 22, 51, 6, 847, DateTimeKind.Local).AddTicks(3142),
                            ModifiedUserName = "Seed Data",
                            UserEmail = "alturadmin@gmail.com",
                            UserFullName = "Altur Admin ",
                            UserName = "alturadmin",
                            UserPassword = "A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3"
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.AppEntities.AppMenus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ActionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AppMenusId")
                        .HasColumnType("int");

                    b.Property<string>("AreaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClaimId")
                        .HasColumnType("int");

                    b.Property<string>("ControllerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNewTab")
                        .HasColumnType("bit");

                    b.Property<string>("MenuDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuIcon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MenuOrderNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parameter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RootId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AppMenusId");

                    b.HasIndex("ClaimId");

                    b.ToTable("AppMenus");
                });

            modelBuilder.Entity("Core.Entities.Concrete.AppEntities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2025, 3, 24, 22, 51, 6, 834, DateTimeKind.Local).AddTicks(9731),
                            CreatedUserName = "Seed Data",
                            IsActive = true,
                            ModifiedDate = new DateTime(2025, 3, 24, 22, 51, 6, 835, DateTimeKind.Local).AddTicks(7951),
                            RoleDescription = "En yetkili kullanıcı",
                            RoleName = "Sistem Admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2025, 3, 24, 22, 51, 6, 835, DateTimeKind.Local).AddTicks(8883),
                            CreatedUserName = "Seed Data",
                            IsActive = true,
                            ModifiedDate = new DateTime(2025, 3, 24, 22, 51, 6, 835, DateTimeKind.Local).AddTicks(8885),
                            RoleDescription = "Sadece sipariş verebilir. ",
                            RoleName = "Müşteri"
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.AppEntities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClaimId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClaimId");

                    b.HasIndex("RoleId");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("Core.Entities.Concrete.AppEntities.AppUserRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2025, 3, 24, 22, 51, 6, 836, DateTimeKind.Local).AddTicks(4741),
                            CreatedUserName = "Seed Data",
                            IsActive = true,
                            ModifiedDate = new DateTime(2025, 3, 24, 22, 51, 6, 836, DateTimeKind.Local).AddTicks(4744),
                            RoleId = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2025, 3, 24, 22, 51, 6, 836, DateTimeKind.Local).AddTicks(5044),
                            CreatedUserName = "Seed Data",
                            IsActive = true,
                            ModifiedDate = new DateTime(2025, 3, 24, 22, 51, 6, 836, DateTimeKind.Local).AddTicks(5045),
                            RoleId = 1,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Entities.Concrete.AppEntities.AppClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppClaims");
                });

            modelBuilder.Entity("Entities.Concrete.AppEntities.AppToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId")
                        .IsUnique();

                    b.ToTable("AppTokens");
                });

            modelBuilder.Entity("Entities.Concrete.AppEntities.AppUserClaims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClaimId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClaimId");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Entities.Concrete.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("Entities.Concrete.BasketDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BasketId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("BasketDetails");
                });

            modelBuilder.Entity("Entities.Concrete.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryDescription = "Akıllı Telefon kategorisi ",
                            CategoryName = "Akıllı Telefon ",
                            CreatedDate = new DateTime(2025, 3, 24, 22, 51, 6, 847, DateTimeKind.Local).AddTicks(6946),
                            CreatedUserName = "Seed Data",
                            IsActive = true,
                            ModifiedDate = new DateTime(2025, 3, 24, 22, 51, 6, 847, DateTimeKind.Local).AddTicks(6949),
                            ModifiedUserName = "Seed Data"
                        },
                        new
                        {
                            Id = 2,
                            CategoryDescription = "Laptop ve Masaüstü Bilgisayarlar",
                            CategoryName = "Bilgisayar",
                            CreatedDate = new DateTime(2025, 3, 24, 22, 51, 6, 847, DateTimeKind.Local).AddTicks(7268),
                            CreatedUserName = "Seed Data",
                            IsActive = true,
                            ModifiedDate = new DateTime(2025, 3, 24, 22, 51, 6, 847, DateTimeKind.Local).AddTicks(7270),
                            ModifiedUserName = "Seed Data"
                        },
                        new
                        {
                            Id = 3,
                            CategoryDescription = "Harici bilgisayar parçaları ",
                            CategoryName = "Bilgisayar bileşenleri ",
                            CreatedDate = new DateTime(2025, 3, 24, 22, 51, 6, 847, DateTimeKind.Local).AddTicks(7272),
                            CreatedUserName = "Seed Data",
                            IsActive = true,
                            ModifiedDate = new DateTime(2025, 3, 24, 22, 51, 6, 847, DateTimeKind.Local).AddTicks(7272),
                            ModifiedUserName = "Seed Data"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedUserId")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCardImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2025, 3, 24, 22, 51, 6, 848, DateTimeKind.Local).AddTicks(853),
                            CreatedUserName = "Seed Data",
                            IsActive = true,
                            ModifiedDate = new DateTime(2025, 3, 24, 22, 51, 6, 848, DateTimeKind.Local).AddTicks(856),
                            ModifiedUserName = "Seed Data",
                            ProductCardImage = "https://cdn.vatanbilgisayar.com/Upload/PRODUCT/apple/thumb/0003-mpuf3tu-a_large.jpg",
                            ProductDescription = "128 gb lık versiyon",
                            ProductName = "Iphone 14",
                            ProductPrice = 20000m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2025, 3, 24, 22, 51, 6, 848, DateTimeKind.Local).AddTicks(1682),
                            CreatedUserName = "Seed Data",
                            IsActive = true,
                            ModifiedDate = new DateTime(2025, 3, 24, 22, 51, 6, 848, DateTimeKind.Local).AddTicks(1684),
                            ModifiedUserName = "Seed Data",
                            ProductCardImage = "https://encrypted-tbn2.gstatic.com/shopping?q=tbn:ANd9GcTNtyK9OXNPvPrrO8AO3JpPGtv9lOTvDRfKku6m3ZqtaO0KRwPUAYmJjgQYoRJLY5HfSoBx4dCkd9O57yAbVdNxGrxgUKmT",
                            ProductDescription = "128 gb lık versiyon",
                            ProductName = "Samsung S24 FE",
                            ProductPrice = 15000m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2025, 3, 24, 22, 51, 6, 848, DateTimeKind.Local).AddTicks(1687),
                            CreatedUserName = "Seed Data",
                            IsActive = true,
                            ModifiedDate = new DateTime(2025, 3, 24, 22, 51, 6, 848, DateTimeKind.Local).AddTicks(1687),
                            ModifiedUserName = "Seed Data",
                            ProductCardImage = "https://m.media-amazon.com/images/I/61tOfogRfXL.__AC_SX300_SY300_QL70_ML2_.jpg",
                            ProductDescription = "Yazilimci Bilgisayarı",
                            ProductName = "Monster Laptop",
                            ProductPrice = 40000m,
                            Stock = 0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2025, 3, 24, 22, 51, 6, 848, DateTimeKind.Local).AddTicks(1689),
                            CreatedUserName = "Seed Data",
                            IsActive = true,
                            ModifiedDate = new DateTime(2025, 3, 24, 22, 51, 6, 848, DateTimeKind.Local).AddTicks(1689),
                            ModifiedUserName = "Seed Data",
                            ProductCardImage = "https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcSXIJhS_a--H2uKCFDS5BEYT41Vhmf717hT06Z9ySrFl4R_7p6tWkfUwXvyb-zQJJz9JDlOgVE5lxZa0Hr0u3eN4_YOfJk9n6S1V9JAuKqJIFPhpaYTP42Vfw",
                            ProductDescription = "500 Gb",
                            ProductName = "ssd ",
                            ProductPrice = 1000m,
                            Stock = 0
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.AppEntities.AppMenus", b =>
                {
                    b.HasOne("Core.Entities.Concrete.AppEntities.AppMenus", null)
                        .WithMany("ChildMenus")
                        .HasForeignKey("AppMenusId");

                    b.HasOne("Entities.Concrete.AppEntities.AppClaim", "AppClaim")
                        .WithMany("AppMenus")
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppClaim");
                });

            modelBuilder.Entity("Core.Entities.Concrete.AppEntities.AppRoleClaim", b =>
                {
                    b.HasOne("Entities.Concrete.AppEntities.AppClaim", "AppClaims")
                        .WithMany("AppRoleClaims")
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Concrete.AppEntities.AppRole", "AppRoles")
                        .WithMany("AppRoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppClaims");

                    b.Navigation("AppRoles");
                });

            modelBuilder.Entity("Core.Entities.Concrete.AppEntities.AppUserRoles", b =>
                {
                    b.HasOne("Core.Entities.Concrete.AppEntities.AppRole", "Role")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiService.Entities.Concrete.AppEntities.AppUser", "AppUser")
                        .WithMany("AppUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Entities.Concrete.AppEntities.AppToken", b =>
                {
                    b.HasOne("ApiService.Entities.Concrete.AppEntities.AppUser", "AppUser")
                        .WithOne("UserToken")
                        .HasForeignKey("Entities.Concrete.AppEntities.AppToken", "AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Entities.Concrete.AppEntities.AppUserClaims", b =>
                {
                    b.HasOne("Entities.Concrete.AppEntities.AppClaim", "AppClaim")
                        .WithMany("AppUserClaims")
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiService.Entities.Concrete.AppEntities.AppUser", "AppUser")
                        .WithMany("AppUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppClaim");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Entities.Concrete.Basket", b =>
                {
                    b.HasOne("ApiService.Entities.Concrete.AppEntities.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("Entities.Concrete.BasketDetail", b =>
                {
                    b.HasOne("Entities.Concrete.Basket", "Basket")
                        .WithMany("BasketDetails")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Products", "Products")
                        .WithOne("BasketDetail")
                        .HasForeignKey("Entities.Concrete.BasketDetail", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Entities.Concrete.Products", b =>
                {
                    b.HasOne("Entities.Concrete.Categories", "Category")
                        .WithMany("ProductList")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ApiService.Entities.Concrete.AppEntities.AppUser", b =>
                {
                    b.Navigation("AppUserClaims");

                    b.Navigation("AppUserRoles");

                    b.Navigation("UserToken")
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Entities.Concrete.AppEntities.AppMenus", b =>
                {
                    b.Navigation("ChildMenus");
                });

            modelBuilder.Entity("Core.Entities.Concrete.AppEntities.AppRole", b =>
                {
                    b.Navigation("AppRoleClaims");

                    b.Navigation("AppUserRoles");
                });

            modelBuilder.Entity("Entities.Concrete.AppEntities.AppClaim", b =>
                {
                    b.Navigation("AppMenus");

                    b.Navigation("AppRoleClaims");

                    b.Navigation("AppUserClaims");
                });

            modelBuilder.Entity("Entities.Concrete.Basket", b =>
                {
                    b.Navigation("BasketDetails");
                });

            modelBuilder.Entity("Entities.Concrete.Categories", b =>
                {
                    b.Navigation("ProductList");
                });

            modelBuilder.Entity("Entities.Concrete.Products", b =>
                {
                    b.Navigation("BasketDetail")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
