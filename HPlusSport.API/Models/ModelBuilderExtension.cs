using Microsoft.EntityFrameworkCore;

namespace HPlusSport.API.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Active Wear - Men" },
                new Category { Id = 2, Name = "Active Wear - Women" },
                new Category { Id = 3, Name = "Mineral Water" },
                new Category { Id = 4, Name = "Publications" },
                new Category { Id = 5, Name = "Supplements" });

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryID = 1, Name = "Grunge Skater Jeans", Sku = "AWMGSJ", Price = 68, IsAvaliable = true },
                new Product { Id = 2, CategoryID = 1, Name = "Polo Shirt", Sku = "AWMPS", Price = 35, IsAvaliable = true },
                new Product { Id = 3, CategoryID = 1, Name = "Skater Graphic T-Shirt", Sku = "AWMSGT", Price = 33, IsAvaliable = true },
                new Product { Id = 4, CategoryID = 1, Name = "Slicker Jacket", Sku = "AWMSJ", Price = 125, IsAvaliable = true },
                new Product { Id = 5, CategoryID = 1, Name = "Thermal Fleece Jacket", Sku = "AWMTFJ", Price = 60, IsAvaliable = true },
                new Product { Id = 6, CategoryID = 1, Name = "Unisex Thermal Vest", Sku = "AWMUTV", Price = 95, IsAvaliable = true },
                new Product { Id = 7, CategoryID = 1, Name = "V-Neck Pullover", Sku = "AWMVNP", Price = 65, IsAvaliable = true },
                new Product { Id = 8, CategoryID = 1, Name = "V-Neck Sweater", Sku = "AWMVNS", Price = 65, IsAvaliable = true },
                new Product { Id = 9, CategoryID = 1, Name = "V-Neck T-Shirt", Sku = "AWMVNT", Price = 17, IsAvaliable = true },

                new Product { Id = 10, CategoryID = 2, Name = "Bamboo Thermal Ski Coat", Sku = "AWWBTSC", Price = 99, IsAvaliable = true },
                new Product { Id = 11, CategoryID = 2, Name = "Cross-Back Training Tank", Sku = "AWWCTT", Price = 0, IsAvaliable = false },
                new Product { Id = 12, CategoryID = 2, Name = "Grunge Skater Jeans", Sku = "AWWGSJ", Price = 68, IsAvaliable = true },
                new Product { Id = 13, CategoryID = 2, Name = "Slicker Jacket", Sku = "AWWSJ", Price = 125, IsAvaliable = true },
                new Product { Id = 14, CategoryID = 2, Name = "Stretchy Dance Pants", Sku = "AWWSDP", Price = 55, IsAvaliable = true },
                new Product { Id = 15, CategoryID = 2, Name = "Ultra-Soft Tank Top", Sku = "AWWUTT", Price = 22, IsAvaliable = true },
                new Product { Id = 16, CategoryID = 2, Name = "Unisex Thermal Vest", Sku = "AWWUTV", Price = 95, IsAvaliable = true },
                new Product { Id = 17, CategoryID = 2, Name = "V-Next T-Shirt", Sku = "AWWVNT", Price = 17, IsAvaliable = true },

                new Product { Id = 18, CategoryID = 3, Name = "Blueberry Mineral Water", Sku = "MWB", Price = 2.8M, IsAvaliable = true },
                new Product { Id = 19, CategoryID = 3, Name = "Lemon-Lime Mineral Water", Sku = "MWLL", Price = 2.8M, IsAvaliable = true },
                new Product { Id = 20, CategoryID = 3, Name = "Orange Mineral Water", Sku = "MWO", Price = 2.8M, IsAvaliable = true },
                new Product { Id = 21, CategoryID = 3, Name = "Peach Mineral Water", Sku = "MWP", Price = 2.8M, IsAvaliable = true },
                new Product { Id = 22, CategoryID = 3, Name = "Raspberry Mineral Water", Sku = "MWR", Price = 2.8M, IsAvaliable = true },
                new Product { Id = 23, CategoryID = 3, Name = "Strawberry Mineral Water", Sku = "MWS", Price = 2.8M, IsAvaliable = true },

                new Product { Id = 24, CategoryID = 4, Name = "In the Kitchen with H+ Sport", Sku = "PITK", Price = 24.99M, IsAvaliable = true },

                new Product { Id = 25, CategoryID = 5, Name = "Calcium 400 IU (150 tablets)", Sku = "SC400", Price = 9.99M, IsAvaliable = true },
                new Product { Id = 26, CategoryID = 5, Name = "Flaxseed Oil 100 mg (90 capsules)", Sku = "SFO100", Price = 12.49M, IsAvaliable = true },
                new Product { Id = 27, CategoryID = 5, Name = "Iron 65 mg (150 caplets)", Sku = "SI65", Price = 13.99M, IsAvaliable = true },
                new Product { Id = 28, CategoryID = 5, Name = "Magnesium 250 mg (100 tablets)", Sku = "SM250", Price = 12.49M, IsAvaliable = true },
                new Product { Id = 29, CategoryID = 5, Name = "Multi-Vitamin (90 capsules)", Sku = "SMV", Price = 9.99M, IsAvaliable = true },
                new Product { Id = 30, CategoryID = 5, Name = "Vitamin A 10,000 IU (125 caplets)", Sku = "SVA", Price = 11.99M, IsAvaliable = true },
                new Product { Id = 31, CategoryID = 5, Name = "Vitamin B-Complex (100 caplets)", Sku = "SVB", Price = 12.99M, IsAvaliable = true },
                new Product { Id = 32, CategoryID = 5, Name = "Vitamin C 1000 mg (100 tablets)", Sku = "SVC", Price = 9.99M, IsAvaliable = true },
                new Product { Id = 33, CategoryID = 5, Name = "Vitamin D3 1000 IU (100 tablets)", Sku = "SVD3", Price = 12.49M, IsAvaliable = true });
        }
    }
}
