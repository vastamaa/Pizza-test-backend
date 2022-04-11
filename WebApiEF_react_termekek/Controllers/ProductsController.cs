using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiEF_react_termekek.Models;
using WebApiEF_react_termekek.Services;

namespace WebApiEF_react_termekek.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet("")]
        public async Task<IEnumerable<Termekek>> GetProducts() => await _productsService.GetAllProductsAsync();

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetProductById([FromRoute] int id)
        {
            var product = await _productsService.GetOneProductByIdAsync(id);

            if (product is not null) return Ok(product);

            return NotFound();            
        }

        [HttpPost("")]
        public async Task<IActionResult> AddProduct([FromBody] TermekekVM termekekVM)
        {
            var result = await _productsService.AddProductAsync(termekekVM);

            if (result > 0)
            {
                return Ok("Upload succesfull!");
            }

            return BadRequest();
        }
    }
}
