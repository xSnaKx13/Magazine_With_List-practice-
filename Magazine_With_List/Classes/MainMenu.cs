using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine_With_List
{
    internal class MainMenu
    {
        public void MainMenuBar()
        {
            bool isWorking = true;
            while (isWorking)
            {
                Console.Clear();
                Console.WriteLine("МАГАЗИН ПРОДУКТОВ\n\n 1 - Список товаров\n" +
                                                     " 2 - Корзина\n" +
                                                     " 3 - Закрыть приложение\n\n\n\n\n\n\n\n" +
                                                 "0 - панель администратора");


                ConsoleKeyInfo key = Console.ReadKey();
                if (char.IsDigit(key.KeyChar))
                {
                    int userChoice = int.Parse(key.KeyChar.ToString());

                    switch (userChoice)
                    {
                        case 1:
                            IPrintProducts printProduct = new PrintProductCategory();
                            printProduct.PrintProduct(0);
                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                        case 0:
                            AdminPanel.AdminControl();
                            break;
                        default:
                            Console.WriteLine("Не корректное значение");
                            Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Не корректное значение");
                    Console.ReadLine();
                }
            }
            
        }
    }
}
