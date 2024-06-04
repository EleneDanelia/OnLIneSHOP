using Microsoft.EntityFrameworkCore;
using OnLIneSHOP.Models.Base;

namespace OnLIneSHOP.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Brand> brands { get; set; }

        public DbSet<Item> items { get; set; }  
        public DbSet<User> users { get; set; }
        public DbSet<Review> reviews { get; set; }
    }
}
