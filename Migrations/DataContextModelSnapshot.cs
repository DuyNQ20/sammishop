﻿// <auto-generated />
using System;
using CatalogService.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MyProjectMVC.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MyProject.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<bool>("Delected");

                    b.Property<DateTimeOffset>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.Property<int>("ProductId");

                    b.Property<string>("content");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Comment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            CreatedAt = new DateTimeOffset(new DateTime(2019, 2, 14, 22, 27, 2, 569, DateTimeKind.Unspecified).AddTicks(8191), new TimeSpan(0, 7, 0, 0, 0)),
                            CreatedBy = "Quang Duy",
                            Delected = true,
                            ModifiedAt = new DateTimeOffset(new DateTime(2019, 2, 14, 22, 27, 2, 569, DateTimeKind.Unspecified).AddTicks(8200), new TimeSpan(0, 7, 0, 0, 0)),
                            ModifiedBy = "Quang Duy",
                            ProductId = 1,
                            content = "Nội dung bình luận 1 cho iphone"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            CreatedAt = new DateTimeOffset(new DateTime(2019, 2, 14, 22, 27, 2, 569, DateTimeKind.Unspecified).AddTicks(8234), new TimeSpan(0, 7, 0, 0, 0)),
                            CreatedBy = "Quang Duy",
                            Delected = false,
                            ModifiedAt = new DateTimeOffset(new DateTime(2019, 2, 14, 22, 27, 2, 569, DateTimeKind.Unspecified).AddTicks(8234), new TimeSpan(0, 7, 0, 0, 0)),
                            ModifiedBy = "Quang Duy",
                            ProductId = 1,
                            content = "Nội dung bình luận 2 cho iphone"
                        });
                });

            modelBuilder.Entity("MyProject.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTimeOffset>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.Property<int>("ProductId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("MyProject.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Info");

                    b.Property<string>("Logo");

                    b.Property<DateTimeOffset>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Manufacturer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            CreatedAt = new DateTimeOffset(new DateTime(2019, 2, 14, 22, 27, 2, 563, DateTimeKind.Unspecified).AddTicks(9708), new TimeSpan(0, 7, 0, 0, 0)),
                            CreatedBy = "Quang Duy",
                            Info = "Thông tin apple",
                            Logo = "Logo Apple",
                            ModifiedAt = new DateTimeOffset(new DateTime(2019, 2, 14, 22, 27, 2, 567, DateTimeKind.Unspecified).AddTicks(3273), new TimeSpan(0, 7, 0, 0, 0)),
                            ModifiedBy = "Quang Duy",
                            Name = "Apple"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            CreatedAt = new DateTimeOffset(new DateTime(2019, 2, 14, 22, 27, 2, 567, DateTimeKind.Unspecified).AddTicks(5950), new TimeSpan(0, 7, 0, 0, 0)),
                            CreatedBy = "Quang Duy",
                            Info = "Thông tin samsung",
                            Logo = "Logo Samsung",
                            ModifiedAt = new DateTimeOffset(new DateTime(2019, 2, 14, 22, 27, 2, 567, DateTimeKind.Unspecified).AddTicks(5971), new TimeSpan(0, 7, 0, 0, 0)),
                            ModifiedBy = "Quang Duy",
                            Name = "Samsung"
                        });
                });

            modelBuilder.Entity("MyProject.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Decriptions");

                    b.Property<bool>("Deleted");

                    b.Property<int>("Inventory");

                    b.Property<bool>("IsNew");

                    b.Property<int>("ManufacturerId");

                    b.Property<DateTimeOffset>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("Specifications");

                    b.Property<int>("VendorId");

                    b.Property<int>("View");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("VendorId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            CreatedAt = new DateTimeOffset(new DateTime(2019, 2, 14, 22, 27, 2, 569, DateTimeKind.Unspecified).AddTicks(4424), new TimeSpan(0, 7, 0, 0, 0)),
                            CreatedBy = "Quang Duy",
                            Decriptions = "Cuối cùng iPhone X cũng đã ra mắt trong sự kiện diễn ra rạng sáng nay (13/9) theo giờ Việt Nam. </br>Đây là sản phẩm được Apple tung ra để kỷ niệm 10 năm iPhone.",
                            Deleted = false,
                            Inventory = 1000,
                            IsNew = true,
                            ManufacturerId = 1,
                            ModifiedAt = new DateTimeOffset(new DateTime(2019, 2, 14, 22, 27, 2, 569, DateTimeKind.Unspecified).AddTicks(4436), new TimeSpan(0, 7, 0, 0, 0)),
                            ModifiedBy = "Quang Duy",
                            Name = "IPhone X",
                            Price = 25000000m,
                            Specifications = "Nhà sản xuất:Apple </br>Hệ điều hành: iOS 11 </br>Kích thước:	143,6 x 70,9 x 7,7 mm </br>Trọng lượng: 174g </br>Ngày giới thiệu:	13 / 09 / 2017",
                            VendorId = 1,
                            View = 500
                        });
                });

            modelBuilder.Entity("MyProject.Models.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Address");

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Email");

                    b.Property<DateTimeOffset>("ModifiedAt");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Vendor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            Address = "Địa chỉ apple",
                            CreatedAt = new DateTimeOffset(new DateTime(2019, 2, 14, 22, 27, 2, 568, DateTimeKind.Unspecified).AddTicks(3699), new TimeSpan(0, 7, 0, 0, 0)),
                            CreatedBy = "Quang Duy",
                            Email = "apple@gmail.com",
                            ModifiedAt = new DateTimeOffset(new DateTime(2019, 2, 14, 22, 27, 2, 568, DateTimeKind.Unspecified).AddTicks(3712), new TimeSpan(0, 7, 0, 0, 0)),
                            ModifiedBy = "Quang Duy",
                            Name = "Nhà cung cấp Apple",
                            Phone = "0987654321"
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            Address = "Địa chỉ samsung",
                            CreatedAt = new DateTimeOffset(new DateTime(2019, 2, 14, 22, 27, 2, 568, DateTimeKind.Unspecified).AddTicks(3746), new TimeSpan(0, 7, 0, 0, 0)),
                            CreatedBy = "Quang Duy",
                            Email = "samsung@gmail.com",
                            ModifiedAt = new DateTimeOffset(new DateTime(2019, 2, 14, 22, 27, 2, 568, DateTimeKind.Unspecified).AddTicks(3746), new TimeSpan(0, 7, 0, 0, 0)),
                            ModifiedBy = "Quang Duy",
                            Name = "Nhà cung cấp Samsung",
                            Phone = "0123456789"
                        });
                });

            modelBuilder.Entity("MyProject.Models.Comment", b =>
                {
                    b.HasOne("MyProject.Models.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyProject.Models.Image", b =>
                {
                    b.HasOne("MyProject.Models.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyProject.Models.Product", b =>
                {
                    b.HasOne("MyProject.Models.Manufacturer", "Manufacturer")
                        .WithMany("Products")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyProject.Models.Vendor", "Vendor")
                        .WithMany("Products")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
