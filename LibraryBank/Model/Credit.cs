using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBank
{

    public class Credit:BankingService
    {
        public string View { get; set; }
        public int LoanMaturity  { get; set; } 

       
        public Credit(string dateTime, string view, double summ,
            double percent, int loanMaturity) : base(dateTime, summ, percent)
        {
            View = view;
            LoanMaturity = loanMaturity;
        }
        public override string GetInfo()
        {
            return base.GetInfo() + String.Format(
               $"Вид: {View}\n" +
                $"Срок погашение: {LoanMaturity} года.\n");
                
        }
       


    }
}
