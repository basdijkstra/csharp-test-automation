using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver.Examples
{
    [TestClass]
    public class ExamplesIteration3
    {

        [TestMethod]
        public void StartBrowser_PerformGoogleSearch_AssertOnResultPage_StopBrowser()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.google.com");

            driver.FindElement(By.Name("q")).SendKeys("Thomsons Online Benefits");

            driver.FindElement(By.Name("btnK")).Click();

            string currentTitle = driver.Title;

            Assert.AreEqual("Thomsons Online Benefits - Google zoeken", currentTitle);

            IWebElement resultsElement = driver.FindElement(By.Id("resultStats"));

            Assert.IsTrue(resultsElement.Displayed);

            driver.Quit();
        }
    }
}
