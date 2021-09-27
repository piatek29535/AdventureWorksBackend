using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorksBackend
{
    public class Product
    {
        [Column("ProductID")]
        public int ProductID { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("ProductNumber")]
        public string ProductNumber { get; set; }

        [Column("ProductCategoryID")]
        public int ProductCategoryID { get; set; }
    }
}
