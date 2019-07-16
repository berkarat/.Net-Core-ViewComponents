using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponentExample.Models
{
    public class ProductCategory
    {
        public List<Product> Products { get; set; }
        public List<Category>  Categories { get; set; }
    }
}
