using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumWebDriver.Examples.Helpers;
using System;

namespace SeleniumWebDriver.Examples.BasePages
{
    public class GoogleBasePage
    {
        private IWebDriver _driver;
        private SeleniumHelpers selenium;

        private By textfieldSearchQuery = By.Name("q");

        public GoogleBasePage(IWebDriver driver)
        {
            _driver = driver;
            selenium = new SeleniumHelpers(_driver);
        }

        public void DoSearchFor(string searchQuery)
        {
            selenium.SendKeys(textfieldSearchQuery, searchQuery);

            new Actions(_driver).SendKeys(Keys.Enter).Build().Perform();
        }
    }
}
