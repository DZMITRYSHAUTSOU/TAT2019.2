using OpenQA.Selenium;

namespace dev_4
{
    class MainPage : PageObject
    {
        private IWebElement loginButton;

        public MainPage(IWebDriver webDriver) : base(webDriver)
        {
            loginButton = webDriver.FindElement(By.CssSelector("[href*='https://r.mail.ru/n109322822']"));
        }

        public LoginPage GoToLoginPage()
        {
            loginButton.Click();
            return new LoginPage(webDriver);
        }
    }
}
