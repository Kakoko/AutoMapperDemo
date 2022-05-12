using AutoMapper;
using AutomapperDemo.API.DTO;
using AutomapperDemo.API.Entities;
using AutomapperDemo.API.HelperFunctions;

namespace AutomapperDemo.API.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Source -> Destination
            CreateMap<User, UserReadDto>()
                .ForMember(
                    dest => dest.FullName,
                    opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(
                    dest => dest.Age,
                    opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge())
                    );

            CreateMap<UserCreateDto, User>();
        }
    }
}
