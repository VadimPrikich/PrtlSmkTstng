using OpenQA.Selenium;

namespace mPortal
{
    public class TransactionsHelper : BaseHelper
    {
        public TransactionsHelper(AppManager manager) : base(manager)
        {
        }

        //___Verification___ 
        public TransactionsHelper UserIsOnTransactionsPage()
        {
            WaitAndVerifyElement(By.XPath("//button[contains(@ng-click,'controller.searchTransactions(true, true)')]"));
            driver.FindElement(By.XPath("//button[contains(@ng-click,'controller.searchTransactions(true, true)')]"));
            return this;
        }

        public TransactionsHelper UserIsOnTransactionReportPage()
        {
            WaitAndVerifyElement(By.XPath("//th[contains(.,'Store Name')]"));
            driver.FindElement(By.XPath("//th[contains(.,'Store Name')]"));
            return this;
        }

        //____Navigation____
        public TransactionsHelper UserNavigatesToTransactionsReportPage()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/transactions-report']"));
            driver.FindElement(By.XPath("//a[@href='/transactions-report']")).Click();
            return this;
        }

    }
}