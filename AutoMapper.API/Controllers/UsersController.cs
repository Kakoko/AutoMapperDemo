using AutoMapper.API.Dto;
using AutoMapper.API.Entities;
using AutoMapper.API.Helper;
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
        private readonly IMapper _mapper;

        public UsersController(IUserRepository userRepository , IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return Ok(_userRepository.GetAllUser());
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<UserReadDto> Get(Guid id)
        {
            var user = _userRepository.GetUserById(id);

            //var userDto = new UserReadDto()
            //{
            //    Email = user.Email,
            //    FullName = $"{user.FirstName} {user.LastName}",
            //    Age = HelperFunctions.GetCurrentAge(user.DateOfBirth)
            //};

            return Ok(_mapper.Map<UserReadDto>(user));
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult<User> Post(User user)
        {
            return Ok(_userRepository.CreateUser(user));
        }

        
    }
}
