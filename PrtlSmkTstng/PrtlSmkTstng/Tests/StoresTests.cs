using NUnit.Framework;

namespace mPortal
{
    [TestFixture]
    public class StoresTests : AuthTestBase
    {
        [Test]
        public void OpenStoresPage()
        {
            app.Nav.Stores();
            app.StoresHelper.UserIsOnStoresPage();
        }
    }
}