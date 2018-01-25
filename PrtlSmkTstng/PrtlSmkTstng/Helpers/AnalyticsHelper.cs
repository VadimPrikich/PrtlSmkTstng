using OpenQA.Selenium;

namespace mPortal
{
    public class AnalyticsHelper : BaseHelper
    {


        //:base передача полученного драйвера в базовый (в конструктор базового класса)
        public AnalyticsHelper(AppManager manager) : base(manager)
        {
        }

        //___Verification___ 
        public AnalyticsHelper UserIsOnAnalyticsReport()
        {
            WaitAndVerifyElement(By.CssSelector("#reportContainer"));
            driver.FindElement(By.CssSelector("#reportContainer"));
            return this;
        }

        public AnalyticsHelper UserIsOnAnalyticsInternalDiag()
        {
            WaitAndVerifyElement(By.CssSelector("#reportContainer"));
            driver.FindElement(By.CssSelector("#reportContainer"));
            return this;
        }

        public AnalyticsHelper UserIsOnAnalyticsConfig()
        {
            WaitAndVerifyElement(By.XPath("//small[contains(.,'00000000-0000-0000-0000-000000000000')]"));
            driver.FindElement(By.XPath("//small[contains(.,'00000000-0000-0000-0000-000000000000')]"));
            return this;
        }

        //_____Navigation____
        public AnalyticsHelper NavigateToAnalyticsInternalDiag()
        {
            WaitAndVerifyElement(By.XPath("//select[@class='form-control ng-pristine ng-valid ng-touched']"));
            driver.FindElement(By.XPath("//select[@class='form-control ng-pristine ng-valid ng-touched']")).Click();
            WaitAndVerifyElement(By.XPath("//option[contains(.,'qa-p97internaldiag')]"));
            driver.FindElement(By.XPath("//option[contains(.,'qa-p97internaldiag')]")).Click();
            return this;
        }

        public AnalyticsHelper NavigateToReportConfiguration()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/power-bi-config']"));
            driver.FindElement(By.XPath("//a[@href='/power-bi-config']")).Click();
            return this;
        }
        
    }

}