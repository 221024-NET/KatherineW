using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantAssignment.Models;

namespace RestaurantAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantMenusController : ControllerBase
    {
        private readonly RAContext _context;

        public RestaurantMenusController(RAContext context)
        {
            _context = context;
        }

        // GET: api/RestaurantMenus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RestaurantMenu>>> GetRestaurantMenus()
        {
            return await _context.RestaurantMenus.ToListAsync();
        }

        // GET: api/RestaurantMenus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RestaurantMenu>> GetRestaurantMenu(int id)
        {
            var restaurantMenu = await _context.RestaurantMenus.FindAsync(id);

            if (restaurantMenu == null)
            {
                return NotFound();
            }

            return restaurantMenu;
        }

        // PUT: api/RestaurantMenus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRestaurantMenu(int id, RestaurantMenu restaurantMenu)
        {
            if (id != restaurantMenu.RmId)
            {
                return BadRequest();
            }

            _context.Entry(restaurantMenu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RestaurantMenuExists(id))
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

        // POST: api/RestaurantMenus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RestaurantMenu>> PostRestaurantMenu(RestaurantMenu restaurantMenu)
        {
            _context.RestaurantMenus.Add(restaurantMenu);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRestaurantMenu", new { id = restaurantMenu.RmId }, restaurantMenu);
        }

        // DELETE: api/RestaurantMenus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestaurantMenu(int id)
        {
            var restaurantMenu = await _context.RestaurantMenus.FindAsync(id);
            if (restaurantMenu == null)
            {
                return NotFound();
            }

            _context.RestaurantMenus.Remove(restaurantMenu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RestaurantMenuExists(int id)
        {
            return _context.RestaurantMenus.Any(e => e.RmId == id);
        }
    }
}
