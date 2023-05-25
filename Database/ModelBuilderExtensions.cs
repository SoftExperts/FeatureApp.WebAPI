using FeatureApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = Guid.NewGuid(), Name = "Grunge Skater Jeans", Sku = "AWMGSJ", Price = 68, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Polo Shirt", Sku = "AWMPS", Price = 35, IsAvailable = true, IsNew = false },
                new Product { Id = Guid.NewGuid(), Name = "Skater Graphic T-Shirt", Sku = "AWMSGT", Price = 33, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Slicker Jacket", Sku = "AWMSJ", Price = 125, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Thermal Fleece Jacket", Sku = "AWMTFJ", Price = 60, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Unisex Thermal Vest", Sku = "AWMUTV", Price = 95, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "V-Neck Pullover", Sku = "AWMVNP", Price = 65, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "V-Neck Sweater", Sku = "AWMVNS", Price = 65, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "V-Neck T-Shirt", Sku = "AWMVNT", Price = 17, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Bamboo Thermal Ski Coat", Sku = "AWWBTSC", Price = 99, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Cross-Back Training Tank", Sku = "AWWCTT", Price = 0, IsAvailable = false, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Grunge Skater Jeans", Sku = "AWWGSJ", Price = 68, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Slicker Jacket", Sku = "AWWSJ", Price = 125, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Stretchy Dance Pants", Sku = "AWWSDP", Price = 55, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Ultra-Soft Tank Top", Sku = "AWWUTT", Price = 22, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Unisex Thermal Vest", Sku = "AWWUTV", Price = 95, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "V-Next T-Shirt", Sku = "AWWVNT", Price = 17, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Blueberry Mineral Water", Sku = "MWB", Price = 2.8M, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Lemon-Lime Mineral Water", Sku = "MWLL", Price = 2.8M, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Orange Mineral Water", Sku = "MWO", Price = 2.8M, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Peach Mineral Water", Sku = "MWP", Price = 2.8M, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Raspberry Mineral Water", Sku = "MWR", Price = 2.8M, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Strawberry Mineral Water", Sku = "MWS", Price = 2.8M, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "In the Kitchen with H+ Sport", Sku = "PITK", Price = 24.99M, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now },
                new Product { Id = Guid.NewGuid(), Name = "Calcium 400 IU (150 tablets)", Sku = "SC400", Price = 9.99M, IsAvailable = true, IsNew = false, CreatedBy = Guid.NewGuid(), CreatedDate = DateTime.Now });
        }
    }
}
