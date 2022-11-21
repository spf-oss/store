using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Reflection;
using 电商项目.API.Moldes;

namespace 电商项目.API.DataBase
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<TouristRoute> TouristRoutes { get; set; }

        public DbSet <TouristRoutePicture> TouristRoutePictures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var touristRouteJsonPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                + "/DataBase/touristRoutesMockData.json";

            var touristRouteData = File.ReadAllText(touristRouteJsonPath);

            var touristRoutes = JsonConvert.DeserializeObject<List<TouristRoute>>(touristRouteData);

            _ = modelBuilder.Entity<TouristRoute>().HasData(touristRoutes!);


            var touristRoutePicturePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                + "/DataBase/touristRoutePicturesMockData.json";

            var touristRoutePictureData = File.ReadAllText(touristRoutePicturePath);

            var touristRoutePictures = JsonConvert.DeserializeObject<List<TouristRoutePicture>>(touristRoutePictureData);

            _ = modelBuilder.Entity<TouristRoutePicture>().HasData(touristRoutePictures!);

            base.OnModelCreating(modelBuilder);
        }
    }
}
