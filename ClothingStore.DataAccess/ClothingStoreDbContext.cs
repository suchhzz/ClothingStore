using ClothingStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.DataAccess
{
    public class ClothingStoreDbContext : DbContext
    {
        public ClothingStoreDbContext(DbContextOptions<ClothingStoreDbContext> options) : base (options)
        {
            
        }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ColorEntity> Colors { get; set; }
        public DbSet<SizeEntity> Sizes { get; set; }
        public DbSet<QualityEntity> Qualities { get; set; }
        public DbSet<ImageEntity> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ColorEntity>()
                .HasMany(c => c.Products)
                .WithMany(p => p.Colors);

            modelBuilder.Entity<SizeEntity>()
                .HasMany(s => s.Products)
                .WithMany(p => p.Sizes);

            modelBuilder.Entity<QualityEntity>()
                .HasMany(q => q.Products)
                .WithMany(p => p.Qualities);

            modelBuilder.Entity<ImageEntity>()
                .HasOne(i => i.Product)
                .WithMany(p => p.Images)
                .HasForeignKey(i => i.ProductId);
        }

    }
}
