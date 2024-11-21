using Adam_Waleed_0522028_api.Model;
using Microsoft.EntityFrameworkCore;

namespace Adam_Waleed_0522028_api.Data
{
    public class AppdbContext : DbContext
    {
        public AppdbContext(DbContextOptions options) : base(options) { }
        public DbSet<Movies_M> movies_Ms { get; set; }
        public DbSet<Director_M> director_Ms { get; set; }
        public DbSet<Category_M> category_ms { get; set; }
        public DbSet<Nationality_M> nationality_ms { get; set; }
    }
}
