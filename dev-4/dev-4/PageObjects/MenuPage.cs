using OpenQA.Selenium;

namespace dev_4
{
    /// <summary>
    /// Class for menu page
    /// </summary>
    public class MenuPage : PageObject
    {
        private IWebElement sortButton;
        private readonly By _sortButtonLocator = By.CssSelector("[href*='/search/gosearch?q_read=2&q_folder=all']");
        /// <summary>
        /// Sets web driver and sort button fields
        /// </summary>
        /// <param name="webDriver">web driver used by page object</param>
        public MenuPage(IWebDriver webDriver) : base(webDriver)
        {
            sortButton = webDriver.FindElement(_sortButtonLocator);
        }
        /// <summary>
        /// Clicks "Sort by unread" button
        /// </summary>
        /// <returns>Sorted inbox page</returns>
        public InboxPage SortByUnread()
        {
            sortButton.Click();
            return new InboxPage(webDriver);
        }
    }
}