using NUnit.Framework;

namespace mPortal
{
    [TestFixture]
    public class BillingTestsTests : AuthTestBase
    {
        [Test]
        public void OpenBillingReportPage()
        {
            app.Nav.Billing();
            app.BillingHelper.UserIsOnBillingPage();
        }

        [Test]
        public void OpenLicensesReport()
        {
            app.Nav.Billing();
            app.BillingHelper.NavigateToLicensesPage();
            app.BillingHelper.UserIsOnLicensesPage();
        }
    }
}