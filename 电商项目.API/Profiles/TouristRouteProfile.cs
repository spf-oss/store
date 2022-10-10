using AutoMapper;
using 电商项目.API.Dtos;
using 电商项目.API.Moldes;

namespace 电商项目.API.Profiles
{
    public class TouristRouteProfile : Profile
    {
        public TouristRouteProfile()
        {
            _ = this.CreateMap<TouristRoute, TouristRouteDto>()
                .ForMember(
                    dest => dest.Price,
                    opt => opt.MapFrom(
                        src => src.OriginaPrice * (decimal)(src.DiscountPresent ?? 1)
                    )
                )
                .ForMember(
                    dest => dest.TravelDays,
                    opt => opt.MapFrom(
                        src => src.TravelDays.ToString()
                    )
                )
                .ForMember(
                    dest => dest.TripType,
                    opt => opt.MapFrom(
                        src => src.TripType.ToString()
                    )
                )
                .ForMember(
                    dest => dest.DeparTureCity,
                    opt => opt.MapFrom(
                        src => src.DeparTureCity.ToString()
                    )
                );

            _ = this.CreateMap<TouristRouteForCreationDto, TouristRoute>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => Guid.NewGuid())
                );
        }
    }
}
