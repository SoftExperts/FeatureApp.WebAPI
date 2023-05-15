using DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Product;

namespace FeatureApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("AddProduct")]
        public async Task<ActionResult>AddProduct(ProductDto productDto)
        {
            try
            {
                await _productService.AddProduct(productDto);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("GetAllProucts")]
        public async Task<ActionResult> GetAllProucts()
        {
            try
            {
                return Ok(await _productService.GetAllProducts());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
