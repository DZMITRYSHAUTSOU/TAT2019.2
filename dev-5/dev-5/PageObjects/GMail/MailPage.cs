using OpenQA.Selenium;

namespace dev_5.GMail
{
    class MailPage : PageObject
    {
        private readonly By _replyButtonLocator = By.CssSelector("div[data-tooltip='Reply']");

        public MailPage(IWebDriver webDriver) : base(webDriver) { }
        /// <summary>
        /// Clicks on Reply button
        /// </summary>
        /// <returns>Compose new email page</returns>
        public ComposeNewEmailPage CreateReplyEmail()
        {
            webDriver.FindElement(_replyButtonLocator).Click();
            return new ComposeNewEmailPage(webDriver);
        }
    }
}
