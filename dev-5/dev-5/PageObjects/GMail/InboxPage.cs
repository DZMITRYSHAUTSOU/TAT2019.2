using OpenQA.Selenium;

namespace dev_5.GMail
{
    class InboxPage : PageObject
    {
        public InboxPage(IWebDriver webDriver) : base(webDriver) { }
        public string SenderEmail { get; } = "epam_tat2019@mail.ru";

        public MailPage CheckMail()
        {
            webDriver.FindElement(By.CssSelector($"span[email='{SenderEmail}']")).Click();
            return new MailPage(webDriver);
        }

        public NewEmailPage GoToNewMailPage()
        {
            webDriver.FindElement(By.ClassName("compose-button__wrapper")).Click();
            return new NewEmailPage(webDriver);
        }
    }
}