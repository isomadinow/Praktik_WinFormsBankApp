using System;
using LibraryBank;
using System.Windows.Forms;
using LibraryBank.StaticClass;

namespace WindowsFormsBankApp
{
    public partial class Form1 : Form
    {
        public Bank bank;
      
        public Form1()
        {
            

            InitializeComponent();
        }


        private void buttonCreateBank_Click(object sender, EventArgs e)
        {

            string nameBank = textBoxNameBank.Text;
            string adress = textBoxAdress.Text;
            string phoneNumber = textBoxPhoneNumb.Text;
            bank = new Bank(nameBank, adress, phoneNumber);
            tabControlMain.SelectedTab = tabMain;
            tabCreateBank.Text = "Банк:"+bank.Name;
            textBoxNameBank.Enabled = false;
            textBoxAdress.Enabled=false;
            textBoxPhoneNumb.Enabled=false;
            
           
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
           
            string fio = textBoxFIO.Text;
            string passport = textBoxPassport.Text;
            string phoneNumber = textBoxPhone.Text;
            bank.AddClient(fio, passport, phoneNumber);
            listBoxClient.Items.Add(fio);
            tabControlMain.SelectedTab = tabMain;
            textBoxFIO.Text = "";
            textBoxPassport.Text = "";
            textBoxPhone.Text = "";
        }

        private void buttonAddCredit_Click(object sender, EventArgs e)
        {
            string date = textBoxCreditDate.Text;
            string view = textBoxCreditView.Text;
            double creditSumm = (double)numericCreditSum.Value;
            double creditPercent = (double)numericCreditPercent.Value;
            int creditLoan = (int)numericLCreditLoan.Value;
            bank.AddCredit(date, view, creditSumm, creditPercent, creditLoan);
            listBoxCredits.Items.Add(view);
            tabControlMain.SelectedTab = tabMain;
            textBoxCreditDate.Text = "";
            textBoxCreditView.Text = "";
            numericCreditSum.Value = 0;
            numericCreditPercent.Value = 0;
            numericLCreditLoan.Value = 0;
           
        }

        private void buttonAddDeposit_Click(object sender, EventArgs e)
        {
            string date = textBoxDateDeposit.Text;
            string view = textBoxViewDeposit.Text;
            string id = textBoxDepositId.Text;
            double depositSumm = (double)numericSumDeposit.Value;
            double depositPercent = (double)numericPercentDeposit.Value;
            bank.AddDeposit(date, depositSumm, depositPercent, view, id);
            listBoxDeposits.Items.Add(view);
            tabControlMain.SelectedTab = tabMain;
            textBoxDateDeposit.Text = "";
            textBoxViewDeposit.Text = "";
            textBoxDepositId.Text = "";
            numericSumDeposit.Value = 0;
            numericPercentDeposit.Value = 0;

        }

        private void buttonRemoveClient_Click(object sender, EventArgs e)
        {
            int index = listBoxClient.SelectedIndex;
            if (index != -1)
            {
                bank.RemoveClient(index);
                listBoxClient.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Выберите клиента");
            }
        }

        private void buttonRemoveCredit_Click(object sender, EventArgs e)
        {
            int index = listBoxCredits.SelectedIndex;
            if (index != -1)
            {
                bank.RemoveCredit(index);
                listBoxCredits.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Выберите кредит");
            }
        }

        private void buttonRemoveDeposit_Click(object sender, EventArgs e)
        {
            int index = listBoxDeposits.SelectedIndex;
            if (index != -1)
            {
                bank.RemoveDeposit(index);
                listBoxDeposits.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Выберите депозит");
            }
        }

        private void buttonShowClient_Click(object sender, EventArgs e)
        {
            int index = listBoxClient.SelectedIndex;
            if (index != -1)
            {
                MessageBox.Show(Information.GetClientInfo(bank.Clients[index]));
            }
            else
            {
                MessageBox.Show("Выберите клиента");
            }
        }

        private void buttonShowCredit_Click(object sender, EventArgs e)
        {
            int index = listBoxCredits.SelectedIndex;
            if (index != -1)
            {
                MessageBox.Show(Information.GetCreditInfo(bank.Credits[index]));
            }
            else
            {
                MessageBox.Show("Выберите кредит");
            }
        }

        private void buttonShowDeposit_Click(object sender, EventArgs e)
        {
            int index = listBoxDeposits.SelectedIndex;
            if (index != -1)
            {
                MessageBox.Show(Information.GetDepositInfo(bank.Deposits[index]));
            }
            else
            {
                MessageBox.Show("Выберите Депозит");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxLogo.Image = Properties.Resources.bb;

            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }   
        
    
}
