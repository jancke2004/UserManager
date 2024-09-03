using Microsoft.EntityFrameworkCore;
using UserManager.Repository.Entities; // Ensure this namespace is correct

namespace UserManager.Repository
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        // Additional DbSet properties

        // Optionally, override OnModelCreating for further configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Fluent API configurations can go here
        }
    }
}
