using 电商项目.API.Moldes;

namespace 电商项目.API.Services
{
    /// <summary>
    /// 旅游路线仓储
    /// </summary>
    public interface ITouristRouteRespository
    {
        IEnumerable<TouristRoute> GetTouristRoutes();

        TouristRoute? GetTouristRoute(Guid id);
    }
}
