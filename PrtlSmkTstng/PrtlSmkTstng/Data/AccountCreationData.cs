using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mPortal
{
    public class AccountCreationData
    {
        //private string emailAddress;
        private string newPassword;
        private string confirmNewPassword;
        private string givenName;
        private string surname;
        
        public AccountCreationData(string emailAddress)
        {
            //this.emailAddress = emailAddress;
        }

        public AccountCreationData(string emailAddress, string givenName) : this()
        {
            EmailAddress = emailAddress;
            this.givenName = givenName;
        }

        public AccountCreationData()
        {
            //var personNameGenerator = new PersonNameGenerator();
            //GivenName = personNameGenerator.GenerateRandomFirstName();
            // EmailAddress = personNameGenerator.Ge();
        } 

        public string EmailAddress
        {
            //возвращает значение
            get;
            //присваивает значение
            set;
        }

        public string NewPassword
        {
            //возвращает значение
            get
            {
                return newPassword;
            }
            //присваивает значение
            set
            {
                newPassword = value;
            }
        }

        public string ConfirmNewPassword
        {
            //возвращает значение
            get
            {
                return confirmNewPassword;
            }
            //присваивает значение
            set
            {
                confirmNewPassword = value;
            }
        }

        public string GivenName
        {
            //возвращает значение
            get
            {
                return givenName;
            }
            //присваивает значение
            set
            {
                givenName = value;
            }
        }

        public string Surname
        {
            //возвращает значение
            get
            {
                return surname;
            }
            //присваивает значение
            set
            {
                surname = value;
            }
        }

       

        
    }
}
