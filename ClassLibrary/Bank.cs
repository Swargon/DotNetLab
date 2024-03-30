using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public delegate void BankHandler(string message);

    public class Bank
    {
        public event BankHandler Notifications;

        public string BankName { get; private set; }
        public int ListOfATMs { get; set; }
        private List<Account> accounts;

        public Bank(string bankName, int listOfATMs)
        {
            BankName = bankName;
            ListOfATMs = listOfATMs;
            accounts = new List<Account>();
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        public bool Authentication(int cardNumber, int pin, Account[] userAccounts, out int userIndex)
        {
            userIndex = -1;
            for (int i = 0; i < userAccounts.Length; i++)
            {
                if (userAccounts[i].CardNumber == cardNumber && userAccounts[i].Pin == pin)
                {
                    userIndex = i;
                    return true;
                }
            }
            return false;
        }
    }
}