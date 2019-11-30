using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace dev_4_desktop
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            IWebDriver chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl("https://mail.ru/");
            MainPage a = new MainPage(chromeDriver);
            Thread.Sleep(3000);
            Thread.Sleep(3000);
            InboxPage b = a.Login("epam_tat2019", "CorrectPassword"); Thread.Sleep(3000);
            //Thread.Sleep(3000);
            ////int UnreadCount = b.GetUnreadCount();
            //b =b.SortByUnread();
            //Thread.Sleep(3000);
            //MailPage c = b.CheckMail();
            //Thread.Sleep(1000);
            //b = c.ReturnToInbox();
            //Thread.Sleep(3000);
            ////int AfterUnreadCount = b.GetUnreadCount();
            //chromeDriver.Quit();    
        }
    }
}
