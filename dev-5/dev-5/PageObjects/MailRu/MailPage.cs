using OpenQA.Selenium;

namespace dev_5.MailRu
{
    class MailPage : PageObject
    {
        private readonly By _backButtonLocator = By.CssSelector(".portal-menu-element_back");

        public MailPage(IWebDriver webDriver) : base(webDriver) { }
        /// <summary>
        /// Clicks return button
        /// </summary>
        /// <returns></returns>
        public InboxPage ReturnToInbox()
        {
            webDriver.FindElement(_backButtonLocator).Click();
            return new InboxPage(webDriver);
        }
    }
}
