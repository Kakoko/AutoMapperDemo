using AutoMapper.API.Entities;

namespace AutoMapper.API.Services
{
    public interface IUserRepository
    {
        User CreateUser(User user);
        List<User> GetAllUser();
        User GetUserById(Guid guid);
    }
}
