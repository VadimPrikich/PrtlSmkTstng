using NUnit.Framework;

namespace mPortal
{
    [TestFixture]
    public class LoyaltyTests : AuthTestBase
    {
        [Test]
        public void OpenLoyaltyPage()
        {
            app.Nav.Loyalty();
            app.LoyaltyHelper.UserIsOnLoyaltyPrograms(); 
        }

        [Test]
        public void OpenLoyaltyPrograms()
        {
            app.Nav.Loyalty();
            app.LoyaltyHelper.NavigateToTenantLoyaltyProgramsPage();
            app.LoyaltyHelper.UserIsOnTenantLoyaltyPrograms();
        }

        [Test]
        public void OpenSiteLoyaltyPrograms()
        {
            app.Nav.Loyalty();
            app.LoyaltyHelper.NavigateToSiteLoyaltyProgramsPage();
            app.LoyaltyHelper.UserIsOnTenantLoyaltyPrograms();
        }

        [Test]
        public void OpenLoyaltySiteConfiguration()
        {
            app.Nav.Loyalty();
            app.LoyaltyHelper.NavigateToSiteLoyaltyProgramsPage();
            app.LoyaltyHelper.NavigateToSiteLoyaltyConfiguration();
            app.LoyaltyHelper.UserIsOnLoyaltySiteConfigurationPage();
        }
    }
}