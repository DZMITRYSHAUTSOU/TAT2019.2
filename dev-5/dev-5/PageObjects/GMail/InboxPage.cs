using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace dev_5.GMail
{
    class InboxPage : PageObject
    {
        public InboxPage(IWebDriver webDriver) : base(webDriver) { }

        public MailPage SearchEmailFrom(string senderEmail)
        {
            WebDriverWait waiter = new WebDriverWait(webDriver, webDriver.Manage().Timeouts().ImplicitWait);
            waiter.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath($"//tr[.//span[@email='{senderEmail}']]"))).Click();
            return new MailPage(webDriver);
        }

        public ComposeNewEmailPage ComposeNewEmail()
        {
            webDriver.FindElement(By.ClassName("compose-button__wrapper")).Click();
            return new ComposeNewEmailPage(webDriver);
        }
    }
}