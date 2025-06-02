using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine_With_List
{
    internal class AdminPanel
    {
        /*public static string _login { get; } = "aamartynov21";
        public static string _password { get; } = "Qwerty-1993.";

        public static void Admin()
        {
            int count = 3;

            for (int i = count; count > 0; count--)
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine().ToLower();
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();
                if (login == _login && password == _password)
                {
                    Console.WriteLine("Вход успешно произведен!\n  нажмите Enter для продолжения");
                    Console.ReadLine();
                    AdminControl();
                    break;
                }
                else if ((count - 1) == 0)
                {
                    Console.WriteLine("Учетная запись заблокирована!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Не верно введен логин или пороль\nОсталось {count - 1} попыток\n  нажмите Enter для продолжения");
                    Console.ReadLine();

                }
            }
        }*/
        public static void AdminControl()
        {
            Console.Clear();
            bool isWorking = true;
            while (isWorking)
            {
                Console.Clear();
                Console.WriteLine("Выбирете функционал: \n" +
                    "1 - Добавить продукт в список товаров\n" +
                    "3 - Покинуть панель управления");
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (char.IsDigit(keyInfo.KeyChar))
                {
                    int adminChoice = int.Parse(keyInfo.KeyChar.ToString());
                    switch (adminChoice)
                    {
                        case 1:
                            AddProduct.AddProductInStore();
                            break;
                        case 2:

                            break;
                        case 3:
                            Console.WriteLine("Подтвердите выход: \n1 - да\n2 - остаться");
                            int exit = int.Parse(Console.ReadLine());
                            switch (exit)
                            {
                                case 1:
                                    MainMenu menu = new MainMenu();
                                    menu.MainMenuBar();
                                    break;
                                case 2:

                                    break;
                            }

                            break;
                        default:
                            Console.WriteLine("Не корректный ввод\nповторите попытку нажав Enter");
                            break;
                    }
                }
            }
        }
    }
}
