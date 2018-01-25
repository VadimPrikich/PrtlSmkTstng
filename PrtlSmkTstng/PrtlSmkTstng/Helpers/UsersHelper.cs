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
    public class UsersHelper : BaseHelper
    {
        

        //:base передача полученного драйвера в базовый (в конструктор базового класса)
        public UsersHelper(AppManager manager) : base(manager)
        {
        }

        //___Verification___ 
        public UsersHelper UserIsOnManagmentPortalUsersPage()
        {
            driver.FindElement(By.XPath("//h3[contains(.,'Management Portal Users')]"));
            return this;
        }

        //____Verification____
        public UsersHelper UserIsOnMobileUsersPage()
        {
            driver.FindElement(By.XPath("//h3[contains(.,'Mobile App Users')]"));
            return this;
        }

        //____Verification____
        public UsersHelper UserIsOnRolesPage()
        {
            driver.FindElement(By.XPath("//label[contains(.,'Role Name:')]"));
            return this;
        }

        //____Verification_____
        public UsersHelper UserIsOnAddUserPage()
        {
            driver.FindElement(By.XPath("//h2[contains(.,'Add New User to Management Portal')]"));
            return this;
        }

        //____Navigation_____
        public UsersHelper NavigateToMobileAppUsers()
        {
            WaitAndVerifyElement(By.XPath("//a[@ui-sref='users.mobile']"));
            driver.FindElement(By.XPath("//a[@ui-sref='users.mobile']")).Click();
            return this;
        }

        //___Navigation_____
        public UsersHelper NavigateToRoles()
        {
            
            //WaitAndVerifyElement(By.XPath("//a[@href='/security-groups']"));
            driver.FindElement(By.XPath("//a[@href='/security-groups']")).Click();
            return this;
        }

        //____Navigation_____
        public UsersHelper NavigateToAddUser()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/invite-users']"));
            driver.FindElement(By.XPath("//a[@href='/invite-users']")).Click();
            return this;
        }

        public UsersHelper IfUserIsOnQAPortal()
        {
            if (UserIsOnQAPortal())
            {
                //do test for QA env
            }
            return this;
        }
        //newAccountCreation
        // когда вызываем в helpere method то возвращается ссылка на него 
        //public AccountHelper InitNewAccountCreation()
        //{
        //    driver.FindElement(By.LinkText("Create Account")).Click();
        //    return this;
        //}

        ////newAccountCreation
        //public AccountHelper FillAccountForm(AccountCreationData creationData)
        //{

        //    Type(By.Id("email"), creationData.EmailAddress);
        //    Type(By.Id("newPassword"), creationData.NewPassword);
        //    Type(By.Id("reenterPassword"), creationData.ConfirmNewPassword);
        //    Type(By.Id("givenName"), creationData.GivenName);
        //    Type(By.Id("surname"), creationData.Surname);
        //    return this;
        //}

        ////newAccountCreation
        //public AccountHelper ClickContinueButton()
        //{
        //    driver.FindElement(By.Id("continue")).Click();
        //    return this;
        //}


    }
}
