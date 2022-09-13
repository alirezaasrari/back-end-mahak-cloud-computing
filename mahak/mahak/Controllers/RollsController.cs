using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mahak.Data;
using mahak.Models;

namespace mahak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RollsController : ControllerBase
    {
        private readonly DataContext _context;

        public RollsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Rolls
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Roll>>> GetRoll()
        {
          if (_context.Roll == null)
          {
              return NotFound();
          }
            return await _context.Roll.ToListAsync();
        }

        // GET: api/Rolls/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Roll>> GetRoll(int id)
        {
          if (_context.Roll == null)
          {
              return NotFound();
          }
            var roll = await _context.Roll.FindAsync(id);

            if (roll == null)
            {
                return NotFound();
            }

            return roll;
        }

        // PUT: api/Rolls/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoll(int id, Roll roll)
        {
            if (id != roll.Id)
            {
                return BadRequest();
            }

            _context.Entry(roll).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RollExists(id))
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

        // POST: api/Rolls
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Roll>> PostRoll(Roll roll)
        {
          if (_context.Roll == null)
          {
              return Problem("Entity set 'DataContext.Roll'  is null.");
          }
            _context.Roll.Add(roll);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoll", new { id = roll.Id }, roll);
        }

        // DELETE: api/Rolls/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoll(int id)
        {
            if (_context.Roll == null)
            {
                return NotFound();
            }
            var roll = await _context.Roll.FindAsync(id);
            if (roll == null)
            {
                return NotFound();
            }

            _context.Roll.Remove(roll);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RollExists(int id)
        {
            return (_context.Roll?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
