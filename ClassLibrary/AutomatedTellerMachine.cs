using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AutomatedTellerMachine
    {
        public delegate void BankOperationsHandler(AutomatedTellerMachine sender, BankOperations e);
        public event BankOperationsHandler Notify;

        public float Money { get; set; }
        public string IdATMs { get; protected set; }
        public string Address { get; protected set; }

        public AutomatedTellerMachine(float money, string idATMs, string address)
        {
            Money = money;
            IdATMs = idATMs;
            Address = address;
        }

        public void Put(float amount, Account userAccount)
        {
            if (amount <= 0)
            {
                Notify?.Invoke(this, new BankOperations("Сума повинна бути більше нуля", amount));
                return;
            }

            userAccount.Balance += amount;
            Money += amount;

            Notify?.Invoke(this, new BankOperations($"На рахунок користувача {userAccount.Name} {userAccount.Surname} зараховано {amount}UAN", amount));
        }


        public void Take(float sum, Account[] accounts, int user)
        {
            Account userAccount = accounts[user];

            if (Money < sum)
            {
                Notify?.Invoke(this, new BankOperations("Вибачте, наразі ви не можете зняти кошти через технічні проблеми банку", sum));
                return;
            }

            if (userAccount.Balance < sum)
            {
                Notify?.Invoke(this, new BankOperations("Недостатньо коштів на рахунку", sum));
                return;
            }

            userAccount.Balance -= sum;
            Money -= sum;

            Notify?.Invoke(this, new BankOperations($"{sum}UAN було знято з рахунку", sum));
        }

        public bool CardTransfer(float sum, int cardNumber, Account[] account, int user)
        {
            if (account[user].Balance < sum)
            {
                Notify?.Invoke(this, new BankOperations("Недостатньо коштів на рахунку", sum));
                return false;
            }

            for (int j = 0; j < Account.amountUsers; j++)
            {
                if (account[j].CardNumber == cardNumber)
                {
                    account[user].Balance -= sum;
                    account[j].Balance += sum;
                    Notify?.Invoke(this, new BankOperations($"{sum}UAN було переведено на картку за номером {cardNumber}", sum));
                    return true;
                }
            }

            Notify?.Invoke(this, new BankOperations($"картку за номером {cardNumber} не знайдено", sum));
            return false;
        }
    }
}