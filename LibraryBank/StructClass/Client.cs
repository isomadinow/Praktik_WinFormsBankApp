using System;
using System.Collections.Generic;


namespace LibraryBank
{
    public struct Client
    {
        public string FullName { get; set; }
        public string Passport { get; set; }
        public string Phone { get; set; }
    
        public Client(string fullName, string passport, string phone)
        {
           
           FullName = fullName;
            Passport = passport;
            Phone = phone;
          
        }

        public override string ToString()
        {
            return string.Format("Данные о клиенте:\n" +
                $"ФИО: {FullName}\n" +
                $"Пасортны данные:{Passport}\n" +
                $"Номер телефона:{Phone}\n"
               );
        }

    
    }
}
