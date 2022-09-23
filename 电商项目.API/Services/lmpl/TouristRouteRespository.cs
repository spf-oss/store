using Microsoft.EntityFrameworkCore;
using 电商项目.API.DataBase;
using 电商项目.API.Moldes;

namespace 电商项目.API.Services
{
    public class TouristRouteRespository : ITouristRouteRespository
    {
        private readonly AppDBContext _context;

        public TouristRouteRespository(AppDBContext context)
        {
            _context = context 
                ?? throw new NotImplementedException(nameof(TouristRouteRespository));
        }

        public TouristRoutePicture? GetPicture(int pictureId)
        {
            return _context.TouristRoutePictures.FirstOrDefault(m => m.Id == pictureId);
        }

        public IEnumerable<TouristRoutePicture> GetPicturesByTouristRouteId(Guid touristRouteId)
        {
            return _context.TouristRoutePictures.Where(m => m.TouristRouteId == touristRouteId).ToList();
        }

        public TouristRoute? GetTouristRoute(Guid id)
        {
            return _context.TouristRoutes.Include(m => m.TouristRoutePictures).FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            //Include vs Join 数据表连接
            return _context.TouristRoutes.Include(t => t.TouristRoutePictures);
        }

        public bool TouristRoutesExists(Guid touristId)
        {
            return _context.TouristRoutes.Any(m => m.Id == touristId);
        }
    }
}
