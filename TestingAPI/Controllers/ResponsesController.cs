using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestingAPI.DAL;
using TestingAPI.Model;

namespace TestingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponsesController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public ResponsesController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/Responses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Responses>>> GetResponses()
        {
            return await _context.Responses.ToListAsync();
        }

        // GET: api/Responses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Responses>> GetResponses(int id)
        {
            var responses = await _context.Responses.FindAsync(id);

            if (responses == null)
            {
                return NotFound();
            }

            return responses;
        }

        // PUT: api/Responses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResponses(int id, Responses responses)
        {
            if (id != responses.id)
            {
                return BadRequest();
            }

            _context.Entry(responses).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResponsesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Responses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Responses>> PostResponses(Responses responses)
        {
            _context.Responses.Add(responses);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetResponses", new { id = responses.id }, responses);
        }

        // DELETE: api/Responses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResponses(int id)
        {
            var responses = await _context.Responses.FindAsync(id);
            if (responses == null)
            {
                return NotFound();
            }

            _context.Responses.Remove(responses);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ResponsesExists(int id)
        {
            return _context.Responses.Any(e => e.id == id);
        }
    }
}
