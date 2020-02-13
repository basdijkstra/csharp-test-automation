using OpenQA.Selenium;
using SeleniumWebDriver.Exercises.Helpers;

namespace SeleniumWebDriver.Exercises.BasePages
{
    public class BasePage
    {
        private IWebDriver _driver;
        private SeleniumHelpers selenium;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
            selenium = new SeleniumHelpers(_driver);
        }

        /***
         * Implement a SelectMenuItem() method that takes a String argument
         * and performs a click on the element with a LinkText equal to the String argument
         */
    }
}
