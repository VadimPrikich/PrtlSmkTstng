using NUnit.Framework;


namespace mPortal
{
    [TestFixture]
    public class TransactionsTests : AuthTestBase
    {
        [Test]
        public void OpenTransactionsPage()
        {
            app.Nav.Transactions();
            app.TransactionsHelper.UserIsOnTransactionsPage();
        }

        [Test]
        public void OpenTransactionsReportPage()
        {
            app.Nav.Transactions();
            app.TransactionsHelper.UserNavigatesToTransactionsReportPage();
            app.TransactionsHelper.UserIsOnTransactionReportPage();
        }


    }
}

