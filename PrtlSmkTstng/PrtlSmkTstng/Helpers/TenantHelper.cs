using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace mPortal
{
    public class TenantHelper : BaseHelper
    {
        //:base передача полученного драйвера в базовый (в конструктор базового класса)
        public TenantHelper(AppManager manager) : base(manager)
        {
        }

        //___Verification___ 
        public TenantHelper UserIsOnTenantsPage()
        {
            WaitAndVerifyElement(By.XPath("//small[contains(.,'7ed17b4a-27d7-45ed-89e1-8330db86c6a1')]"));
            driver.FindElement(By.XPath("//small[contains(.,'7ed17b4a-27d7-45ed-89e1-8330db86c6a1')]"));
            return this;
        }

        public TenantHelper UserIsOnTenantPropertiesPage()
        {
            WaitAndVerifyElement(By.XPath("//span[contains(.,'ActiveAlert.EventCode.DefaultRetentionTime')]"));
            driver.FindElement(By.XPath("//span[contains(.,'ActiveAlert.EventCode.DefaultRetentionTime')]"));
            return this;
        }

        public TenantHelper UserIsOnMobileLocalesStringPage()
        {
            WaitAndVerifyElement(By.XPath("//span[contains(.,'Add Chase Pay')]"));
            driver.FindElement(By.XPath("//span[contains(.,'Add Chase Pay')]"));
            return this;
        }

        public TenantHelper UserIsOnMobileLocalesDiffPage()
        {
            WaitAndVerifyElement(By.XPath("//td[contains(.,'add_chase_pay_title')]"));
            driver.FindElement(By.XPath("//td[contains(.,'add_chase_pay_title')]"));
            return this;
        }

        public TenantHelper UserIsOnMobileLocalesLanguagePage()
        {
            WaitAndVerifyElement(By.XPath("//span[contains(.,'English')][1]"));
            driver.FindElement(By.XPath("//span[contains(.,'English')][1]"));
            return this;
        }

        public TenantHelper UserIsOnMobileFeatures()
        {
            WaitAndVerifyElement(By.XPath("//td[contains(.,'CONTACT_PHONE_IN_SETTINGS')]"));
            driver.FindElement(By.XPath("//td[contains(.,'CONTACT_PHONE_IN_SETTINGS')]"));
            return this;
        }


        //_______Navigation______
        public TenantHelper NavigateToTenantPropertiesPage()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/tenant-properties']"));
            driver.FindElement(By.XPath("//a[@href='/tenant-properties']")).Click();
            return this;
        }

        public TenantHelper NavigateToMobileAppLocales()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/mobile-app-locales/strings']"));
            driver.FindElement(By.XPath("//a[@href='/mobile-app-locales/strings']")).Click();
            return this;
        }

        public TenantHelper NavigateToMobileFeatures()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/mobile-features']"));
            driver.FindElement(By.XPath("//a[@href='/mobile-features']")).Click();
            return this;
        }

        public TenantHelper NavigateToMobileAppLocalesDiff()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/mobile-app-locales/diff']"));
            driver.FindElement(By.XPath("//a[@href='/mobile-app-locales/diff']")).Click();
            return this;
        }

        public TenantHelper NavigateToMobileAppLocalesLanguage()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/mobile-app-locales/languages']"));
            driver.FindElement(By.XPath("//a[@href='/mobile-app-locales/languages']")).Click();
            return this;
        }

    }
}
