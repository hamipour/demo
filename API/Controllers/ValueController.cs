using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistance;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValueController : ControllerBase
    {
        private readonly DataContext _context;
        public ValueController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Value>>> Get()
        {
            return Ok(await _context.Values.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Value>> Get(int id)
        {
            return Ok(await _context.Values.FindAsync(id));
        }
    }
}