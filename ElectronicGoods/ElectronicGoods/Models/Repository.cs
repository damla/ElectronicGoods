using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicGoods.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = null; // it will be filled
        static Repository()
        {
            // constructor
            _products = new List<Product>
            {
                // sample data
                new Product()
                {
                    ProductId = 1,
                    ProductName = "IPhone X",
                    Description= "Brand new IPhone!",
                    Price = 100.00 ,
                    Quantity = 150,
                    ImageUrl = "1.jpg"
                },
                new Product()
                {
                    ProductId = 2,
                    ProductName = "Samsung S10",
                    Description= "Samsung's newest phone!",
                    Price = 735.00,
                    Quantity = 155,
                    ImageUrl = "2.jpg"
                },
                new Product()
                {
                    ProductId = 3,
                    ProductName = "Huawei P20 Lite",
                    Description= "It has perfect camera!",
                    Price = 620.00,
                    Quantity = 143,
                    ImageUrl = "3.jpg"
                },
                new Product()
                {
                    ProductId = 4,
                    ProductName = "Alienware Notebook",
                    Description= "Gamer's first choice!",
                    Price = 1199.99,
                    Quantity = 87,
                    ImageUrl = "4.jpg"
                },
                new Product()
                {
                    ProductId = 5,
                    ProductName = "Monster Notebook",
                    Description= "Perfect for gamers.",
                    Price = 1220.00,
                    Quantity = 92,
                    ImageUrl = "5.jpg"
                },
                new Product()
                {
                    ProductId = 6,
                    ProductName = "Macbook Air",
                    Description= "Simple and elegant.",
                    Price = 1350.00,
                    Quantity = 77,
                    ImageUrl = "1.jpg"
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