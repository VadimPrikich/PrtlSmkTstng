using NUnit.Framework;

namespace mPortal
{
    [TestFixture]
    public class AnalyticsTests : AuthTestBase
    {
        [Test]
        public void OpenAnalyticsPage()
        {
            app.Nav.Analytics();
            
        }

        [Test]
        public void OpenAnaliticsInternalDiagramPage()
        {
            app.Nav.Analytics();
            
        }

        [Test]
        public void OpenAnalyticsConfigurationPage()
        {
            app.Nav.Analytics();
            app.AnalyticsHelper.NavigateToReportConfiguration();
            app.AnalyticsHelper.UserIsOnAnalyticsConfig();
        }

    }
}