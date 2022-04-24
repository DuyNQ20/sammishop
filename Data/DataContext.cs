using Microsoft.EntityFrameworkCore;
using Sammishop.Models;
using System;

namespace  Sammishop.Data
{
    public class DataContext : DbContext
    {
        private DbContextOptions<DataContext> Options { get; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Options = options;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // để k bị lỗi primary key IdentityUserLogin table

            modelBuilder.Entity<Comment>().ToTable("Comment");
            modelBuilder.Entity<File>().ToTable("File");
            modelBuilder.Entity<Supplier>().ToTable("Supplier");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Vendor>().ToTable("Vendor");
            modelBuilder.Entity<ProductCategory>().ToTable("ProductCategory");
            modelBuilder.Entity<Status>().ToTable("Status");
            modelBuilder.Entity<Color>().ToTable("Color");
            // modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Cart>().ToTable("Cart");
            modelBuilder.Entity<Role>().ToTable("Role");
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<OrderStatus>().ToTable("OrderStatus");
            modelBuilder.Entity<PaymentMethod>().ToTable("PaymentMethod");
            modelBuilder.Entity<DiscountCategory>().ToTable("DiscountCategory");
            modelBuilder.Entity<Discount>().ToTable("Discount");
            modelBuilder.Entity<DiscountProductCategory>().ToTable("DiscountProductCategory");
            modelBuilder.Entity<DiscountProduct>().ToTable("DiscountProduct");
            modelBuilder.Entity<History>().ToTable("History");


            modelBuilder.Entity<Supplier>().HasData(
                new Supplier
                {
                    Id = 1,
                    Name = "Loreal",
                    Info = "Thông tin Loreal",
                    Logo = "Logo Loreal",
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Đào Thu Hoài",
                    ModifiedAt = DateTime.Now,
                    ModifiedBy = "Đào Thu Hoài"
                },
                new Supplier
                {
                    Id = 2,
                    Name = "Maybelline",
                    Info = "Thông tin Maybelline",
                    Logo = "Logo Maybelline",
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Đào Thu Hoài",
                    ModifiedAt = DateTime.Now,
                    ModifiedBy = "Đào Thu Hoài"
                },
                new Supplier
                {
                    Id = 3,
                    Name = "Vichy",
                    Info = "Thông tin Vichy",
                    Logo = "Logo Vichy",
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Đào Thu Hoài",
                    ModifiedAt = DateTime.Now,
                    ModifiedBy = "Đào Thu Hoài"
                },
                new Supplier
                {
                    Id = 4,
                    Name = " Innisfree",
                    Info = "Thông tin  Innisfree",
                    Logo = "Logo  Innisfree",
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Đào Thu Hoài",
                    ModifiedAt = DateTime.Now,
                    ModifiedBy = "Đào Thu Hoài"
                },
                new Supplier
                {
                    Id = 5,
                    Name = "Some By Mi",
                    Info = "Thông tin Some By Mi",
                    Logo = "Logo Some By Mi",
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Đào Thu Hoài",
                    ModifiedAt = DateTime.Now,
                    ModifiedBy = "Đào Thu Hoài"
                },
                new Supplier
                {
                    Id = 6,
                    Name = "Black Rouge",
                    Info = "Thông tin Black Rouge",
                    Logo = "Logo Black Rouge",
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Đào Thu Hoài",
                    ModifiedAt = DateTime.Now,
                    ModifiedBy = "Đào Thu Hoài"
                }
             );

            modelBuilder.Entity<Vendor>().HasData(
                new Vendor
                {
                    Id = 1,
                    Name = "Loreal",
                    Address = "Địa chỉ Hà Nội",
                    Email = "Loreal@gmail.com",
                    Phone = "0987654321",
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Đào Thu Hoài",
                    ModifiedAt = DateTime.Now,
                    ModifiedBy = "Đào Thu Hoài"
                },
                new Vendor
                {
                    Id = 2,
                    Name = "Maybelline",
                    Address = "Địa chỉ Cầu giấy",
                    Email = "Maybelline@gmail.com",
                    Phone = "0123456789",
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Đào Thu Hoài",
                    ModifiedAt = DateTime.Now,
                    ModifiedBy = "Đào Thu Hoài"
                }
             );

            modelBuilder.Entity<ProductCategory>().HasData(
               new ProductCategory
               {
                   Id = 1,
                   Name = "Make Up",
                   Active = true,
                   CreatedAt = DateTime.Now,
                   CreatedBy = "Đào Thu Hoài",
                   ModifiedAt = DateTime.Now,
                   ModifiedBy = "Đào Thu Hoài"
               },
               new ProductCategory
               {
                   Id = 2,
                   Name = "Skin Care",
                   Active = true,
                   CreatedAt = DateTime.Now,
                   CreatedBy = "Đào Thu Hoài",
                   ModifiedAt = DateTime.Now,
                   ModifiedBy = "Đào Thu Hoài"
               },
               new ProductCategory
               {
                   Id = 3,
                   Name = "Chăm sóc tóc",
                   Active = true,
                   CreatedAt = DateTime.Now,
                   CreatedBy = "Đào Thu Hoài",
                   ModifiedAt = DateTime.Now,
                   ModifiedBy = "Đào Thu Hoài"
               }
            );
            modelBuilder.Entity<Status>().HasData(
              new Status
              {
                  Id = 1,
                  Name = "Xuất bản",
                  Active = true,
                  CreatedAt = DateTime.Now,
                  CreatedBy = "Đào Thu Hoài",
                  ModifiedAt = DateTime.Now,
                  ModifiedBy = "Đào Thu Hoài"
              },
              new Status
              {
                  Id = 2,
                  Name = "Chưa xuất bản",
                  Active = true,
                  CreatedAt = DateTime.Now,
                  CreatedBy = "Đào Thu Hoài",
                  ModifiedAt = DateTime.Now,
                  ModifiedBy = "Đào Thu Hoài"
              }
           );
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    Name = "Admin",
                    Level = 1,
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Đào Thu Hoài",
                    ModifiedAt = DateTime.Now,
                    ModifiedBy = "Đào Thu Hoài"

                }
            );
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 2,
                    Name = "Custommer",
                    Level = 2,
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Đào Thu Hoài",
                    ModifiedAt = DateTime.Now,
                    ModifiedBy = "Đào Thu Hoài"

                }
            );
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 3,
                    Name = "Employee",
                    Level = 2,
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Đào Thu Hoài",
                    ModifiedAt = DateTime.Now,
                    ModifiedBy = "Đào Thu Hoài"

                }
            );
            modelBuilder.Entity<User>().HasData(
              new User
              {
                  Id = 1,
                  Email = "thuhoai@gmail.com",
                  Username = "admin",
                  Password = "123456",
                  Name = "Đào Thu Hoài",
                  Address = "Ha Noi",
                  RoleId = 1,
                  Active = true,
                  CreatedAt = DateTime.Now,
                  CreatedBy = "Đào Thu Hoài",
                  ModifiedAt = DateTime.Now,
                  ModifiedBy = "Đào Thu Hoài"
              },
              new User
              {
                  Id = 2,
                  Email = "customer@gmail.com",
                  Username = "customer",
                  Password = "123456",
                  Name = "Đào Thu Hoài",
                  Address = "Ha Noi",
                  RoleId = 2,
                  Active = true,
                  CreatedAt = DateTime.Now,
                  CreatedBy = "Đào Thu Hoài",
                  ModifiedAt = DateTime.Now,
                  ModifiedBy = "Đào Thu Hoài"
              },
            new User
            {
                Id = 3,
                Email = "nhanvien@gmail.com",
                Username = "nhanvien",
                Password = "123456",
                Name = "Nguyễn Quang Duy",
                Address = "Ha Noi",
                RoleId = 3,
                Active = true,
                CreatedAt = DateTime.Now,
                CreatedBy = "Đào Thu Hoài",
                ModifiedAt = DateTime.Now,
                ModifiedBy = "Đào Thu Hoài"
            }
           );



            modelBuilder.Entity<Color>().HasData(
             new Color
             {
                 Id = 1,
                 Name = "Xanh",
                 Active = true,
                 CreatedAt = DateTime.Now,
                 CreatedBy = "Đào Thu Hoài",
                 ModifiedAt = DateTime.Now,
                 ModifiedBy = "Đào Thu Hoài"
             }
            
          );
            modelBuilder.Entity<Color>().HasData(
             new Color
             {
                 Id = 2,
                 Name = "Đỏ",
                 Active = true,
                 CreatedAt = DateTime.Now,
                 CreatedBy = "Đào Thu Hoài",
                 ModifiedAt = DateTime.Now,
                 ModifiedBy = "Đào Thu Hoài"
             }

          );

            modelBuilder.Entity<Product>().HasData(
              new Product
              {
                  Id = 1,
                  Name = "NATURE REPUBLIC TINH CHẤT GREEN DERMA MILD CICA SERUM 50ML (IP04)",
                  OriginalPrice = 410000,
                  SalePrice = 287000,
                  Specifications = "",
                  Decriptions = "",
                  Inventory = 1000,
                  IsNew = true,
                  View = 500,
                  VendorId = 1,
                  ProductCategoryId = 1,
                  ColorId = 1,
                  StatusId = 1,
                  SupplierId = 1,
                  Active = true,
                  CreatedAt = DateTime.Now,
                  CreatedBy = "Đào Thu Hoài",
                  ModifiedAt = DateTime.Now,
                  ModifiedBy = "Đào Thu Hoài"
              },
              new Product
              {
                  Id = 2,
                  Name = "NATURE REPUBLIC TINH CHẤT GREEN DERMA MILD CICA SERUM 50ML (IP04)",
                  OriginalPrice = 410000,
                  SalePrice = 287000,
                  Specifications = "",
                  Decriptions = "",
                  Inventory = 1000,
                  IsNew = true,
                  View = 500,
                  VendorId = 1,
                  ProductCategoryId = 1,
                  ColorId = 1,
                  StatusId = 1,
                  SupplierId = 1,
                  Active = true,
                  CreatedAt = DateTime.Now,
                  CreatedBy = "Đào Thu Hoài",
                  ModifiedAt = DateTime.Now,
                  ModifiedBy = "Đào Thu Hoài"
              }
           );


            modelBuilder.Entity<Comment>().HasData(
               new Comment
               {
                   Id = 1,
                   ProductId = 1,
                   content = "Nội dung bình luận 1 cho iphone",
                   Active = true,
                   Delected = true,
                   CreatedAt = DateTime.Now,
                   CreatedBy = "Đào Thu Hoài",
                   ModifiedAt = DateTime.Now,
                   ModifiedBy = "Đào Thu Hoài"
               },
                new Comment
                {
                    Id = 2,
                    ProductId = 1,
                    content = "Nội dung bình luận 2 cho iphone",
                    Delected = false,
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Đào Thu Hoài",
                    ModifiedAt = DateTime.Now,
                    ModifiedBy = "Đào Thu Hoài"
                }
            );
            modelBuilder.Entity<File>().HasData(
               new File
               {
                   Id = 1,
                   ProductId = 1,
                   Path = "images\\smartphone\\iphonex.png",
                   Name = "iphonex",
                   Extention = ".png",
                   thumbnail = true,
                   CreatedAt = DateTime.Now,
                   CreatedBy = "Đào Thu Hoài",
                   ModifiedAt = DateTime.Now,
                   ModifiedBy = "Đào Thu Hoài"
               }
            );

            modelBuilder.Entity<Cart>().HasData(
              new Cart
              {
                  Id = 1,
                  ProductId = 1,
                  UserId = 1,
                  Active = true,
                  CreatedAt = DateTime.Now,
                  CreatedBy = "Đào Thu Hoài",
                  ModifiedAt = DateTime.Now,
                  ModifiedBy = "Đào Thu Hoài"
              },
              new Cart
              {
                  Id = 2,
                  ProductId = 2,
                  UserId = 1,
                  Active = true,
                  CreatedAt = DateTime.Now,
                  CreatedBy = "Đào Thu Hoài",
                  ModifiedAt = DateTime.Now,
                  ModifiedBy = "Đào Thu Hoài"
              }
           );


            modelBuilder.Entity<OrderStatus>().HasData(
             new OrderStatus
             {
                 Id = 1,
                 Name = "Đang chờ",
                 Active = true,
                 CreatedAt = DateTime.Now,
                 CreatedBy = "Đào Thu Hoài",
                 ModifiedAt = DateTime.Now,
                 ModifiedBy = "Đào Thu Hoài"
             },
             new OrderStatus
             {
                 Id = 2,
                 Name = "Đang giao hàng",
                 Active = true,
                 CreatedAt = DateTime.Now,
                 CreatedBy = "Đào Thu Hoài",
                 ModifiedAt = DateTime.Now,
                 ModifiedBy = "Đào Thu Hoài"
             },
             new OrderStatus
             {
                 Id = 3,
                 Name = "Đã giao thành công",
                 Active = true,
                 CreatedAt = DateTime.Now,
                 CreatedBy = "Đào Thu Hoài",
                 ModifiedAt = DateTime.Now,
                 ModifiedBy = "Đào Thu Hoài"
             },
             new OrderStatus
             {
                 Id = 4,
                 Name = "Đã hủy",
                 Active = true,
                 CreatedAt = DateTime.Now,
                 CreatedBy = "Đào Thu Hoài",
                 ModifiedAt = DateTime.Now,
                 ModifiedBy = "Đào Thu Hoài"
             }
          );

            modelBuilder.Entity<PaymentMethod>().HasData(
             new PaymentMethod
             {
                 Id = 1,
                 Name = "Thanh toán tiền mặt khi nhận hàng",
                 Code = "COD",
                 Active = true,
                 CreatedAt = DateTime.Now,
                 CreatedBy = "Đào Thu Hoài",
                 ModifiedAt = DateTime.Now,
                 ModifiedBy = "Đào Thu Hoài"
             },
              new PaymentMethod
              {
                  Id = 2,
                  Name = "Thanh toán bằng thẻ quốc tế Visa, Master, JCB",
                  Code = "Visa - Master - JCB",
                  Active = true,
                  CreatedAt = DateTime.Now,
                  CreatedBy = "Đào Thu Hoài",
                  ModifiedAt = DateTime.Now,
                  ModifiedBy = "Đào Thu Hoài"
              },
               new PaymentMethod
               {
                   Id = 3,
                   Name = "Thẻ ATM nội địa/Internet Banking (Miễn phí thanh toán)",
                   Code = "Visa - Master - JCB",
                   Active = true,
                   CreatedAt = DateTime.Now,
                   CreatedBy = "Đào Thu Hoài",
                   ModifiedAt = DateTime.Now,
                   ModifiedBy = "Đào Thu Hoài"
               },
                new PaymentMethod
                {
                    Id = 4,
                    Name = "Thanh toán bằng MoMo",
                    Code = "MoMo",
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Đào Thu Hoài",
                    ModifiedAt = DateTime.Now,
                    ModifiedBy = "Đào Thu Hoài"
                }
          );

            modelBuilder.Entity<DiscountCategory>().HasData(
                new DiscountCategory
                {
                    Id = 1,
                    Name = "Voucher",
                    Decriptions = "Khuyến mại theo số tiền",
                    Active = true,
                    CreatedAt = DateTime.Now,
                    CreatedBy = "Đào Thu Hoài",
                    ModifiedAt = DateTime.Now,
                    ModifiedBy = "Đào Thu Hoài"
                },
                 new DiscountCategory
                 {
                     Id = 2,
                     Name = "Counpon",
                     Decriptions = "Khuyến mại theo %",
                     Active = true,
                     CreatedAt = DateTime.Now,
                     CreatedBy = "Đào Thu Hoài",
                     ModifiedAt = DateTime.Now,
                     ModifiedBy = "Đào Thu Hoài"
                 }
            );

            modelBuilder.Entity<Discount>().HasData(
              new Discount
              {
                  Id = 1,
                  UserId = 1,
                  Code = "MA10",
                  DiscountMoney = 10000,
                  Quantity = 1000,
                  Descriptions = "Giảm 10.000 cho skin care",
                  DiscountCategoryId = 2,
                  DateTimeStart = DateTime.Parse("2022-03-31"),
                  DateTimeFinish = DateTime.Parse("2022-04-30"),
                  ApplyAll = false,
                  Active = true,
                  CreatedAt = DateTime.Now,
                  CreatedBy = "Đào Thu Hoài",
                  ModifiedAt = DateTime.Now,
                  ModifiedBy = "Đào Thu Hoài"
              },
              new Discount
              {
                  Id = 2,
                  UserId = 1,
                  Code = "MA20",
                  DiscountMoney = 20000,
                  Quantity = 1000,
                  Descriptions = "Giảm 20.000 cho tất cả sản phẩm",
                  DiscountCategoryId = 2,
                  DateTimeStart = DateTime.Parse("2022-03-31"),
                  DateTimeFinish = DateTime.Parse("2022-04-30"),
                  ApplyAll = false,
                  Active = true,
                  CreatedAt = DateTime.Now,
                  CreatedBy = "Đào Thu Hoài",
                  ModifiedAt = DateTime.Now,
                  ModifiedBy = "Đào Thu Hoài"
              }
           );

            modelBuilder.Entity<DiscountProductCategory>().HasData(
              new DiscountProductCategory
              {
                  Id = 1,
                  DiscountId = 1,
                  ProductCategoryId = 1,
                  Active = true,
                  CreatedAt = DateTime.Now,
                  CreatedBy = "Đào Thu Hoài",
                  ModifiedAt = DateTime.Now,
                  ModifiedBy = "Đào Thu Hoài"
              },
               new DiscountProductCategory
               {
                   Id = 2,
                   DiscountId = 1,
                   ProductCategoryId = 2,
                   Active = true,
                   CreatedAt = DateTime.Now,
                   CreatedBy = "Đào Thu Hoài",
                   ModifiedAt = DateTime.Now,
                   ModifiedBy = "Đào Thu Hoài"
               }
               ,
               new DiscountProductCategory
               {
                   Id = 3,
                   DiscountId = 2,
                   ProductCategoryId = 1,
                   Active = true,
                   CreatedAt = DateTime.Now,
                   CreatedBy = "Đào Thu Hoài",
                   ModifiedAt = DateTime.Now,
                   ModifiedBy = "Đào Thu Hoài"
               }
           );

        }



        public DbSet<Comment> Comments { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<ProductCategory> ProductCategorys { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<DiscountCategory> DiscountCategories { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<DiscountProductCategory> DiscountProductCategories { get; set; }
        public DbSet<DiscountProduct> DiscountProducts { get; set; }
        public DbSet<History> Histories { get; set; }


    }
}
