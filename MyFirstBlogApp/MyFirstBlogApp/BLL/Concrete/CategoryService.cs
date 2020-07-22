using MyFirstBlogApp.BLL.Abstract;
using MyFirstBlogApp.DAL.Repo.EF.Abstract;
using MyFirstBlogApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBlogApp.BLL.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public void Add(Category category)
        {
            categoryRepository.Add(category);

        }

        public void Delete(int id)
        {
            categoryRepository.Delete(id);
        }

        public List<Category> GetAll()
        {
            var data = categoryRepository.GetAll();
            return data.ToList();
        }

        public Category GetById(int id)
        {
            var data = categoryRepository.GetById(id);
            return data;
        }

        public void Update(Category category)
        {
            if (category.Id <= 0)
            {
                throw new Exception("Id Can not be null");
            }
            categoryRepository.Update(category);
        }
    }
}
