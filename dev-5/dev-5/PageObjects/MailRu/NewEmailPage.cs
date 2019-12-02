using OpenQA.Selenium;

namespace dev_5.MailRu
{
    class NewEmailPage : PageObject
    {
        private readonly By _emailAddressInput = By.CssSelector("input[tabindex='100']");
        private readonly By _subjectInput = By.CssSelector("input[tabindex='400']");
        private readonly By _sendButton = By.CssSelector("span[tabindex='570']");
        private readonly By _closeButton = By.CssSelector("span[tabindex='1000']");

        public NewEmailPage(IWebDriver webDriver) : base(webDriver) { }

        public InboxPage WriteEmailTo()
        {
            webDriver.FindElement(_emailAddressInput).SendKeys("d.shautsov2@gmail.com" );
            webDriver.FindElement(_subjectInput).SendKeys("Test theme" + Keys.Tab + Keys.Tab + "Test message");
            webDriver.FindElement(_sendButton).Click();
            webDriver.FindElement(_closeButton).Click();
            return new InboxPage(webDriver);
        }
    }
}
