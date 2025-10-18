using foodboxd_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace foodboxd_backend.Data
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredient { get; set; }
        public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Favorite>()
        .HasKey(tb => new { tb.UserId, tb.DishId });

        modelBuilder.Entity<RecipeIngredient>()
        .HasKey(tb => new { tb.RecipeId, tb.IngredientId });

        modelBuilder.Entity<User>()
        .Property(tb => tb.CreatedAt)
        .HasColumnType("datetime")
        .HasDefaultValueSql("NOW()");

        modelBuilder.Entity<Publication>()
        .Property(tb => tb.CreatedAt)
        .HasColumnType("datetime")
        .HasDefaultValueSql("NOW()");

        modelBuilder.Entity<Rating>()
        .Property(tb => tb.CreatedAt)
        .HasColumnType("datetime")
        .HasDefaultValueSql("NOW()");

        modelBuilder.Entity<Dish>()
        .Property(tb => tb.Description)
        .HasColumnType("TEXT");

        modelBuilder.Entity<Dish>()
        .Property(tb => tb.Photo)
        .HasColumnType("LONGBLOB");

        base.OnModelCreating(modelBuilder);
    }

    }
}