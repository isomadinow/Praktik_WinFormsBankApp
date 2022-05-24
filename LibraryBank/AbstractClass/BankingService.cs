using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBank
{
 
    public abstract class BankingService
    {
        public  string DateTime { get; set; }
        public double Summ { get; set; }
        public double Percent { get; set; }

        public BankingService(string dateTime, double summ, double percent)
        {
            this.DateTime = dateTime;
            this.Summ = summ;
            this.Percent = percent;
        }
        public virtual  string GetInfo()
        {
            return string.Format(
              $"Дата: {DateTime}.\n" +
              $"Сумма: {Summ}.\n" +
              $"Процент: {Percent}.\n");
        }
       

    }
}
