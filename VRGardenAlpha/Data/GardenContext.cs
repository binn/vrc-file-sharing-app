using Microsoft.EntityFrameworkCore;

namespace VRGardenAlpha.Data
{
    public class GardenContext : DbContext
    {
        public GardenContext(DbContextOptions<GardenContext> options) : base(options) { }
        
        public DbSet<Post> Posts { get; set; }
    }
}
