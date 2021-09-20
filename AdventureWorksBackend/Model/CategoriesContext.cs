using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorksBackend.Model
{
    public class CategoriesContext : DbContext
    {
        public CategoriesContext(DbContextOptions<CategoriesContext> options) : base(options)
        {

        }
        public DbSet<Categories> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
