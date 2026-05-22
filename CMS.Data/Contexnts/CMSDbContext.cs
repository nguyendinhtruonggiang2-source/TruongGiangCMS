using CMS.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data.Contexts
{
    public class CMSDbContext : DbContext
    {
        public CMSDbContext(DbContextOptions<CMSDbContext> options)
            : base(options)
        {
        }

        // Bảng bài viết
        public DbSet<Post> Posts { get; set; }

        // Bảng danh mục bài viết
        public DbSet<Category> Categories { get; set; }

        // Bảng người dùng
        public DbSet<User> Users { get; set; }

        // Bảng danh mục sản phẩm
        public DbSet<CategoryProduct> CategoryProducts { get; set; }

        // Bảng sản phẩm
        public DbSet<Product> Products { get; set; }

        // Bảng khách hàng
        public DbSet<Customer> Customers { get; set; }

        // Bảng đơn hàng
        public DbSet<Order> Orders { get; set; }

        // Bảng chi tiết đơn hàng
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(o => o.TotalPrice)
                .HasColumnType("decimal(18,2)");
        }
    }
}