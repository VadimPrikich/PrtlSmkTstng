using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPortal
{
    //вспомогательный класс
    public class AccountData
    {
        private string emailAddress;
        private string userPassword;

        //конструктор 
        public AccountData(string emailAddress, string userPassword)
        {
            this.emailAddress = emailAddress;
            this.userPassword = userPassword;
        }
        //свойства
        public string EmailAddress
        {
            //возвращает значение
            get
            {
                return emailAddress;
            }
            //присваивает значение
            set
            {
                emailAddress = value;
            }
        }

        public string UserPassword
        {
            //возвращает значение
            get
            {
                return userPassword;
            }
            //присваивает значение
            set
            {
                userPassword = value;
            }
        }
    }
}
