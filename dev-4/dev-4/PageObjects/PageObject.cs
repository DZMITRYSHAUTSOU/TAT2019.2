using OpenQA.Selenium;


namespace dev_4
{
    /// <summary>
    /// Abstract class for page objects
    /// </summary>
    public abstract class PageObject
    {
        protected IWebDriver webDriver;
        /// <summary>
        /// Takes webDriver and sets it
        /// </summary>
        /// <param name="webDriver">web driver used by page object</param>
        public PageObject(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
    }
}