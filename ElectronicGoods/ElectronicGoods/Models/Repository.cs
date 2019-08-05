using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicGoods.Models
{
    public static class Repository
    {
        private static List<Product> _products = null; // it will be filled
        static Repository()
        {
            // constructor
            _products = new List<Product>()
            {
                // sample data
                new Product()
                {
                    ProductId = 1,
                    ProductName = "IPhone X",
                    Description= "Brand new IPhone!",
                    Price = 100.00 ,
                    Quantity = 150,
                    ImageUrl = "iphonex.jpg"
                },
                new Product()
                {
                    ProductId = 3,
                    ProductName = "Huawei P20 Lite",
                    Description= "It has perfect camera!",
                    Price = 620.00,
                    Quantity = 143,
                    ImageUrl = "p20.jpg"
                },
                new Product()
                {
                    ProductId = 2,
                    ProductName = "Samsung S10",
                    Description= "Samsung's newest phone!",
                    Price = 735.00,
                    Quantity = 155,
                    ImageUrl = "s10.jpg"
                },
                new Product()
                {
                    ProductId = 4,
                    ProductName = "Alienware Notebook",
                    Description= "Gamer's first choice!",
                    Price = 1199.99,
                    Quantity = 87,
                    ImageUrl = "alienware.jpg"
                },
                new Product()
                {
                    ProductId = 5,
                    ProductName = "Monster Notebook",
                    Description= "Perfect for gamers.",
                    Price = 1220.00,
                    Quantity = 92,
                    ImageUrl = "monster.jpg"
                }
            };
        }
        public static List<Product> Products // as an get method
        {
            get
            {
                return _products;
            }
        }
        public static void AddProduct(Product entity)
        {
            _products.Add(entity);
        }
        public static Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id); // returns the product matched with the id
        }
    }
}