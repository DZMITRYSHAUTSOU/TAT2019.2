using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace dev_4_desktop
{
    abstract class PageObject
    {
        protected IWebDriver webDriver;

        public PageObject(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
    }
}
