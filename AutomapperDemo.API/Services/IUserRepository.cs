using AutomapperDemo.API.Entities;

namespace AutomapperDemo.API.Services
{
    public interface IUserRepository
    {
        User CreateUser(User user);
        List<User> GetAllUser();
        User GetUserById(Guid guid);
    }
}
