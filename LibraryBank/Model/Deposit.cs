using System;
namespace LibraryBank
{
    public class Deposit:BankingService
    {
        public string View { get; set; }
        public string IdNumber { get; set; }
        public Deposit(string dateTime , string view,string idNumber,
            double summ, double percent):base(dateTime,summ,percent)
        {
            View = view;
            IdNumber = idNumber;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + String.Format($"Вид: {View}\n" +
                $"Номер счёта: {IdNumber}.");
        }
      
    }
}
