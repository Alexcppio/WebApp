using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApp.Models;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController: ControllerBase
    {
        private DataContext context;
        public ProductsController(DataContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return context.Products;
        }
        [HttpGet("{id}")]
        public Product GetProduct(long id, [FromServices]
        ILogger<ProductsController> logger)
        {
            logger.LogDebug("GetProduct Action Invoked");
            return context.Products.Find(id);
        }
    }
}
