using JuanApp.Models;
using Microsoft.EntityFrameworkCore;

namespace JuanApp.Data
{
    public class JuanAppDbContext : DbContext
    {
        public JuanAppDbContext(DbContextOptions<JuanAppDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slider> Sliders { get; set; }
    }
}
