using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MenuMasterAPI.Models;

namespace MenuMasterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataMenuMastersController : ControllerBase
    {
        private readonly MenuMasterContext _context;

        public DataMenuMastersController(MenuMasterContext context)
        {
            _context = context;
        }

        // GET: api/DataMenuMasters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DataMenuMaster>>> GetDataMenuMasters()
        {
          if (_context.DataMenuMasters == null)
          {
              return NotFound();
          }
            return await _context.DataMenuMasters.ToListAsync();
        }

        // GET: api/DataMenuMasters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DataMenuMaster>> GetDataMenuMaster(int id)
        {
          if (_context.DataMenuMasters == null)
          {
              return NotFound();
          }
            var dataMenuMaster = await _context.DataMenuMasters.FindAsync(id);

            if (dataMenuMaster == null)
            {
                return NotFound();
            }

            return dataMenuMaster;
        }

        // PUT: api/DataMenuMasters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDataMenuMaster(int id, DataMenuMaster dataMenuMaster)
        {
            if (id != dataMenuMaster.IdUser)
            {
                return BadRequest();
            }

            _context.Entry(dataMenuMaster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DataMenuMasterExists(id))
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

        // POST: api/DataMenuMasters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DataMenuMaster>> PostDataMenuMaster(DataMenuMaster dataMenuMaster)
        {
          if (_context.DataMenuMasters == null)
          {
              return Problem("Entity set 'MenuMasterContext.DataMenuMasters'  is null.");
          }
            _context.DataMenuMasters.Add(dataMenuMaster);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDataMenuMaster", new { id = dataMenuMaster.IdUser }, dataMenuMaster);
        }

        // DELETE: api/DataMenuMasters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDataMenuMaster(int id)
        {
            if (_context.DataMenuMasters == null)
            {
                return NotFound();
            }
            var dataMenuMaster = await _context.DataMenuMasters.FindAsync(id);
            if (dataMenuMaster == null)
            {
                return NotFound();
            }

            _context.DataMenuMasters.Remove(dataMenuMaster);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DataMenuMasterExists(int id)
        {
            return (_context.DataMenuMasters?.Any(e => e.IdUser == id)).GetValueOrDefault();
        }
    }
}
