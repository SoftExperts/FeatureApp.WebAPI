using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Product;
using Services.SecurityAttacks;
using System.ComponentModel.DataAnnotations;

namespace FeatureApp.WebAPI.Controllers
{
    [ApiVersion("1.0")]
    //[Route("api/[controller]")]
    [Route("v{v:apiVersion}/products")]
    [ApiController]
    public class SecurityCheckV1Controller : ControllerBase
    {
        private readonly ISecurityAttacks _securityAttacks;
        public SecurityCheckV1Controller(ISecurityAttacks securityAttacks)
        {
                _securityAttacks = securityAttacks;
        }

        /// <summary>
        ///  SQLInjectionAttacks To DropAll ProductsById
        /// </summary>
        /// <param name="Id">'4629fa34-4adb-41c1-9b28-13f1c8401a1c'; Drop Table Products</param>
        /// <returns></returns>
        [HttpPost("SQLInjectionAttack")]
        public async Task<ActionResult> SQLInjectionAttack(string Id)
        {
            try
            {
                await _securityAttacks.InjectionAttack(Id);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        } 
        
        /// <summary>
        ///  SQLInjectionAttacks To DropAll ProductsById
        /// </summary>
        /// <param name="Id">'4629fa34-4adb-41c1-9b28-13f1c8401a1c'; Drop Table Products</param>
        /// <returns></returns>
        [HttpPost("PreventInjectionAttack")]
        public async Task<ActionResult> PreventInjectionAttack(Guid Id)
        {
            try
            {
                await _securityAttacks.PreventInjectionAttack(Id);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        [HttpPost("FileAttack")]
        public async Task<ActionResult> FileAttack(IFormFile file)
        {
            try
            {
                await _securityAttacks.FileAttack(file);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        [HttpPost("PreventFileAttack")]
        public async Task<ActionResult> PreventFileAttack([FileExtensions(Extensions = ".pdf,.txt")][MaxLength(10 * 1024)] IFormFile file)
        {
            try
            {
                await _securityAttacks.PreventFileAttack(file);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
