using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace dev_4
{
    /// <summary>
    /// Class for executing action sequence given in dev_4.
    /// </summary>
    class MailRuManager
    {
        public string AccountLogin { get; set; }
        public string AccountPassword { get; set; }
        public int UnreadCountBeforeEmailCheck { get; private set; }
        public int UnreadCountAfterEmailCheck { get; private set; }
        private IWebDriver webDriver;
        private MainPage _mainPage;
        private LoginPage _loginPage;
        private InboxPage _inboxPage;
        private MenuPage _menuPage;
        private MailPage _mailPage;
        /// <summary>
        /// Constructor that takes account's login, password and web driver where all Pages will be opened
        /// </summary>
        /// <param name="login">Account's login</param>
        /// <param name="password">Account's password</param>
        public MailRuManager(string login, string password, IWebDriver webDriver)
        {
            AccountLogin = login;
            AccountPassword = password;
            this.webDriver = webDriver;
        }
        /// <summary>
        /// Navigates driver to main page
        /// </summary>
        private void GoToMainPage()
        {
            webDriver.Navigate().GoToUrl("https://m.mail.ru/");
            _mainPage = new MainPage(webDriver);
        }
        /// <summary>
        /// Clicks on Sign in button
        /// </summary>
        private void GoToLoginPage()
        {
            _loginPage = _mainPage.GoToLoginPage();
        }
        /// <summary>
        /// Sign in to account using AccountLogin and AccountPassword
        /// </summary>
        private void Login()
        {
            _inboxPage = _loginPage.LogIn(AccountLogin, AccountPassword);
        }
        /// <summary>
        /// Sets value for UnreadCountAfterEmailCheck propertie.
        /// </summary>
        private void SetCountBeforeEmailCheck()
        {
            UnreadCountBeforeEmailCheck = _inboxPage.GetInboxCount();
        }
        /// <summary>
        /// Clicks on unread Email in sorted inbox
        /// </summary>
        private void CheckMail()
        {
            _menuPage = _inboxPage.GoToMenu();
            _inboxPage = _menuPage.SortByUnread();
            _mailPage = _inboxPage.CheckMail();
            _inboxPage = _mailPage.ReturnToInbox();
        }
        /// <summary>
        /// Sets value for UnreadCountAfterEmailCheck propertie.
        /// </summary>
        private void SetCountAfterEmailCheck()
        {
            UnreadCountAfterEmailCheck = _inboxPage.GetInboxCount();
        }
        /// <summary>
        /// Writes UnreadCountBeforeEmailCheck and UnreadCountAfterEmailCheck to console.
        /// </summary>
        public void DisplayResults()
        {
            Console.WriteLine("Unread mail count before email check : " + UnreadCountBeforeEmailCheck + "\n" +
                "Unread mail count after email check : " + UnreadCountAfterEmailCheck);
        }
        /// <summary>
        /// This method calls all methods of the class, action sequence is:
        /// 1. Open a browser, go to m.mail.ru
        /// 2. Go to login page
        /// 3. Login
        /// 4. Check unread email count
        /// If there is 1 or more unread messages
        /// 5. Sort email by unread email and check first one
        /// 6. Return to inbox page
        /// 7. Check unread email count once more
        /// 8. Close browser
        /// </summary>
        public void ExecuteActionSequence()
        {
            GoToMainPage();
            GoToLoginPage();
            Login();
            SetCountBeforeEmailCheck();
            if (UnreadCountBeforeEmailCheck > 0)
            {
                CheckMail();
                SetCountAfterEmailCheck();
            }
            else
            {
                UnreadCountAfterEmailCheck = 0;
            }
            webDriver.Quit();
        }
    }
}