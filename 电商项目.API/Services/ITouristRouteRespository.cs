﻿using 电商项目.API.Moldes;

namespace 电商项目.API.Services
{
    /// <summary>
    /// 旅游路线仓储
    /// </summary>
    public interface ITouristRouteRespository
    {
        IEnumerable<TouristRoute> GetTouristRoutes(string keyword);

        TouristRoute? GetTouristRoute(Guid id);

        bool TouristRoutesExists(Guid touristId);

        IEnumerable<TouristRoutePicture> GetPicturesByTouristRouteId(Guid touristRouteId);

        TouristRoutePicture? GetPicture(int pictureId);
    }
}
