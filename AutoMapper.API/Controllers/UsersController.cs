using AutoMapper.API.Entities;
using AutoMapper.API.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoMapper.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return Ok(_userRepository.GetAllUser());
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(Guid id)
        {
            return Ok(_userRepository.GetUserById(id));
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult<User> Post(User user)
        {
            return Ok(_userRepository.CreateUser(user));
        }

        
    }
}
