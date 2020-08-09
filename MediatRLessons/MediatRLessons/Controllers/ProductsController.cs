using MediatR;
using MediatRLessons.Entites;
using MediatRLessons.Handler.Commands;
using MediatRLessons.Handler.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRLessons.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IMemoryCache memoryCache;

        public ProductsController(IMediator mediator,IMemoryCache memoryCache)
        {
            this.mediator = mediator;
            this.memoryCache = memoryCache;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            
            var result = await mediator.Send(new List.GetAllProducts());
            return Ok(result);
        } 

        [HttpPost("add")]
        //[ResponseCache]
        public async Task<IActionResult> Post(Create.AddProduct request)
        {
            DateTime time;
            if(!memoryCache.TryGetValue("Time",out time))
            {
                //////////////////
                ///
                Product p = new Product();
                memoryCache.Set<Product>("Time", p);
            }

            var result = await mediator.Send(request);
            return Ok(result);
        }
    }
}
