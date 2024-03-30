using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public delegate void AccountHandler(string message);

    public class Account
    {
        public delegate void BankOperationsHandler(Account sender, BankOperations e);

        public static int amountUsers = 0;

        public string Name { get; set; }
        public string Surname { get; set; }
        public int CardNumber { get; private set; }
        public float Balance { get; set; }
        public int Pin { get; private set; }

        AccountHandler info;

        public Account(string name, string surname, int cardNumber, int pin, float balance)
        {
            Name = name;
            Surname = surname;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = balance;
            amountUsers++;
        }

        public void RegisterHandler(AccountHandler del)
        {
            info = del;
        }

        public void PrintInfo()
        {
            info?.Invoke($"Ім'я: {Name}\nПрізвище: {Surname}\nНомер картки: {CardNumber}\nБаланс: {Balance}");
        }
    }
}