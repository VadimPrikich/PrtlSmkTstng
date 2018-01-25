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
    public class NavigationHelper : BaseHelper
    {
        private string baseURL;
        
        //конструктор для передачи информации о driver.
        //в качестве параметра будем передавать driver.
        public NavigationHelper(AppManager manager, string baseURL) : base(manager)
        {
            this.baseURL = baseURL;
        }

        //если мы находимся на той же странице то переход не делать 
        public void OpenHomePage()
        {
            if (driver.Url == baseURL)
            {
                return;
            }
            //Open Home page
            driver.Navigate().GoToUrl(baseURL);
        }

        
        public NavigationHelper SignIn()
        {
            WaitAndVerifyElement(By.XPath("//a[@class='top-menu--signin']")); 
            driver.FindElement(By.XPath("//a[@class='top-menu--signin']")).Click();
            return this;
        }
        
        //____Left Menu_______
        public NavigationHelper Users()
        {
            WaitAndVerifyElement(By.XPath("//a[@title='Users']"));
            driver.FindElement(By.XPath("//a[@title='Users']")).Click();
            return this;
        }

        public NavigationHelper Stores()
        {
            WaitAndVerifyElement(By.XPath("//a[@title='Stores']"));
            driver.FindElement(By.XPath("//a[@title='Stores']")).Click();
            return this;
        }

        public NavigationHelper Transactions()
        {
            WaitAndVerifyElement(By.XPath("//a[@title='Transactions']"));
            driver.FindElement(By.XPath("//a[@title='Transactions']")).Click();
            return this;
        }

        public NavigationHelper Tenants()
        {
            WaitAndVerifyElement(By.XPath("//a[@title='Tenants']"));
            driver.FindElement(By.XPath("//a[@title='Tenants']")).Click();
            return this;
        }

        public NavigationHelper Analytics()
        {
            WaitAndVerifyElement(By.XPath("//a[@title='Analytics']"));
            driver.FindElement(By.XPath("//a[@title='Analytics']")).Click();
            return this;
        }

        public NavigationHelper Marketing()
        {
            WaitAndVerifyElement(By.XPath("//a[@title='Marketing']"));
            driver.FindElement(By.XPath("//a[@title='Marketing']")).Click();
            return this;
        }

        public NavigationHelper Billing()
        {
            WaitAndVerifyElement(By.XPath("//a[@title='Billing']"));
            driver.FindElement(By.XPath("//a[@title='Billing']")).Click();
            return this;
        }

        public NavigationHelper SystemMonitoring()
        {
            WaitAndVerifyElement(By.XPath("//a[@title='System Monitoring']"));
            driver.FindElement(By.XPath("//a[@title='System Monitoring']")).Click();
            return this;
        }

        public NavigationHelper Simulations()
        {
            WaitAndVerifyElement(By.XPath("//a[@title='Simulations']"));
            driver.FindElement(By.XPath("//a[@title='Simulations']")).Click();
            return this;
        }

        public NavigationHelper Loyalty()
        {
            WaitAndVerifyElement(By.XPath("//a[@title='Loyalty']"));
            driver.FindElement(By.XPath("//a[@title='Loyalty']")).Click();
            return this;
        }

        public NavigationHelper Velocity()
        {
            WaitAndVerifyElement(By.XPath("//a[@title='Velocity']"));
            driver.FindElement(By.XPath("//a[@title='Velocity']")).Click();
            return this;
        }

        public NavigationHelper UserSettings()
        {
            WaitAndVerifyElement(By.XPath("//a[@ui-sref='user-settings']"));
            driver.FindElement(By.XPath("//a[@ui-sref='user-settings']")).Click();
            return this;
        }

        public NavigationHelper HomePage()
        {

            return this;
        }
               
    }
}
