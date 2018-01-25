using OpenQA.Selenium;

namespace mPortal
{
    public class BillingHelper : BaseHelper
    {
        public BillingHelper(AppManager manager) : base(manager)
        {
        }

        //___Verification___ 
        public BillingHelper UserIsOnBillingPage()
        {
            WaitAndVerifyElement(By.XPath("//tr[1]/td[2]"));
            driver.FindElements(By.XPath("//tr[1]/td[2]"));
            return this;
        }

        public BillingHelper UserIsOnLicensesPage()
        {            
            WaitAndVerifyElement(By.XPath("//label[@for='siteLicenses']"));
            driver.FindElement(By.XPath("//label[@for='siteLicenses']"));
            return this;
        }

        //___Navigation___
        public BillingHelper NavigateToLicensesPage()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/licenses']"));
            driver.FindElement(By.XPath("//a[@href='/licenses']")).Click();
            return this;
        }
    }    
}
