using OpenQA.Selenium;

namespace mPortal
{
    public class VelocityHelper : BaseHelper
    {
        //:base передача полученного драйвера в базовый (в конструктор базового класса)
        public VelocityHelper(AppManager manager) : base(manager)
        {
        }
        
        //___Verification___ 
        public VelocityHelper UserIsOnVelocityPage()
        {
            WaitAndVerifyElement(By.XPath("//label[contains(.,'Exclude omitted')]"));
            driver.FindElement(By.XPath("//label[contains(.,'Exclude omitted')]"));
            return this;
        }

        public VelocityHelper UserIsOnUserExemption()
        {
            WaitAndVerifyElement(By.XPath("//tr[1]/td[2]/div"));
            driver.FindElement(By.XPath("//tr[1]/td[2]/div"));
            return this;
        }

        public VelocityHelper UserIsOnStoreExemption()
        {
            WaitAndVerifyElement(By.XPath("//tr[1]/td[2]"));
            driver.FindElement(By.XPath("//tr[1]/td[2]"));
            return this;
        }

        public VelocityHelper UserIsOnVelocityParameters()
        {
            WaitAndVerifyElement(By.XPath("//label[contains(.,'Purchase Check')]"));
            driver.FindElement(By.XPath("//label[contains(.,'Purchase Check')]"));
            return this;
        }

        public VelocityHelper UserIsOnVelocityLimitsPage()
        {
            WaitAndVerifyElement(By.XPath("//label[contains(.,'Payment Methods Usage Limit')]"));
            driver.FindElement(By.XPath("//label[contains(.,'Payment Methods Usage Limit')]"));
            return this;
        }


        //___Navigation___
        public VelocityHelper NavigateToUserExemption()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/velocity/user-exemption']"));
            driver.FindElement(By.XPath("//a[@href='/velocity/user-exemption']")).Click();
            return this;
        }

        public VelocityHelper NavigateToStoreExemption()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/velocity/store-exemption']"));
            driver.FindElement(By.XPath("//a[@href='/velocity/store-exemption']")).Click();
            return this;
        }

        public VelocityHelper NavigateToVelocityParameters()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/velocity/parameters']"));
            driver.FindElement(By.XPath("//a[@href='/velocity/parameters']")).Click();
            return this;
        }

        public VelocityHelper NavigateToVelocityLimits()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/velocity-limits']"));
            driver.FindElement(By.XPath("//a[@href='/velocity-limits']")).Click();
            return this;
        }
    }
}