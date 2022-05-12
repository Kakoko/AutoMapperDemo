using AutomapperDemo.API.Entities;

namespace AutomapperDemo.API.Services
{
    public class UserRepository : IUserRepository
    {
        public static List<User> users = new List<User>()
        {
            new User { Id = new Guid("45408c64-1af9-4ea4-a9e0-f835b13d980b") , DateOfBirth = Convert.ToDateTime("01/01/1990") ,
            Email = "test@test.com" , FirstName = "Jane" , LastName = "Doe",
            Password = "testPassword"},
            new User { Id = new Guid("804b906d-c6bc-4e58-b454-f3ce7cf7c3f1") , DateOfBirth = Convert.ToDateTime("06/07/1978") ,
            Email = "test@test.com" , FirstName = "John" , LastName = "Doe",
            Password = "testPassword2"},
            new User { Id = new Guid("8335de6c-e315-492d-82b3-18f07aa150a9") , DateOfBirth = Convert.ToDateTime("07/05/2005") ,
            Email = "test@test.com" , FirstName = "Max" , LastName = "Doe",
            Password = "testPassword3"}
        };
        public User CreateUser(User user)
        {
            user.Id = Guid.NewGuid();
            users.Add(user);
            return user;
        }

        public List<User> GetAllUser()
        {
            return users;
        }

        public User GetUserById(Guid guid)
        {
            var user = users.FirstOrDefault(u => u.Id == guid);
            return user;
        }
    }
}
