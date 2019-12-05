using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace dev_5.GMail
{
    class MainPage : PageObject
    {
        private readonly By _loginBarLocator = By.CssSelector("input[type='email']");
        private readonly By _passwordBarLocator = By.CssSelector("input[type='password']");

        public MainPage(IWebDriver webDriver) : base(webDriver) { }
        /// <summary>
        /// Sign in to account
        /// </summary>
        /// <param name="login">Account's login</param>
        /// <param name="password">Account's password</param>
        /// <returns>Inbox page of account</returns>
        public InboxPage Login(string login, string password)
        {
            WebDriverWait waiter = new WebDriverWait(webDriver, webDriver.Manage().Timeouts().ImplicitWait);
            webDriver.FindElement(_loginBarLocator).SendKeys(login + Keys.Enter);
            waiter.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(_passwordBarLocator)).SendKeys(password + Keys.Enter);
            return new InboxPage(webDriver);
        }
    }
}
