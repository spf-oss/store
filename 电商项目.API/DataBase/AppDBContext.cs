using Microsoft.EntityFrameworkCore;
using 电商项目.API.Moldes;

namespace 电商项目.API.DataBase
{
    public class AppDBContext : DbContext
    {
#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        {
        }

        public DbSet<TouristRoute> TouristRoutes { get; set; }

        public DbSet <TouristRoutePicture> TouristRoutePictures { get; set; }
    }
}
