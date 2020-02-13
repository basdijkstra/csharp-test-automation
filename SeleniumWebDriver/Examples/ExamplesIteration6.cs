using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebDriver.Examples.Helpers;

namespace SeleniumWebDriver.Examples
{
    [TestClass]
    public class ExamplesIteration6
    {
        IWebDriver driver;
        SeleniumHelpers selenium;

        [TestInitialize]
        public void StartBrowser()
        {
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            selenium = new SeleniumHelpers(driver);
        }

        [TestMethod]
        public void StartBrowser_PerformGoogleSearch_AssertOnResultPage_StopBrowser()
        {
            selenium.NavigateTo("https://www.google.com");

            selenium.SendKeys(By.Name("q"), "Thomsons Online Benefits");

            selenium.Click(By.Name("btnK"));

            Assert.IsTrue(selenium.TitleIsEqualTo("Thomsons Online Benefits - Google zoeken"));

            Assert.IsTrue(selenium.ElementIsVisible(By.Id("resultStats")));
        }

        [TestCleanup]
        public void StopBrowser()
        {
            driver.Quit();
        }
    }
}
