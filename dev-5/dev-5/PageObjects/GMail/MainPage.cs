using OpenQA.Selenium;
using OpenQA.Selenium.Support;

namespace dev_5.GMail
{
    class MainPage : PageObject
    {
        private readonly By _loginBarLocator = By.CssSelector("input[type='email']");
        private readonly By _passwordBarLocator = By.CssSelector("input[type='password']");

        public MainPage(IWebDriver webDriver) : base(webDriver) { }

        public InboxPage Login(string login, string password)
        {
            webDriver.FindElement(_loginBarLocator).SendKeys(login + Keys.Enter);
            webDriver.FindElement(_passwordBarLocator).SendKeys(password + Keys.Enter);
            return new InboxPage(webDriver);
        }
    }
}
