using OpenQA.Selenium;
using System;

namespace dev_5.Managers
{
    abstract class Manager
    {
        protected readonly IWebDriver _webDriver;
        protected string _login;
        protected string _password;
        /// <summary>
        /// Default constructor for managers
        /// </summary>
        /// <param name="webDriver">Web driver used by page objects</param>
        /// <param name="login">Account's login</param>
        /// <param name="password">Account's password</param>
        public Manager(IWebDriver webDriver, string login, string password)
        {
            _webDriver = webDriver;
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
            _login = login;
            _password = password;
        }
    }
}
