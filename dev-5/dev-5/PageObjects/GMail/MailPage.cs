using OpenQA.Selenium;

namespace dev_5.GMail
{
    class MailPage : PageObject
    {
        private readonly By _replyButtonLocator = By.CssSelector("div[data-tooltip='Reply']");

        public MailPage(IWebDriver webDriver) : base(webDriver) { }

        public NewEmailPage CreateReplyEmail()
        {
            webDriver.FindElement(_replyButtonLocator).Click();
            return new NewEmailPage(webDriver);
        }
    }
}
