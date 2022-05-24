using System;

namespace LibraryBank.StaticClass
{
    public static class Information
    {
        public static string GetClientInfo(Client client)
        {
            return client.ToString();
        }
        public static string GetCreditInfo(Credit credit)
        {
            return credit.GetInfo();
        }
        public static string GetDepositInfo(Deposit deposit)
        {
            return deposit.GetInfo();
        }
    }
}
