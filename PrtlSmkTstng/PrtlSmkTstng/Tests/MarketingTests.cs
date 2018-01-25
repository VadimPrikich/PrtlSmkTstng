using NUnit.Framework;

namespace mPortal
{
    [TestFixture]
    public class MarketingTests : AuthTestBase
    {
        [Test]
        public void OpenMarketingOffer()
        {
            app.Nav.Marketing();
            app.MarketingHelper.UserIsOnMarketingOffersPage();
        }

        [Test]
        public void OpenTenantConfiguration()
        {
            app.Nav.Marketing();
            app.MarketingHelper.NavigateToTenantConfiguration();
            app.MarketingHelper.UserIsOnOfferDetailsConfiguration();
        }

        [Test]
        public void OpenMarketingReport()
        {
            app.Nav.Marketing();
            app.MarketingHelper.NavigateToOffersReport();
            app.MarketingHelper.UserIsOnOffersReport();
        }

        [Test]
        public void OpenPromoCards()
        {
            app.Nav.Marketing();
            app.MarketingHelper.NavigateToPromoCards();
            app.MarketingHelper.UserIsOnPromoCards();
        }
    }
}
