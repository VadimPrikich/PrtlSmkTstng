    using NUnit.Framework;

namespace mPortal
{
    [TestFixture]
    public class UserTests : AuthTestBase
    {
        [Test]
        public void OpenPortalUsersPage()
        {
            app.Nav.Users();
            app.UserHelper.UserIsOnManagmentPortalUsersPage();
        }

        [Test]
        public void OpenMobileUsersPage()
        {
            app.Nav.HomePage();
            app.UserHelper.IfUserIsOnQAPortal();
            app.Nav.Users();
            app.UserHelper.NavigateToMobileAppUsers();
            app.UserHelper.UserIsOnMobileUsersPage();
        }

        [Test]
        public void OpenRolesPage()
        {
            app.Nav.Users();
            app.UserHelper.NavigateToRoles();
            app.UserHelper.UserIsOnRolesPage();
        }

        [Test]
        public void OpenAddUserPage()
        {
            app.Nav.Users();
            app.UserHelper.NavigateToAddUser();
            app.UserHelper.UserIsOnAddUserPage();
        }
    }
}
