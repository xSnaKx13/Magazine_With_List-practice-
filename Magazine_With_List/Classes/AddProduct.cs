using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine_With_List
{
    internal class AddProduct
    {

        public static void AddProductInStore()
        {
            var _products = Products.GetProducts();

            Console.Write(" - Введите название товара:  ");
            string nameProduct = Console.ReadLine();
            Console.WriteLine(" - Выбирете категорию товара:\n 1 - Овощи\n 2 - Фрукты\n 3 - Бытовые товары\n 4 - Сладости");
            string productCategory = null;

            ConsoleKeyInfo key = Console.ReadKey();

            if (char.IsDigit(key.KeyChar))
            {
                int categoryNumber = int.Parse(key.KeyChar.ToString());
                switch (categoryNumber)
                {
                    case 1:
                        productCategory = "Овощи";
                        break;
                    case 2:
                        productCategory = "Фрукты";
                        break;
                    case 3:
                        productCategory = "Бытовые товары";
                        break;
                    case 4:
                        productCategory = "Сладости";
                        break;
                    default:
                        Console.WriteLine("Выбрана не корректная категория товара");
                        return;
                }
            }
            else
            {
                Console.WriteLine("\nОшибка: Введен недопустимый символ. Нужно выбрать цифру от 1 до 4.");
                Console.ReadLine();
                return;
            }

            Console.Write(" - Введите цену товара:  ");
            if (decimal.TryParse(Console.ReadLine(), out decimal productPrice))
            {
                Console.WriteLine($"Цена товара: {productPrice}");
            }
            else
            {
                Console.WriteLine("Ошибка: Введено некорректное значение цены.");
                Console.ReadLine();
                return;
            }

            _products.Add(new Products(nameProduct, productCategory, productPrice));
            Console.WriteLine("-- Товар добавлен в список товаров --");
            Console.ReadLine();
        }
    }
}
