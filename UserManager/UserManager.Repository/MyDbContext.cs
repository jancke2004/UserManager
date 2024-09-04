using Microsoft.EntityFrameworkCore;
using UserManager.Repository.Entities; 

namespace UserManager.Repository
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        // DbSet properties

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // API Congifs
        }
    }
}
