using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sammishop.Migrations
{
    public partial class @int : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiscountCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Decriptions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Info = table.Column<string>(nullable: true),
                    Logo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SupplierId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategory_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    Descriptions = table.Column<string>(nullable: true),
                    DiscountMoney = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    DateTimeStart = table.Column<DateTime>(nullable: false),
                    DateTimeFinish = table.Column<DateTime>(nullable: false),
                    DiscountCategoryId = table.Column<int>(nullable: false),
                    ApplyAll = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discount_DiscountCategory_DiscountCategoryId",
                        column: x => x.DiscountCategoryId,
                        principalTable: "DiscountCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Discount_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Specifications = table.Column<string>(nullable: true),
                    Decriptions = table.Column<string>(nullable: true),
                    OriginalPrice = table.Column<decimal>(nullable: false),
                    SalePrice = table.Column<decimal>(nullable: false),
                    Inventory = table.Column<int>(nullable: false),
                    IsNew = table.Column<bool>(nullable: false),
                    View = table.Column<int>(nullable: false),
                    VendorId = table.Column<int>(nullable: false),
                    SupplierId = table.Column<int>(nullable: false),
                    ProductCategoryId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    ColorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Vendor_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiscountProductCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: false),
                    DiscountId = table.Column<int>(nullable: false),
                    ProductCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountProductCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiscountProductCategory_Discount_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscountProductCategory_ProductCategory_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cart_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: false),
                    content = table.Column<string>(nullable: true),
                    Delected = table.Column<bool>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiscountProduct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: false),
                    DiscountId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DiscountProduct_Discount_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscountProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "File",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Extention = table.Column<string>(nullable: true),
                    Size = table.Column<long>(nullable: false),
                    UploadedBy = table.Column<string>(nullable: true),
                    UploadedAt = table.Column<DateTime>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    Hash = table.Column<string>(nullable: true),
                    thumbnail = table.Column<bool>(nullable: false),
                    Module = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_File", x => x.Id);
                    table.ForeignKey(
                        name: "FK_File_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.Id);
                    table.ForeignKey(
                        name: "FK_History_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_History_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    ModifiedAt = table.Column<DateTimeOffset>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    DeliveryAddress = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Receiver = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    PaymentMethodId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    SalePrice = table.Column<decimal>(nullable: false),
                    Total = table.Column<decimal>(nullable: false),
                    DiscountMoney = table.Column<decimal>(nullable: false),
                    OrderStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_OrderStatus_OrderStatusId",
                        column: x => x.OrderStatusId,
                        principalTable: "OrderStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_PaymentMethod_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(5292), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(5295), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Xanh" },
                    { 2, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(5475), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(5477), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Đỏ" }
                });

            migrationBuilder.InsertData(
                table: "DiscountCategory",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "Decriptions", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3801), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Khuyến mại theo số tiền", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3805), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Voucher" },
                    { 2, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3819), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Khuyến mại theo %", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3820), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Counpon" }
                });

            migrationBuilder.InsertData(
                table: "OrderStatus",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(2312), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(2316), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Đang chờ" },
                    { 2, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(2328), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(2329), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Đang giao hàng" },
                    { 3, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(2331), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(2331), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Đã giao thành công" },
                    { 4, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(2333), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(2333), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Đã hủy" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "Id", "Active", "Code", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, true, "COD", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3057), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3061), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Thanh toán tiền mặt khi nhận hàng" },
                    { 2, true, "Visa - Master - JCB", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3077), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3077), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Thanh toán bằng thẻ quốc tế Visa, Master, JCB" },
                    { 3, true, "Visa - Master - JCB", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3079), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3080), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Thẻ ATM nội địa/Internet Banking (Miễn phí thanh toán)" },
                    { 4, true, "MoMo", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3081), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3082), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Thanh toán bằng MoMo" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Name", "SupplierId" },
                values: new object[,]
                {
                    { 3, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2268), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2269), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Laptop", null },
                    { 2, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2265), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2267), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Ipad", null },
                    { 1, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2248), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2253), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Điện thoại", null }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "Level", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(3658), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", 1, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(3662), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Admin" },
                    { 2, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(3846), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", 2, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(3848), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Custommer" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2877), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2882), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Xuất bản" },
                    { 2, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2893), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2894), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Chưa xuất bản" }
                });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "Info", "Logo", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 470, DateTimeKind.Unspecified).AddTicks(5436), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Thông tin apple", "Logo Apple", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(6823), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Apple" },
                    { 2, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7393), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Thông tin samsung", "Logo Samsung", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7403), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Samsung" },
                    { 3, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7410), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Thông tin xiaomi", "Logo Xiaomi", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7412), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Xiaomi" },
                    { 4, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7413), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Thông tin Huwei", "Logo Huwei", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7414), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Huwei" },
                    { 5, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7416), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Thông tin Oppo", "Logo Oppo", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7418), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Oppo" },
                    { 6, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7419), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Thông tin Nokia", "Logo Nokia", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7420), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Nokia" }
                });

            migrationBuilder.InsertData(
                table: "Vendor",
                columns: new[] { "Id", "Active", "Address", "CreatedAt", "CreatedBy", "Email", "ModifiedAt", "ModifiedBy", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, true, "Địa chỉ Hà Nội", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(1420), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "hoangha@gmail.com", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(1429), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Hoàng Hà Mobile", "0987654321" },
                    { 2, true, "Địa chỉ Cầu giấy", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(1454), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Cellphones@gmail.com", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(1455), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "CellPhone S", "0123456789" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Active", "ColorId", "CreatedAt", "CreatedBy", "Decriptions", "Inventory", "IsNew", "ModifiedAt", "ModifiedBy", "Name", "OriginalPrice", "ProductCategoryId", "SalePrice", "Specifications", "StatusId", "SupplierId", "VendorId", "View" },
                values: new object[,]
                {
                    { 1, true, 1, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(8408), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Cuối cùng iPhone X cũng đã ra mắt trong sự kiện diễn ra rạng sáng nay (13/9) theo giờ Việt Nam. </br>Đây là sản phẩm được Apple tung ra để kỷ niệm 10 năm iPhone.", 1000, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(8412), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "IPhone X", 20000000m, 1, 25000000m, "Nhà sản xuất:Apple </br>Hệ điều hành: iOS 11 </br>Kích thước:	143,6 x 70,9 x 7,7 mm </br>Trọng lượng: 174g </br>Ngày giới thiệu:	13 / 09 / 2017", 1, 1, 1, 500 },
                    { 2, true, 1, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(8665), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Cuối cùng iPhone X cũng đã ra mắt trong sự kiện diễn ra rạng sáng nay (13/9) theo giờ Việt Nam. </br>Đây là sản phẩm được Apple tung ra để kỷ niệm 10 năm iPhone.", 1000, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(8667), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Samsung X", 20000000m, 1, 25000000m, "Nhà sản xuất:Apple </br>Hệ điều hành: iOS 11 </br>Kích thước:	143,6 x 70,9 x 7,7 mm </br>Trọng lượng: 174g </br>Ngày giới thiệu:	13 / 09 / 2017", 1, 1, 1, 500 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Active", "Address", "CreatedAt", "CreatedBy", "Email", "ModifiedAt", "ModifiedBy", "Name", "Password", "Phone", "RoleId", "Username" },
                values: new object[,]
                {
                    { 1, true, "Ha Noi", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(4690), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "thuhoai@gmail.com", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(4694), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Đào Thu Hoài", "123456", null, 1, "admin" },
                    { 2, true, "Ha Noi", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(4713), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "customer@gmail.com", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(4714), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", "Đào Thu Hoài", "123456", null, 2, "customer" }
                });

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "ProductId", "Quantity", "UserId" },
                values: new object[,]
                {
                    { 1, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(1622), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(1626), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", 1, 0, 1 },
                    { 2, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(1639), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(1640), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", 2, 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "Delected", "ModifiedAt", "ModifiedBy", "ProductId", "content" },
                values: new object[,]
                {
                    { 1, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(9451), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(9455), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", 1, "Nội dung bình luận 1 cho iphone" },
                    { 2, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(9474), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", false, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(9476), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", 1, "Nội dung bình luận 2 cho iphone" }
                });

            migrationBuilder.InsertData(
                table: "Discount",
                columns: new[] { "Id", "Active", "ApplyAll", "Code", "CreatedAt", "CreatedBy", "DateTimeFinish", "DateTimeStart", "Descriptions", "DiscountCategoryId", "DiscountMoney", "ModifiedAt", "ModifiedBy", "Quantity", "UserId" },
                values: new object[,]
                {
                    { 1, true, false, "MA10", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(9123), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", new DateTime(2019, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giảm 10.000 cho điện thoại", 2, 10000m, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(9129), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", 1000, 1 },
                    { 2, true, false, "MA20", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(9186), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", new DateTime(2019, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giảm 20.000 cho tất cả sản phẩm", 2, 20000m, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(9187), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", 1000, 1 }
                });

            migrationBuilder.InsertData(
                table: "File",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "Extention", "Hash", "ModifiedAt", "ModifiedBy", "Module", "Name", "Path", "ProductId", "Size", "UploadedAt", "UploadedBy", "Url", "thumbnail" },
                values: new object[] { 1, false, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(736), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", ".png", null, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(741), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", null, "iphonex", "images\\smartphone\\iphonex.png", 1, 0L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, true });

            migrationBuilder.InsertData(
                table: "DiscountProductCategory",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "DiscountId", "ModifiedAt", "ModifiedBy", "ProductCategoryId" },
                values: new object[] { 1, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 475, DateTimeKind.Unspecified).AddTicks(337), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", 1, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 475, DateTimeKind.Unspecified).AddTicks(342), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", 1 });

            migrationBuilder.InsertData(
                table: "DiscountProductCategory",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "DiscountId", "ModifiedAt", "ModifiedBy", "ProductCategoryId" },
                values: new object[] { 2, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 475, DateTimeKind.Unspecified).AddTicks(356), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", 1, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 475, DateTimeKind.Unspecified).AddTicks(357), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", 2 });

            migrationBuilder.InsertData(
                table: "DiscountProductCategory",
                columns: new[] { "Id", "Active", "CreatedAt", "CreatedBy", "DiscountId", "ModifiedAt", "ModifiedBy", "ProductCategoryId" },
                values: new object[] { 3, true, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 475, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", 2, new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 475, DateTimeKind.Unspecified).AddTicks(360), new TimeSpan(0, 7, 0, 0, 0)), "Đào Thu Hoài", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_ProductId",
                table: "Cart",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserId",
                table: "Cart",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ProductId",
                table: "Comment",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Discount_DiscountCategoryId",
                table: "Discount",
                column: "DiscountCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Discount_UserId",
                table: "Discount",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountProduct_DiscountId",
                table: "DiscountProduct",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountProduct_ProductId",
                table: "DiscountProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountProductCategory_DiscountId",
                table: "DiscountProductCategory",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountProductCategory_ProductCategoryId",
                table: "DiscountProductCategory",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_File_ProductId",
                table: "File",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_History_ProductId",
                table: "History",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_History_UserId",
                table: "History",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderStatusId",
                table: "Order",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PaymentMethodId",
                table: "Order",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ProductId",
                table: "Order",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ColorId",
                table: "Product",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryId",
                table: "Product",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_StatusId",
                table: "Product",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SupplierId",
                table: "Product",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_VendorId",
                table: "Product",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_SupplierId",
                table: "ProductCategory",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "DiscountProduct");

            migrationBuilder.DropTable(
                name: "DiscountProductCategory");

            migrationBuilder.DropTable(
                name: "File");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Discount");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "DiscountCategory");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Supplier");
        }
    }
}
