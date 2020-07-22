using MyFirstBlogApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlogApp.BLL.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int id);

        void Add(Category category);
        void Update(Category category);
        void Delete(int id);

    }
}
