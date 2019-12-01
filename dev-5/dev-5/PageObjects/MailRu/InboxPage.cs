using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace dev_4_desktop
{
    class InboxPage : PageObject
    {
        private IWebElement unreadCount;

        public InboxPage(IWebDriver webDriver) : base(webDriver)
        {
            unreadCount = webDriver.FindElement(By.ClassName("badge__text"));
        }

        public int GetUnreadCount()
        {
            return int.Parse(unreadCount.Text);
        }

        public InboxPage SortByUnread()
        {
            webDriver.FindElement(By.CssSelector(".filters-control")).Click();
            webDriver.FindElement(By.XPath("//*[@id='app-canvas']/div/div[1]/div[1]/div/div[1]/div[2]/div[2]/table/tbody/tr/td[2]/div/div/div/div/div[2]/div/div[2]/span[2]")).Click();
            return new InboxPage(webDriver);
        }

        public MailPage CheckMail()
        {
            webDriver.FindElement(By.CssSelector(".llc__item_unread")).Click();
            Thread.Sleep(1000);
            return new MailPage(webDriver);
        }
    }
}