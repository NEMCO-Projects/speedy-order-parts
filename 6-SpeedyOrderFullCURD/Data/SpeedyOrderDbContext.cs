using Microsoft.EntityFrameworkCore;
using SpeedyOrderPages.Models;

namespace SpeedyOrderPages.Data
{
    public class SpeedyOrderDbContext : DbContext
    {
        public SpeedyOrderDbContext(DbContextOptions<SpeedyOrderDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
    }
}
