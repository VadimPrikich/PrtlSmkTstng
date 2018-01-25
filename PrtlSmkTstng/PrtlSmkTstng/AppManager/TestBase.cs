using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace mPortal
{
    //класс ответственный за инициализацию и завершение
    //использует помощники для работы с разными частями нашего приложенияв
    public class TestBase
    {
        //ссылка на помощники
        protected AppManager app;
               
        //methods 
        // программный код. обрабатывает данные
        [SetUp]
        //модификатор видимости public
        // void - тип возвращаемого значения - ничего. bool - true OR false 
        // setup имя - в скобках параметры

        //Метод setup где создаётся driver
        public void SetupApplicationManager()
        {
            //ссылаемся нарямую
            app = AppManager.GetInstance();
            ////инициализируем 
            //app = new AppManager();
            //app.Nav.OpenHomePage();
            //app.Auth.Login(new AccountData("admin", "secret"));
        }

        //[TearDown]
        //public void TeardownTest()
        //{
        //    ////вызываем метод стоп 
        //    //app.Stop();
        //}
        
           

    }
}
