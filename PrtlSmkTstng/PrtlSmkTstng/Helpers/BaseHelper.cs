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
    //Общие методы для всех помощников
    public class BaseHelper
    {
        //поле driver
        //protected что бы было доступно в классах наследниках
        protected IWebDriver driver;
        protected AppManager manager;

        //конструктор. на вход принимает ссылку на дравер через который мы управляем браузером и присваивает в поле
        public BaseHelper (AppManager manager)
        {
            //переданное значение объект будет присваиваться в поле field.
            driver = manager.Driver;
            this.manager = manager;
        }

        public void Type(By locator, string text)
        {
            //заполнить поле если не null
            if (text != null)
            {
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);
    
            }
        }

        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void WaitAndVerifyElement(By locator)
        {
            for (int second = 0; ; second++)
            {
                if (second >= 60) Assert.Fail("timeout");
                try
                {
                    if (IsElementPresent(locator)) break;
                }
                catch (Exception)
                { }
                Thread.Sleep(1000);
            }
        }

        public bool UserIsOnQAPortal()
        {
            string URL = driver.Url.ToString();
            return Assert.Equals(URL, "https://manage-qa.petrozone.com/");
        }

        //public bool WaitUntilLoaderHidden(this IWebDriver driver, int timeout = 10)
        //{
        //    for (var i = 0; i < timeout; i++)
        //    {
        //        IWebElement element = driver.FindElement(By.XPath("//div[@class='overlay']"));
        //        Console.WriteLine(element);
        //        string elementVisibility = element.GetCssValue("visibility");
        //        if (elementVisibility == "hidden") return true;
        //        Thread.Sleep(1000);
        //        Console.WriteLine();
        //    }
        //    return false;
        //}
                
    }
}