using AmazonOnionApi.Application.Features.Products.Queries.GetAllProducts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AmazonOnionApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;
        public ProductController(IMediator mediator)
        {
            this.mediator = mediator; 
        }
        // GET: api/<ProductController>
        [HttpGet]
        public async Task<ActionResult>GetAllProducts()
        {
            var response = await mediator.Send(new GetAllProductsQueryRequest());
            return Ok(response);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
