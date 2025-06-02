using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine_With_List
{
    internal interface IPrintProducts
    {
        void PrintProduct(int choiseCategory);
    }

    public class PrintProductCategory : IPrintProducts
    {
        public void PrintProduct(int choiseCategory)
        {
            var _products = Products.GetProducts();

            Console.WriteLine("Выберете категорию товара: \n" +
                "1 - Овощи " +
                "2 - Фрукты " +
                "3 - Бытовые товары " +
                "4 - Сладости");

            ConsoleKeyInfo key = Console.ReadKey();
            if (char.IsDigit(key.KeyChar))
            {
                choiseCategory = int.Parse(key.KeyChar.ToString());
                string productCategory;

                switch (choiseCategory)
                {
                    case 1:
                        choiseCategory = 1;
                        productCategory = "Овощи";
                        break;
                    case 2:
                        choiseCategory = 2;
                        productCategory = "Фрукты";
                        break;
                    case 3:
                        choiseCategory = 3;
                        productCategory = "Бытовые товары";
                        break;
                    case 4:
                        choiseCategory = 4;
                        productCategory = "Сладости";
                        break;
                    default:
                        Console.WriteLine("Выбрана не корректная категория товара");
                        Console.ReadLine();
                        return;
                }
                Console.WriteLine($"\nТовары в категории '{productCategory}':");
                foreach (var products in _products)
                {
                    if (products._productCategory == productCategory)
                    {
                        Console.WriteLine(products._nameProduct + " " + products._productPrice);
                    }               
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Выбрана некорректная категория товара");
                Console.ReadLine();
            }

            

        }
    }
}
