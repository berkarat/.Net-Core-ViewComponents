using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentExample.Models;
using ViewComponentExample.Repository.Abstract;

namespace ViewComponentExample.Repository.Entity
{
    public class EfCategoryRepository : ICategoryRepository

    {
        List<Category> categories = new List<Category>()
      {
          new Category(){CategoryName="Software"},
          new Category(){CategoryName="Electronics"},
          new Category(){CategoryName="Art"},
          new Category(){CategoryName="Keyboards"},
          new Category(){CategoryName="Hardware"},
      };
        public IEnumerable<Category> GetCategories => categories.OrderBy(i => i.CategoryName);
    }
}
