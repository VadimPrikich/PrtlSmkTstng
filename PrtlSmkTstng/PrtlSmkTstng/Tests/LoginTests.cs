using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace mPortal
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredetials()
        {
            //подготовили тест к выполнению
            app.Auth.Logout();
            //выполняем логин с нужными данными
            //вынесем данные аккаунта под переменную 
            AccountData account = new AccountData("Vsddssom", "Vasdsdna2");
            app.Auth.Login(account);

        //выполняем проверку что залогинились
        //Assert.IsTrue(app.Auth.IsLoggedIn(account));

        //https://stackoverflow.com/questions/30377901/how-to-make-selenium-webdriver-wait-for-page-to-load-when-new-page-is-loaded-via
        //

        }

        [Test]
        public void LoginWithValidCredetials2()
        {
            //подготовили тест к выполнению
            //app.Auth.Logout();
            //выполняем логин с нужными данными
            //вынесем данные аккаунта под переменную 
            AccountData account = new AccountData("qzxzx.com", "Wzxz!");
            app.Auth.Login(account);
            //выполняем проверку что залогинились
            Assert.IsTrue(app.Auth.IsLoggedIn(account));
        }


        [Test]
        public void LoginWithInvalidCredetials()
        {
            //подготовили тест к выполнению
            //app.Auth.Logout();
            //выполняем логин с нужными данными
            //вынесем данные аккаунта под переменную 
            AccountData account = new AccountData("admin", "123456");
            app.Auth.Login(account);
            //выполняем проверку что залогинились
            Assert.IsFalse(app.Auth.IsLoggedIn(account));
        }
    }
}
