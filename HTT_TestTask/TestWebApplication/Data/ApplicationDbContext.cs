using TestWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace TestWebApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ApplicationDbContext() 
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

		public ApplicationDbContext(DbContextOptions options) : base (options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
					new Category { CategoryId = 1, Name = "Напитки" },
					new Category { CategoryId = 2, Name = "Телефоны"},
					new Category { CategoryId = 3, Name = "Еда"}
				);

			modelBuilder.Entity<Product>().HasData(
                    new Product { ProductId = 1, CategoryId = 1, Name = "Молоко", Price = 68 },
					new Product { ProductId = 2, CategoryId = 1, Name = "Fanta", Price = 77 },
					new Product { ProductId = 3, CategoryId = 1, Name = "Sprite", Price = 81 },
					new Product { ProductId = 4, CategoryId = 1, Name = "Вода", Price = 22 }
				);
			modelBuilder.Entity<Product>().HasData(
					new Product { ProductId = 5, CategoryId = 2, Name = "iPhone X", Price = 110450 },
					new Product { ProductId = 6, CategoryId = 2, Name = "Samsung 11", Price = 108600 },
					new Product { ProductId = 7, CategoryId = 2, Name = "Redmi 9 ", Price = 38201 }
				);

			modelBuilder.Entity<Product>().HasData(
					new Product { ProductId = 8, CategoryId = 3, Name = "Свинина", Price = 385 },
					new Product { ProductId = 9, CategoryId = 3, Name = "Курица", Price = 244 },
					new Product { ProductId = 10, CategoryId = 3, Name = "Хлеб", Price = 52 }
				);

		}
	}
}
