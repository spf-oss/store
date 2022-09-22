﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using 电商项目.API.Dtos;
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
    }
}
