using AutoMapper;
using AutomapperDemo.API.DTO;
using AutomapperDemo.API.Entities;
using AutomapperDemo.API.Services;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutomapperDemo.API.Controllers
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
        public ActionResult<List<UserReadDto>> Get()
        {
            var usersFromRepository = _userRepository.GetAllUser();
            var usersReadDto = _mapper.Map<List<UserReadDto>>(usersFromRepository);
            return Ok(usersReadDto);
        }


        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public ActionResult<UserReadDto> Get(Guid id)
        {

            //return Ok(_userRepository.GetUserById(id));
            var user = _userRepository.GetUserById(id);

            var userReadDto = _mapper.Map<UserReadDto>(user);
            //var userReadDto = new UserReadDto()
            //{
            //    Email = user.Email,
            //    FullName = $"{user.FirstName} {user.LastName}",
            //    Age = HelperFunctions.HelperFunctions.GetCurrentAge(user.DateOfBirth)
            //};
            return Ok(userReadDto);
        }

        // POST api/<UsersController>
        [HttpPost]
        public ActionResult<UserReadDto> Post(UserCreateDto user)
        {
            var userToCreate = _mapper.Map<User>(user);
            var createdUser = _userRepository.CreateUser(userToCreate);


            return Ok(_mapper.Map<UserReadDto>(createdUser));
        }

        
    }
}
