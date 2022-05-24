using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBank.Interface
{
    public interface IBank
    {
        void AddClient(string name, string passport, string phone);
        void RemoveClient(int index);
        void AddCredit(string dateTime, string view, double summ, double percent, int loanMaturity);
        void RemoveCredit(int index);
        void AddDeposit(string dateTime, double summ, double percent, string view, string idNumber);
        void RemoveDeposit(int index);
    }
}
