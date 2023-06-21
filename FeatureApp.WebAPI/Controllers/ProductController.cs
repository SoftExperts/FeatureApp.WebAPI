using DTOs;
using Entities.QueryFilters;
using Microsoft.AspNetCore.Mvc;
using Services.Product;

namespace FeatureApp.WebAPI.Controllers
{
    [ApiVersion("1.0")]
    //[Route("api/[controller]")]
    [Route("v{v:apiVersion}/products")]
    [ApiController]
    public class ProductV1Controller : ControllerBase
    {
        private readonly IProductService productService;

        public ProductV1Controller(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("GetAllProducts")]
        public async Task<ActionResult> GetAllProucts()
        {
            try
            {
                return Ok(await productService.GetAllProductsAsync());
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("GetFilteredProducts")]
        public async Task<ActionResult> GetAllProucts([FromBody] ProductQueryParameter parameters)
        {
            try
            {
                return Ok(await productService.GetAllRecordsAsQueryable(parameters));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("GetProductById/{Id}")]
        public async Task<ActionResult> GetProductById(Guid Id)
        {
            try
            {
                return Ok(await productService.GetProductByIdAsync(Id));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("AddProduct")]
        public async Task<ActionResult>AddProduct(ProductDto productDto)
        {
            try
            {
                await productService.AddProductAsync(productDto);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("AddMultipleProducts")]
        public async Task<ActionResult> AddRangeProducts(List<ProductDto> productDtos)
        {
            try
            {
                await productService.AddRangeProductsAsync(productDtos);

                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("UpdateProduct")]
        public async Task<ActionResult>UpdateProduct(ProductDto productDto)
        {
            try
            {
                await productService.UpdateProductAsync(productDto);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("UpdateMultipleProducts")]
        public async Task<ActionResult> UpdateMultipleProducts(IEnumerable<ProductDto> productDtos)
        {
            try
            {
                await productService.UpdateMultipleProductsAsync(productDtos);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("DeleteProduct/{Id}")]
        public async Task<ActionResult> DeleteProduct(Guid Id)
        {
            try
            {
                await productService.DeleteProductAsync(Id);

                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        [HttpDelete("DeleteMultipleProducts/{Ids}")]
        public async Task<ActionResult> DeleteMultipleProducts(List<Guid> Ids)
        {
            try
            {
                await productService.DeleteRangeProductAsync(Ids);

                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }


    #region Version 2.0

    [ApiVersion("2.0")]
    //[Route("api/[controller]")]
    [Route("v{v:apiVersion}/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet("GetAllProducts")]
        public async Task<ActionResult> GetAllProucts()
        {
            try
            {
                return Ok(await productService.GetAllProductsAsync());
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("GetFilteredProducts")]
        public async Task<ActionResult> GetAllProucts([FromQuery] ProductQueryParameter parameters)
        {
            try
            {
                return Ok(await productService.GetAllRecordsAsQueryable(parameters));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("GetProductById/{Id}")]
        public async Task<ActionResult> GetProductById(Guid Id)
        {
            try
            {
                return Ok(await productService.GetProductByIdAsync(Id));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("AddProduct")]
        public async Task<ActionResult> AddProduct(ProductDto productDto)
        {
            try
            {
                await productService.AddProductAsync(productDto);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("AddMultipleProducts")]
        public async Task<ActionResult> AddRangeProducts(List<ProductDto> productDtos)
        {
            try
            {
                await productService.AddRangeProductsAsync(productDtos);

                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("UpdateProduct")]
        public async Task<ActionResult> UpdateProduct(ProductDto productDto)
        {
            try
            {
                await productService.UpdateProductAsync(productDto);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("UpdateMultipleProducts")]
        public async Task<ActionResult> UpdateMultipleProducts(IEnumerable<ProductDto> productDtos)
        {
            try
            {
                await productService.UpdateMultipleProductsAsync(productDtos);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("DeleteProduct/{Id}")]
        public async Task<ActionResult> DeleteProduct(Guid Id)
        {
            try
            {
                await productService.DeleteProductAsync(Id);

                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("DeleteMultipleProducts/{Ids}")]
        public async Task<ActionResult> DeleteMultipleProducts(List<Guid> Ids)
        {
            try
            {
                await productService.DeleteRangeProductAsync(Ids);

                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    #endregion
}
