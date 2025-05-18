using Microsoft.EntityFrameworkCore;
using PosLibrary.Models;

namespace PosLibrary.Data
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=pos.db");

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Product>()
     .HasOne(p => p.Category)             
     .WithMany()
     .HasForeignKey(p => p.CategoryId)
     .OnDelete(DeleteBehavior.Restrict);
                

            mb.Entity<User>().HasData(
                new User { Id = 1, Username = "manager", Password = "manager123", Role = "Manager" },
                new User { Id = 2, Username = "cashier1", Password = "guest", Role = "Cashier" },
                new User { Id = 3, Username = "cashier2", Password = "guest", Role = "Cashier" }
            );


            mb.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Category 1" },
                new Category { Id = 2, Name = "Category 2" },   
                new Category { Id = 3, Name = "Category 3" }
            );


            mb.Entity<Product>().HasData(
                new Product { Id = 1, Code = "P001", Name = "Product 1", CategoryId = 1, Price = 10.00m, Stock = 100 },
                new Product { Id = 2, Code = "P002", Name = "Product 2", CategoryId = 2, Price = 20.00m, Stock = 50 },
                new Product { Id = 3, Code = "P003", Name = "Product 3", CategoryId = 3, Price = 30.00m, Stock = 25 }
            );
        }
    }
}
