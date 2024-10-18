using Microsoft.AspNetCore.Mvc;
using OnlineShoppingPlatform.Models;
using OnlineShoppingPlatform.Repositories;

namespace OnlineShoppingPlatform.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetAllProducts() => Ok(_productRepository.GetAllProducts());

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id) => Ok(_productRepository.GetProductById(id));

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productRepository.AddProduct(product);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product product)
        {
            _productRepository.UpdateProduct(product);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
            return Ok();
        }
    }

}
