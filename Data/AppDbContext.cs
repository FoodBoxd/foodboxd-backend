using foodboxd_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace foodboxd_backend.Data
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }

    }
}