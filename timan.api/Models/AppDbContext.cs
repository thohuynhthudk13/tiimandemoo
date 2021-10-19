using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timan.models;

namespace timan.api.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<ProductList> productLists { get; set; }
        public DbSet<Category> categories { get; set; }

        protected override void  OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //
            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 1, CategoryName = "Giày da nam" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 2, CategoryName = "Giày thể thao nữ" });

            modelBuilder.Entity<ProductList>().HasData(new ProductList {
                ProductID = 1,
                ProductName = "Giày Da Nam Đế Bằng MH19",
                Price = "550.038",
                Photo = "images/giaydanam.png",
                Desc1 = "Hỗ trợ đổi size miễn phí",
                Desc2 = "Bảo hành từ 1 đến 5 năm",
                Desc3 = "Giao hàng nhanh toàn quốc",
                Desc4 = "Bộ sản phẩm bao gồm: Hộp, Giấy Lót, Thẻ Bảo Hành, Thẻ Hướng Dẫn Bảo Quản",
                Status = "Còn hàng",
                Sold = 432,
                Rate = 342,
                CategoryID = 1

            });

            modelBuilder.Entity<ProductList>().HasData(new ProductList
            {
                ProductID = 2,
                ProductName = "Giày thể thao nữ",
                Price = "550.038",
                Photo = "images/giaythethonu.jpg",
                Desc1 = "Hỗ trợ đổi size miễn phí",
                Desc2 = "Bảo hành từ 1 đến 5 năm",
                Desc3 = "Giao hàng nhanh toàn quốc",
                Desc4 = "Bộ sản phẩm bao gồm: Hộp, Giấy Lót, Thẻ Bảo Hành, Thẻ Hướng Dẫn Bảo Quản",
                Status = "Còn hàng",
                Sold = 533,
                Rate = 283,
                CategoryID = 2

            });
        }
    }
}
