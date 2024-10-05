using AutoMapper;
using BEPWay.Interfaces;
using BEPWay.Models.Domain;
using BEPWay.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BEPWay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IUserRepository repo;

        public UserController(IMapper mapper, IUserRepository repo) 
        {
            this.mapper = mapper;
            this.repo = repo;
        }
        [HttpPost]
        public async Task<IActionResult> Signup([FromBody]UserDTO user)
        {
            var userModel = mapper.Map<User>(user);
            var response = await repo.AddAsync(userModel);
            if(response == null)
            {
                return BadRequest("Error occured");
            }
            return Ok("Created successfully");
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody]LoginDTO user)
        {
            var userModel = new User()
            {
                UserName = user.Username,
                Password = user.Password
            };
            var response = await repo.LoginAsync(userModel);
            if(response == null)
            {
                return BadRequest("Incorrect! Username or Password");
            }
            return Ok(response);
        }

        [HttpPost]
        [Route("payment")]
        public async Task<IActionResult> Payment([FromBody] LoginDTO user)
        {
            var userModel = new User()
            {
                UserName = user.Username,
                Password = user.Password
            };
            var response = await repo.LoginAsync(userModel);
            if (response == null)
            {
                return BadRequest("Incorrect! Username or Password");
            }
            return Ok(response);
        }
    }
}
