using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;

namespace dev_4_desktop
{
    class MainPage : PageObject
    {
        IWebElement loginBar;

        public MainPage(IWebDriver webDriver) : base(webDriver)
        {
            loginBar = webDriver.FindElement(By.Id("mailbox:login"));
        }

        public InboxPage Login(string login, string password)
        {
            loginBar.SendKeys(login + Keys.Enter);
            Thread.Sleep(500);
            webDriver.FindElement(By.Id("mailbox:password")).SendKeys(password+Keys.Enter);
            Thread.Sleep(5000);
            return new InboxPage(webDriver);
        }
    }
}
