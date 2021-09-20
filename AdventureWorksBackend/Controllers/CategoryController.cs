using AdventureWorksBackend.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorksBackend.Controllers
{
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
        public IEnumerable<Categories> Get()
        {
            return _context.Categories.ToList();
        }

        

        [Route("error")]
        public string Error()
        {
            return "Error";
        }
    }
}
