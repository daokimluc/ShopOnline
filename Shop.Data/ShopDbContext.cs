using Shop.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class ShopDbContext : DbContext
    {
        // Khởi tạo constructer
        public ShopDbContext() : base("ShopConnection")
        {
            // Load bảng cha không tự động cinlcude bảng con
            this.Configuration.LazyLoadingEnabled = false;
        }
        // Khai báo danh sách Table 
        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategorys { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Product> Products { set; get; }
        public DbSet<ProductCategory> ProductCategorys { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<Error> Errors { set; get; }

        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }


        // Phương thức ghi đè, chạy khi khởi tạo entity Framwork
        protected override void OnModelCreating(DbModelBuilder Builder)
        {
           
        }

    }
}
