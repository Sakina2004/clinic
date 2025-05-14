using clinic.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace clinic.DataAccesLayer
{
    public class AppDbContext:DbContext
    {
        
            public AppDbContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("salammmmlarrr");
                base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Category> Categories { get; set; }
        
    }
}
