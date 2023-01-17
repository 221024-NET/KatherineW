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
    public class RestaurantCuisinesController : ControllerBase
    {
        private readonly RAContext _context;

        public RestaurantCuisinesController(RAContext context)
        {
            _context = context;
        }

        // GET: api/RestaurantCuisines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RestaurantCuisine>>> GetRestaurantCuisines()
        {
            return await _context.RestaurantCuisines.ToListAsync();
        }

        // GET: api/RestaurantCuisines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RestaurantCuisine>> GetRestaurantCuisine(int id)
        {
            var restaurantCuisine = await _context.RestaurantCuisines.FindAsync(id);

            if (restaurantCuisine == null)
            {
                return NotFound();
            }

            return restaurantCuisine;
        }

        // PUT: api/RestaurantCuisines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRestaurantCuisine(int id, RestaurantCuisine restaurantCuisine)
        {
            if (id != restaurantCuisine.RcId)
            {
                return BadRequest();
            }

            _context.Entry(restaurantCuisine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RestaurantCuisineExists(id))
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

        // POST: api/RestaurantCuisines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RestaurantCuisine>> PostRestaurantCuisine(RestaurantCuisine restaurantCuisine)
        {
            _context.RestaurantCuisines.Add(restaurantCuisine);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRestaurantCuisine", new { id = restaurantCuisine.RcId }, restaurantCuisine);
        }

        // DELETE: api/RestaurantCuisines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestaurantCuisine(int id)
        {
            var restaurantCuisine = await _context.RestaurantCuisines.FindAsync(id);
            if (restaurantCuisine == null)
            {
                return NotFound();
            }

            _context.RestaurantCuisines.Remove(restaurantCuisine);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RestaurantCuisineExists(int id)
        {
            return _context.RestaurantCuisines.Any(e => e.RcId == id);
        }
    }
}
