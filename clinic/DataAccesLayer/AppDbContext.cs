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
        public DbSet<Project> Projects { get; set; }
        public DbSet<Category> Categories { get; set; }
        
    }
}
