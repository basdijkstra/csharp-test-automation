using OpenQA.Selenium;
using SeleniumWebDriver.Examples.Helpers;
using System;

namespace SeleniumWebDriver.Examples.BasePages
{
    public class GoogleHomePage : GoogleBasePage
    {
        private IWebDriver _driver;
        private SeleniumHelpers selenium;

        private By textfieldSearchQuery = By.Name("q");
        private By buttonDoSearch = By.Name("btnK");

        public GoogleHomePage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
            selenium = new SeleniumHelpers(_driver);
        }

        public GoogleHomePage Load()
        {
            selenium.NavigateTo("https://www.google.com");
            return this;
        }

        public GoogleHomePage EnterSearchTerm(String searchQuery)
        {
            selenium.SendKeys(textfieldSearchQuery, searchQuery);
            return this;
        }

        public void ClickSearchButton()
        {
            selenium.Click(buttonDoSearch);
        }

        public void LoadAndSearchFor(String searchQuery)
        {
            Load().EnterSearchTerm(searchQuery).ClickSearchButton();
        }
    }
}
