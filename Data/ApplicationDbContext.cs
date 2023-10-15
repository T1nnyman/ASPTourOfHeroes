using Microsoft.EntityFrameworkCore;
using TourOfHeroes.Models;

namespace TourOfHeroes.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Hero> Heroes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Hero>().HasData(
                new Hero { HeroID = 12, Name = "Dr. Nice" },
                new Hero { HeroID = 13, Name = "Bombasto" },
                new Hero { HeroID = 14, Name = "Celeritas" },
                new Hero { HeroID = 15, Name = "Magneta" },
                new Hero { HeroID = 16, Name = "RubberMan" },
                new Hero { HeroID = 17, Name = "Dynama" },
                new Hero { HeroID = 18, Name = "Dr. IQ" },
                new Hero { HeroID = 19, Name = "Magma" },
                new Hero { HeroID = 20, Name = "Tornado" }
            );
        }
    }
}
