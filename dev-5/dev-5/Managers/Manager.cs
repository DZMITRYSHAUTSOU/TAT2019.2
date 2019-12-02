using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;

namespace dev_5.Managers
{
    abstract class Manager
    {
        private readonly IWebDriver _webDriver;
        private readonly string _login;
        private readonly string _password;

        public Manager(IWebDriver webDriver, string login, string password)
        {
            _webDriver = webDriver;
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _login = login;
            _password = password;
        }
    }
}
