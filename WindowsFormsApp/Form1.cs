using System;
using System.Windows.Forms;
using ClassLibrary;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        Account[] accounts =
        {
            new Account ("account", "1", 11, 11, 1000),
            new Account ("account", "2", 22, 22, 200),
        };

        AutomatedTellerMachine atm = new AutomatedTellerMachine(150000, "#0001", "вул. Абрикосова");
        Bank bank = new Bank("Bank", 1);
        int user;

        public void UpdateBalance(float newBalance)
        {
            accounts[user].Balance = newBalance;
        }

        public float GetBalance()
        {
            return accounts[user].Balance;
        }


        public Form1()
        {
            InitializeComponent();
        }

        float ParseInput(string text)
        {
            if (!float.TryParse(text, out float result))
            {
                MessageBox.Show("Помилка введення значення. Будь-ласка, повторіть введення ще раз!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = this;
            int cardNumber = (int)ParseInput(textBoxCardNum.Text);
            int pinCode = (int)ParseInput(textBoxPinCode.Text);
            bool authenticationSuccess = bank.Authentication(cardNumber, pinCode, accounts, out user);

            if (authenticationSuccess)
            {
                textBoxCardNum.Text = "";
                textBoxPinCode.Text = "";
                MessageBox.Show("Ви успішно авторизувались.", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                float balance = accounts[user].Balance;
                Form2 form2 = new Form2(form1, accounts[user], atm, bank, accounts);
                form2.Owner = form1;
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильний номер картки або ПІН-код.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCardNum.Text = "";
                textBoxPinCode.Text = "";
            }
        }

        private void textBoxCardNum_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string text = textBox.Text;

            if (System.Text.RegularExpressions.Regex.IsMatch(text, "[^0-9]"))
            {
                textBox.Text = System.Text.RegularExpressions.Regex.Replace(text, "[^0-9]", "");
            }
        }

        private void textBoxPinCode_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string text = textBox.Text;

            if (System.Text.RegularExpressions.Regex.IsMatch(text, "[^0-9]"))
            {
                textBox.Text = System.Text.RegularExpressions.Regex.Replace(text, "[^0-9]", "");
            }
        }
    }
}
