using OpenQA.Selenium;

namespace mPortal
{
    public class MonitoringHelper : BaseHelper
    {
        public MonitoringHelper(AppManager manager) : base(manager)
        {
        }

        //___Verification___ 
        public MonitoringHelper UserIsOnMonitoringPage()
        {
            WaitAndVerifyElement(By.XPath("//div[@class='ui-grid-cell-contents ng-binding ng-scope'][contains(.,'MPPA')]"));
            driver.FindElement(By.XPath("//div[@class='ui-grid-cell-contents ng-binding ng-scope'][contains(.,'MPPA')]"));
            return this;
        }

        public MonitoringHelper UserIsOnMaintenanceModePage()
        {
            WaitAndVerifyElement(By.XPath("//tr[2]/td[2]"));
            driver.FindElement(By.XPath("//tr[2]/td[2]"));
            return this;
        }

        public MonitoringHelper UserIsOnAlertsOnMapPage()
        {
            //how to verify alerts on map
            WaitAndVerifyElement(By.XPath("//label[contains(.,'Warning')]"));
            driver.FindElement(By.XPath("//label[contains(.,'Warning')]"));
            return this;
        }

        public MonitoringHelper UserIsOnHeartbeatPage()
        {
            WaitAndVerifyElement(By.XPath("//tr[1]/td[4]/mp-empty-text"));
            driver.FindElement(By.XPath("//tr[1]/td[4]/mp-empty-text"));
            WaitAndVerifyElement(By.XPath("//th[contains(.,'Last site heartbeat')]"));
            driver.FindElement(By.XPath("//th[contains(.,'Last site heartbeat')]"));
            return this;
        }

        public MonitoringHelper UserIsOnManageAlertsPage()
        {
            WaitAndVerifyElement(By.XPath("//span[contains(.,'Loyalty Host started')]"));
            driver.FindElements(By.XPath("//span[contains(.,'Loyalty Host started')]"));
            WaitAndVerifyElement(By.XPath("//td[contains(.,'PetroZoneWebApi')]"));
            driver.FindElements(By.XPath("//td[contains(.,'PetroZoneWebApi')]"));
            return this;
        }

        public MonitoringHelper UserIsOnMachinesConfiguration()
        {
            WaitAndVerifyElement(By.XPath("//td[contains(.,'VERIFONEMPPADEV')]"));
            driver.FindElement(By.XPath("//td[contains(.,'VERIFONEMPPADEV')]"));
            return this;
        }

        public MonitoringHelper UserIsOnAuditPage()
        {
            WaitAndVerifyElement(By.XPath("//div[@class='ui-grid-cell-contents ng-scope'][contains(.,'Update')]"));
            driver.FindElement(By.XPath("//div[@class='ui-grid-cell-contents ng-scope'][contains(.,'Update')]"));
            return this;
        }


        //___Navigation____
        public MonitoringHelper NavigateToActiveAlerts()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/mppa-notifications-lockout']"));
            driver.FindElement(By.XPath("//a[@href='/mppa-notifications-lockout']")).Click();
            return this;
        }

        public MonitoringHelper NavigateToAlertsOnMap()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/mppa-notifications-map']"));
            driver.FindElement(By.XPath("//a[@href='/mppa-notifications-map']")).Click();
            return this;
        }

        public MonitoringHelper NavigateToHeartbeats()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/mppa-notifications-heartbeats']"));
            driver.FindElement(By.XPath("//a[@href='/mppa-notifications-heartbeats']")).Click();
            return this;
        }

        public MonitoringHelper NavigateToManageAlerts()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/mppa-notifications-manage']"));
            driver.FindElement(By.XPath("//a[@href='/mppa-notifications-manage']")).Click();
            return this;
        }
            
        public MonitoringHelper NavigateToMachinesConfigurations()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/mppa-notifications-machines']"));
            driver.FindElement(By.XPath("//a[@href='/mppa-notifications-machines']")).Click();
            return this;
        }

        public MonitoringHelper NavigateToAudit()
        {
            WaitAndVerifyElement(By.XPath("//a[@href='/audit']"));
            driver.FindElement(By.XPath("//a[@href='/audit']")).Click();
            return this;
        }

    }
}