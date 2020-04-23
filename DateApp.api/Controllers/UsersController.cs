using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DateApp.api.Data;
using DateApp.api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DateApp.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController:ControllerBase
    {
        private readonly IDatingRepository _repo;
        private readonly IMapper _mapper;

        public UsersController(IDatingRepository repo ,IMapper mapper)
        {
            this._repo = repo;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users= await _repo.GetUsers();
             var usersToReturn=_mapper.Map<IEnumerable<UserForListDTO>>(users);
            return Ok(usersToReturn);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user=await _repo.GetUser(id);
            var userToReturn=_mapper.Map<UserForDetailedDTO>(user);
            return Ok(userToReturn);
        }
    }
}