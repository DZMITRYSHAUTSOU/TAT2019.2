using OpenQA.Selenium;

namespace dev_4
{
    class MainPage : PageObject
    {
        private IWebElement loginButton;
        /// <summary>
        /// Sets Login button and web driver fields
        /// </summary>
        /// <param name="webDriver">web driver used by page object</param>
        public MainPage(IWebDriver webDriver) : base(webDriver)
        {
            loginButton = webDriver.FindElement(By.CssSelector("[href*='https://r.mail.ru/n109322822']"));
        }
        /// <summary>
        /// Clicks login button element
        /// </summary>
        /// <returns>Login page</returns>
        public LoginPage GoToLoginPage()
        {
            loginButton.Click();
            return new LoginPage(webDriver);
        }
    }
}
