using OpenQA.Selenium;

namespace mPortal
{
    public class LoyaltyHelper : BaseHelper
    {
        //:base передача полученного драйвера в базовый (в конструктор базового класса)
        public LoyaltyHelper(AppManager manager) : base(manager)
        {
        }

        //___Verification___ 
        public LoyaltyHelper UserIsOnLoyaltyPrograms()
        {
            WaitAndVerifyElement(By.XPath("//td[contains(.,'608635')]"));
            driver.FindElement(By.XPath("//td[contains(.,'608635')]"));
            return this;
        }

        public LoyaltyHelper UserIsOnTenantLoyaltyPrograms()
        {
            WaitAndVerifyElement(By.XPath("//small[contains(.,'ID: 5')]"));
            driver.FindElement(By.XPath("//small[contains(.,'ID: 5')]"));
            return this;
        }

        public LoyaltyHelper UserIsOnSiteLoyaltyProgramsPage()
        {
            WaitAndVerifyElement(By.XPath("//div[contains(.,'P97 Loyalty')]"));
            driver.FindElements(By.XPath("//div[contains(.,'P97 Loyalty')]"));
            return this;
        }

        public LoyaltyHelper UserIsOnLoyaltySiteConfigurationPage()
        {
            WaitAndVerifyElement(By.XPath("//h3[contains(.,'Site Configuration')]"));
            driver.FindElement(By.XPath("//h3[contains(.,'Site Configuration')]"));
            return this;
        }


        //___Navigation___
        public LoyaltyHelper NavigateToTenantLoyaltyProgramsPage()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/tenant-loyalty-programs']"));
            driver.FindElement(By.XPath("//a[@href='/tenant-loyalty-programs']")).Click();
            return this;
        }

        public LoyaltyHelper NavigateToSiteLoyaltyProgramsPage()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/store-loyalty-programs']"));
            driver.FindElement(By.XPath("//a[@href='/store-loyalty-programs']")).Click();
            return this;
        }

        public LoyaltyHelper NavigateToSiteLoyaltyConfiguration()
        {
            WaitAndVerifyElement(By.XPath("//tr[1]/td[6]/button"));
            driver.FindElement(By.XPath("//tr[1]/td[6]/button")).Click();
            return this;
        }
    }
}