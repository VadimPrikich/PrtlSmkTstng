using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace mPortal
{
    //базовый class для тестов которые требуют вход в систему, для которых нужен логин. Эти тесты тогда будут наследоваться от AuthTestBase
    //login который выполняется перед каждым тестовым методом
    //иногда логинится не надо. тесты наследуются от Test Base
    public class AuthTestBase : TestBase
    {
        //в нём метод SetUp который выполняет логин
        [SetUp]
        
        //Метод setup где создаётся driver
        public void SetupLogin()
        {     
            app.Auth.Login(new AccountData("vadim.prikich@p97.com", "Valentina2"));
        }
    }
}
