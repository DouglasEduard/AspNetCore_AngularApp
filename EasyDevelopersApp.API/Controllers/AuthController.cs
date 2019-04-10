using System.Threading.Tasks;
using EasyDevelopersApp.API.Data;
using EasyDevelopersApp.API.Dtos;
using EasyDevelopersApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EasyDevelopersApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class AuthController: ControllerBase
    {
       public IAuthRepository _repo { get; }

        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }   
        
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            //validate request

            userForRegisterDto.Username = userForRegisterDto.Username.ToLower();

            if (await _repo.UserExistis(userForRegisterDto.Username))
                return BadRequest("User name already exists");

            var UserToCreate = new User
            {
                UserName = userForRegisterDto.Username
            };

            var createdUser = await _repo.Register(UserToCreate, userForRegisterDto.Password);

            return StatusCode(201);            
        }
    }
}