using JuanApp.Models;
using Microsoft.EntityFrameworkCore;

namespace JuanApp.Data
{
    public class JuanAppDbContext : DbContext
    {
        public JuanAppDbContext(DbContextOptions<JuanAppDbContext> options) : base(options)
        {
        }
        public DbSet<Slider> Sliders { get; set; }
    }
}
