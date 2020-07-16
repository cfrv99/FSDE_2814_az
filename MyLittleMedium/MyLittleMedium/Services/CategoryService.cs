using MyLittleMedium.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLittleMedium.Services
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
    public class CategoryService : ICategoryService
    {
        static List<Category> Categories;

        static CategoryService()
        {
            Categories = new List<Category>
            {
                new Category
                {
                    Id=1,
                    Name="Cars"
                },
                new Category
                {
                    Id=2,
                    Name="Electronics"
                },
                new Category
                {
                    Id=3,
                    Name="Books"
                },
                new Category
                {
                    Id=4,
                    Name="Flowers"
                },
            };
        }
        public List<Category> GetAll()
        {
            return Categories;
        }
    }
}
