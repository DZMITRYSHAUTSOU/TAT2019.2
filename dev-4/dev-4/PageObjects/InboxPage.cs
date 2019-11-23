using OpenQA.Selenium;

namespace dev_4
{
    public class InboxPage : PageObject
    {
        public InboxPage(IWebDriver webDriver) : base(webDriver) { }
        /// <summary>
        /// Finds element with unread inbox count text. If there is none, returns 0
        /// </summary>
        /// <returns>Unread inbox count, or 0 from try-catch</returns>
        public int GetInboxCount()
        {
            try
            {
                return int.Parse(webDriver.FindElement(By.ClassName("msglist-title__counter")).Text);
            }
            catch(NoSuchElementException e)
            {
                return 0;
            }
        }
        /// <summary>
        /// Clicks first found unread email
        /// </summary>
        /// <returns>Email page that was clicked on</returns>
        public MailPage CheckMail()
        {
            try
            {
                webDriver.FindElement(By.CssSelector(".messageline_unread"))?.Click();
                return new MailPage(webDriver);
            }
            catch(NoSuchElementException e)
            {
                return new MailPage(webDriver);
            }
        }
        /// <summary>
        /// Clicks menu button
        /// </summary>
        /// <returns>Menu page</returns>
        public MenuPage GoToMenu()
        {
            webDriver.FindElement(By.CssSelector(".toolbar__button-wrapper")).Click();
            return new MenuPage(webDriver);
        }
    }
}