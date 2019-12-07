using OpenQA.Selenium;

namespace dev_5.MailRu
{
    class ComposeNewEmailPage : PageObject
    {
        private readonly By _emailAddressInput = By.CssSelector("input[tabindex='100']");
        private readonly By _subjectInput = By.CssSelector("input[tabindex='400']");
        private readonly By _sendButton = By.CssSelector("span[tabindex='570']");
        private readonly By _closeButton = By.CssSelector("span[tabindex='1000']");
        private readonly By _textBoxLocator = By.XPath("//div[@role='textbox']/div/div[1]");

        public ComposeNewEmailPage(IWebDriver webDriver) : base(webDriver) { }
        /// <summary>
        /// Writes default message to email
        /// </summary>
        /// <param name="email">email of recipient</param>
        /// <returns>Inbox page</returns>
        public InboxPage WriteDefaultEmailTo(string email)
        {
            webDriver.FindElement(_emailAddressInput).SendKeys(email);
            webDriver.FindElement(_subjectInput).SendKeys("Test theme");
            webDriver.FindElement(_textBoxLocator).SendKeys("Test message");
            webDriver.FindElement(_sendButton).Click();
            webDriver.FindElement(_closeButton).Click();
            return new InboxPage(webDriver);
        }
    }
}
