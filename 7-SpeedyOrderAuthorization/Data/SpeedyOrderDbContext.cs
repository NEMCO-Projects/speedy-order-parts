using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SpeedyOrderPages.Models;

namespace SpeedyOrderPages.Data
{
    public class SpeedyOrderDbContext : IdentityDbContext
    {
        public SpeedyOrderDbContext(DbContextOptions<SpeedyOrderDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
    }
}
