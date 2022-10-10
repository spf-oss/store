using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using 电商项目.API.Dtos;
using 电商项目.API.Moldes;
using 电商项目.API.Services;

namespace 电商项目.API.Controllers
{
    [ApiController]
    public class TourisRoutePicturesController : ControllerBase
    {
        private readonly ITouristRouteRespository _tourist;
        private readonly IMapper _mapper;

        public TourisRoutePicturesController(ITouristRouteRespository tourist, IMapper mapper)
        {
            _tourist = tourist ?? throw new ArgumentNullException(nameof(tourist));

            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        [Route("api/RoutePictures/{tourisRouteId}")]
        public IActionResult GetPictureListForTourisRoute(Guid tourisRouteId)
        {
            if (!_tourist.TouristRoutesExists(tourisRouteId))
            {
                return this.NotFound("旅游线路不存在");
            }

            var picturesFromRepo = _tourist.GetPicturesByTouristRouteId(tourisRouteId);

            if (picturesFromRepo == null || !picturesFromRepo.Any())
            {
                return this.NotFound("照片不存在");
            }

            return this.Ok(_mapper.Map<IEnumerable<TourisRoutePicturesDto>>(picturesFromRepo));
        }

        [HttpGet]
        [Route("api/RoutePictures/{tourisRouteId}/{pictureId}")]
        public IActionResult GetPicture(Guid tourisRouteId, int pictureId)
        {
            if (!_tourist.TouristRoutesExists(tourisRouteId))
            {
                return this.NotFound("旅游线路不存在");
            }

            var pictureRepo = _tourist.GetPicture(pictureId);

            if (pictureRepo == null)
            {
                return this.NotFound("图片不存在");
            }

            return this.Ok(_mapper.Map<TourisRoutePicturesDto>(pictureRepo));
        }

        public IActionResult CreateTouristRoute([FromBody] TouristRouteForCreationDto touristRouteForCreationDto)
        {
            var touristRouteModel = _mapper.Map<TouristRoute>(touristRouteForCreationDto);

            _tourist.AddTouristRoute(touristRouteModel);

            _ = _tourist.Save();

            var touristRouteToReture = _mapper.Map<TouristRouteDto>(touristRouteModel);

            return this.CreatedAtRoute(
                "GetTouristRouteById",
                new { touristRouteId = touristRouteToReture.Id },
                touristRouteToReture
            );
        }
    }
}
