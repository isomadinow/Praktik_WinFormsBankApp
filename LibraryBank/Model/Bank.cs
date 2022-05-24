using LibraryBank.Interface;
using System.Collections.Generic;

namespace LibraryBank
{
    public class Bank: IBank
    {
        public string Name { get; set; }
        public string CenterOfficeAdress { get; set; }
        public string PhoneNumeber { get; set; }
        public List<Client> Clients { get; set; }
        public List<Credit> Credits { get; set; }
        public List<Deposit> Deposits { get; set; }

        public Bank(string name, string centerOfficeAdress, string phoneNumber)
        {
            Name = name;
            CenterOfficeAdress = centerOfficeAdress;
            PhoneNumeber = phoneNumber;
            Clients = new List<Client>();
            Credits = new List<Credit>();
            Deposits = new List<Deposit>();

        }
     

        public void AddClient(string Fio, string passport, string phone)
        {
            Client client = new Client(Fio,passport,phone);
             Clients.Add(client);
        }
        public void RemoveClient(int index)
        {
            if(Clients.Count>index && index>=0) Clients.RemoveAt(index);
        }

        public void AddCredit(string dateTime, string view, double summ, double percent, int loanMaturity)
        {
            Credit credit = new Credit(dateTime, view, summ, percent, loanMaturity);
            Credits.Add(credit);
        }
        public void RemoveCredit(int index)
        {
            if (index >= 0 && index < Credits.Count) Credits.RemoveAt(index);
        }
        public void AddDeposit(string dateTime, double summ, double percent, string view, string idNumber)
        {
            Deposit deposit = new Deposit(dateTime, view, idNumber, summ, percent);
            Deposits.Add(deposit);
        }
        public void RemoveDeposit(int index)
        {
            if (index >= 0 && index < Deposits.Count) Deposits.RemoveAt(index);
        }

      

        public string GetBankData()
        {
            return string.Format("Данные о банке:\n" +
                $"Название:{Name}\n" +
                $"Офис Центральный:{CenterOfficeAdress}\n" +
                $"Телефонный номер банка: {PhoneNumeber}\n"
                );
        }

    }
}
