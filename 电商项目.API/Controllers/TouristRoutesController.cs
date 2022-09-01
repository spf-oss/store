using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using 电商项目.API.DataBase;
using 电商项目.API.Services;

namespace 电商项目.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristRoutesController : ControllerBase
    {
        private readonly ITouristRouteRespository _touristRouteRespository;

        public TouristRoutesController(ITouristRouteRespository touristRouteRespository)
        {
            _touristRouteRespository = touristRouteRespository
                ?? throw new NotImplementedException(nameof(ITouristRouteRespository));
        }

        [HttpGet]
        [Route("GetTouristRoutes")]
        public IActionResult GetTouristRoutes()
        {
            var touristRoutesFromRepo = _touristRouteRespository.GetTouristRoutes();

            if (!touristRoutesFromRepo.Any())
            {
                return this.NotFound("没有旅游路线");
            }

            return this.Ok(touristRoutesFromRepo);
        }

        [HttpGet]
        [Route("GetTouristRoute")]
        public IActionResult GetTouristRoute(Guid Id)
        {
            var touristRouteFromRepo = _touristRouteRespository.GetTouristRoute(Id);

            if (touristRouteFromRepo == null)
            {
                return this.NotFound("旅游路线:\"  " + Id + "   找不到");
            }

            return this.Ok(touristRouteFromRepo);
        }
    }
}
