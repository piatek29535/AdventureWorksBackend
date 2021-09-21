using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorksBackend.Model
{
    public class CategoriesContext : DbContext
    {

        public static readonly string DefaultSchema = "SalesLT";
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public CategoriesContext(DbContextOptions<CategoriesContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(DefaultSchema);
        }
    }
}
