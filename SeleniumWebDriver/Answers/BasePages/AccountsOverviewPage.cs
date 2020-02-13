using OpenQA.Selenium;
using SeleniumWebDriver.Answers.Helpers;

namespace SeleniumWebDriver.Answers.BasePages
{
    public class AccountsOverviewPage : BasePage
    {
        private IWebDriver _driver;
        private SeleniumHelpers selenium;
        
        public AccountsOverviewPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelpers(_driver);
        }
    }
}
