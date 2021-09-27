using AdventureWorksBackend.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorksBackend.Controllers
{
    [EnableCors("Policy")]
    [ApiController]
    [Route("categories")]
    public class CategoryController : ControllerBase
    {
        private readonly CategoriesContext _context;
        public CategoryController(CategoriesContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<ProductCategory> Get()
        {

            return _context.ProductCategory.ToList();
            /*return _context.ProductCategory
                .Where(item => item.ParentProductCategoryID != null)
                .Select(item => new Categories(item.ParentProductCategoryID, item.Name, new Categories(item.ProductCategoryID, null, null)))
                .ToList();
              */  
        }

        [HttpPut]
        [Route("puttest")]
        public void PutCategory()
        {
            
        }

        [Route("error")]
        public string Error()
        {
            return "Error";
        }
    }
}
