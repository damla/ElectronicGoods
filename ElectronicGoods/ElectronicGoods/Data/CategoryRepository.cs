using ElectronicGoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicGoods.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;
        static CategoryRepository()
        {
            // sample data
            _categories = new List<Category>()
            {
                new Category()
                {
                    CategoryId = 1,
                    CategoryName = "Phones",
                    ImageUrl = "phones.jpg"
                },
                new Category()
                {
                    CategoryId = 2,
                    CategoryName = "Notebooks",
                    ImageUrl = "notebooks.jpg"
                },
                new Category()
                {
                    CategoryId = 3,
                    CategoryName = "Console Games",
                    ImageUrl = "console_games.jpg"
                },
                new Category()
                {
                    CategoryId = 7,
                    CategoryName = "PC Games",
                    ImageUrl = "pcgames.jpg"
                }
            };
        }
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
        public static void AddCategory(Category entity)
        {
            _categories.Add(entity);
        }
        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(p => p.CategoryId == id); // returns the product matched with the id
        }
    }
}
