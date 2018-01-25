using NUnit.Framework;

namespace mPortal
{
    [TestFixture]
    public class TenantsTests : AuthTestBase
    {
        [Test]
        public void OpenTenantsPage()
        {
            app.Nav.Tenants();
            app.TenantHelper.UserIsOnTenantsPage();
        }

        [Test]
        public void OpenTenantProperties()
        {
            app.Nav.Tenants();
            app.TenantHelper.NavigateToTenantPropertiesPage();
            app.TenantHelper.UserIsOnTenantPropertiesPage();
        }

        [Test]
        public void OpenMobileAppLocales()
        {
            app.Nav.Tenants();
            app.TenantHelper.NavigateToMobileAppLocales();
            app.TenantHelper.UserIsOnMobileLocalesStringPage();
        }

        [Test]
        public void OpenMobileAppLocalesDiff()
        {
            app.Nav.Tenants();
            app.TenantHelper.NavigateToMobileAppLocales();
            app.TenantHelper.NavigateToMobileAppLocalesDiff();
            app.TenantHelper.UserIsOnMobileLocalesDiffPage();
        }

        [Test]
        public void OpenMobileAppLocalesLanguage()
        {
            app.Nav.Tenants();
            app.TenantHelper.NavigateToMobileAppLocales();
            app.TenantHelper.NavigateToMobileAppLocalesLanguage();
            app.TenantHelper.UserIsOnMobileLocalesLanguagePage();
        }

        [Test]
        public void OpenMobileFeature()
        {
            app.Nav.Tenants();
            app.TenantHelper.NavigateToMobileFeatures();
            app.TenantHelper.UserIsOnMobileFeatures();
        }



    }
}