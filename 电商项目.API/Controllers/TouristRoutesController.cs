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
            var routs = _touristRouteRespository.GetTouristRoutes();

            return this.Ok(routs);
        }

        [HttpGet]
        [Route("GetTouristRoute")]
        public IActionResult GetTouristRoute(Guid Id)
        {
            var rout = _touristRouteRespository.GetTouristRoute(Id);

            return this.Ok(rout);
        }
    }
}
