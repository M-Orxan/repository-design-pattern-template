using Microsoft.EntityFrameworkCore;
using RepositoryDesignPatternExample.Models;

namespace RepositoryDesignPatternExample.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
