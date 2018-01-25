using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using System.Threading;

namespace mPortal
{

    public class HomePageHelper : BaseHelper
    {
        public HomePageHelper(AppManager manager) : base(manager)
        {
        }

        public HomePageHelper NewsLetterEmail(AccountData email)
        {

            if (UserOnHomePage())
            {
                //если мы on home page ничего делать
                return this;
            }
            //если not on home page then navigate on home page
            else manager.Nav.OpenHomePage();

            Type(By.Name("newsletterEmail"), email.EmailAddress);
            //driver.FindElement(By.Name("newsletterEmail")).Clear();
            //driver.FindElement(By.Name("newsletterEmail")).SendKeys("example@gmail.com");
            //driver.FindElement(By.CssSelector("button.main_landing--subscribe--mail_inp--btn.ng-binding")).Click();
            ClickSubmit();
            Thread.Sleep(500);
            Assert.AreEqual("Your subscription has been confirmed!", driver.FindElement(By.CssSelector("label.ng-binding")).Text);
            return this;
        }

        private bool UserOnHomePage()
        {
            return IsElementPresent(By.CssSelector("h4.ng-binding"));
        }


        public HomePageHelper ClickSubmit()
        {
            driver.FindElement(By.CssSelector("button.main_landing--subscribe--mail_inp--btn.ng-binding")).Click();
            return this;
        }


    }
}
