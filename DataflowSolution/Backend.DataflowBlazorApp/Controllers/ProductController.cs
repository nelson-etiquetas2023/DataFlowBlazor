using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Backend.DataflowBlazorApp.Data;
using Microsoft.EntityFrameworkCore;
using Shared.DataflowBlazorApp.Models;
using System.Security;

namespace Backend.DataflowBlazorApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync() 
        {
            return Ok(await _context.Products.ToListAsync());
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetAsync(int id) 
        {
            var products = await _context.Products.FindAsync(id);
            if (products == null) 
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Postsync(Product product) 
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(Product product) 
        {
            _context.Update(product);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeleteAsync(int id) 
        {
            var productDelete = await _context.Products.FindAsync(id);
            if (productDelete == null) 
            {
                return NotFound(id);
            }
            _context.Products.Remove(productDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
