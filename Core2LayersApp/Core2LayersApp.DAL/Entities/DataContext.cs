using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Core2LayersApp.DAL.Entities
{
    class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
           : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                .HasKey(t => new { t.ProductId, t.CategoryId });

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pt => pt.Product)
                .WithMany(p => p.ProductCategories)
                .HasForeignKey(pt => pt.ProductId);

            modelBuilder.Entity<ProductCategory>()
                .HasOne(pt => pt.Category)
                .WithMany(t => t.ProductCategories)
                .HasForeignKey(pt => pt.CategoryId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=relationdb;Trusted_Connection=True;");

        }
        public DbSet<Type> Types { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }      
    }
}
