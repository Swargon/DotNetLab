using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleAppBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            System.Globalization.CultureInfo customCulture =
            (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Console.Title = "Lab1 Добровольський А. Є. ІПЗ-22-1";

            float CheckFloat(string errorMessage = "Помилка введення значення. Будь-ласка, повторіть введення ще раз!")
            {
                float x;
                bool validInput = false;

                do
                {
                    Console.Write("Введіть значення: ");
                    string input = Console.ReadLine();

                    if (float.TryParse(input, out x))
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(errorMessage);
                        Console.ResetColor();
                    }
                } while (!validInput);

                return x;
            }

            int CheckInt(string errorMessage = "Помилка введення значення. Будь-ласка, повторіть введення ще раз!")
            {
                int x;
                bool validInput = false;

                do
                {
                    Console.Write("Введіть значення: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out x))
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(errorMessage);
                        Console.ResetColor();
                    }
                } while (!validInput);

                return x;
            }

            Account[] account =
            {
                new Account ("account", "1", 11, 11, 1000),
                new Account ("account", "2", 22, 22, 200),
            };

            AutomatedTellerMachine MyATM = new AutomatedTellerMachine(150000, "#0001", "вул. Абрикосова");

            Bank bank = new Bank("Bank", 1);
            bank.Notifications += PrintInfo;

            bool exitProgram = false;

            do
            {
                int user;
                bool flag = false;
                do
                {
                    Console.WriteLine("Введіть номер карти: ");
                    int card = CheckInt();
                    Console.WriteLine("Введіть пароль: ");
                    int pin = CheckInt();
                    flag = bank.Authentication(card, pin, account, out user);
                    Console.ReadKey();
                } while (!flag);
                Console.Clear();

                MyATM.Notify += DisplayMessage;
                account[user].RegisterHandler(PrintInfo);

                int num;
                bool logout = false;
                do
                {
                    Console.WriteLine("1.Вивести дані користувача.\n2.Зняти кошти.\n3.Покласти кошти.\n4.Перевести кошти.\n5.Вийти з акаунту.\n0.Вихід з програми");
                    Console.Write("Введіть пункт меню: ");
                    num = CheckInt();

                    switch (num)
                    {
                        case 1:
                            Console.Clear();
                            account[user].PrintInfo();
                            break;
                        case 2:
                            Console.Clear();
                            Console.Write("Введіть суму зняття: ");
                            float take = CheckFloat();
                            MyATM.Take(take, account, user);
                            break;
                        case 3:
                            Console.Clear();
                            Console.Write("Введіть суму поповнення: ");
                            float put = CheckFloat();
                            MyATM.Put(put, account[user]);
                            break;
                        case 4:
                            Console.Clear();
                            Console.Write("Введіть суму поповнення картки: ");
                            float sum = CheckFloat();
                            Console.Write("Введіть номер картки: ");
                            MyATM.CardTransfer(sum, int.Parse(Console.ReadLine()), account, user);
                            break;
                        case 5:
                            Console.Clear();
                            logout = true;
                            break;
                        case 0:
                            exitProgram = true;
                            logout = true;
                            break;
                    }
                } while (!logout);

            } while (!exitProgram);


            void DisplayMessage(AutomatedTellerMachine sender, BankOperations e)
            {
                Console.WriteLine($"Сумма транзакції: {e.Sum}UAN");
                Console.WriteLine(e.Message);
            }

            void PrintInfo(string message)
            {
                Console.WriteLine(message);
                Console.ReadKey();
            }
        }
    }
}