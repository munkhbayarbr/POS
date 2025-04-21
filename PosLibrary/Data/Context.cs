using Microsoft.EntityFrameworkCore;
using PosLibrary.Models;

namespace PosLibrary.Data
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

       
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=pos.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "manager", Password = "manager123", Role = "Manager" },
                new User { Id = 2, Username = "cashier1", Password = "guest", Role = "Cashier" },
                new User { Id = 3, Username = "cashier2", Password = "guest", Role = "Cashier" }
            );
        }
    }
}
