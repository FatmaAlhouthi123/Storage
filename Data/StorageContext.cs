using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Storage.Models;

namespace Storage.Data {
    public class StorageContext : DbContext {
        public StorageContext(DbContextOptions<StorageContext> options)
            : base(options) {
        }
        //som vi använder oss av för att hämta data från databasen
        public DbSet<Storage.Models.Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            // modelBuilder.Entity<Students>().HasData();
            modelBuilder.Entity<Product>().HasData(new Product() { Id = 1, Name = "tv", Category = "livingroom", Count = 5, Description = "60 inches ", Orderdate = new DateTime(2008, 3, 1, 7, 0, 0), Price = 20000, Shelf = "B110" },
                new Product() { Id = 2, Name = "dish", Category = "kitchen", Count = 5, Description = "medums ", Orderdate = new DateTime(2018, 3, 1, 7, 0, 0), Price =50, Shelf = "A10" },
                new Product() { Id = 3, Name = "radio", Category = "livingroom", Count = 5, Description = "black ", Orderdate = new DateTime(2020, 3, 1, 6, 0, 0), Price = 1000, Shelf = "C110" }












            );
        }
    }
}
