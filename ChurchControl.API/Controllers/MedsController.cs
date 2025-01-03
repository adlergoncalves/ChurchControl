using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ChurchControl.API.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurchControl.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MedsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Meds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Meds>>> GetMeds()
        {
            return await _context.Meds.ToListAsync();
        }

        // GET: api/Meds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Meds>> GetMeds(int id)
        {
            var meds = await _context.Meds.FindAsync(id);

            if (meds == null)
            {
                return NotFound();
            }

            return meds;
        }

        // POST: api/Meds
        [HttpPost]
        public async Task<ActionResult<Meds>> PostMeds(Meds meds)
        {
            _context.Meds.Add(meds);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMeds", new { id = meds.Id }, meds);
        }

        // PUT: api/Meds/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeds(int id, Meds meds)
        {
            if (id != meds.Id)
            {
                return BadRequest();
            }

            _context.Entry(meds).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedsExists(id))
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

        // DELETE: api/Meds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeds(int id)
        {
            var meds = await _context.Meds.FindAsync(id);
            if (meds == null)
            {
                return NotFound();
            }

            _context.Meds.Remove(meds);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MedsExists(int id)
        {
            return _context.Meds.Any(e => e.Id == id);
        }
    }
}
