using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace dev_4_desktop
{
    class MailPage : PageObject
    {
        IWebElement returnButton;

        public MailPage(IWebDriver webDriver) : base (webDriver)
        {
            returnButton = webDriver.FindElement(By.CssSelector(".portal-menu-element_back"));
            Thread.Sleep(1000);
        }

        public InboxPage ReturnToInbox()
        {
            returnButton.Click();
            return new InboxPage(webDriver);
        }
    }
}
