using 电商项目.API.Moldes;

namespace 电商项目.API.Services
{
    public class TouristRouteRespository : ITouristRouteRespository
    {
        private readonly List<TouristRoute> _routes;

        public TouristRouteRespository()
        {
            _routes = new List<TouristRoute>();

            this.Initialization();
        }

        public TouristRoute? GetTouristRoute(Guid id)
        {
            return _routes.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            return _routes;
        }

        private void Initialization()
        {
            _routes.Add(new TouristRoute()
            {
                Id = Guid.NewGuid(),
                Title = "武功山",
                Description = "武功山好玩",
                Fees = "不怎么花钱",
                OriginaPrice = 1000,
                DiscountPresent = 0.8,
                CreateTime = DateTime.Now,
            });

            _routes.Add(new TouristRoute()
            {
                Id = Guid.NewGuid(),
                Title = "武功山",
                Description = "武功山好玩",
                Fees = "不怎么花钱",
                OriginaPrice = 1000,
                DiscountPresent = 0.8,
                CreateTime = DateTime.Now,
            });
        }
    }
}
