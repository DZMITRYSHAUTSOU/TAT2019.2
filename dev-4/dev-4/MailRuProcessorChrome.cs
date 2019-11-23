using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace dev_4
{
    /// <summary>
    /// Class for executing action sequence given in dev_4
    /// </summary>
    class MailRuProcessorChrome
    {
        public string AccountLogin { get; set; }
        public string AccountPassword { get; set; }
        public int UnreadCountBeforeEmailCheck { get; private set; }
        public int UnreadCountAfterEmailCheck { get; private set; }
        private IWebDriver chromeDriver = new ChromeDriver();
        private MainPage _mainPage;
        private LoginPage _loginPage;
        private InboxPage _inboxPage;
        private MenuPage _menuPage;
        private MailPage _mailPage;

        public MailRuProcessorChrome(string login, string password)
        {
            AccountLogin = login;
            AccountPassword = password;
        }

        private void GoToMainPage()
        {
            chromeDriver.Navigate().GoToUrl("https://m.mail.ru/");
            _mainPage = new MainPage(chromeDriver);
        }

        private void GoToLoginPage()
        {
            _loginPage = _mainPage.GoToLoginPage();
        }

        private void Login()
        {
            _inboxPage = _loginPage.LogIn(AccountLogin, AccountPassword);
        }

        private void SetCountBeforeEmailCheck()
        {
            UnreadCountBeforeEmailCheck = _inboxPage.GetInboxCount();
        }

        private void CheckMail()
        {
            _menuPage = _inboxPage.GoToMenu();
            _inboxPage = _menuPage.SortByUnread();
            _mailPage = _inboxPage.CheckMail();
            _inboxPage = _mailPage.ReturnToInbox();
        }

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
            chromeDriver.Quit();
        }
    }
}