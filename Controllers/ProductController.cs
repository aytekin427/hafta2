using hafta2.DTOs;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace hafta2.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [Consumes("application/json")]
    [ApiController]


    public class ProductController:ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("Add")]
        public IActionResult Add([FromBody]ProductAddDto model)
        {
            var result = _productService.Add(model);

            return Ok(result);
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody]ProductUpdateDto model)
        {
            var result = _productService.Update(model);

            return Ok(result);
        }

        [HttpDelete("Delete")]
        public IActionResult Delete([BindRequired]Guid id)
        {
            var result = _productService.Delete(id);

            return Ok(result);
        }

        /// <summary>
        /// Get All Products
        /// </summary>        
        /// <returns></returns>
        [HttpGet("Get")]
        [ProducesResponseType(typeof(IList<ProductGetDto>), 200)]
        public IActionResult Get()
        {
            var result = _productService.Get();

            return Ok(result);
        }
    }
}
