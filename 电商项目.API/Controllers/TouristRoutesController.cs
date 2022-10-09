using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;
using 电商项目.API.DataBase;
using 电商项目.API.Dtos;
using 电商项目.API.ResourceParameters;
using 电商项目.API.Services;

namespace 电商项目.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristRoutesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITouristRouteRespository _touristRouteRespository;

        public TouristRoutesController(ITouristRouteRespository touristRouteRespository, IMapper mapper)
        {
            _mapper = mapper
                ?? throw new NotImplementedException(nameof(IMapper));

            _touristRouteRespository = touristRouteRespository
                ?? throw new NotImplementedException(nameof(ITouristRouteRespository));
        }

        [HttpGet]
        [Route("GetTouristRoutes")]
        public IActionResult GetTouristRoutes([FromQuery] TouristRouteResourceParamaters paramaters)
        {
            var touristRoutesFromRepo = _touristRouteRespository.GetTouristRoutes(
                paramaters.Keyword, paramaters.RatingOperator, paramaters.RatingValue ?? 0);

            if (!touristRoutesFromRepo.Any())
            {
                return this.NotFound("没有旅游路线");
            }

            var touristRoutesDto = _mapper.Map<IEnumerable<TouristRouteDto>>(touristRoutesFromRepo);

            return this.Ok(touristRoutesDto);
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

            var touristRouteDto = _mapper.Map<TouristRouteDto>(touristRouteFromRepo);

            return this.Ok(touristRouteDto);
        }
    }
}
