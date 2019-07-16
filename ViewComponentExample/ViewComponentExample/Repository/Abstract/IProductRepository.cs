using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentExample.Models;

namespace ViewComponentExample.Repository.Abstract
{
  public  interface IProductRepository
    {

       IEnumerable<Product> Products { get;  }

        void AddProduct(Product product);
        
    }
}
