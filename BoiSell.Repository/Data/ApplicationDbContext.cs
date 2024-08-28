using BoiSell.Core.Enums;
using BoiSell.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace BoiSell.Web.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Self Help" },
                new Category { Id = 2, Name = "History" },
                new Category { Id = 3, Name = "Education" },
                new Category { Id = 4, Name = "Horror" },
                new Category { Id = 5, Name = "Business" },
                new Category { Id = 6, Name = "Home & Garden" },
                new Category { Id = 7, Name = "Health & Fitness" },
                new Category { Id = 8, Name = "Medical & Nursing" },
                new Category { Id = 9, Name = "Mystery & Thrillers" },
                new Category { Id = 10, Name = "Poetry" },
                new Category { Id = 11, Name = "Religion" },
                new Category { Id = 12, Name = "Science Fiction" },
                new Category { Id = 13, Name = "Computer & Technology" },
                new Category { Id = 14, Name = "Sports & Recreation" },
                new Category { Id = 15, Name = "Travel" }
            );



            builder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Status).HasConversion<string>();

                // Seed books
                entity.HasData(
                    new Book
                    {
                        Id = 1,
                        Title = "Atomic Habits",
                        Author = "James Clear",
                        ISBN = Guid.NewGuid().ToString(),
                        Description = "Tiny Changes, Remarkable Results.No matter your goals, Atomic Habits offers a proven framework for improving--every day. James Clear, one of the world's leading experts on habit formation, reveals practical strategies that will teach you exactly how to form good habits, break bad ones, and master the tiny behaviors that lead to remarkable results.",
                        Price = 1000,
                        Discount = 5,
                        SpecialTag = "Classic",
                        Publisher = "Scribner",
                        PublishedDate = new DateOnly(1925, 4, 10),
                        Pages = 180,
                        Language = "English",
                        CategoryId = 1,
                        ImageUrl = "/images/books/AtomicHabits.jpg",
                        Status = BookStatus.Available,
                        CreatedAt = DateTime.Now
                    },
                    new Book
                    {
                        Id = 2,
                        Title = "Sapiens: A Brief History of Humankind",
                        Author = "Yuval Noah Harari",
                        ISBN = Guid.NewGuid().ToString(),
                        Description = "A look at the history and impact of Homo sapiens.The book, focusing on Homo sapiens, surveys the history of humankind, starting from the Stone Age and going up to the twenty-first century.",
                        Price = 300,
                        Discount = 0,
                        SpecialTag = "Bestseller",
                        Publisher = "Harvill Secker",
                        PublishedDate = new DateOnly(2011, 9, 4),
                        Pages = 443,
                        Language = "English",
                        CategoryId = 2,
                        ImageUrl = "/images/books/BlueChristanity.jpg",
                        Status = BookStatus.Available,
                        CreatedAt = DateTime.Now
                    },
                    new Book
                    {
                        Id = 3,
                        Title = "A Brief History of Time",
                        Author = "Stephen Hawking",
                        ISBN = Guid.NewGuid().ToString(),
                        Description = "A landmark book in cosmology.A simple summary of A Brief History of Time goes all the way from the beginning of the universe to its end, explaining things like space and time, the expanding universe, the uncertainty principle, black holes, wormholes, and time travel along the way. It sold over 25 million copies.",
                        Price = 120,
                        Discount = 10,
                        SpecialTag = "Science",
                        Publisher = "Bantam Books",
                        PublishedDate = new DateOnly(1988, 3, 1),
                        Pages = 212,
                        Language = "English",
                        CategoryId = 3,
                        ImageUrl = "/images/books/Celopatra.jpg",
                        Status = BookStatus.Available,
                        CreatedAt = DateTime.Now
                    },
                    new Book
                    {
                        Id = 4,
                        Title = "Twilight",
                        Author = "Stephenie Meyer",
                        ISBN = Guid.NewGuid().ToString(),
                        Description = "A vampire romance novel.Twilight is a captivating novel by Stephenie Meyer. Set in the small town of Forks, it tells the story of Bella, a teenager who falls in love with a vampire named Edward. Their unconventional relationship unfolds in a world where love and danger collide.",
                        Price = 900,
                        Discount = 0,
                        SpecialTag = "Popular",
                        Publisher = "Little, Brown and Company",
                        PublishedDate = new DateOnly(2005, 10, 5),
                        Pages = 498,
                        Language = "English",
                        CategoryId = 4,
                        ImageUrl = "/images/books/twilight.jpg",
                        Status = BookStatus.Available,
                        CreatedAt = DateTime.Now
                    }
                );
            });
        }
    }
}
