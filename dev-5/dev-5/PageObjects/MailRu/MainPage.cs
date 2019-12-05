using OpenQA.Selenium;

namespace dev_5.MailRu
{
    class MainPage : PageObject
    {
        private readonly By _loginBarLocator = By.Id("mailbox:login");
        private readonly By _passwordBarLocator = By.Id("mailbox:password");

        public MainPage(IWebDriver webDriver) : base(webDriver) { }
        /// <summary>
        /// Sign in to account
        /// </summary>
        /// <param name="login">Account's login</param>
        /// <param name="password">Account's password</param>
        /// <returns>Inbox page of account</returns>
        public InboxPage Login(string login, string password)
        {
            webDriver.FindElement(_loginBarLocator).SendKeys(login + Keys.Enter);
            webDriver.FindElement(_passwordBarLocator).SendKeys(password + Keys.Enter);
            return new InboxPage(webDriver);
        }
    }
}
