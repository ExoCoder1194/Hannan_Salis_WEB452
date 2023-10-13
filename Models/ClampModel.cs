using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CLAMP_Assignment1.Models
{
    public class Clamp
    {
        public int Id { get; set; }
        public string Material { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public double MaximumOpeningWidth { get; set; }
        public int LoadCapacity { get; set; }
        public decimal Price { get; set; }
        public int CustomerReview { get; set; }
    }

    public class ClampContext : DbContext
    {
        public ClampContext(DbContextOptions<ClampContext> options) : base(options) { }

        public DbSet<Clamp> Clamps { get; set; }
    }

    public class ClampContextFactory : IDesignTimeDbContextFactory<ClampContext>
    {
        public ClampContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ClampContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-CLAMP_Assignment1-BEDC1C97-EBFE-46C8-B024-DE4118C8994E;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new ClampContext(optionsBuilder.Options);
        }
    }
}
