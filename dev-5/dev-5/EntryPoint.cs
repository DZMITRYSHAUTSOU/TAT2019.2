using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using dev_5.Managers;
using dev_5.GMail;

namespace dev_5
{
    /// <summary>
    /// Program's entry point
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            ChromeDriver chromeDriver = new ChromeDriver();
            chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            chromeDriver.Navigate().GoToUrl("https://gmail.com/");
            MainPage a = new MainPage(chromeDriver);
            InboxPage b = a.Login("d.shautsov2", "Fesseg123");
            MailPage c = b.CheckMail();
            chromeDriver.Quit();
            //MailRuManager manager = new MailRuManager(new ChromeDriver(), "epam_tat2019", "CorrectPassword");
            //manager.ExecuteSequence();
        }
    }
}
