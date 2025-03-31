using Microsoft.EntityFrameworkCore;
using BlogSite.Entities;

namespace BlogSite.DataAccess.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "admin", PasswordHash = "123456", Role = "Admin" }
            );
        }
    }
}
