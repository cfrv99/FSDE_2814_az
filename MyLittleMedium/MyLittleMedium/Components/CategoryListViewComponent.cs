using Microsoft.AspNetCore.Mvc;
using MyLittleMedium.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLittleMedium.Components
{
    public class CategoryListViewComponent:ViewComponent
    {
        private readonly ICategoryService categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var data = categoryService.GetAll();
            return View(data);
        }
    }
}
