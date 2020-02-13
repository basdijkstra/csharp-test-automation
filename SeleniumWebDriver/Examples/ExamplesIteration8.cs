using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebDriver.Examples.BasePages;

namespace SeleniumWebDriver.Examples
{
    [TestClass]
    public class ExamplesIteration8
    {
        IWebDriver driver;

        [TestInitialize]
        public void StartBrowser()
        {
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
        }

        [TestMethod]
        public void StartBrowser_PerformGoogleSearch_AssertOnResultPage_StopBrowser()
        {
            new GoogleHomePage(driver)
                .Load()
                .DoSearchFor("Thomsons Online Benefits");

            new GoogleResultsPage(driver)
                .DoSearchFor("Cluj-Napoca");
        }

        [TestCleanup]
        public void StopBrowser()
        {
            driver.Quit();
        }
    }
}
