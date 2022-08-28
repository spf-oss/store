using Microsoft.EntityFrameworkCore;
using 电商项目.API.Moldes;

namespace 电商项目.API.DataBase
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<TouristRoute>? TouristRoutes { get; set; }

        public DbSet <TouristRoutePicture>? TouristRoutePictures { get; set; }
    }
}
