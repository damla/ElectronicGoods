using ElectronicGoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectronicGoods.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null; // it will be filled
        static ProductRepository()
        {
            // constructor
            _products = new List<Product>()
            {
                // sample data
                new Product()
                {
                    ProductId = 1,
                    ProductName = "IPhone X",
                    Summary = "Brand new IPhone!",
                    Description = "<p>Menşe Ülke: Çin</p> <p>Dokunmatik Ekran: Var </p> <p>Ekran Boyu: 5.8 inch</p> <p>Ekran Çözünürlüğü: (px) 2436x1125</p> <p>Ekran Renk Sayısı: 16 Milyon</p> <p>İşlemci Türü: Apple A11 İşlemci </p> <p>Hızı: 2.10 GHz </p> <p>İşlemci Sayısı: 6 Çekirdek</p> <p>Otomatik Odaklama, Otomatik Pozlama, Görüntü Sabitleyici, Görüntülü Görüşme, Yüz Algılama, Zamanlayıcı Modu, Arka Arkaya Çekim Modu, Konum Bilgisi</p>",
                    Price = 1000.00 ,
                    Quantity = 150,
                    ImageUrl = "iphonex.jpg",
                    CategoryId = 1
                },
                new Product()
                {
                    ProductId = 3,
                    ProductName = "Huawei P20 Lite",
                    Summary= "It has perfect camera!",
                    Description = "<p>Menşe Ülke: Çin</p> <p>Dokunmatik Ekran: Var </p><p>Ekran Boyu: 5.8 inch</p> <p>Ekran Çözünürlüğü: (px) 2436x1125</p> <p>Ekran Renk Sayısı: 16 Milyon</p>  <p>İşlemci Türü: Apple A11 İşlemci </p>  <p>Hızı: 2.10 GHz </p> <p>İşlemci Sayısı: 6 Çekirdek</p> <p>Otomatik Odaklama, Otomatik Pozlama, Görüntü Sabitleyici, Görüntülü Görüşme, Yüz Algılama, Zamanlayıcı Modu, Arka Arkaya Çekim Modu, Konum Bilgisi</p>",
                    Price = 620.00,
                    Quantity = 143,
                    ImageUrl = "p20.jpg",
                    CategoryId = 1
                },
                new Product()
                {
                    ProductId = 2,
                    ProductName = "Samsung S10",
                    Summary= "Samsung's newest phone!",
                    Description = "<p>Menşe Ülke: Çin</p> <p>Dokunmatik Ekran: Var </p> <p>Ekran Boyu: 5.8 inch</p> <p>Ekran Çözünürlüğü: (px) 2436x1125</p> <p>Ekran Renk Sayısı: 16 Milyon</p> <p>İşlemci Türü: Apple A11 İşlemci </p> <p>Hızı: 2.10 GHz </p> <p>İşlemci Sayısı: 6 Çekirdek</p> <p>Otomatik Odaklama, Otomatik Pozlama, Görüntü Sabitleyici, Görüntülü Görüşme, Yüz Algılama, Zamanlayıcı Modu, Arka Arkaya Çekim Modu, Konum Bilgisi</p>",
                    Price = 735.00,
                    Quantity = 155,
                    ImageUrl = "s10.jpg",
                    CategoryId = 1
                },
                new Product()
                {
                    ProductId = 4,
                    ProductName = "Alienware Notebook",
                    Summary= "Gamer's first choice!",
                    Description = "<p>Menşe Ülke: Çin</p> <p>Dokunmatik Ekran: Var </p> <p>Ekran Boyu: 5.8 inch</p> <p>Ekran Çözünürlüğü: (px) 2436x1125</p> <p>Ekran Renk Sayısı: 16 Milyon</p> <p>İşlemci Türü: Apple A11 İşlemci </p> <p>Hızı: 2.10 GHz </p> <p>İşlemci Sayısı: 6 Çekirdek</p> <p>Otomatik Odaklama, Otomatik Pozlama, Görüntü Sabitleyici, Görüntülü Görüşme, Yüz Algılama, Zamanlayıcı Modu, Arka Arkaya Çekim Modu, Konum Bilgisi</p>",
                    Price = 1199.99,
                    Quantity = 87,
                    ImageUrl = "alienware.jpg",
                    CategoryId = 2
                },
                new Product()
                {
                    ProductId = 5,
                    ProductName = "Monster Notebook",
                    Summary= "Perfect for gamers.",
                    Description = "<p>Menşe Ülke: Çin</p> <p>Dokunmatik Ekran: Var </p> <p>Ekran Boyu: 5.8 inch</p> <p>Ekran Çözünürlüğü: (px) 2436x1125</p> <p>Ekran Renk Sayısı: 16 Milyon</p> <p>İşlemci Türü: Apple A11 İşlemci </p> <p>Hızı: 2.10 GHz </p> <p>İşlemci Sayısı: 6 Çekirdek</p> <p>Otomatik Odaklama, Otomatik Pozlama, Görüntü Sabitleyici, Görüntülü Görüşme, Yüz Algılama, Zamanlayıcı Modu, Arka Arkaya Çekim Modu, Konum Bilgisi</p>",
                    Price = 1220.00,
                    Quantity = 92,
                    ImageUrl = "monster.jpg",
                    CategoryId = 2
                },
                new Product()
                {
                    ProductId = 17,
                    ProductName = "GTA V",
                    Summary= "Best multiplayer game in the world!",
                    Description = "<p>Menşe Ülke: Çin</p> <p>Dokunmatik Ekran: Var </p> <p>Ekran Boyu: 5.8 inch</p> <p>Ekran Çözünürlüğü: (px) 2436x1125</p> <p>Ekran Renk Sayısı: 16 Milyon</p> <p>İşlemci Türü: Apple A11 İşlemci </p> <p>Hızı: 2.10 GHz </p> <p>İşlemci Sayısı: 6 Çekirdek</p> <p>Otomatik Odaklama, Otomatik Pozlama, Görüntü Sabitleyici, Görüntülü Görüşme, Yüz Algılama, Zamanlayıcı Modu, Arka Arkaya Çekim Modu, Konum Bilgisi</p>",
                    Price = 150.00,
                    Quantity = 155,
                    ImageUrl = "gta5.jpg",
                    CategoryId = 7
                },
                new Product()
                {
                    ProductId = 9,
                    ProductName = "Horizon",
                    Summary= "Best racing game!",
                    Description = "<p>Menşe Ülke: Çin</p> <p>Dokunmatik Ekran: Var </p> <p>Ekran Boyu: 5.8 inch</p> <p>Ekran Çözünürlüğü: (px) 2436x1125</p> <p>Ekran Renk Sayısı: 16 Milyon</p> <p>İşlemci Türü: Apple A11 İşlemci </p> <p>Hızı: 2.10 GHz </p> <p>İşlemci Sayısı: 6 Çekirdek</p> <p>Otomatik Odaklama, Otomatik Pozlama, Görüntü Sabitleyici, Görüntülü Görüşme, Yüz Algılama, Zamanlayıcı Modu, Arka Arkaya Çekim Modu, Konum Bilgisi</p>",
                    Price = 110.00,
                    Quantity = 148,
                    ImageUrl = "horizon.jpg",
                    CategoryId = 3
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