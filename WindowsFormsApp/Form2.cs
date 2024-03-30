using System;
using System.Windows.Forms;
using ClassLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        private Form1 parentForm;
        private Account account;
        private AutomatedTellerMachine atm;
        private Bank bank;
        private Account[] accounts;


        float ParseInput(string text)
        {
            float.TryParse(text, out float result);
            return result;
        }

        public Form2(Form1 parentForm, Account account, AutomatedTellerMachine atm, Bank bank, Account[] accounts)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.account = account;
            this.atm = atm;
            this.bank = bank;
            this.accounts = accounts;
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            labelRecipientCard.Visible = false;
            textBoxRecipientCard.Visible = false;
            buttonConfirmTransfer.Visible = false;
            buttonCancelTransfer.Visible = false;

            textBoxCash.Text = $"Баланс: {account.Balance}";
        }

        private void buttonConfirmTransfer_Click(object sender, EventArgs e)
        {
            float sum = ParseInput(textBoxAmount.Text);
            int recipientCard = (int)ParseInput(textBoxRecipientCard.Text);

            Account recipientAccount = null;
            foreach (Account acc in accounts)
            {
                if (acc.CardNumber == recipientCard)
                {
                    recipientAccount = acc;
                    break;
                }
            }

            if (recipientAccount == null)
            {
                MessageBox.Show("Отримувача не знайдено в базі даних банку.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sum > account.Balance)
            {
                MessageBox.Show("Сума переказу перевищує ваш доступний баланс.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool transferSuccess = atm.CardTransfer(sum, recipientCard, new Account[] { account, recipientAccount }, 0);

            if (transferSuccess)
            {
                MessageBox.Show($"Переказ грошей на суму {sum} UAN виконано успішно.", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                float newBalance = account.Balance;
                parentForm.UpdateBalance(newBalance);
                textBoxCash.Text = $"Баланс: {newBalance}";

                labelRecipientCard.Visible = false;
                textBoxRecipientCard.Visible = false;
                buttonConfirmTransfer.Visible = false;
                buttonCancelTransfer.Visible = false;

                buttonWithdrawCash.Visible = true;
                buttonDeposit.Visible = true;
                buttonAccountInfo.Visible = true;
                buttonStartTransfer.Visible = true;
            }
            else
            {
                MessageBox.Show("Помилка під час виконання переказу. Спробуйте ще раз.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Close();
        }

        private void buttonAccountInfo_Click(object sender, EventArgs e)
        {
            string userInfo = $"Ім'я: {account.Name}\nПризвіще: {account.Surname}\nНомер картки: {account.CardNumber}\nБаланс: {account.Balance} UAN";
            MessageBox.Show(userInfo, "Інформація про обліковий запис", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            float depositAmount = ParseInput(textBoxAmount.Text);

            if (depositAmount <= 0)
            {
                MessageBox.Show("Сума для поповнення повинна бути більше нуля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            atm.Put(depositAmount, account);

            float newBalance = account.Balance;
            parentForm.UpdateBalance(newBalance);

            textBoxCash.Text = $"Баланс: {newBalance}";

            MessageBox.Show($"Баланс успішно поповнено на {depositAmount} UAN.", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonWithdrawCash_Click(object sender, EventArgs e)
        {
            float withdrawAmount = ParseInput(textBoxAmount.Text);

            if (withdrawAmount <= 0)
            {
                MessageBox.Show("Сума для зняття повинна бути більше нуля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            atm.Take(withdrawAmount, new Account[] { account }, 0);

            float newBalance = account.Balance;
            parentForm.UpdateBalance(newBalance);

            textBoxCash.Text = $"Баланс: {newBalance}";

            MessageBox.Show($"Гроші у сумі {withdrawAmount} UAN успішно знято з вашого рахунку.", "Успішно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string text = textBox.Text;

            if (System.Text.RegularExpressions.Regex.IsMatch(text, "[^0-9]"))
            {
                textBox.Text = System.Text.RegularExpressions.Regex.Replace(text, "[^0-9]", "");
            }
        }

        private void textBoxRecipientCard_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string text = textBox.Text;

            if (System.Text.RegularExpressions.Regex.IsMatch(text, "[^0-9]"))
            {
                textBox.Text = System.Text.RegularExpressions.Regex.Replace(text, "[^0-9]", "");
            }
        }

        private void buttonStartTransfer_Click(object sender, EventArgs e)
        {
            labelRecipientCard.Visible = true;
            textBoxRecipientCard.Visible = true;
            buttonConfirmTransfer.Visible = true;
            buttonCancelTransfer.Visible = true;

            buttonWithdrawCash.Visible = false;
            buttonDeposit.Visible = false;
            buttonAccountInfo.Visible = false;
            buttonStartTransfer.Visible = false;
        }

        private void buttonCancelTransfer_Click(object sender, EventArgs e)
        {
            labelRecipientCard.Visible = false;
            textBoxRecipientCard.Visible = false;
            buttonConfirmTransfer.Visible = false;
            buttonCancelTransfer.Visible = false;

            buttonWithdrawCash.Visible = true;
            buttonDeposit.Visible = true;
            buttonAccountInfo.Visible = true;
            buttonStartTransfer.Visible = true;
        }
    }
}