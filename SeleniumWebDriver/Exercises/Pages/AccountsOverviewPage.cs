using OpenQA.Selenium;
using SeleniumWebDriver.Exercises.Helpers;

namespace SeleniumWebDriver.Exercises.Pages
{
    public class AccountsOverviewPage
    {
        private IWebDriver _driver;
        private SeleniumHelpers selenium;
        
        public AccountsOverviewPage(IWebDriver driver)
        {
            _driver = driver;
            selenium = new SeleniumHelpers(_driver);
        }

        public void SelectMenuItem(string menuItemToSelect)
        {
            selenium.Click(By.LinkText(menuItemToSelect));
        }
    }
}
