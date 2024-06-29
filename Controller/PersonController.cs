

using crudApiApp.Data;
using crudApiApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace crudApiApp.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PersonContext _context;
        public PersonController (PersonContext context){_context = context;}
        
        // Get person
        [HttpGet("/person")]
        public async Task< ActionResult<IEnumerable<PersonModel>>> GetPerson()
        {
            return await _context.PersonModel.ToListAsync();
        }
        // [HttpGet("{id}")]
        // public  async Task<>

    }

    
}