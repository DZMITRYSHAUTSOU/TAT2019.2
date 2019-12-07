using OpenQA.Selenium;

namespace dev_5.GMail
{
    class ComposeNewEmailPage : PageObject
    {
        private readonly By _textBoxLocator = By.CssSelector("div[role='textbox']");
        private readonly By _sendButtonLocator = By.CssSelector(".T-I.J-J5-Ji.aoO.v7.T-I-atl.L3");
        private readonly By _backButtonLocator = By.CssSelector("div[data-tooltip='Back to Inbox']");

        public ComposeNewEmailPage(IWebDriver webDriver) : base(webDriver) { }
        /// <summary>
        /// Sends a default reply email
        /// </summary>
        /// <returns>Inbox page of account</returns>
        public InboxPage WriteDefaultReplyEmail()
        {
            webDriver.FindElement(_textBoxLocator).SendKeys("Test reply message");
            webDriver.FindElement(_sendButtonLocator).Click();
            return new InboxPage(webDriver);
        }
    }
}
