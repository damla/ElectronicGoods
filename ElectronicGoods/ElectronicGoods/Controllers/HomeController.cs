using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicGoods.Data;
using ElectronicGoods.Models;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicGoods.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? id) // CategoryId => Home/Index/3
        {
            IEnumerable<Product> products = ProductRepository.Products;

            if(id != null)
            {
                products = products.Where(p => p.CategoryId == id).ToList(); // if id parameter came from URL matches with a category, show that product.
            }

            //ProductCategoryModel model = new ProductCategoryModel()
            //{
            //    Products = ProductRepository.Products,
            //    Categories = CategoryRepository.Categories
            //}; menuyu bagimsiz cagirdigimiz icin bu kisma gerek kalmadi

            return View(products);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Details(int id) // ProductId => Home/Details/2
        {
            //ProductCategoryModel model = new ProductCategoryModel()
            //{
            //    Categories = CategoryRepository.Categories,
            //    Product = ProductRepository.GetById(id)
            //};
            return View(ProductRepository.GetById(id));
        }

        [HttpGet]
        public IActionResult Search(string q)
        {
            if (string.IsNullOrWhiteSpace(q))
                return Redirect("~/");
            else
                return View("Index", ProductRepository.SearchProduct(q));
        }
    }
}