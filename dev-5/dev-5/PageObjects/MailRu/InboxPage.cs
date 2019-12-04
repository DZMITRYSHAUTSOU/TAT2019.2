using OpenQA.Selenium;

namespace dev_5.MailRu
{
    class InboxPage : PageObject
    {
        private readonly By _composeNewEmailLocator = By.ClassName("compose-button__wrapper");

        public InboxPage(IWebDriver webDriver) : base(webDriver) { }

        public ComposeNewEmailPage GoToNewMailPage()
        {
            webDriver.FindElement(_composeNewEmailLocator).Click();
            return new ComposeNewEmailPage(webDriver);
        }

        public void LocateUnreadMessageFrom(string email)
        {
            webDriver.FindElement(By.XPath($"//span[contains(@title,{email})] and ..div[@class='llc__item_unread']"));
        }
    }
}