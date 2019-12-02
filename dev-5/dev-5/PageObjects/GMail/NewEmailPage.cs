using OpenQA.Selenium;

namespace dev_5.GMail
{
    class NewEmailPage : PageObject
    {
        private readonly By _textBoxLocator = By.CssSelector("div[role='textbox']");
        private readonly By _sendButtonLocator = By.Id(":12a");
        private readonly By _backButtonLocator = By.CssSelector("div[data-tooltip='Back to Inbox']");

        public NewEmailPage(IWebDriver webDriver) : base(webDriver) { }

        public InboxPage WriteEmailTo()
        {
            webDriver.FindElement(_textBoxLocator).SendKeys("Test reply message");
            webDriver.FindElement(_sendButtonLocator).Click();
            return new InboxPage(webDriver);
        }
    }
}
