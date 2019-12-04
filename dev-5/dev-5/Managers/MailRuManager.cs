using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using dev_5.MailRu;
using OpenQA.Selenium;

namespace dev_5.Managers
{
    class MailRuManager : Manager
    {
        public MailRuManager(IWebDriver webDriver, string login, string password) : base(webDriver, login, password) { }
        private InboxPage inboxPage; 

        public void SignIn()
        {
            _webDriver.Navigate().GoToUrl("https://mail.ru/");
            MainPage mainPage = new MainPage(_webDriver);
            inboxPage = mainPage.Login(_login, _password);
        }

        public void SendTestMessage(string email)
        {
            ComposeNewEmailPage newEmail = inboxPage.GoToNewMailPage();
            inboxPage = newEmail.WriteEmailTo(email);
        }

        public void SearchEmailFrom(string email)
        {
            inboxPage.LocateUnreadMessageFrom(email);
        }
    }
}
