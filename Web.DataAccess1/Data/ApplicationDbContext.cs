using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.DataAccess1.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Tech Solution", Address="123 Tech St", City="Tech City", PostalCode="12121", Phone ="0512121", State="IL" },
                new Company { Id = 2, Name = "Link Solution", Address = "3 Link St", City = "Link City", PostalCode = "151321", Phone = "465421", State = "TL" },
                new Company { Id = 3, Name = "Tok Solution", Address = "387 Tok St", City = "Tok City", PostalCode = "789812", Phone = "456578", State = "HL" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "The Adventures of Tom Sawyer",
                    Author = "Mark Twain",
                    Description = "Orphan Tom Sawyer lives with his Aunt Polly and his half-brother Sid in the town of St. Petersburg," +
                " Missouri, sometime in the 1840s. He frequently skips school to play or go swimming.",
                    ISBN = "SWD9999901",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 2,
                    Title = "The Alchemist",
                    Author = "Paulo Coelho",
                    Description = "An Andalusian shepherd boy named Santiago dreams of a treasure while in a ruined church. " +
                    "He consults a Gypsy fortune-teller about the meaning of the recurring dream.",
                    ISBN = "STZ5156901",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 2,
                    ImageUrl = ""
                },
                new Product
                {
                    Id = 3,
                    Title = "The Clone",
                    Author = "Hacker",
                    Description = "An Andalusian shepherd boy named Santiago dreams of a treasure while in a ruined church. " +
                    "He consults a Gypsy fortune-teller about the meaning of the recurring dream.",
                    ISBN = "STZ5156901",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 3,
                    ImageUrl = ""
                });
        }
    }
}
