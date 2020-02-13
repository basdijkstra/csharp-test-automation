using OpenQA.Selenium;
using SeleniumWebDriver.Answers.Helpers;

namespace SeleniumWebDriver.Answers.BasePages
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

        public void SelectMenuItem(string menuItemToSelect)
        {
            selenium.Click(By.LinkText(menuItemToSelect));
        }
    }
}
