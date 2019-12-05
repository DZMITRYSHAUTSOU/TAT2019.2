using OpenQA.Selenium;

namespace dev_5.GMail
{
    class InboxPage : PageObject
    {
        public InboxPage(IWebDriver webDriver) : base(webDriver) { }
        /// <summary>
        /// Searches an email from senderEmail param and clicks on it
        /// </summary>
        /// <param name="senderEmail">Email to search</param>
        /// <returns>Mail page if it's found</returns>
        public MailPage SearchEmailFrom(string senderEmail)
        {
            webDriver.FindElement(By.XPath($"//tr[//span[@email='{senderEmail}']]")).Click();
            return new MailPage(webDriver);
        }
    }
}