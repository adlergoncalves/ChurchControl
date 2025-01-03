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
    public class VisitantesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VisitantesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Visitantes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Visitante>>> GetVisitantes()
        {
            return await _context.Visitantes.ToListAsync();
        }

        // GET: api/Visitantes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Visitante>> GetVisitante(int id)
        {
            var visitante = await _context.Visitantes.FindAsync(id);

            if (visitante == null)
            {
                return NotFound();
            }

            return visitante;
        }

        // POST: api/Visitantes
        [HttpPost]
        public async Task<ActionResult<Visitante>> PostVisitante(Visitante visitante)
        {
            _context.Visitantes.Add(visitante);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVisitante", new { id = visitante.Id }, visitante);
        }

        // PUT: api/Visitantes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVisitante(int id, Visitante visitante)
        {
            if (id != visitante.Id)
            {
                return BadRequest();
            }

            _context.Entry(visitante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VisitanteExists(id))
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

        // DELETE: api/Visitantes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVisitante(int id)
        {
            var visitante = await _context.Visitantes.FindAsync(id);
            if (visitante == null)
            {
                return NotFound();
            }

            _context.Visitantes.Remove(visitante);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VisitanteExists(int id)
        {
            return _context.Visitantes.Any(e => e.Id == id);
        }
    }
}
