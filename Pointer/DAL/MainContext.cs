using Microsoft.EntityFrameworkCore;
using Pointer.Interfaces;
using Pointer.Models;


namespace Pointer.DAL
{
    public class MainContext : DbContext, IMainDbContext 
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {
        }

        public virtual DbSet<Point> Points { get; set; }
        public virtual DbSet<ColorOfPoint> Colors { get; set; }

    }
}
