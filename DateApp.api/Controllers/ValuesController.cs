using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DateApp.api.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DateApp.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;

        public ValuesController(DataContext  context)
        {
            this._context = context;
        }
        //Get  api/values
        [HttpGet]
         [AllowAnonymous]
        public async Task<IActionResult> GetValues()
        {
             var values=  _context.Values.ToListAsync();
         return Ok(await values);
        }

        //Get api/value/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public  async Task<IActionResult> GetValue(int id)
        {
         var value= await _context.Values.FirstOrDefaultAsync(x=>x.Id==id);
         return Ok(value);
        }
        
    }
}
