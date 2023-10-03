using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Contexts
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        { }
        public DbSet<DrillBlock> DrillBlock { get; set; }
        public DbSet<DrillBlockPoints> DrillBlockPoints { get; set; }
        public DbSet<Hole> Hole { get; set; }




    }

}

