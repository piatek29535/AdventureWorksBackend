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
    [Route("category")]
    public class ProductController : ControllerBase
    {
        private readonly ProductContext _context;
        public ProductController(ProductContext productContext)
        {
            _context = productContext;
        }

        [HttpGet]
        [Route("{id}")]
        public Product GetProduct(int id)
        {
            return _context.Product.Single(item => item.ProductID == id);
        }

    }
}
