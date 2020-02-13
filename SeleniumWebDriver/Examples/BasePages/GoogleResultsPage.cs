using OpenQA.Selenium;
using SeleniumWebDriver.Examples.Helpers;
using System;

namespace SeleniumWebDriver.Examples.BasePages
{
    public class GoogleResultsPage : GoogleBasePage
    {
        private IWebDriver _driver;
        private SeleniumHelpers selenium;

        private By textfieldResultStats = By.Id("resultStats");

        public GoogleResultsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelpers(_driver);
        }

        public bool ResultStatsAreDisplayed()
        {
            return selenium.ElementIsVisible(textfieldResultStats);
        }
    }
}
