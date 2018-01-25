using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace mPortal
{
    //управляет тестируемым приложением
    //управление помощниками
    public class AppManager
    {
        protected IWebDriver driver;
        protected string baseURL;
        //ссылки на помощников
        //поле для нового помощника
        protected HomePageHelper homePageHelper;
        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected AccountHelper accountHelper;

        //
        protected UsersHelper userHelper;
        protected StoresHelper storesHelper;
        protected TenantHelper tenantHelper;
        protected MarketingHelper marketingHelper;
        protected LoyaltyHelper loyaltyHelper;
        protected VelocityHelper velocityHelper;
        protected MonitoringHelper monitoringHelper;
        protected AnalyticsHelper analyticsHelper;
        protected TransactionsHelper transactionsHelper;
        protected BillingHelper billingHelper;

        private static ThreadLocal<AppManager> app = new ThreadLocal<AppManager>();


        //конструктор для инициализации помощников private
        private AppManager()
        {
            driver = new FirefoxDriver();
            baseURL = "https://example.com";
            //добовляем код для создания помощников
            //в качестве объекта передаём только что созданный объект типа драйвер
            
            accountHelper = new AccountHelper(this);
            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this, baseURL);
            homePageHelper = new HomePageHelper(this);
           
            //
            userHelper = new UsersHelper(this);
            storesHelper = new StoresHelper(this);
            tenantHelper = new TenantHelper(this);
            marketingHelper = new MarketingHelper(this);
            loyaltyHelper = new LoyaltyHelper(this);
            velocityHelper = new VelocityHelper(this);
            monitoringHelper = new MonitoringHelper(this);
            analyticsHelper = new AnalyticsHelper(this);
            transactionsHelper = new TransactionsHelper(this);
            billingHelper = new BillingHelper(this);

        }

        ~AppManager()
        {
            driver.Quit();
        }


        public static AppManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                AppManager newInstance = new AppManager();
                newInstance.Nav.OpenHomePage();
                app.Value = newInstance;
            }
            return app.Value;
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }

        public HomePageHelper HomePageHelper
        {
            get
            {
                return homePageHelper;
            }
        }

        public NavigationHelper Nav
        {
            get
            {
                return navigationHelper;
            }
        }
             
        public AccountHelper Acnt
        {
            get
            {
                return accountHelper;
            }
        }
                
        public UsersHelper UserHelper
        {
            get
            {
                return userHelper;
            }
        }

        public StoresHelper StoresHelper
        {
            get
            {
                return storesHelper;
            }
        }

        public TenantHelper TenantHelper
        {
            get
            {
                return tenantHelper;
            }
        }

        public MarketingHelper MarketingHelper
        {
            get
            {
                return marketingHelper;
            }
        }

        public LoyaltyHelper LoyaltyHelper
        {
            get
            {
                return loyaltyHelper;
            }
        }

        public VelocityHelper VelocityHelper
        {
            get
            {
                return velocityHelper;
            }
        }

        public MonitoringHelper MonitoringHelper
        {
            get
            {
                return monitoringHelper;
            }
        }

        public AnalyticsHelper AnalyticsHelper
        {
            get
            {
                return analyticsHelper;
            }
        }

        public TransactionsHelper TransactionsHelper
        {
            get
            {
                return transactionsHelper;
            }
        }

        public BillingHelper BillingHelper
        {
            get
            {
                return billingHelper;
            }
        }
    }
}
        


        

