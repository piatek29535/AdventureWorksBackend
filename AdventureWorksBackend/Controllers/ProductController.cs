using AdventureWorksBackend.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorksBackend.Controllers
{
    [EnableCors("Policy")]
    [ApiController]
    [Route("product")]
    public class ProductController : ControllerBase
    {
        private readonly ProductContext _context;
        public ProductController(ProductContext productContext)
        {
            _context = productContext;
        }

        [HttpGet]
        [Route("{id}")]
        public IEnumerable<Product> GetProduct(int ID)
        {
            return _context.Product.Where(item => item.ProductCategoryID == ID).ToList();
        }

    }
}
