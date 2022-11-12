using Formula1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Formula1
{
    public class FormulaDbContext : IdentityDbContext<User>
    {
        public FormulaDbContext(DbContextOptions<FormulaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Constructor> Constructors { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Tyre> Tyres { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
