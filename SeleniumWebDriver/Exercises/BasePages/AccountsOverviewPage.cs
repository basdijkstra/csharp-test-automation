using OpenQA.Selenium;
using SeleniumWebDriver.Exercises.Helpers;

namespace SeleniumWebDriver.Exercises.BasePages
{
    /***
     * Make the AccountsOverviewPage inherit from the BasePage
     */

    public class AccountsOverviewPage
    {
        private IWebDriver _driver;
        private SeleniumHelpers selenium;

        /***
         * Pass the WebDriver object to the constructor of the BasePage here
         */
        public AccountsOverviewPage(IWebDriver driver)
        {
            _driver = driver;
            selenium = new SeleniumHelpers(_driver);
        }

        /***
         * Remove this method entirely, because we won't need it anymore.
         */
        public void SelectMenuItem(string menuItemToSelect)
        {
            selenium.Click(By.LinkText(menuItemToSelect));
        }
    }
}
