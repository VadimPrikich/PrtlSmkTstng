using NUnit.Framework;

namespace mPortal
{
    [TestFixture]
    public class VelocityTests : AuthTestBase
    {
        [Test]
        public void OpenVelocityPage()
        {
            app.Nav.Velocity();
            app.VelocityHelper.UserIsOnVelocityPage();
        }

        [Test]
        public void OpenUserExemptionPage()
        {
            app.Nav.Velocity();
            app.VelocityHelper.NavigateToUserExemption();
            app.VelocityHelper.UserIsOnUserExemption();            
        }

        [Test]
        public void OpenStoreExemptionPage()
        {
            app.Nav.Velocity();
            app.VelocityHelper.NavigateToStoreExemption();
            app.VelocityHelper.UserIsOnStoreExemption();
        }

        [Test]
        public void OpenVelocityParametersPage()
        {
            app.Nav.Velocity();
            app.VelocityHelper.NavigateToVelocityParameters();
            app.VelocityHelper.UserIsOnVelocityParameters();
        }

        [Test]
        public void OpenVelocityLimitsPage()
        {
            app.Nav.Velocity();
            app.VelocityHelper.NavigateToVelocityLimits();
            app.VelocityHelper.UserIsOnVelocityLimitsPage();
        }
    }
}