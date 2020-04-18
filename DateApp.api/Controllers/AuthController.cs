using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using DateApp.api.Data;
using DateApp.api.Dtos;
using DateApp.api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace DateApp.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController:ControllerBase
    {
        private readonly IAuthRepository _repo;
        private readonly IConfiguration _config;

        public AuthController(IAuthRepository repo,IConfiguration config)
        {
            this._repo = repo;
            this._config = config;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserForRegisterDTO userForRegisterDTO)
        {
            userForRegisterDTO.Username   =userForRegisterDTO.Username.ToLower();
            if(await _repo.UserExists(userForRegisterDTO.Username))
            {
                return BadRequest("UserName already exists");
            }

            var userToCreate=new User
            {
            UserName=userForRegisterDTO.Username
            };
            var createdUser=await _repo.Register(userToCreate,userForRegisterDTO.Password);

            return StatusCode(201);
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserForLoginDTO userForLoginDTO)
        {
            throw new Exception("Computer Says no");
           var userFromRepo=await _repo.Login(userForLoginDTO.Username,userForLoginDTO.Password);
           if(userFromRepo==null)
           {
               return Unauthorized();
           }

        var claims=new []
        {
        new Claim(ClaimTypes.NameIdentifier,userFromRepo.Id.ToString())
        ,new Claim(ClaimTypes.Name,userFromRepo.UserName)

        };
        var key=new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));
        var creds=new SigningCredentials(key,SecurityAlgorithms.HmacSha512Signature);
        var tokenDescriptor=new SecurityTokenDescriptor
        {
            Subject=new ClaimsIdentity(claims),
            Expires=DateTime.Now.AddDays(1),
            SigningCredentials=creds
        };

        var tokenHandler=new JwtSecurityTokenHandler();
        var token=tokenHandler.CreateToken(tokenDescriptor);
        return Ok(new {
            token=tokenHandler.WriteToken(token)
        });

    
        }

    }
}