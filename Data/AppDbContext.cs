using foodboxd_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace foodboxd_backend.Data
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions options) : base(options) {}

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredient { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<RatingLike> RatingLikes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Favorite>()
            .HasKey(tb => new { tb.UserId, tb.DishId });

            modelBuilder.Entity<RecipeIngredient>()
            .HasKey(tb => new { tb.RecipeId, tb.IngredientId });

            modelBuilder.Entity<RatingLike>()
                .HasKey(rl => new { rl.UserId, rl.RatingId });

            modelBuilder.Entity<RatingLike>()
                .HasOne(rl => rl.User)
                .WithMany(u => u.RatingLikes)
                .HasForeignKey(rl => rl.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<RatingLike>()
                .HasOne(rl => rl.Rating)
                .WithMany(r => r.Likes)
                .HasForeignKey(rl => rl.RatingId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
            .Property(tb => tb.CreatedAt)
            .HasColumnType("datetime")
            .HasDefaultValueSql("NOW()");

            modelBuilder.Entity<Rating>()
            .Property(tb => tb.CreatedAt)
            .HasColumnType("datetime")
            .HasDefaultValueSql("NOW()");

            modelBuilder.Entity<Rating>()
            .Property(tb => tb.Comment)
            .HasColumnType("LONGTEXT");

            modelBuilder.Entity<Dish>()
            .Property(tb => tb.Description)
            .HasColumnType("TEXT");

            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }
    }
}