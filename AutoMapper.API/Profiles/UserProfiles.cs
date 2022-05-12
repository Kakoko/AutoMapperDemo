namespace AutoMapper.API.Profiles
{
    public class UserProfiles : Profile
    {
        public UserProfiles()
        {
            // Destination to Source
            CreateMap<Dto.UserReadDto, Entities.User>();
            
        }
    }
}
