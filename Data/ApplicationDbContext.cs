
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Model.DB;


namespace ShoppingCart.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<LoginHistory> LoginHistory { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { }
    }
}
