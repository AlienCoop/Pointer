using Microsoft.EntityFrameworkCore;
using Pointer.Models;

namespace Pointer.Interfaces
{
    public interface IMainDbContext
    {
        DbSet<Point> Points { get; set; }
        DbSet<ColorOfPoint> Colors { get; set; }

        //ColorOfPoint<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
