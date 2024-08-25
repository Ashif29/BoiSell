using BoiSell.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BoiSell.Web.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Business" },
                new Category { Id = 2, Name = "Computer & Technology" },
                new Category { Id = 3, Name = "Education" },
                new Category { Id = 4, Name = "Health & Fitness" },
                new Category { Id = 5, Name = "History" },
                new Category { Id = 6, Name = "Home & Garden" },
                new Category { Id = 7, Name = "Horror" },
                new Category { Id = 8, Name = "Medical & Nursing" },
                new Category { Id = 9, Name = "Mystery & Thrillers" },
                new Category { Id = 10, Name = "Poetry" },
                new Category { Id = 11, Name = "Religion" },
                new Category { Id = 12, Name = "Science Fiction" },
                new Category { Id = 13, Name = "Self Help" },
                new Category { Id = 14, Name = "Sports & Recreation" },
                new Category { Id = 15, Name = "Travel" }
            );
        }
    }
}
