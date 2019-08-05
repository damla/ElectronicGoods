using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectronicGoods.Data;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicGoods.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(ProductRepository.Products);
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            return View(ProductRepository.GetById(id));
        }
    }
}