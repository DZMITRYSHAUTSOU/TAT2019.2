using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using dev_5.MailRu;

namespace dev_5.Managers
{
    class MailRuManager : Manager
    {
        public MailRuManager(IWebDriver webDriver, string login, string password) : base(webDriver, login, password) { }
        public delegate void EmailHandler();
        public event EmailHandler EmailSent; 

        public void ExecuteSequence()
        {
            IWebDriver chromeDriver = new ChromeDriver();
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            chromeDriver.Navigate().GoToUrl("https://mail.ru/");
            MainPage a = new MainPage(chromeDriver);
            InboxPage b = a.Login("epam_tat2019", "CorrectPassword");
            b = b.GoToNewMailPage().WriteEmailTo();
            EmailSent?.Invoke();
            chromeDriver.Quit();
        }
    }
}
