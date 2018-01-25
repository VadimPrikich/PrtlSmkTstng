using OpenQA.Selenium;

namespace mPortal
{
    public class MarketingHelper : BaseHelper
    {
        public MarketingHelper(AppManager manager) : base(manager)
        {
        }

        //___Verification___ 
        public MarketingHelper UserIsOnMarketingOffersPage()
        {
            WaitAndVerifyElement(By.XPath("//img[@class='offers--list--item--img']"));
            driver.FindElement(By.XPath("//img[@class='offers--list--item--img']"));
            return this;
        }

        public MarketingHelper UserIsOnOfferDetailsConfiguration()
        {
            WaitAndVerifyElement(By.XPath("//h3[contains(.,'Offer Type:')]"));
            driver.FindElement(By.XPath("//h3[contains(.,'Offer Type:')]"));
            return this;
        }

        public MarketingHelper UserIsOnOffersReport()
        {
            WaitAndVerifyElement(By.XPath("//label[contains(.,'Date range: ')]"));
            driver.FindElement(By.XPath("//label[contains(.,'Date range: ')]"));
            return this;
        }

        public MarketingHelper UserIsOnPromoCards()
        {
            WaitAndVerifyElement(By.XPath("//label[contains(.,'User Type')]"));
            driver.FindElement(By.XPath("//label[contains(.,'User Type')]"));
            return this;
        }

        //____Navigation_______
        public MarketingHelper NavigateToTenantConfiguration()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/options']"));
            driver.FindElement(By.XPath("//a[@href='/options']")).Click();
            return this;
        }

        public MarketingHelper NavigateToOffersReport()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/offers-report']"));
            driver.FindElement(By.XPath("//a[@href='/offers-report']")).Click();
            return this;
        }
        
        public MarketingHelper NavigateToPromoCards()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/promo-cards?expired=false']"));
            driver.FindElement(By.XPath("//a[@href='/promo-cards?expired=false']")).Click();
            return this;
        }

       public MarketingHelper NavigateToOffers()
        {
            WaitAndVerifyElement(By.XPath("//a[contains(.,'Offers')]"));
            driver.FindElement(By.XPath("//a[contains(.,'Offers')]")).Click();
            return this;
        }
        
    }
}
