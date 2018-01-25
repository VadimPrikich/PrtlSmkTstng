using NUnit.Framework;

namespace mPortal
{
    [TestFixture]
    public class MonitoringTests : AuthTestBase
    {
        [Test]
        public void OpenSystemMonitoringPage()
        {
            app.Nav.SystemMonitoring();
            app.MonitoringHelper.UserIsOnMonitoringPage();
        }

        [Test]
        public void OpenAlertsOnMapPage()
        {
            //app.Nav.SystemMonitoring();
            //app.MonitoringHelper.NavigateToAlertsOnMap();
            //app.MonitoringHelper.UserIsOnAlertsOnMapPage();
        }

        [Test]
        public void OpenHeartbeatPage()
        {
            app.Nav.SystemMonitoring();
            app.MonitoringHelper.NavigateToHeartbeats();
            app.MonitoringHelper.UserIsOnHeartbeatPage();
        }

        [Test]
        public void OpenManageAlertsPage()
        {
            app.Nav.SystemMonitoring();
            app.MonitoringHelper.NavigateToManageAlerts();
            app.MonitoringHelper.UserIsOnManageAlertsPage();
        }

        [Test]
        public void OpenMachinesConfigurationPage()
        {
            app.Nav.SystemMonitoring();
            app.MonitoringHelper.NavigateToMachinesConfigurations();
            app.MonitoringHelper.UserIsOnMachinesConfiguration();
        }

        [Test]
        public void OpenAudit()
        {
            app.Nav.SystemMonitoring();
            app.MonitoringHelper.NavigateToAudit();
            app.MonitoringHelper.UserIsOnAuditPage();
        }
    }
}