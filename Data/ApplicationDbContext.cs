using Microsoft.EntityFrameworkCore;
using CarAssetApp.Models;

namespace CarAssetApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Asset> Assets { get; set; }
    }
}
