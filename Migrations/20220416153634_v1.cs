using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sammishop.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(2340), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(2347), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(2376), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(2377), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 110, DateTimeKind.Unspecified).AddTicks(1828), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 110, DateTimeKind.Unspecified).AddTicks(1834), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 110, DateTimeKind.Unspecified).AddTicks(2176), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 110, DateTimeKind.Unspecified).AddTicks(2178), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 110, DateTimeKind.Unspecified).AddTicks(8100), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 110, DateTimeKind.Unspecified).AddTicks(8108), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 110, DateTimeKind.Unspecified).AddTicks(8137), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 110, DateTimeKind.Unspecified).AddTicks(8139), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateTimeFinish", "DateTimeStart", "Descriptions", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 112, DateTimeKind.Unspecified).AddTicks(5765), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giảm 10.000 cho skin care", new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 112, DateTimeKind.Unspecified).AddTicks(5778), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateTimeFinish", "DateTimeStart", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 112, DateTimeKind.Unspecified).AddTicks(5889), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 112, DateTimeKind.Unspecified).AddTicks(5891), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DiscountCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(7111), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(7119), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DiscountCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(7145), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(7146), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DiscountProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 112, DateTimeKind.Unspecified).AddTicks(7639), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 112, DateTimeKind.Unspecified).AddTicks(7649), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DiscountProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 112, DateTimeKind.Unspecified).AddTicks(7679), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 112, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DiscountProductCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 112, DateTimeKind.Unspecified).AddTicks(7681), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 112, DateTimeKind.Unspecified).AddTicks(7682), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "File",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(563), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(570), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(4112), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(4121), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(4149), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(4151), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(4153), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(4154), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(4157), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(4158), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(5663), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(5670), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(5700), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(5702), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(5704), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(5706), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(5707), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 111, DateTimeKind.Unspecified).AddTicks(5709), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Decriptions", "ModifiedAt", "Name", "OriginalPrice", "SalePrice", "Specifications" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 110, DateTimeKind.Unspecified).AddTicks(6261), new TimeSpan(0, 7, 0, 0, 0)), "", new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 110, DateTimeKind.Unspecified).AddTicks(6273), new TimeSpan(0, 7, 0, 0, 0)), "NATURE REPUBLIC TINH CHẤT GREEN DERMA MILD CICA SERUM 50ML (IP04)", 410000m, 287000m, "" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Decriptions", "ModifiedAt", "Name", "OriginalPrice", "SalePrice", "Specifications" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 110, DateTimeKind.Unspecified).AddTicks(6366), new TimeSpan(0, 7, 0, 0, 0)), "", new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 110, DateTimeKind.Unspecified).AddTicks(6368), new TimeSpan(0, 7, 0, 0, 0)), "NATURE REPUBLIC TINH CHẤT GREEN DERMA MILD CICA SERUM 50ML (IP04)", 410000m, 287000m, "" });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 109, DateTimeKind.Unspecified).AddTicks(5915), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 109, DateTimeKind.Unspecified).AddTicks(5927), new TimeSpan(0, 7, 0, 0, 0)), "Make Up" });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 109, DateTimeKind.Unspecified).AddTicks(5960), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 109, DateTimeKind.Unspecified).AddTicks(5961), new TimeSpan(0, 7, 0, 0, 0)), "Skin Care" });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 109, DateTimeKind.Unspecified).AddTicks(5963), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 109, DateTimeKind.Unspecified).AddTicks(5965), new TimeSpan(0, 7, 0, 0, 0)), "Chăm sóc tóc" });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 109, DateTimeKind.Unspecified).AddTicks(8773), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 109, DateTimeKind.Unspecified).AddTicks(8779), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 109, DateTimeKind.Unspecified).AddTicks(9172), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 109, DateTimeKind.Unspecified).AddTicks(9175), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 109, DateTimeKind.Unspecified).AddTicks(7372), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 109, DateTimeKind.Unspecified).AddTicks(7381), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 109, DateTimeKind.Unspecified).AddTicks(7405), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 109, DateTimeKind.Unspecified).AddTicks(7407), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Info", "Logo", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 105, DateTimeKind.Unspecified).AddTicks(3467), new TimeSpan(0, 7, 0, 0, 0)), "Thông tin Loreal", "Logo Loreal", new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 108, DateTimeKind.Unspecified).AddTicks(5858), new TimeSpan(0, 7, 0, 0, 0)), "Loreal" });

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Info", "Logo", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 108, DateTimeKind.Unspecified).AddTicks(6639), new TimeSpan(0, 7, 0, 0, 0)), "Thông tin Maybelline", "Logo Maybelline", new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 108, DateTimeKind.Unspecified).AddTicks(6653), new TimeSpan(0, 7, 0, 0, 0)), "Maybelline" });

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Info", "Logo", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 108, DateTimeKind.Unspecified).AddTicks(6669), new TimeSpan(0, 7, 0, 0, 0)), "Thông tin Vichy", "Logo Vichy", new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 108, DateTimeKind.Unspecified).AddTicks(6670), new TimeSpan(0, 7, 0, 0, 0)), "Vichy" });

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Info", "Logo", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 108, DateTimeKind.Unspecified).AddTicks(6672), new TimeSpan(0, 7, 0, 0, 0)), "Thông tin  Innisfree", "Logo  Innisfree", new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 108, DateTimeKind.Unspecified).AddTicks(6674), new TimeSpan(0, 7, 0, 0, 0)), " Innisfree" });

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Info", "Logo", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 108, DateTimeKind.Unspecified).AddTicks(6677), new TimeSpan(0, 7, 0, 0, 0)), "Thông tin Some By Mi", "Logo Some By Mi", new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 108, DateTimeKind.Unspecified).AddTicks(6678), new TimeSpan(0, 7, 0, 0, 0)), "Some By Mi" });

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Info", "Logo", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 108, DateTimeKind.Unspecified).AddTicks(6680), new TimeSpan(0, 7, 0, 0, 0)), "Thông tin Black Rouge", "Logo Black Rouge", new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 108, DateTimeKind.Unspecified).AddTicks(6681), new TimeSpan(0, 7, 0, 0, 0)), "Black Rouge" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 110, DateTimeKind.Unspecified).AddTicks(730), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 110, DateTimeKind.Unspecified).AddTicks(739), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 110, DateTimeKind.Unspecified).AddTicks(775), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 110, DateTimeKind.Unspecified).AddTicks(777), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 109, DateTimeKind.Unspecified).AddTicks(3125), new TimeSpan(0, 7, 0, 0, 0)), "Loreal@gmail.com", new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 109, DateTimeKind.Unspecified).AddTicks(3146), new TimeSpan(0, 7, 0, 0, 0)), "Loreal" });

            migrationBuilder.UpdateData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 109, DateTimeKind.Unspecified).AddTicks(3210), new TimeSpan(0, 7, 0, 0, 0)), "Maybelline@gmail.com", new DateTimeOffset(new DateTime(2022, 4, 16, 22, 36, 33, 109, DateTimeKind.Unspecified).AddTicks(3212), new TimeSpan(0, 7, 0, 0, 0)), "Maybelline" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(1622), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(1626), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(1639), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(1640), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(5292), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(5295), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(5475), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(5477), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(9451), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(9455), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(9474), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(9476), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateTimeFinish", "DateTimeStart", "Descriptions", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(9123), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2019, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giảm 10.000 cho điện thoại", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(9129), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Discount",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateTimeFinish", "DateTimeStart", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(9186), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2019, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(9187), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DiscountCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3801), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3805), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DiscountCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3819), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3820), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DiscountProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 475, DateTimeKind.Unspecified).AddTicks(337), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 475, DateTimeKind.Unspecified).AddTicks(342), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DiscountProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 475, DateTimeKind.Unspecified).AddTicks(356), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 475, DateTimeKind.Unspecified).AddTicks(357), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "DiscountProductCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 475, DateTimeKind.Unspecified).AddTicks(359), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 475, DateTimeKind.Unspecified).AddTicks(360), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "File",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(736), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(741), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(2312), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(2316), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(2328), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(2329), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(2331), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(2331), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(2333), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(2333), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3057), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3061), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3077), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3077), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3079), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3080), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3081), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 474, DateTimeKind.Unspecified).AddTicks(3082), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Decriptions", "ModifiedAt", "Name", "OriginalPrice", "SalePrice", "Specifications" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(8408), new TimeSpan(0, 7, 0, 0, 0)), "Cuối cùng iPhone X cũng đã ra mắt trong sự kiện diễn ra rạng sáng nay (13/9) theo giờ Việt Nam. </br>Đây là sản phẩm được Apple tung ra để kỷ niệm 10 năm iPhone.", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(8412), new TimeSpan(0, 7, 0, 0, 0)), "IPhone X", 20000000m, 25000000m, "Nhà sản xuất:Apple </br>Hệ điều hành: iOS 11 </br>Kích thước:	143,6 x 70,9 x 7,7 mm </br>Trọng lượng: 174g </br>Ngày giới thiệu:	13 / 09 / 2017" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Decriptions", "ModifiedAt", "Name", "OriginalPrice", "SalePrice", "Specifications" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(8665), new TimeSpan(0, 7, 0, 0, 0)), "Cuối cùng iPhone X cũng đã ra mắt trong sự kiện diễn ra rạng sáng nay (13/9) theo giờ Việt Nam. </br>Đây là sản phẩm được Apple tung ra để kỷ niệm 10 năm iPhone.", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(8667), new TimeSpan(0, 7, 0, 0, 0)), "Samsung X", 20000000m, 25000000m, "Nhà sản xuất:Apple </br>Hệ điều hành: iOS 11 </br>Kích thước:	143,6 x 70,9 x 7,7 mm </br>Trọng lượng: 174g </br>Ngày giới thiệu:	13 / 09 / 2017" });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2248), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2253), new TimeSpan(0, 7, 0, 0, 0)), "Điện thoại" });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2265), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2267), new TimeSpan(0, 7, 0, 0, 0)), "Ipad" });

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2268), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2269), new TimeSpan(0, 7, 0, 0, 0)), "Laptop" });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(3658), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(3662), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(3846), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(3848), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2877), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2882), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2893), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(2894), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Info", "Logo", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 470, DateTimeKind.Unspecified).AddTicks(5436), new TimeSpan(0, 7, 0, 0, 0)), "Thông tin apple", "Logo Apple", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(6823), new TimeSpan(0, 7, 0, 0, 0)), "Apple" });

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Info", "Logo", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7393), new TimeSpan(0, 7, 0, 0, 0)), "Thông tin samsung", "Logo Samsung", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7403), new TimeSpan(0, 7, 0, 0, 0)), "Samsung" });

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Info", "Logo", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7410), new TimeSpan(0, 7, 0, 0, 0)), "Thông tin xiaomi", "Logo Xiaomi", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7412), new TimeSpan(0, 7, 0, 0, 0)), "Xiaomi" });

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Info", "Logo", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7413), new TimeSpan(0, 7, 0, 0, 0)), "Thông tin Huwei", "Logo Huwei", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7414), new TimeSpan(0, 7, 0, 0, 0)), "Huwei" });

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Info", "Logo", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7416), new TimeSpan(0, 7, 0, 0, 0)), "Thông tin Oppo", "Logo Oppo", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7418), new TimeSpan(0, 7, 0, 0, 0)), "Oppo" });

            migrationBuilder.UpdateData(
                table: "Supplier",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Info", "Logo", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7419), new TimeSpan(0, 7, 0, 0, 0)), "Thông tin Nokia", "Logo Nokia", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 472, DateTimeKind.Unspecified).AddTicks(7420), new TimeSpan(0, 7, 0, 0, 0)), "Nokia" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(4690), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(4694), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(4713), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(4714), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Email", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(1420), new TimeSpan(0, 7, 0, 0, 0)), "hoangha@gmail.com", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(1429), new TimeSpan(0, 7, 0, 0, 0)), "Hoàng Hà Mobile" });

            migrationBuilder.UpdateData(
                table: "Vendor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Email", "ModifiedAt", "Name" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(1454), new TimeSpan(0, 7, 0, 0, 0)), "Cellphones@gmail.com", new DateTimeOffset(new DateTime(2022, 4, 9, 17, 33, 19, 473, DateTimeKind.Unspecified).AddTicks(1455), new TimeSpan(0, 7, 0, 0, 0)), "CellPhone S" });
        }
    }
}
