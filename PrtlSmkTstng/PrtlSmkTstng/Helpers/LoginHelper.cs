using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace mPortal
{
    //класс для всего что связано с логином и логаутом
    public class LoginHelper : BaseHelper
    {

        
        //конструктор для передачи информации о driver.
        //в качестве параметра будем передавать driver.
        public LoginHelper(AppManager manager) : base(manager)
        {
        }

        //private void Login(string username, string password)
        public LoginHelper Login(AccountData account)
        {
            //UserOnHomePage();
            //проверим если логин выполнен тогда не делать логин ещё раз 
            //if (IsLoggedIn())
            //{
            //    if (IsLoggedIn(account))
            //    {
            //        //если мы залогинены под нужным аккаунтом тогда не нужно ничего делать
            //        return this;
            //    }
            //    //если залогинены в систему но не под правильной учеткой тогда разлогинится и залогинится под нужной
            //    Logout();
            //}
            //и залогинится под нужной c требуемыми параметрами
            if (IsLoggedIn())
            {
            }
            else
            {                
                manager.Nav.SignIn();

                if (LogginAgain())
                {
                    CkickAnotherAccountButton();
                }

                Type(By.Id("cred_userid_inputtext"), account.EmailAddress);
                Type(By.Id("cred_password_inputtext"), account.UserPassword);

                driver.FindElement(By.Id("cred_sign_in_button")).Click();
                
                //this element could be found only then user is logged in
                WaitAndVerifyElement(By.XPath("//span[contains(@ng-if,'controller.getLastLoginTime()')]"));
            }
            return this;
        }



        private void CkickAnotherAccountButton()
        {
            WaitAndVerifyElement(By.XPath("//img[@alt='Use another account']"));
            driver.FindElement(By.XPath("//img[@alt='Use another account']")).Click();
        }


        //public void Logout()
        //{
        //    if (IsLoggedIn())
        //    {
        //        driver.FindElement(By.XPath("//a[contains(.,'Sign Out')]")).Click();
        //    }            
        //}

        public LoginHelper Logout()
        {
            if (IsLoggedIn())
            {
                //driver.FindElement(By.XPath("//a[contains(.,'Sign Out')]")).Click();
                driver.FindElement(By.XPath("//span[@class='top-menu--user--text ng-binding']")).Click();
                driver.FindElement(By.XPath("//a[@ng-click='controller.signOut()']")).Click();
            }
            return this;
        }

        public bool IsLoggedIn()
        {
            //нужна проверка чтоб догадаться вошли ли мы в систему или нет
            //форма логина
            //какой то элемент
            return IsElementPresent(By.XPath("//span[@class='top-menu--last-login ng-binding ng-scope']"));
        }

        public bool LogginAgain()
        {
            return IsElementPresent(By.CssSelector("#login_user_chooser[style*=block]"));
        }


        //public bool IsLoggedIn()
        //{
        //    //нужна проверка чтоб догадаться вошли ли мы в систему или нет
        //    //форма логина
        //    //какой то элемент
        //    return IsElementPresent(By.XPath("//h4[contains(.,'Summary')]")); //|| IsElementPresent(By.XPath("//a[contains(@class,'header--email ng-binding')]")); ;
        //    //return IsElementPresent(By.XPath("//a[@class='up_header--email ng-binding']"));
        //}

        public bool IsLoggedIn(AccountData account)
        {
            //проверяем что мы залогинины
            return IsLoggedIn()
                &&
            driver.FindElement(By.XPath("//span[@class='top-menu--user--text ng-binding']")).Text == account.EmailAddress;
            //и проверяем что мы залогинены под нужным аккаунтом 
            //находим элемент logout и внутри него 
            //&& driver.FindElement(By.XPath("//a[contains(.,'Sign Out')]")).FindElement(By.TagName("a")).Text == "(" + account.EmailAddress + ")";
            //&& driver.FindElement(By.XPath("//a[@class='up_header--email ng-binding']")).Text == "(" + account.EmailAddress + ")";
            //&& driver.FindElement(By.XPath("//a[@class='up_header--email ng-binding']")).FindElement(By.TagName("a")).Text == "(" + account.EmailAddress + ")";

        }

       

        //from home Helper -> BaseHelper then it can be used by different helpers not only homePage helper but login helper
        private bool UserOnHomePage()
        {
            return IsElementPresent(By.XPath("//a[contains(.,'PetroZone')]"));
        }

    }
}
  