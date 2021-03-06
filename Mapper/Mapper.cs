using Microsoft.AspNetCore.Http;
using Sammishop.Models;
using Sammishop.ViewModels;
using System;
using System.Globalization;

namespace  Sammishop.Mapper
{
    public static class Mapper
    {

        public static void Map(this Product destination, ProductView source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            var now =  DateTime.UtcNow;

            if (destination.CreatedAt == DateTimeOffset.MinValue)
            {
                destination.CreatedAt = now;
            }
            destination.ColorId = 1;
            destination.Name = source.Name;
            destination.OriginalPrice = source.OriginalPrice;
            destination.SalePrice = source.SalePrice;
            destination.Specifications = source.Specifications;
            destination.Decriptions = source.Decriptions;
            destination.Inventory = source.Inventory;
           
            destination.IsNew = source.IsNew;
            destination.VendorId = source.VendorId;
            destination.SupplierId = source.SupplierId;
            destination.ProductCategoryId = source.ProductCategoryId;
            destination.ModifiedAt = now;
            destination.StatusId = source.StatusId;
            destination.Active = source.StatusId==1?true:false;
        }

        public static void SaveMap(this Product destination, ProductView source)
        {

            destination.ColorId = 1;
            var now = DateTime.UtcNow;

            destination.Name = source.Name;
            destination.OriginalPrice = source.OriginalPrice;
            destination.SalePrice = source.SalePrice;
            destination.Specifications = source.Specifications;
            destination.Decriptions = source.Decriptions;
            destination.Inventory = source.Inventory;
            destination.IsNew = source.IsNew;
            destination.VendorId = source.VendorId;
            destination.SupplierId = source.SupplierId;
            destination.ProductCategoryId = source.ProductCategoryId;
            destination.ModifiedAt = now;
            destination.CreatedAt = now;
            destination.StatusId = source.StatusId;
            destination.Active = source.StatusId == 1 ? true : false;
        }


        // Product Categories
        public static void Map(this ProductCategory destination, ProductCategoryView source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            var now = DateTime.UtcNow;

            if (destination.CreatedAt == DateTimeOffset.MinValue)
            {
                destination.CreatedAt = now;
            }

            destination.Name = source.Name;
            destination.ModifiedAt = now;
            destination.Active = source.Active;
        }

        public static void SaveMap(this ProductCategory destination, ProductCategoryView source)
        {
            var now = DateTime.UtcNow;

            destination.Name = source.Name;
            destination.ModifiedAt = now;
            destination.CreatedAt = now;
            destination.Active = source.Active;
        }


        // Vendor
        public static void Map(this Vendor destination, VendorView source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            var now = DateTime.UtcNow;

            if (destination.CreatedAt == default)
            {
                destination.CreatedAt = now;
            }

            destination.Name = source.Name;
            destination.Address = source.Address;
            destination.Email = source.Email;
            destination.Phone = source.Phone;
            destination.ModifiedAt = now;
            destination.Active = source.Active;
        }

        public static void Map(this Supplier destination, SupplierView source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            var now = DateTime.UtcNow;

            if (destination.CreatedAt == default)
            {
                destination.CreatedAt = now;
            }

            destination.Name = source.Name;
            destination.Info = source.Info;
            destination.Logo = source.Logo;
            destination.ModifiedAt = now;
            destination.Active = source.Active;
            

        }


        // File
        

        public static void SaveMap(this File destination, IFormFile source)
        {
            var now = DateTime.UtcNow;

            destination.Name = source.Name;
            destination.Size = source.Length;
            destination.UploadedAt = now;
            destination.Url = System.IO.Path.Combine(StorageConfiguration.Path);
            destination.Path = System.IO.Path.Combine(StorageConfiguration.Path, source.FileName); ;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="destination"></param>
        /// <param name="source"></param>
        /// <param name="productId">Tham thieu toi Product</param>
        public static void SaveMap(this File destination, IFormFile source, int productId, bool thumbnail=false)
        {
            var now = DateTime.UtcNow;

            destination.Name = source.FileName;
            destination.Size = source.Length;
            destination.UploadedAt = now;
            destination.Url = System.IO.Path.Combine(StorageConfiguration.Path);
            destination.Path = System.IO.Path.Combine(StorageConfiguration.Path, source.FileName);
            destination.thumbnail = thumbnail;
            destination.ProductId = productId;
        }

        // Carts
        public static void Map(this Cart destination, CartView source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            var now = DateTime.UtcNow;

            if (destination.CreatedAt == null)
            {
                destination.CreatedAt = now;
            }
            
            destination.UserId = source.UserId;
            destination.ProductId = source.ProductId;
            destination.ModifiedAt = now;
            destination.Active = source.Active;
            destination.Quantity = source.Quantity;
        }

        public static void SaveMap(this Cart destination, CartView source)
        {
            
            var now = DateTime.UtcNow;

            destination.CreatedAt = now;
            destination.UserId = source.UserId;
            destination.ProductId = source.ProductId;
            destination.ModifiedAt = now;
            destination.Active = source.Active;
            destination.Quantity = source.Quantity;
        }

        // Order
        public static void Map(this Order destination, OrderView source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            var now = DateTime.UtcNow;

            if (destination.CreatedAt == DateTimeOffset.MinValue)
            {
                destination.CreatedAt = now;
            }

            destination.Code = source.Code;
            destination.DeliveryAddress = source.DeliveryAddress;
            destination.Phone = source.Phone;
            destination.Receiver = source.Receiver;
            destination.Note = source.Note;
            destination.SalePrice = source.SalePrice;
            destination.Quantity = source.Quantity;
            destination.Total = source.Total;
            destination.DiscountMoney = source.DiscountMoney;
            destination.UserId = source.UserId;
            destination.ProductId = source.ProductId;
            destination.OrderStatusId = source.OrderStatusId;
            destination.ModifiedAt = now;
            destination.Active = true;
        }

        public static void SaveMap(this Order destination, OrderView source)
        {
            var now = DateTime.UtcNow;
            destination.Code = source.Code;
            destination.DeliveryAddress = source.DeliveryAddress;
            destination.Phone = source.Phone;
            destination.Receiver = source.Receiver;
            destination.Note = source.Note;
            destination.SalePrice = source.SalePrice;
            destination.Quantity = source.Quantity;
            destination.Total = source.Total;
            destination.DiscountMoney = source.DiscountMoney;
            destination.UserId = source.UserId;
            destination.ProductId = source.ProductId;
            destination.PaymentMethodId = source.PaymentMethodId;
            destination.OrderStatusId = 1; // Trạng thái đang chờ            
            destination.ModifiedAt = now;
            destination.Active = true;
            destination.CreatedAt = now;
        }


        // User
        public static void Map(this User destination, UserView source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            var now = DateTime.UtcNow;

            if (destination.CreatedAt == DateTimeOffset.MinValue)
            {
                destination.CreatedAt = now;
            }

            destination.Name = source.Name;
            destination.Address = source.Address;
            destination.Phone = source.Phone;
            destination.Email = source.Email;
            destination.Username = source.Username;
            destination.Password = source.Password;
            destination.ModifiedAt = now;
            destination.Active = true;
        }

        public static void SaveMap(this User destination, UserView source)
        {
            var now = DateTime.UtcNow;
            destination.Name = source.Name;
            destination.Address = source.Address;
            destination.Phone = source.Phone;
            destination.Email = source.Email;
            destination.Username = source.Username;
            destination.Password = source.Password;
            destination.ModifiedAt = now;
            destination.Active = true;
            destination.CreatedAt = now;
        }


        // Discount
        public static void Map(this Discount destination, DiscountView source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            var now = DateTime.UtcNow;

            if (destination.CreatedAt == DateTimeOffset.MinValue)
            {
                destination.CreatedAt = now;
            }

            destination.Code = source.Code;
            destination.DiscountMoney = source.DiscountMoney;
            destination.Descriptions = source.Descriptions;
            destination.DiscountCategoryId = source.DiscountCategoryId;
            destination.DateTimeStart = source.DateTimeStart == default? DateTime.Now : DateTime.ParseExact(source.DateTimeStart, "dd/MM/yyyy", CultureInfo.InvariantCulture); ;
            destination.DateTimeFinish = source.DateTimeFinish == default ? DateTime.Now : DateTime.ParseExact(source.DateTimeFinish, "dd/MM/yyyy", CultureInfo.InvariantCulture); ;
            destination.ApplyAll = source.ApplyAll;
            destination.UserId = source.UserId;
            destination.Quantity = source.Quantity;
            destination.ModifiedAt = now;
            destination.Active = DateTime.ParseExact(source.DateTimeFinish, "dd/MM/yyyy", CultureInfo.InvariantCulture) < DateTime.ParseExact(source.DateTimeStart, "dd/MM/yyyy", CultureInfo.InvariantCulture) ? false : true;
        }

        public static void SaveMap(this Discount destination, DiscountView source)
        {
            var now = DateTime.UtcNow;
            destination.Code = source.Code;
            destination.DiscountMoney = source.DiscountMoney;
            destination.Descriptions = source.Descriptions;
            destination.DiscountCategoryId = source.DiscountCategoryId;
            destination.DateTimeStart = source.DateTimeStart == default ? DateTime.Now : DateTime.ParseExact(source.DateTimeStart, "dd/MM/yyyy", CultureInfo.InvariantCulture); ;
            destination.DateTimeFinish = source.DateTimeFinish == default ? DateTime.Now : DateTime.ParseExact(source.DateTimeFinish, "dd/MM/yyyy", CultureInfo.InvariantCulture); ;
            destination.ApplyAll = source.ApplyAll;
            destination.UserId = source.UserId;
            destination.Quantity = source.Quantity;
            destination.ModifiedAt = now;
            destination.Active = DateTime.ParseExact(source.DateTimeFinish, "dd/MM/yyyy", CultureInfo.InvariantCulture) <  DateTime.ParseExact(source.DateTimeStart, "dd/MM/yyyy", CultureInfo.InvariantCulture) ? false : true;
            destination.CreatedAt = now;
        }


        // DiscountProduct
        public static void Map(this DiscountProduct destination, DiscountProductView source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            var now = DateTime.UtcNow;

            if (destination.CreatedAt == DateTimeOffset.MinValue)
            {
                destination.CreatedAt = now;
            }

            destination.DiscountId = source.DiscountId;
            destination.ProductId = source.ProductId;
            destination.ModifiedAt = now;
            destination.Active = source.Active;
        }

        public static void SaveMap(this DiscountProduct destination, DiscountProductView source)
        {
            var now = DateTime.UtcNow;
            destination.DiscountId = source.DiscountId;
            destination.ProductId = source.ProductId;
            destination.ModifiedAt = now;
            destination.Active = source.Active;
            destination.CreatedAt = now;
        }

        // DiscountProductCategory
        public static void Map(this DiscountProductCategory destination, DiscountProductCategoryView source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            var now = DateTime.UtcNow;

            if (destination.CreatedAt == DateTimeOffset.MinValue)
            {
                destination.CreatedAt = now;
            }

            destination.DiscountId = source.DiscountId;
            destination.ProductCategoryId = source.ProductCategoryId;
            destination.ModifiedAt = now;
            destination.Active = source.Active;
        }

        public static void SaveMap(this DiscountProductCategory destination, DiscountProductCategoryView source)
        {
            var now = DateTime.UtcNow;
            destination.DiscountId = source.DiscountId;
            destination.ProductCategoryId = source.ProductCategoryId;
            destination.ModifiedAt = now;
            destination.Active = source.Active;
            destination.CreatedAt = now;
        }

        // History
        public static void Map(this History destination, HistoryView source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            var now = DateTime.UtcNow;

            if (destination.CreatedAt == DateTimeOffset.MinValue)
            {
                destination.CreatedAt = now;
            }

            destination.ProductId = source.ProductId;
            destination.UserId = source.UserId;
            destination.ModifiedAt = now;
            destination.Active = source.Active;
        }

        public static void SaveMap(this History destination, HistoryView source)
        {
            var now = DateTime.UtcNow;
            destination.ProductId = source.ProductId;
            destination.UserId = source.UserId;
            destination.ModifiedAt = now;
            destination.Active = source.Active;
            destination.CreatedAt = now;
        }

    }
}
