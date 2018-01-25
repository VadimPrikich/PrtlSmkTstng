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
    public class StoresHelper : BaseHelper
    {
        //:base передача полученного драйвера в базовый (в конструктор базового класса)
        public StoresHelper(AppManager manager) : base(manager)
        {
        }

        //___Verification___ 
        public StoresHelper UserIsOnStoresPage()
        {
            WaitAndVerifyElement(By.XPath("//input[@placeholder='Search by store ID, MPPA ID, number, name, address, city, state, zip']"));
            driver.FindElement(By.XPath("//input[@placeholder='Search by store ID, MPPA ID, number, name, address, city, state, zip']"));
            return this;
        }

       
    }
}
