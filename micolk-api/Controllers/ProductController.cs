using Application.Products.Commands.CreateProduct;
using Application.Products.Queries.GetProductById;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace micolk_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ApiControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<ProductDto>> GetProductById([FromQuery] GetProductByIdQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpPost]
        public async Task<ActionResult<ProductDto>> Post(CreateProductCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
