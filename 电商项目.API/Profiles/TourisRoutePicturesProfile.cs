using AutoMapper;
using 电商项目.API.Dtos;
using 电商项目.API.Moldes;

namespace 电商项目.API.Profiles
{
    public class TourisRoutePicturesProfile : Profile
    {
        public TourisRoutePicturesProfile()
        {
            _ = this.CreateMap<TouristRoutePicture, TourisRoutePicturesDto>();
        }
    }
}
