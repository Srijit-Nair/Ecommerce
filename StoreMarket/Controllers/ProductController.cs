using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Infrastructure.Data;

namespace StoreMarket.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsContext _context;

        public ProductsController(ProductsContext productsContext)
        {
            _context = productsContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<Products>>> GetProducts()
        {
            var productList = await _context.Products.ToListAsync();
            
            return Ok(productList);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Products>> GetProduct(int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}
