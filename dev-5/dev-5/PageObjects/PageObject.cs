using OpenQA.Selenium;

namespace dev_5
{
    abstract class PageObject
    {
        protected IWebDriver webDriver;
        /// <summary>
        /// Default constructor for page objects
        /// </summary>
        /// <param name="webDriver">Web driver in which the page is open</param>
        public PageObject(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
    }
}
