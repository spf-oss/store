using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
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

        public IEnumerable<TouristRoute> GetTouristRoutes(string keyword, string operatorType, int raringVlaue)
        {
            //Include vs Join 数据表连接
            IQueryable<TouristRoute> result = _context.TouristRoutes
                .Include(t => t.TouristRoutePictures);

            if (!String.IsNullOrWhiteSpace(keyword))
            {
                keyword = keyword.Trim();

                result = result.Where(t => t.Title.Contains(keyword));
            }
            if (raringVlaue >= 0)
            {
                result = operatorType switch
                {
                    "largerThan" => result.Where(t => t.Rating >= raringVlaue),
                    "lessThan" => result.Where(t => t.Rating <= raringVlaue),
                    _ => result.Where(t => t.Rating == raringVlaue),
                };
            }
            return result.ToList();
        }
        public bool TouristRoutesExists(Guid touristId)
        {
            return _context.TouristRoutes.Any(m => m.Id == touristId);
        }

        public bool Save()
        {
            return _context.SaveChanges() >= 0;
        }

        public void AddTouristRoute(TouristRoute touristRoute)
        {
            if (touristRoute == null)
            {
                throw new ArgumentNullException(nameof(touristRoute));
            }
            _ = _context.TouristRoutes.Add(touristRoute);
        }
    }
}
