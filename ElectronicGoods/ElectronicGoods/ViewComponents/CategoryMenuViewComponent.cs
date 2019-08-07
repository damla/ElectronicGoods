using ElectronicGoods.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicGoods.ViewComponents
{
    public class CategoryMenuViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // if it is /home/index/3 add category with id=3 active class.
            if (RouteData.Values["action"].ToString() == "Index" ) 
                ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(CategoryRepository.Categories); 
        }
    }
}
