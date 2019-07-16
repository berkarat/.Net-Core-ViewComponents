using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentExample.Models;
using ViewComponentExample.Repository.Abstract;

namespace ViewComponentExample.Repository.Entity
{
    public class EfProductRepository : IProductRepository

    {
        List<Product> _products = new List<Product>()
      {
          new Product(){Name="Computer",Price=2250},
          new Product(){Name="Camera",Price=500},
          new Product(){Name="Monitor",Price=1250},
          new Product(){Name="Mouse",Price=50},
      };


        public IEnumerable<Product> Products => _products;

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
    }
}
