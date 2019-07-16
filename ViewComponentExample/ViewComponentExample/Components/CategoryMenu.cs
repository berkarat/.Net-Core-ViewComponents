using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentExample.Repository.Abstract;

namespace ViewComponentExample.Components
{
    public class CategoryMenu : ViewComponent
    {

        private ICategoryRepository repository;
        public CategoryMenu(ICategoryRepository reposit)
        {
            repository = reposit;
        }

        public IViewComponentResult Invoke()
        {
            return View(repository.GetCategories);
        }
    }
}
