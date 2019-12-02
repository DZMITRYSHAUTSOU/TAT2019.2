using OpenQA.Selenium;

namespace dev_5.MailRu
{
    class InboxPage : PageObject
    {
        private readonly By _newEmailLocator = By.ClassName("compose-button__wrapper");

        public InboxPage(IWebDriver webDriver) : base(webDriver) { }

        public NewEmailPage GoToNewMailPage()
        {
            webDriver.FindElement(_newEmailLocator).Click();
            return new NewEmailPage(webDriver);
        }
    }
}