using OpenQA.Selenium;

namespace dev_4
{
    /// <summary>
    /// Class for Email page
    /// </summary>
    public class MailPage : PageObject
    {
        private IWebElement backButton;
        /// <summary>
        /// Sets web driver and back button fields
        /// </summary>
        /// <param name="webDriver">web driver used by page object</param>
        public MailPage(IWebDriver webDriver) : base(webDriver)
        {
            backButton = webDriver.FindElement(By.CssSelector(".button_back"));
        }
        /// <summary>
        /// Clicks return button on email page
        /// </summary>
        /// <returns>Inbox page</returns>
        public InboxPage ReturnToInbox()
        {
            backButton.Click();
            return new InboxPage(webDriver);
        }
    }
}