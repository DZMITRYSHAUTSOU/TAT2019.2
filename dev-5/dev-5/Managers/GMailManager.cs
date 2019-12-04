using OpenQA.Selenium;
using dev_5.GMail;

namespace dev_5.Managers
{
    class GMailManager : Manager
    {
        InboxPage inboxPage;

        public GMailManager(IWebDriver webDriver, string login, string password) : base(webDriver, login, password) { }

        public void SignIn()
        {
            _webDriver.Navigate().GoToUrl("https://gmail.com/");
            MainPage mainPage = new MainPage(_webDriver);
            inboxPage = mainPage.Login(_login, _password);
        }

        public void ReplyWithDefaultEmailTo(string email)
        {
            MailPage mailPage = inboxPage.SearchEmailFrom(email);
            ComposeNewEmailPage newEmail = mailPage.CreateReplyEmail();
            newEmail.WriteReplyEmail();
        }
    }
}
