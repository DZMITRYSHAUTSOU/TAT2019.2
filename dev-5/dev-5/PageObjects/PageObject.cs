using OpenQA.Selenium;

namespace dev_5
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
