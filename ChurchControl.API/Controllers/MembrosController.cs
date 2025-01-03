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
    public class MembrosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MembrosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Membros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Membro>>> GetMembros()
        {
            return await _context.Membros.ToListAsync();
        }

        // GET: api/Membros/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Membro>> GetMembro(int id)
        {
            var membro = await _context.Membros.FindAsync(id);

            if (membro == null)
            {
                return NotFound();
            }

            return membro;
        }

        // POST: api/Membros
        [HttpPost]
        public async Task<ActionResult<Membro>> PostMembro(Membro membro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Membros.Add(membro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMembro", new { id = membro.Id }, membro);
        }

        // PUT: api/Membros/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMembro(int id, Membro membro)
        {
            if (id != membro.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Entry(membro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MembroExists(id))
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

        // DELETE: api/Membros/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMembro(int id)
        {
            var membro = await _context.Membros.FindAsync(id);
            if (membro == null)
            {
                return NotFound();
            }

            _context.Membros.Remove(membro);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MembroExists(int id)
        {
            return _context.Membros.Any(e => e.Id == id);
        }
    }
}
