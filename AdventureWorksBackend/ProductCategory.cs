using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorksBackend
{
    public class ProductCategory
    {
        [Column("ProductCategoryID")]
        public int? ProductCategoryID { get; set; }
        [Column("Name")]
        public string? Name { get; set; }

        [Column("ParentProductCategoryID")]
        public int? ParentProductCategoryID { get; set; }

        [Column("rowguid")]
        public Guid? rowguid { get; set; }

        [Column("ModifiedDate")]
        public DateTime? ModifiedDate { get; set; }

    }
}
