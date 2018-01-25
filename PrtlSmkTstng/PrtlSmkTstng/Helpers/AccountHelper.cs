using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace mPortal
{
    public class AccountHelper : BaseHelper
    {
        

        //:base передача полученного драйвера в базовый (в конструктор базового класса)
        public AccountHelper(AppManager manager) : base(manager)
        {
        }

        //1
        public AccountHelper Creation(AccountCreationData creationData)
        {
            InitNewAccountCreation();
            FillAccountForm(creationData);
            ClickContinueButton();
            return this;
        }

        //2

        //newAccountCreation
        // когда вызываем в helpere method то возвращается ссылка на него 
        public AccountHelper InitNewAccountCreation()
        {
            driver.FindElement(By.LinkText("Create Account")).Click();
            return this;
        }
                
        //newAccountCreation
        public AccountHelper FillAccountForm(AccountCreationData creationData)
        {

            Type(By.Id("email"), creationData.EmailAddress);
            Type(By.Id("newPassword"), creationData.NewPassword);
            Type(By.Id("reenterPassword"), creationData.ConfirmNewPassword);
            Type(By.Id("givenName"), creationData.GivenName);
            Type(By.Id("surname"), creationData.Surname);
            return this;
        }

        //newAccountCreation
        public AccountHelper ClickContinueButton()
        {
            driver.FindElement(By.Id("continue")).Click();
            return this;
        }

      
    }
}
