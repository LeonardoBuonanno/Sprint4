using Microsoft.AspNetCore.Mvc;
using Sprint4.Services;

namespace Sprint4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var produtos = _productService.ObterTodosProdutos();
            return Ok(produtos);
        }
    }
}
