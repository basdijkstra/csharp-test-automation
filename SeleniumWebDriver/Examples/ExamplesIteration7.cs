using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebDriver.Examples.Pages;

namespace SeleniumWebDriver.Examples
{
    [TestClass]
    public class ExamplesIteration7
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
                .EnterSearchTerm("Thomsons Online Benefits")
                .ClickSearchButton();

            Assert.IsTrue(new GoogleResultsPage(driver).ResultStatsAreDisplayed());
        }

        [TestMethod]
        public void StartBrowser_PerformGoogleSearch_AssertOnResultPage_StopBrowser_LessVerbose()
        {
            new GoogleHomePage(driver)
                .LoadAndSearchFor("Thomsons Online Benefits");                
            
            Assert.IsTrue(new GoogleResultsPage(driver).ResultStatsAreDisplayed());
        }

        [TestCleanup]
        public void StopBrowser()
        {
            driver.Quit();
        }
    }
}
