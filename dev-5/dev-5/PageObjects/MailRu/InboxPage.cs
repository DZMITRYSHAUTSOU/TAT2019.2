using OpenQA.Selenium;

namespace dev_5.MailRu
{
    class InboxPage : PageObject
    {
        private readonly By _composeNewEmailLocator = By.ClassName("compose-button__wrapper");

        public InboxPage(IWebDriver webDriver) : base(webDriver) { }
        /// <summary>
        /// Clicks on Compose new email button
        /// </summary>
        /// <returns></returns>
        public ComposeNewEmailPage GoToNewMailPage()
        {
            webDriver.FindElement(_composeNewEmailLocator).Click();
            return new ComposeNewEmailPage(webDriver);
        }
        /// <summary>
        /// Searches for unread message from email param.
        /// </summary>
        /// <param name="email">Email to search</param>
        /// <returns></returns>
        public bool LocateUnreadMessageFrom(string email)
        {
            try
            {
                webDriver.FindElement(By.XPath($"//a[//div[@class='llc__item llc__item_correspondent llc__item_unread' and //span[contains(@title, '{email}')]]]"));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}