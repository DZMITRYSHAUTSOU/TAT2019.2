using OpenQA.Selenium;

namespace dev_4
{
    public class LoginPage : PageObject
    {
        private IWebElement loginBar;
        private IWebElement passwordBar;
        private readonly By _loginBarLocator = By.Name("Login");
        private readonly By _passwordBarLocator = By.Name("Password");
        /// <summary>
        /// Sets web driver and login and password web elements
        /// </summary>
        /// <param name="webDriver">Web driver used by page object</param>
        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
            loginBar = webDriver.FindElement(_loginBarLocator);
            passwordBar = webDriver.FindElement(_passwordBarLocator);
        }
        /// <summary>
        /// Logs into account with login and password. Throws exception if login data is invalid.
        /// </summary>
        /// <param name="login">Account's login</param>
        /// <param name="password">Account's password</param>
        /// <returns>Inbox Page of an Account</returns>
        public InboxPage LogIn(string login, string password)
        {
            loginBar.SendKeys(login + Keys.Tab + Keys.Tab);
            passwordBar.SendKeys(password + Keys.Enter);
            try
            {
                webDriver.FindElement(By.ClassName("error"));
            }
            catch (NoSuchElementException e)
            {
                return new InboxPage(webDriver);
            }
            throw new InvalidLoginOrPasswordException();
        }
    }
}