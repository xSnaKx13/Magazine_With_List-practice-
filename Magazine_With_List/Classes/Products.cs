using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Magazine_With_List
{
    class Products
    {
        
        public string _nameProduct { get; set; }
        public string _productCategory { get; set; }
        public decimal _productPrice { get; set; }

        public Products(string nameProduct, string productCategory, decimal productPrice)
        {
            _nameProduct = nameProduct;
            _productCategory = productCategory;
            _productPrice = productPrice;
        }
        public Products() { }

        private static List<Products> _products = new List<Products>
        {
            new Products("Морковь", "Овощи", 30m),
            new Products("Картошка", "Овощи", 55m),
            new Products("Помидор","Овощи", 300m),
            new Products("Огурец","Овощи", 120m),
            new Products("Лук","Овощи", 49m),
            new Products("Капуста","Овощи", 61m),
            new Products("Болгарский перец","Овощи", 314.90m),
            new Products("Свёкла","Овощи", 59.90m),
            new Products("Баклажан","Овощи", 224.49m),
            new Products("Кабачок","Овощи", 132m),

            new Products("Яблоко","Фрукты", 139.99m),
            new Products("Банан","Фрукты", 105.30m),
            new Products("Апельсин","Фрукты", 160m),
            new Products("Груша","Фрукты", 150.60m),
            new Products("Виноград","Фрукты", 399.90m),
            new Products("Персики","Фрукты", 312.90m),
            new Products("Киви","Фрукты", 114.50m),
            new Products("Манго","Фрукты", 410.60m),
            new Products("Ананас","Фрукты", 220.10m),
            new Products("Слива","Фрукты", 180.40m),

            new Products("Мыло","Бытовые товары", 66.90m),
            new Products("Зубная паста","Бытовые товары", 133.50m),
            new Products("Губка для посуды","Бытовые товары", 49.40m),
            new Products("Стиральный порошок","Бытовые товары", 460.99m),
            new Products("Бумажные полотенца","Бытовые товары", 93.40m),
            new Products("Освежитель воздуха","Бытовые товары", 107.70m),
            new Products("Пакеты для мусора (50 шт.)","Бытовые товары", 110.90m),
            new Products("Батарейки (12 шт.)","Бытовые товары", 267.10m),
            new Products("Лампочка","Бытовые товары", 334.50m),
            new Products("Скотч","Бытовые товары", 61.85m),

            new Products("Шоколад","Сладости", 136.30m),
            new Products("Конфеты","Сладости", 105.99m),
            new Products("Печенье","Сладости", 161m),
            new Products("Мармелад","Сладости", 144.99m),
            new Products("Зефир","Сладости", 196.30m),
            new Products("Вафли","Сладости", 169.99m),
            new Products("Пряники","Сладости", 199.50m),
            new Products("Халва","Сладости", 230.49m),
            new Products("Леденцы","Сладости", 67.30m),
            new Products("Пирожное","Сладости", 89.90m)
        };

        public static List<Products> GetProducts()
        {
            return _products;
        }
    }
}
