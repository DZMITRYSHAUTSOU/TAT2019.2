using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using dev_5.MailRu;

namespace dev_5.Managers
{
    class MailRuManager : Manager
    {
        private InboxPage inboxPage;
        public bool IsThereAMessage { get; private set; }

        public MailRuManager(IWebDriver webDriver, string login, string password) : base(webDriver, login, password) { }
        /// <summary>
        /// Call methods from Page Objects to sign in using login and passwords fields
        /// </summary>
        public void SignIn()
        {
            _webDriver.Navigate().GoToUrl("https://mail.ru/");
            MainPage mainPage = new MainPage(_webDriver);
            inboxPage = mainPage.Login(_login, _password);
        }
        /// <summary>
        /// Call methods from Page Objects to send test message to email param
        /// </summary>
        /// <param name="email">Email of recipient</param>
        public void SendTestMessage(string email)
        {
            ComposeNewEmailPage newEmail = inboxPage.GoToNewMailPage();
            inboxPage = newEmail.WriteDefaultEmailTo(email);
        }
        /// <summary>
        /// Call methods from Page Objects to search for message of sender
        /// </summary>
        /// <param name="email">Sender's email</param>
        public void SearchEmailFrom(string email)
        {
            IsThereAMessage = inboxPage.LocateUnreadMessageFrom(email);
        }
    }
}
