using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Model;
using Services.interFaces;


namespace OnlineStoreApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProductController : ControllerBase
  {
    private readonly IProductInterFace productService;

    public ProductController(IProductInterFace productInterface)
    {
      productService = productInterface;
    }

    [HttpGet("products")]
    public async Task<IActionResult> GetProduct()
    {
      var result = await productService.GetProducts();
      return Ok(result);
    }


    [HttpPut("createProducts")]
    public async Task<IActionResult> CreateProduct([FromBody] Product product)
    {
      throw new NotImplementedException();
    }

    [HttpPost("updateProducts")]
    public async Task<IActionResult> UpdataeProduct([FromBody] Product product)
    {
      throw new NotImplementedException();
    }

  }
}
